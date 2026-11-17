namespace SLib23T1020357.Models.DTOs;

/// <summary>
/// Đại diện cho kết quả truy vấn có phân trang.
/// </summary>
/// <typeparam name="T">Kiểu dữ liệu của các phần tử trong danh sách.</typeparam>
public class PagedResult<T>
{
    public List<T> Items { get; set; } = new();
    public int TotalCount { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }

    public int TotalPages => PageSize > 0
        ? (int)Math.Ceiling((double)TotalCount / PageSize)
        : 0;

    public bool HasPreviousPage => PageIndex > 1;
    public bool HasNextPage => PageIndex < TotalPages;
}