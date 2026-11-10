using SLib23T1020357.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Languages
{
    public partial class FormLanguage : Form
    {
        private List<Language> _originalList = new();

        public FormLanguage()
        {
            InitializeComponent();
            ConfigDataGridView();

            Load += FormLanguage_Load;
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

            ColumnLanguageCode.DataPropertyName = nameof(Language.LanguageCode);
            ColumnLanguageName.DataPropertyName = nameof(Language.LanguageName);
            ColumnLanguageStatus.DataPropertyName = nameof(Language.IsActive);
        }

        private async void FormLanguage_Load(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            try
            {
                _originalList = await ServiceManager.Language.ListAsync();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách ngôn ngữ:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    .Where(language =>
                        language.LanguageCode.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                        language.LanguageName.Contains(keyword, StringComparison.CurrentCultureIgnoreCase))
                    .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            using var form = new FormInputLanguage { isAddMode = true };
            form.LanguageAdded += LanguageSaved;
            form.ShowDialog(this);
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            var language = GetSelectedLanguage();
            if (language == null)
            {
                MessageBox.Show("Vui lòng chọn ngôn ngữ cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var form = new FormInputLanguage { isAddMode = false, LanguageId = language.LanguageId };
            form.LanguageUpdated += LanguageSaved;
            form.ShowDialog(this);
        }

        private async void buttonDelete_Click(object? sender, EventArgs e)
        {
            var language = GetSelectedLanguage();
            if (language == null)
            {
                MessageBox.Show("Vui lòng chọn ngôn ngữ cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                    $"Bạn có chắc muốn xóa ngôn ngữ \"{language.LanguageName}\" không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                if (!await ServiceManager.Language.DeleteAsync(language.LanguageId))
                {
                    MessageBox.Show("Không tìm thấy ngôn ngữ cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa ngôn ngữ:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Language? GetSelectedLanguage()
        {
            return dataGridView1.CurrentRow?.DataBoundItem as Language;
        }

        private async void LanguageSaved(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }
    }
}
