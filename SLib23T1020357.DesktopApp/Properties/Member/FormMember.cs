using SLib23T1020357.Models.Constants;
using SLib23T1020357.Models.DTOs;
using SLib23T1020357.Models.Entities;
using System.ComponentModel;

namespace SLib23T1020357.DesktopApp.Properties.Member;

public partial class FormMember : Form
{
    private BindingList<MemberDto> _bsMembers = new();
    private int _currentPage = 1;
    private int _pageSize = 10;
    private int _totalPages = 1;

    public FormMember()
    {
        InitializeComponent();
        //// 1. Nút Tìm kiếm
        //btnSearch.Click += btnSearch_Click;

        //// 2. Nút Làm mới
        //btnReset.Click += btnReset_Click;

        //// 3. Nút Thêm (Khắc phục lỗi bấm Add không hiện form)
        //btnAdd.Click += btnAdd_Click;

        //// 4. Nút Sửa
        //btnEdit.Click += btnEdit_Click;

        //// 5. Nút Xóa
        //btnDelete.Click += btnDelete_Click;

        //// 6. Các nút phân trang & chọn số dòng
        //btnFirstPage.Click += btnFirstPage_Click;
        //btnPrevPage.Click += btnPrevPage_Click;
        //btnNextPage.Click += btnNextPage_Click;
        //btnLastPage.Click += btnLastPage_Click;
        //cboPageSize.SelectedIndexChanged += cboPageSize_SelectedIndexChanged;
    }

    private async void FormMember_Load(object sender, EventArgs e)
    {
        // 1. Ánh xạ các cột trên DataGridView với thuộc tính của MemberDto
        dgvMember.AutoGenerateColumns = false;
        ColumnMemberCode.DataPropertyName = nameof(MemberDto.MemberCode);
        ColumnFullName.DataPropertyName = nameof(MemberDto.FullName);
        ColumnTypeName.DataPropertyName = nameof(MemberDto.TypeName);
        ColumnMaxActiveLoans.DataPropertyName = nameof(MemberDto.MaxActiveLoans);
        ColumnLoanPeriodDays.DataPropertyName = nameof(MemberDto.LoanPeriodDays);
        ColumnMaxRenewals.DataPropertyName = nameof(MemberDto.MaxRenewals);
        ColumnGender.DataPropertyName = nameof(MemberDto.Gender);
        ColumnPhone.DataPropertyName = nameof(MemberDto.Phone);
        ColumnExpireAt.DataPropertyName = nameof(MemberDto.ExpiredAt);
        ColumnMemberStatus.DataPropertyName = nameof(MemberDto.MemberStatus);

        // 2. Khởi tạo bộ lọc và nạp dữ liệu
        InitFilterControls();
        await LoadMemberTypesFilterAsync();
        await LoadDataAsync();
    }

    /// <summary>
    /// Khởi tạo các giá trị cho bộ lọc trạng thái và kích thước trang.
    /// </summary>
    private void InitFilterControls()
    {
        // 1. Nạp danh sách trạng thái
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.Add(new ComboBoxItem { Text = "-- Tất cả trạng thái --", Value = "" });
        cboStatusFilter.Items.Add(new ComboBoxItem { Text = "Đang hoạt động (Active)", Value = DatabaseConstant.MEMBERS_STATUS_ACTIVE });
        cboStatusFilter.Items.Add(new ComboBoxItem { Text = "Tạm khóa (Suspended)", Value = DatabaseConstant.MEMBERS_STATUS_SUSPENDED });
        cboStatusFilter.Items.Add(new ComboBoxItem { Text = "Hết hạn (Expired)", Value = DatabaseConstant.MEMBERS_STATUS_EXPIRED });
        cboStatusFilter.Items.Add(new ComboBoxItem { Text = "Đã đóng (Closed)", Value = DatabaseConstant.MEMBERS_STATUS_CLOSED });
        cboStatusFilter.SelectedIndex = 0;

        // 2. Nạp số dòng trên mỗi trang
        cboPageSize.Items.Clear();
        cboPageSize.Items.AddRange(new object[] { 10, 20, 50, 100 });
        cboPageSize.SelectedItem = 10;
    }

