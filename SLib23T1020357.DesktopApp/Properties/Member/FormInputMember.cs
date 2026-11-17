using SLib23T1020357.Models.Constants;
using SLib23T1020357.Models.Entities;

namespace SLib23T1020357.DesktopApp.Properties.Member;

public partial class FormInputMember : Form
{
    // Các sự kiện callback báo về cho FormMember khi thêm hoặc sửa thành công
    public event EventHandler? MemberAdded;
    public event EventHandler? MemberUpdated;

    /// <summary>
    /// True nếu là chế độ thêm mới; False nếu là cập nhật
    /// </summary>
    public bool isAddMode { get; set; } = true;

    /// <summary>
    /// Mã định danh độc giả cần cập nhật
    /// </summary>
    public int MemberId { get; set; }

    public FormInputMember()
    {
        InitializeComponent();
    }

    private async void FormInputMember_Load(object sender, EventArgs e)
    {
        // 1. Đăng ký hiển thị định dạng trống nếu bỏ tick chọn ở DateTimePicker
        UiHelper.RegisterDateTimePickerFormat(dtpDateOfBirth);
        UiHelper.RegisterDateTimePickerFormat(dtpExpiredAt);

        // 2. Nạp dữ liệu các ComboBox danh mục
        await LoadMemberTypesAsync();
        LoadComboboxOptions();

        // 3. Nếu là thêm mới, khởi tạo các giá trị mặc định
        if (isAddMode)
        {
            Text = "Thêm mới độc giả";
            txtMemberCode.Focus();
            dtpRegisteredAt.Value = DateTime.Today;
            dtpExpiredAt.Checked = true;
            dtpExpiredAt.Value = DateTime.Today.AddYears(1);
            cboMemberStatus.SelectedValue = DatabaseConstant.MEMBERS_STATUS_ACTIVE;
            return;
        }

        // 4. Nếu là chế độ sửa, lấy dữ liệu hiện tại từ Service và hiển thị lên Form
        try
        {
            Text = "Cập nhật thông tin độc giả";
            txtMemberCode.ReadOnly = true; // Không cho sửa mã độc giả

            var member = await ServiceManager.Member.GetAsync(MemberId);

            txtMemberCode.Text = member.MemberCode;
            txtFullName.Text = member.FullName;
            cboMemberType.SelectedValue = member.MemberTypeId;
            cboGender.SelectedValue = member.Gender ?? DatabaseConstant.MEMBERS_GENDER_OTHER;
            txtEmail.Text = member.Email ?? string.Empty;
            txtPhone.Text = member.Phone ?? string.Empty;
            txtAddress.Text = member.Address ?? string.Empty;
            txtOrganization.Text = member.Organization ?? string.Empty;
            dtpRegisteredAt.Value = member.RegisteredAt;
            cboMemberStatus.SelectedValue = member.MemberStatus;
            txtNotes.Text = member.Notes ?? string.Empty;

            // Xử lý ngày tháng có thể null
            UiHelper.ShowDateTimePickerValue(dtpDateOfBirth, member.DateOfBirth);
            UiHelper.ShowDateTimePickerValue(dtpExpiredAt, member.ExpiredAt);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải thông tin độc giả: {ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }

    /// <summary>
    /// Tải danh sách loại độc giả từ Database vào ComboBox
    /// </summary>
    private async Task LoadMemberTypesAsync()
    {
        try
        {
            var types = await ServiceManager.Member.GetMemberTypesAsync();
            cboMemberType.DisplayMember = nameof(MemberType.TypeName);
            cboMemberType.ValueMember = nameof(MemberType.MemberTypeId);
            cboMemberType.DataSource = types;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh sách loại độc giả: {ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Nạp các giá trị hằng số Giới tính và Trạng thái
    /// </summary>
    private void LoadComboboxOptions()
    {
        // Danh sách Giới tính
        cboGender.DataSource = new[]
        {
            new { Text = "Nam", Value = DatabaseConstant.MEMBERS_GENDER_MALE },
            new { Text = "Nữ", Value = DatabaseConstant.MEMBERS_GENDER_FEMALE },
            new { Text = "Khác", Value = DatabaseConstant.MEMBERS_GENDER_OTHER }
        };
        cboGender.DisplayMember = "Text";
        cboGender.ValueMember = "Value";

        // Danh sách Trạng thái
        cboMemberStatus.DataSource = new[]
        {
            new { Text = "Đang hoạt động (Active)", Value = DatabaseConstant.MEMBERS_STATUS_ACTIVE },
            new { Text = "Tạm đình chỉ (Suspended)", Value = DatabaseConstant.MEMBERS_STATUS_SUSPENDED },
            new { Text = "Hết hạn thẻ (Expired)", Value = DatabaseConstant.MEMBERS_STATUS_EXPIRED },
            new { Text = "Đã đóng thẻ (Closed)", Value = DatabaseConstant.MEMBERS_STATUS_CLOSED }
        };
        cboMemberStatus.DisplayMember = "Text";
        cboMemberStatus.ValueMember = "Value";
    }

    /// <summary>
    /// Lưu thông tin độc giả
    /// </summary>
    private async void btnSave_Click(object? sender, EventArgs e)
    {
        btnSave.Enabled = false;
        try
        {
            // 1. Kiểm tra nhanh tại UI
            if (string.IsNullOrWhiteSpace(txtMemberCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bạn đọc.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên độc giả.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (cboMemberType.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại độc giả.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMemberType.Focus();
                return;
            }

            // 2. Tạo đối tượng Member từ Form
            var member = new SLib23T1020357.Models.Entities.Member
            {
                MemberCode = txtMemberCode.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                MemberTypeId = (int)cboMemberType.SelectedValue,
                Gender = cboGender.SelectedValue?.ToString(),
                DateOfBirth = dtpDateOfBirth.Checked ? dtpDateOfBirth.Value.Date : null,
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim(),
                Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim(),
                Organization = string.IsNullOrWhiteSpace(txtOrganization.Text) ? null : txtOrganization.Text.Trim(),
                RegisteredAt = dtpRegisteredAt.Value.Date,
                ExpiredAt = dtpExpiredAt.Checked ? dtpExpiredAt.Value.Date : null,
                MemberStatus = cboMemberStatus.SelectedValue?.ToString() ?? DatabaseConstant.MEMBERS_STATUS_ACTIVE,
                Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim()
            };

            // 3. Thực thi Thêm hoặc Cập nhật qua Service
            if (isAddMode)
            {
                int newId = await ServiceManager.Member.AddAsync(member);
                member.MemberId = newId;
                MemberAdded?.Invoke(member, EventArgs.Empty);
                MessageBox.Show("Thêm độc giả mới thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                member.MemberId = MemberId;
                await ServiceManager.Member.UpdateAsync(member);
                MemberUpdated?.Invoke(member, EventArgs.Empty);
                MessageBox.Show("Cập nhật thông tin độc giả thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi lưu thông tin độc giả:\n{ex.Message}", "Lỗi nghiệp vụ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            btnSave.Enabled = true;
        }
    }

    private void buttonCancel_Click(object? sender, EventArgs e)
    {
        Close();
    }
}