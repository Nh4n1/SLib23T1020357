using SLib23T1020357.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Categories
{
    public partial class FormCategory : Form
    {
        private List<Category> _originalList = new();

        public FormCategory()
        {
            InitializeComponent();
            ConfigDataGridView();

            Load += FormCategory_Load;
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
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ColumnCategoryName.DataPropertyName = nameof(Category.CategoryName);
            ColumnBookDescription.DataPropertyName = nameof(Category.Description);
            ColumnCategoryStatus.DataPropertyName = nameof(Category.IsActive);
            ColumnBookDescription.DefaultCellStyle.NullValue = "Không có mô tả";
        }

        private async void FormCategory_Load(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            try
            {
                _originalList = await ServiceManager.Category.ListAsync();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách thể loại:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    .Where(category =>
                        category.CategoryName.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                        (category.Description?.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ?? false))
                    .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            using var formInputCategory = new FormInputCategory { isAddMode = true };
            formInputCategory.CategoryAdded += CategorySaved;
            formInputCategory.ShowDialog(this);
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            var category = GetSelectedCategory();
            if (category == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var formInputCategory = new FormInputCategory
            {
                isAddMode = false,
                CategoryId = category.CategoryId
            };
            formInputCategory.CategoryUpdated += CategorySaved;
            formInputCategory.ShowDialog(this);
        }

        private async void buttonDelete_Click(object? sender, EventArgs e)
        {
            var category = GetSelectedCategory();
            if (category == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmation = MessageBox.Show(
                $"Bạn có chắc muốn xóa thể loại \"{category.CategoryName}\" không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirmation != DialogResult.Yes)
                return;

            try
            {
                if (!await ServiceManager.Category.DeleteAsync(category.CategoryId))
                {
                    MessageBox.Show("Không tìm thấy thể loại cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa thể loại:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Category? GetSelectedCategory()
        {
            return dataGridView1.CurrentRow?.DataBoundItem as Category;
        }

        private async void CategorySaved(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }
    }
}
