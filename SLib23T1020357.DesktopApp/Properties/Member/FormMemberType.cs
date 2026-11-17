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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SLib23T1020357.DesktopApp.Properties.Member
{
    /// <summary>
    /// Form quản lý (danh sách, tìm kiếm, thêm, sửa, xóa) loại độc giả.
    /// </summary>
    public partial class FormMemberType : Form
    {
        private BindingList<MemberType> bsMemberType;
        private List<MemberType> listMemberTypes;
        public FormMemberType()
        {
            InitializeComponent();
        }


        private async void FormMemberType_Load(object sender, EventArgs e)
        {
            await getData();
        }

        private async Task getData()
        {
            listMemberTypes = await ServiceManager.MemberType.ListAsync();
            bsMemberType = new BindingList<MemberType>(listMemberTypes);

            dgvMemberType.AutoGenerateColumns = false;


            ColumnTypeName.DataPropertyName = nameof(MemberType.TypeName);
            ColumnMaxActiveLoans.DataPropertyName = nameof(MemberType.MaxActiveLoans);
            ColumnLoanPeriodDays.DataPropertyName = nameof(MemberType.LoanPeriodDays);
            ColumnMaxRenewals.DataPropertyName = nameof(MemberType.MaxRenewals);
            ColumnIsActive.DataPropertyName = nameof(MemberType.IsActive);
            dgvMemberType.DataSource = bsMemberType;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormInputMemberType formInputMemberType = new FormInputMemberType();
            formInputMemberType.isAddMode = true;
            formInputMemberType.MemberTypeAdded += Frm_MemberTypeUpdate;
            formInputMemberType.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var memberType = GetSelectedMemberType();
            if (memberType == null)
            {
                MessageBox.Show("Vui lòng chọn loại độc giả để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormInputMemberType formInputMemberType = new FormInputMemberType 
            { 
                isAddMode=false, 
                MemberTypeId=memberType.MemberTypeId
            };
            formInputMemberType.MemberTypeUpdated+= Frm_MemberTypeUpdate;
            formInputMemberType.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private MemberType? GetSelectedMemberType()
        {
            return dgvMemberType.CurrentRow?.DataBoundItem as MemberType;
        }
        public async void Frm_MemberTypeUpdate(object sender, EventArgs e)
        {
            await getData();
        }
    }

}
