using SLib23T1020357.Models.Entities;
using System.Threading.Tasks;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Authors
{
    public partial class FormInputAuthor : Form
    {
        public event EventHandler AuthorAdded;
        public event EventHandler AuthorUpdated;

        public FormInputAuthor()
        {
            InitializeComponent();
        }

        public bool isAddMode { get; set; }

        /// <summary>
        /// Id của tác giả cần cập nhật (chỉ sử dụng khi isAddMode = false)
        /// </summary>
        public int AuthorId { get; set; }

        private void ResetForm()
        {
            txtAuthorName.Text = string.Empty;
            txtBiography.Text = string.Empty;
            chkIsActive.Checked = true;
            UiHelper.ShowDateTimePickerValue(dtpBirthDate, null);
            UiHelper.ShowDateTimePickerValue(dtpDeadDate, null);
            txtAuthorName.Focus();
        }

        private async void FormInputAuthor_Load(object sender, EventArgs e)
        {
            if (isAddMode)
            {
                // Thêm mới
                this.Text = "Thêm mới tác giả";
                chkIsActive.Checked = true;
                UiHelper.ShowDateTimePickerValue(dtpBirthDate, null);
                UiHelper.ShowDateTimePickerValue(dtpDeadDate, null);
                UiHelper.RegisterDateTimePickerFormat(dtpBirthDate);
                UiHelper.RegisterDateTimePickerFormat(dtpDeadDate);
            }
            else
            {
                // Cập nhật
                this.Text = "Cập nhật thông tin tác giả";
                var editedAuthor = await ServiceManager.Author.GetAsync(AuthorId);
                if (editedAuthor != null)
                {
                    txtAuthorName.Text = editedAuthor.AuthorName;
                    txtBiography.Text = editedAuthor.Biography;
                    chkIsActive.Checked = editedAuthor.IsActive;

                    UiHelper.ShowDateTimePickerValue(dtpBirthDate, editedAuthor.BirthDate);
                    UiHelper.ShowDateTimePickerValue(dtpDeadDate, editedAuthor.DeathDate);
                }

            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            Author author = new Author
            {
                AuthorName = txtAuthorName.Text,
                Biography = txtBiography.Text.Trim(),
                IsActive = chkIsActive.Checked,
                BirthDate = dtpBirthDate.Checked ? dtpBirthDate.Value : null,
                DeathDate = dtpDeadDate.Checked ? dtpDeadDate.Value : null
            };
            if (isAddMode)
            {
                await ServiceManager.Author.AddAsync(author);
                if (AuthorAdded != null)
                {
                    AuthorAdded(author, EventArgs.Empty);
                }


                DialogResult result = MessageBox.Show(
                    "Thêm tác giả thành công!\nBạn có muốn tiếp tục nhập tác giả khác không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    ResetForm();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                author.AuthorId = AuthorId;
                await ServiceManager.Author.UpdateAsync(author);
                if (AuthorUpdated != null)
                {
                    AuthorUpdated(author, EventArgs.Empty);
                }
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInputAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (btnSave.Enabled)
                {
                    btnSave.PerformClick();
                }
            }
        }
    }
}
