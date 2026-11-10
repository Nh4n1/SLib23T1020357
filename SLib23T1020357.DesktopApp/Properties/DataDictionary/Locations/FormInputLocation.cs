using SLib23T1020357.Models.Entities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Locations
{
    public partial class FormInputLocation : Form
    {
        public event EventHandler? LocationAdded;
        public event EventHandler? LocationUpdated;

        public FormInputLocation()
        {
            InitializeComponent();
        }

        public bool isAddMode { get; set; }

        public int LocationId { get; set; }

        private async void FormInputLocation_Load(object? sender, EventArgs e)
        {
            if (isAddMode)
            {
                Text = "Thêm mới vị trí lưu trữ";
                chkIsActive.Checked = true;
                return;
            }

            try
            {
                Text = "Cập nhật vị trí lưu trữ";
                var location = await ServiceManager.Location.GetAsync(LocationId);
                txtLocationCode.Text = location.LocationCode;
                txtLocationName.Text = location.LocationName;
                txtFloor.Text = location.Floor;
                txtRoom.Text = location.Room;
                txtShelf.Text = location.Shelf;
                txtDescription.Text = location.Description;
                chkIsActive.Checked = location.IsActive;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải thông tin vị trí:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                var location = new Location
                {
                    LocationCode = txtLocationCode.Text.Trim(),
                    LocationName = txtLocationName.Text.Trim(),
                    Floor = ToOptionalValue(txtFloor.Text),
                    Room = ToOptionalValue(txtRoom.Text),
                    Shelf = ToOptionalValue(txtShelf.Text),
                    Description = ToOptionalValue(txtDescription.Text),
                    IsActive = chkIsActive.Checked
                };

                if (isAddMode)
                {
                    await ServiceManager.Location.AddAsync(location);
                    LocationAdded?.Invoke(location, EventArgs.Empty);
                }
                else
                {
                    location.LocationId = LocationId;
                    if (!await ServiceManager.Location.UpdateAsync(location))
                    {
                        MessageBox.Show("Không tìm thấy vị trí cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    LocationUpdated?.Invoke(location, EventArgs.Empty);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu thông tin vị trí:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
