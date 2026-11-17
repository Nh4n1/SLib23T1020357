using SLib23T1020357.DataLayer;
using SLib23T1020357.Models.DTOs;
using SLib23T1020357.Models.Entities;

namespace SLib23T1020357.BusinessLayer;

/// <summary>
/// Cung cấp các chức năng nghiệp vụ quản lý độc giả.
/// </summary>
public class MemberService
{
    private readonly MemberRepository _memberRepository;
    private readonly MemberTypeRepository _memberTypeRepository;

    public MemberService(MemberRepository memberRepository, MemberTypeRepository memberTypeRepository)
    {
        _memberRepository = memberRepository
            ?? throw new ArgumentNullException(nameof(memberRepository));
        _memberTypeRepository = memberTypeRepository
            ?? throw new ArgumentNullException(nameof(memberTypeRepository));
    }

    /// <summary>
    /// Tìm kiếm, lọc và phân trang danh sách độc giả.
    /// </summary>
    public async Task<PagedResult<MemberDto>> SearchAsync(
        string? keyword,
        int? memberTypeId,
        string? organization,
        string? memberStatus,
        int pageIndex = 1,
        int pageSize = 10)
    {
        if (pageIndex < 1) pageIndex = 1;
        if (pageSize < 1) pageSize = 10;

        var (items, totalCount) = await _memberRepository.SearchAsync(
            keyword, memberTypeId, organization, memberStatus, pageIndex, pageSize);

        return new PagedResult<MemberDto>
        {
            Items = items,
            TotalCount = totalCount,
            PageIndex = pageIndex,
            PageSize = pageSize
        };
    }

    /// <summary>
    /// Lấy thông tin độc giả theo mã định danh.
    /// </summary>
    public async Task<Member> GetAsync(int memberId)
    {
        if (memberId <= 0)
            throw new Exception("Mã độc giả không hợp lệ.");

        var member = await _memberRepository.GetAsync(memberId);
        if (member == null)
            throw new Exception("Không tìm thấy thông tin độc giả.");

        return member;
    }

    /// <summary>
    /// Thêm độc giả mới.
    /// </summary>
    public async Task<int> AddAsync(Member member)
    {
        await ValidateMemberAsync(member);

        if (await _memberRepository.IsCodeExistsAsync(member.MemberCode))
            throw new Exception($"Mã bạn đọc '{member.MemberCode}' đã tồn tại trong hệ thống.");

        return await _memberRepository.AddAsync(member);
    }

    /// <summary>
    /// Cập nhật thông tin độc giả.
    /// </summary>
    public async Task<bool> UpdateAsync(Member member)
    {
        if (member.MemberId <= 0)
            throw new Exception("Mã độc giả không hợp lệ.");

        await ValidateMemberAsync(member);

        if (await _memberRepository.IsCodeExistsAsync(member.MemberCode, member.MemberId))
            throw new Exception($"Mã bạn đọc '{member.MemberCode}' đã được sử dụng bởi độc giả khác.");

        return await _memberRepository.UpdateAsync(member);
    }

    /// <summary>
    /// Xóa độc giả nếu chưa phát sinh giao dịch mượn sách.
    /// </summary>
    public async Task<bool> DeleteAsync(int memberId)
    {
        if (memberId <= 0)
            throw new Exception("Mã độc giả không hợp lệ.");

        if (await _memberRepository.InUsedAsync(memberId))
            throw new Exception("Không thể xóa độc giả này vì đã có dữ liệu mượn trả sách trong hệ thống.");

        return await _memberRepository.DeleteAsync(memberId);
    }

    /// <summary>
    /// Lấy danh sách loại độc giả (dùng để nạp vào ComboBox lựa chọn trên giao diện).
    /// </summary>
    public async Task<List<MemberType>> GetMemberTypesAsync()
    {
        return await _memberTypeRepository.ListAsync();
    }

    /// <summary>
    /// Kiểm tra tính hợp lệ của dữ liệu độc giả trước khi lưu.
    /// </summary>
    private async Task ValidateMemberAsync(Member member)
    {
        if (member == null)
            throw new Exception("Thông tin độc giả không được để trống.");

        if (string.IsNullOrWhiteSpace(member.MemberCode))
            throw new Exception("Mã bạn đọc không được để trống.");

        if (string.IsNullOrWhiteSpace(member.FullName))
            throw new Exception("Họ và tên độc giả không được để trống.");

        if (member.MemberTypeId <= 0)
            throw new Exception("Vui lòng chọn loại độc giả.");

        // Dùng MemberTypeRepository kiểm tra loại độc giả có tồn tại không
        var memberType = await _memberTypeRepository.GetAsync(member.MemberTypeId);
        if (memberType == null)
            throw new Exception("Loại độc giả được chọn không tồn tại trong hệ thống.");

        if (member.DateOfBirth.HasValue && member.DateOfBirth.Value.Date > DateTime.Today)
            throw new Exception("Ngày sinh không thể lớn hơn ngày hiện tại.");

        if (member.ExpiredAt.HasValue && member.ExpiredAt.Value.Date < member.RegisteredAt.Date)
            throw new Exception("Ngày hết hạn thẻ không được nhỏ hơn ngày đăng ký.");
    }
}