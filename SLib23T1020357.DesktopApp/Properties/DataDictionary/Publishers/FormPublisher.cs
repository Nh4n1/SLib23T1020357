using SLib23T1020357.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Publishers
{
    public partial class FormPublisher : Form
    {
        private List<Publisher> _originalList = new();

        public FormPublisher()
        {
            InitializeComponent();
            ConfigDataGridView();

            Load += FormPublisher_Load;
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

            ColumnPublisherName.DataPropertyName = nameof(Publisher.PublisherName);
            ColumnPublisherPhone.DataPropertyName = nameof(Publisher.Phone);
            ColumnPublisherEmail.DataPropertyName = nameof(Publisher.Email);
            ColumnPublisherStatus.DataPropertyName = nameof(Publisher.IsActive);

            ColumnPublisherPhone.DefaultCellStyle.NullValue = "Chưa xác định";
            ColumnPublisherEmail.DefaultCellStyle.NullValue = "Chưa xác định";
        }

        private async void FormPublisher_Load(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            try
            {
                _originalList = await ServiceManager.Publisher.ListAsync();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách nhà xuất bản:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    .Where(publisher =>
                        publisher.PublisherName.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                        (publisher.Address?.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ?? false) ||
                        (publisher.Phone?.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ?? false) ||
                        (publisher.Email?.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ?? false) ||
                        (publisher.Website?.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ?? false))
                    .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            using var form = new FormInputPublisher { isAddMode = true };
            form.PublisherAdded += PublisherSaved;
            form.ShowDialog(this);
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            var publisher = GetSelectedPublisher();
            if (publisher == null)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var form = new FormInputPublisher { isAddMode = false, PublisherId = publisher.PublisherId };
            form.PublisherUpdated += PublisherSaved;
            form.ShowDialog(this);
        }

        private async void buttonDelete_Click(object? sender, EventArgs e)
        {
            var publisher = GetSelectedPublisher();
            if (publisher == null)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                    $"Bạn có chắc muốn xóa nhà xuất bản \"{publisher.PublisherName}\" không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (!await ServiceManager.Publisher.DeleteAsync(publisher.PublisherId))
                {
                    MessageBox.Show("Không tìm thấy nhà xuất bản cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa nhà xuất bản:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Publisher? GetSelectedPublisher()
        {
            return dataGridView1.CurrentRow?.DataBoundItem as Publisher;
        }

        private async void PublisherSaved(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }
    }
}