    /// <summary>
    /// Tải danh sách loại độc giả vào ComboBox lọc.
    /// </summary>
    private async Task LoadMemberTypesFilterAsync()
    {
        try
        {
            var types = await ServiceManager.Member.GetMemberTypesAsync();
            var filterList = new List<MemberType>
            {
                new MemberType { MemberTypeId = 0, TypeName = "-- Tất cả loại độc giả --" }
            };
            filterList.AddRange(types);

            cboMemberTypeFilter.DisplayMember = nameof(MemberType.TypeName);
            cboMemberTypeFilter.ValueMember = nameof(MemberType.MemberTypeId);
            cboMemberTypeFilter.DataSource = filterList;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh mục loại độc giả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Gọi Service để tìm kiếm và phân trang dữ liệu.
    /// </summary>
    private async Task LoadDataAsync()
    {
        try
        {
            string keyword = txtSearch.Text.Trim();
            int? memberTypeId = (cboMemberTypeFilter.SelectedValue is int id && id > 0) ? id : null;
            string? organization = null;
            string? status = (cboStatusFilter.SelectedItem as ComboBoxItem)?.Value?.ToString();
            if (string.IsNullOrEmpty(status)) status = null;

            var pagedResult = await ServiceManager.Member.SearchAsync(
                keyword, memberTypeId, organization, status, _currentPage, _pageSize);

            _totalPages = Math.Max(1, pagedResult.TotalPages);

            // Gán dữ liệu vào DataGridView
            _bsMembers = new BindingList<MemberDto>(pagedResult.Items);
            dgvMember.AutoGenerateColumns = false;
            dgvMember.DataSource = _bsMembers;

            // Cập nhật thanh phân trang
            //lblPageInfo.Text = $"Trang {_currentPage} / {_totalPages} (Tổng số: {pagedResult.TotalCount} bạn đọc)";
            btnFirstPage.Enabled = pagedResult.HasPreviousPage;
            btnPrevPage.Enabled = pagedResult.HasPreviousPage;
            btnNextPage.Enabled = pagedResult.HasNextPage;
            btnLastPage.Enabled = pagedResult.HasNextPage;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh sách độc giả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Sự kiện tìm kiếm và phân trang
    private async void btnSearch_Click(object sender, EventArgs e)
    {
        _currentPage = 1;
        await LoadDataAsync();
    }

    private async void btnReset_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        cboMemberTypeFilter.SelectedIndex = 0;
        cboStatusFilter.SelectedIndex = 0;
        _currentPage = 1;
        await LoadDataAsync();
    }

    private async void cboPageSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboPageSize.SelectedItem is int size && size != _pageSize)
        {
            _pageSize = size;
            _currentPage = 1;
            await LoadDataAsync();
        }
    }

    private async void btnFirstPage_Click(object sender, EventArgs e)
    {
        _currentPage = 1;
        await LoadDataAsync();
    }

    private async void btnPrevPage_Click(object sender, EventArgs e)
    {
        if (_currentPage > 1)
        {
            _currentPage--;
            await LoadDataAsync();
        }
    }

    private async void btnNextPage_Click(object sender, EventArgs e)
    {
        if (_currentPage < _totalPages)
        {
            _currentPage++;
            await LoadDataAsync();
        }
    }

    private async void btnLastPage_Click(object sender, EventArgs e)
    {
        _currentPage = _totalPages;
        await LoadDataAsync();
    }

    // Sự kiện Thêm, Sửa, Xóa tương tự FormMemberType
    private void btnAdd_Click(object sender, EventArgs e)
    {
        var form = new FormInputMember
        {
            isAddMode = true
        };
        form.MemberAdded += async (s, args) => await LoadDataAsync();
        form.ShowDialog();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        var selected = GetSelectedMember();
        if (selected == null)
        {
            MessageBox.Show("Vui lòng chọn độc giả cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var form = new FormInputMember
        {
            isAddMode = false,
            MemberId = selected.MemberId
        };
        form.MemberUpdated += async (s, args) => await LoadDataAsync();
        form.ShowDialog();
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        var selected = GetSelectedMember();
        if (selected == null)
        {
            MessageBox.Show("Vui lòng chọn độc giả cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa độc giả '{selected.FullName}' (Mã: {selected.MemberCode})?",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm == DialogResult.Yes)
        {
            try
            {
                await ServiceManager.Member.DeleteAsync(selected.MemberId);
                MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể xóa độc giả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private MemberDto? GetSelectedMember()
    {
        return dgvMember.CurrentRow?.DataBoundItem as MemberDto;
    }

    private class ComboBoxItem
    {
        public string Text { get; set; } = string.Empty;
        public object? Value { get; set; }
        public override string ToString() => Text;
    }
}