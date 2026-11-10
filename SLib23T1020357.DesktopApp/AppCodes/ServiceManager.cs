namespace SLib23T1020357.DesktopApp;
using SLib23T1020357.BusinessLayer;
using SLib23T1020357.DataLayer;

public static class ServiceManager
{
    private static AuthorService _author;
    private static CategoryService _category;
    private static LanguageService _language;
    private static PublisherService _publisher;
    private static MemberTypeService _memberType;
    private static LocationService _location;

    /// <summary>
    /// Khởi tạo các đối tượng nghiệp vụ
    /// Phải được gọi trước khi sử dụng các đối tượng nghiệp vụ
    /// </summary>
    /// <param name="connectionString"></param>
    public static void Initialize(string connectionString)
    {
        _author = new AuthorService(new AuthorRepository(connectionString));
        _category = new CategoryService(new CategoryRepository(connectionString));
        _language = new LanguageService(new LanguageRepository(connectionString));
        _publisher = new PublisherService(new PublisherRepository(connectionString));
        _memberType = new MemberTypeService(new MemberTypeRepository(connectionString));
        _location = new LocationService(new LocationRepository(connectionString));
    }
    /// <summary>
    /// Đối tượng cung cấp các chức năng nghiệp vụ liên quan đến tác giả.
    /// </summary>
    public static AuthorService Author => _author;
    /// <summary>
    /// Đối tượng cung cấp các chức năng nghiệp vụ liên quan đến thể loại sách.
    /// </summary>
    public static CategoryService Category => _category;
    /// <summary>
    /// Đối tượng cung cấp các chức năng nghiệp vụ liên quan đến ngôn ngữ sách.
    /// </summary>
    public static LanguageService Language => _language;
    /// <summary>
    /// Đối tượng cung cấp các chức năng nghiệp vụ liên quan đến nhà xuất bản.
    /// </summary>
    public static PublisherService Publisher => _publisher;
    /// <summary>
    /// Đối tượng cung cấp các chức năng nghiệp vụ liên quan đến loại thành viên.
    /// </summary>
    public static MemberTypeService MemberType => _memberType;
    /// <summary>
    /// Đối tượng cung cấp các chức năng nghiệp vụ liên quan đến vị trí sách.
    /// </summary>
    public static LocationService Location => _location;

}