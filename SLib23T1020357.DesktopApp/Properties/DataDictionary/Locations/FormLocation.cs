using SLib23T1020357.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Locations
{
    public partial class FormLocation : Form
    {
        private List<Location> _originalList = new();

        public FormLocation()
        {
            InitializeComponent();
            ConfigDataGridView();

            Load += FormLocation_Load;
            textBox1.TextChanged += TextBox1_TextChanged;
            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
        }

        private void ConfigDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ColumnLocationCode.DataPropertyName = nameof(SLib23T1020357.Models.Entities.Location.LocationCode);
            ColumnLocationName.DataPropertyName = nameof(SLib23T1020357.Models.Entities.Location.LocationName);
            ColumnFloor.DataPropertyName = nameof(SLib23T1020357.Models.Entities.Location.Floor);
            ColumnRoom.DataPropertyName = nameof(SLib23T1020357.Models.Entities.Location.Room);
            ColumnShelf.DataPropertyName = nameof(SLib23T1020357.Models.Entities.Location.Shelf);
            ColumnLocationStatus.DataPropertyName = nameof(SLib23T1020357.Models.Entities.Location.IsActive);

            ColumnFloor.DefaultCellStyle.NullValue = "-";
            ColumnRoom.DefaultCellStyle.NullValue = "-";
            ColumnShelf.DefaultCellStyle.NullValue = "-";
        }

        private async void FormLocation_Load(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            try
            {
                _originalList = await ServiceManager.Location.ListAsync();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách vị trí sách:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string keyword = textBox1.Text.Trim();
            dataGridView1.DataSource = string.IsNullOrEmpty(keyword)
                ? _originalList
                : _originalList
                    .Where(location =>
                        location.LocationCode.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                        location.LocationName.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                        (location.Floor?.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ?? false) ||
                        (location.Room?.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ?? false) ||
                        (location.Shelf?.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ?? false) ||
                        (location.Description?.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ?? false))
                    .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            using var form = new FormInputLocation { isAddMode = true };
            form.LocationAdded += LocationSaved;
            form.ShowDialog(this);
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            var location = GetSelectedLocation();
            if (location == null)
            {
                MessageBox.Show("Vui lòng chọn vị trí cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var form = new FormInputLocation { isAddMode = false, LocationId = location.LocationId };
            form.LocationUpdated += LocationSaved;
            form.ShowDialog(this);
        }

        private async void buttonDelete_Click(object? sender, EventArgs e)
        {
            var location = GetSelectedLocation();
            if (location == null)
            {
                MessageBox.Show("Vui lòng chọn vị trí cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                    $"Bạn có chắc muốn xóa vị trí \"{location.LocationName}\" không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (!await ServiceManager.Location.DeleteAsync(location.LocationId))
                {
                    MessageBox.Show("Không tìm thấy vị trí cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa vị trí:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Location? GetSelectedLocation()
        {
            return dataGridView1.CurrentRow?.DataBoundItem as Location;
        }

        private async void LocationSaved(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }
    }
}
