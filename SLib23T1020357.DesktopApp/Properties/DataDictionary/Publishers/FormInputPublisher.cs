using SLib23T1020357.Models.Entities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Publishers
{
    public partial class FormInputPublisher : Form
    {
        public event EventHandler? PublisherAdded;
        public event EventHandler? PublisherUpdated;

        public FormInputPublisher()
        {
            InitializeComponent();
        }

        public bool isAddMode { get; set; }

        public int PublisherId { get; set; }

        private async void FormInputPublisher_Load(object? sender, EventArgs e)
        {
            if (isAddMode)
            {
                Text = "Thêm mới nhà xuất bản";
                chkIsActive.Checked = true;
                return;
            }

            try
            {
                Text = "Cập nhật thông tin nhà xuất bản";
                var publisher = await ServiceManager.Publisher.GetAsync(PublisherId);
                txtPublisherName.Text = publisher.PublisherName;
                txtAddress.Text = publisher.Address;
                txtPhone.Text = publisher.Phone;
                txtEmail.Text = publisher.Email;
                txtWebsite.Text = publisher.Website;
                chkIsActive.Checked = publisher.IsActive;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải thông tin nhà xuất bản:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                var publisher = new Publisher
                {
                    PublisherName = txtPublisherName.Text.Trim(),
                    Address = ToOptionalValue(txtAddress.Text),
                    Phone = ToOptionalValue(txtPhone.Text),
                    Email = ToOptionalValue(txtEmail.Text),
                    Website = ToOptionalValue(txtWebsite.Text),
                    IsActive = chkIsActive.Checked
                };

                if (isAddMode)
                {
                    await ServiceManager.Publisher.AddAsync(publisher);
                    PublisherAdded?.Invoke(publisher, EventArgs.Empty);
                }
                else
                {
                    publisher.PublisherId = PublisherId;
                    if (!await ServiceManager.Publisher.UpdateAsync(publisher))
                    {
                        MessageBox.Show("Không tìm thấy nhà xuất bản cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    PublisherUpdated?.Invoke(publisher, EventArgs.Empty);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu thông tin nhà xuất bản:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private static string? ToOptionalValue(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }
    }
}
