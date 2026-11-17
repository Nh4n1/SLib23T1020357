using SLib23T1020357.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLib23T1020357.DesktopApp.Properties.Member
{
    public partial class FormInputMemberType : Form
    {
        public event EventHandler MemberTypeUpdated;
        public event EventHandler MemberTypeAdded;

        public FormInputMemberType()
        {
            InitializeComponent();
        }
        public bool isAddMode { get; set; }

        public int MemberTypeId { get; set; }

        private async void FormInputMemberType_Load(object sender, EventArgs e)
        {
            if (isAddMode)
            {
                Text = "Thêm loại độc giả mới";
                chkIsActive.Checked = true;
                return;
            }
            try
            {
                Text = "Cập nhật loại độc giả";
                var memberType = await ServiceManager.MemberType.GetAsync(MemberTypeId);
                txtTypeName.Text = memberType.TypeName;
                nudMaxActiveLoans.Value = Math.Clamp(memberType.MaxActiveLoans,
                    (int)nudMaxActiveLoans.Minimum, (int)nudMaxActiveLoans.Maximum);
                nudLoanPeriodDays.Value = Math.Clamp(memberType.LoanPeriodDays,
                    (int)nudLoanPeriodDays.Minimum, (int)nudLoanPeriodDays.Maximum);
                nudMaxRenewals.Value = Math.Clamp(memberType.MaxRenewals,
                    (int)nudMaxRenewals.Minimum, (int)nudMaxRenewals.Maximum);
                chkIsActive.Checked = memberType.IsActive;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải thông tin loại độc giả:\n{ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

        }
        private async void btnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                var memberType = new MemberType
                {
                    TypeName = txtTypeName.Text.Trim(),
                    MaxActiveLoans = (int)nudMaxActiveLoans.Value,
                    LoanPeriodDays = (int)nudLoanPeriodDays.Value,
                    MaxRenewals = (int)nudMaxRenewals.Value,
                    IsActive = chkIsActive.Checked
                };

                if (isAddMode)
                {
                    await ServiceManager.MemberType.AddAsync(memberType);
                    MemberTypeAdded?.Invoke(memberType, EventArgs.Empty);
                }
                else
                {
                    memberType.MemberTypeId = MemberTypeId;
                    if (!await ServiceManager.MemberType.UpdateAsync(memberType))
                    {
                        MessageBox.Show("Không tìm thấy loại độc giả cần cập nhật.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MemberTypeUpdated?.Invoke(memberType, EventArgs.Empty);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu thông tin loại độc giả:\n{ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }
    }
}
