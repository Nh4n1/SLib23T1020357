
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLib23T1020357.Models.Entities;
using Timer = System.Windows.Forms.Timer;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Authors
{
    public partial class FormAuthor : Form
    {
        private BindingList<Author> bsAuthors;
        private List<Author> listAuthors;

        // Timer xử lý tìm kiếm tự động
        private Timer searchTimer;

        public FormAuthor()
        {
            InitializeComponent();

            // Khởi tạo Timer
            searchTimer = new Timer();
            searchTimer.Interval = 500;
        }

        private async void FormAuthor_Load(object sender, EventArgs e)
        {
            await GetData();
        }

        private async Task GetData()
        {
            // Load data from the database
            listAuthors = await ServiceManager.Author.ListAsync();

            // Bind data to the DataGridView
            bsAuthors = new BindingList<Author>(listAuthors.ToList());

            // Set the DataGridView properties
            dgvAuthor.AutoGenerateColumns = false;

            ColumnAuthorName.DataPropertyName = nameof(Author.AuthorName);
            ColumnBirthDay.DataPropertyName = nameof(Author.BirthDate);
            ColumnDeadDate.DataPropertyName = nameof(Author.DeathDate);
            ColumnAuthorStatus.DataPropertyName = nameof(Author.IsActive);

            dgvAuthor.DataSource = bsAuthors;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormInputAuthor formInputAuthor = new FormInputAuthor();
            formInputAuthor.isAddMode = true;
            formInputAuthor.AuthorAdded += Frm_AuthorAdd;
            formInputAuthor.ShowDialog();
        }

        private async void Frm_AuthorAdd(object sender, EventArgs e)
        {
            await GetData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dgvAuthor.CurrentRow?.DataBoundItem is not Author selectedAuthor)
            {
                MessageBox.Show("Vui lòng chọn tác giả cần sửa.");
                return;
            }

            int authorId = selectedAuthor.AuthorId;

            FormInputAuthor formInputAuthor = new FormInputAuthor
            {
                isAddMode = false,
                AuthorId = authorId
            };

            formInputAuthor.AuthorUpdated += Frm_AuthorUpdate;
            formInputAuthor.ShowDialog();
        }

        public async void Frm_AuthorUpdate(object sender, EventArgs e)
        {
            await GetData();
        }

        private void dgvAuthor_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dgvAuthor_CellContentDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvAuthor.Rows[e.RowIndex].DataBoundItem is not Author selectedAuthor)
                return;

            FormInputAuthor formInputAuthor = new FormInputAuthor
            {
                isAddMode = false,
                AuthorId = selectedAuthor.AuthorId
            };

            formInputAuthor.AuthorUpdated += Frm_AuthorUpdate;
            formInputAuthor.ShowDialog();
        }

        // Nhận sự kiện khi nội dung TextBox thay đổi
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (listAuthors == null)
                return;

            string keyword = txtSearch.Text.Trim();

            // Nếu từ khóa rỗng thì hiển thị toàn bộ danh sách
            var filteredAuthors = string.IsNullOrEmpty(keyword)
                ? listAuthors
                : listAuthors
                    .Where(author =>
                        author.AuthorName != null &&
                        author.AuthorName.Contains(
                            keyword,
                            StringComparison.OrdinalIgnoreCase))
                    .ToList();

            // Cập nhật dữ liệu hiển thị
            bsAuthors = new BindingList<Author>(filteredAuthors.ToList());
            dgvAuthor.DataSource = bsAuthors;
        }

     
    }
}
