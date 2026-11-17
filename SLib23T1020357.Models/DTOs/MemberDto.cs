namespace SLib23T1020357.Models.DTOs;

using SLib23T1020357.Models.Entities;

/// <summary>
/// DTO chứa đầy đủ thông tin độc giả kèm các quy định mượn từ loại độc giả tương ứng.
/// </summary>
public class MemberDto : Member
{
    /// <summary>
    /// Tên loại bạn đọc (ví dụ: Sinh viên, Giảng viên, Nghiên cứu sinh,...).
    /// </summary>
    public string TypeName { get; set; } = string.Empty;

    /// <summary>
    /// Số sách được mượn đồng thời tối đa.
    /// </summary>
    public int MaxActiveLoans { get; set; }

    /// <summary>
    /// Số ngày được mượn tiêu chuẩn.
    /// </summary>
    public int LoanPeriodDays { get; set; }

    /// <summary>
    /// Số lần gia hạn tối đa cho phép.
    /// </summary>
    public int MaxRenewals { get; set; }
}