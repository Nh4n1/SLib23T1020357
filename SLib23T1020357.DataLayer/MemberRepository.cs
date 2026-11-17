using Dapper;
using Microsoft.Data.SqlClient;
using SLib23T1020357.Models.DTOs;
using SLib23T1020357.Models.Entities;
using System.Data;
using System.Text;

namespace SLib23T1020357.DataLayer;

/// <summary>
/// Thực hiện các thao tác dữ liệu trên bảng Members.
/// </summary>
public class MemberRepository
{
    private readonly string _connectionString;

    public MemberRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    /// <summary>
    /// Tìm kiếm và phân trang danh sách độc giả kết hợp thông tin loại độc giả.
    /// </summary>
    public async Task<(List<MemberDto> Items, int TotalCount)> SearchAsync(
        string? keyword,
        int? memberTypeId,
        string? organization,
        string? memberStatus,
        int pageIndex,
        int pageSize)
    {
        var whereClause = new StringBuilder(" WHERE 1 = 1 ");
        var parameters = new DynamicParameters();

        // 1. Tìm theo họ tên hoặc mã bạn đọc
        if (!string.IsNullOrWhiteSpace(keyword))
        {
            whereClause.Append(" AND (m.FullName LIKE @Keyword OR m.MemberCode LIKE @Keyword) ");
            parameters.Add("Keyword", $"%{keyword.Trim()}%");
        }

        // 2. Lọc theo loại bạn đọc
        if (memberTypeId.HasValue && memberTypeId.Value > 0)
        {
            whereClause.Append(" AND m.MemberTypeId = @MemberTypeId ");
            parameters.Add("MemberTypeId", memberTypeId.Value);
        }

        // 3. Lọc theo tổ chức / đơn vị phân loại
        if (!string.IsNullOrWhiteSpace(organization))
        {
            whereClause.Append(" AND m.Organization LIKE @Organization ");
            parameters.Add("Organization", $"%{organization.Trim()}%");
        }

        // 4. Lọc theo trạng thái bạn đọc (Active, Suspended, Expired, Closed)
        if (!string.IsNullOrWhiteSpace(memberStatus))
        {
            whereClause.Append(" AND m.MemberStatus = @MemberStatus ");
            parameters.Add("MemberStatus", memberStatus);
        }

        int offset = (pageIndex - 1) * pageSize;
        parameters.Add("Offset", offset);
        parameters.Add("PageSize", pageSize);

        string countSql = $@"
            SELECT COUNT(1) 
            FROM Members m 
            {whereClause};";

        string selectSql = $@"
            SELECT 
                m.MemberId, m.MemberCode, m.MemberTypeId, m.FullName, m.DateOfBirth,
                m.Gender, m.Email, m.Phone, m.Address, m.Organization, m.RegisteredAt,
                m.ExpiredAt, m.MemberStatus, m.Notes,
                mt.TypeName, mt.MaxActiveLoans, mt.LoanPeriodDays, mt.MaxRenewals
            FROM Members m
            INNER JOIN MemberTypes mt ON m.MemberTypeId = mt.MemberTypeId
            {whereClause}
            ORDER BY m.MemberId DESC
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        using IDbConnection connection = new SqlConnection(_connectionString);

        int totalCount = await connection.ExecuteScalarAsync<int>(countSql, parameters);
        var items = (await connection.QueryAsync<MemberDto>(selectSql, parameters)).ToList();

        return (items, totalCount);
    }

    /// <summary>
    /// Lấy thông tin độc giả theo mã định danh.
    /// </summary>
    public async Task<Member?> GetAsync(int memberId)
    {
        const string sql = @"SELECT * FROM Members WHERE MemberId = @MemberId;";
        using IDbConnection connection = new SqlConnection(_connectionString);
        return await connection.QueryFirstOrDefaultAsync<Member>(sql, new { MemberId = memberId });
    }

    /// <summary>
    /// Kiểm tra xem mã độc giả (MemberCode) đã tồn tại chưa (phục vụ validate tránh trùng mã).
    /// </summary>
    public async Task<bool> IsCodeExistsAsync(string memberCode, int excludeMemberId = 0)
    {
        const string sql = @"
            SELECT CASE WHEN EXISTS (
                SELECT 1 FROM Members 
                WHERE MemberCode = @MemberCode AND MemberId <> @ExcludeMemberId
            ) THEN 1 ELSE 0 END;";

        using IDbConnection connection = new SqlConnection(_connectionString);
        return await connection.ExecuteScalarAsync<bool>(sql, new
        {
            MemberCode = memberCode,
            ExcludeMemberId = excludeMemberId
        });
    }

    /// <summary>
    /// Thêm mới độc giả.
    /// </summary>
    public async Task<int> AddAsync(Member member)
    {
        const string sql = @"
            INSERT INTO Members (
                MemberCode, MemberTypeId, FullName, DateOfBirth, Gender, 
                Email, Phone, Address, Organization, RegisteredAt, ExpiredAt, 
                MemberStatus, Notes
            ) VALUES (
                @MemberCode, @MemberTypeId, @FullName, @DateOfBirth, @Gender, 
                @Email, @Phone, @Address, @Organization, @RegisteredAt, @ExpiredAt, 
                @MemberStatus, @Notes
            );
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

        using IDbConnection connection = new SqlConnection(_connectionString);
        return await connection.ExecuteScalarAsync<int>(sql, member);
    }

    /// <summary>
    /// Cập nhật thông tin độc giả.
    /// </summary>
    public async Task<bool> UpdateAsync(Member member)
    {
        const string sql = @"
            UPDATE Members
            SET MemberCode = @MemberCode,
                MemberTypeId = @MemberTypeId,
                FullName = @FullName,
                DateOfBirth = @DateOfBirth,
                Gender = @Gender,
                Email = @Email,
                Phone = @Phone,
                Address = @Address,
                Organization = @Organization,
                RegisteredAt = @RegisteredAt,
                ExpiredAt = @ExpiredAt,
                MemberStatus = @MemberStatus,
                Notes = @Notes
            WHERE MemberId = @MemberId;";

        using IDbConnection connection = new SqlConnection(_connectionString);
        int rows = await connection.ExecuteAsync(sql, member);
        return rows > 0;
    }

    /// <summary>
    /// Xóa độc giả theo mã.
    /// </summary>
    public async Task<bool> DeleteAsync(int memberId)
    {
        const string sql = @"DELETE FROM Members WHERE MemberId = @MemberId;";
        using IDbConnection connection = new SqlConnection(_connectionString);
        int rows = await connection.ExecuteAsync(sql, new { MemberId = memberId });
        return rows > 0;
    }

    /// <summary>
    /// Kiểm tra độc giả có đang có giao dịch mượn sách (bảng Loans) hay không.
    /// </summary>
    public async Task<bool> InUsedAsync(int memberId)
    {
        const string sql = @"
            SELECT CASE WHEN EXISTS (
                SELECT 1 FROM Loans WHERE MemberId = @MemberId
            ) THEN 1 ELSE 0 END;";

        using IDbConnection connection = new SqlConnection(_connectionString);
        return await connection.ExecuteScalarAsync<bool>(sql, new { MemberId = memberId });
    }
}