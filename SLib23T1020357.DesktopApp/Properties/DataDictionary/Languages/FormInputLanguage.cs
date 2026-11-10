using SLib23T1020357.Models.Entities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Languages
{
    public partial class FormInputLanguage : Form
    {
        public event EventHandler? LanguageAdded;
        public event EventHandler? LanguageUpdated;

        public FormInputLanguage()
        {
            InitializeComponent();
        }

        public bool isAddMode { get; set; }

        public int LanguageId { get; set; }

        private async void FormInputLanguage_Load(object? sender, EventArgs e)
        {
            if (isAddMode)
            {
                Text = "Thêm mới ngôn ngữ";
                chkIsActive.Checked = true;
                return;
            }

            try
            {
                Text = "Cập nhật thông tin ngôn ngữ";
                var language = await ServiceManager.Language.GetAsync(LanguageId);
                txtLanguageCode.Text = language.LanguageCode;
                txtLanguageName.Text = language.LanguageName;
                chkIsActive.Checked = language.IsActive;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải thông tin ngôn ngữ:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                var language = new Language
                {
                    LanguageCode = txtLanguageCode.Text.Trim(),
                    LanguageName = txtLanguageName.Text.Trim(),
                    IsActive = chkIsActive.Checked
                };

                if (isAddMode)
                {
                    await ServiceManager.Language.AddAsync(language);
                    LanguageAdded?.Invoke(language, EventArgs.Empty);
                }
                else
                {
                    language.LanguageId = LanguageId;
                    if (!await ServiceManager.Language.UpdateAsync(language))
                    {
                        MessageBox.Show("Không tìm thấy ngôn ngữ cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    LanguageUpdated?.Invoke(language, EventArgs.Empty);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu thông tin ngôn ngữ:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }
    }
}
