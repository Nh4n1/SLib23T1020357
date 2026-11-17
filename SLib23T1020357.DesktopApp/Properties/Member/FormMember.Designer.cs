namespace SLib23T1020357.DesktopApp.Properties.Member
{
    partial class FormMember
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnReset = new Button();
            btnSearch = new Button();
            cboStatusFilter = new ComboBox();
            cboMemberTypeFilter = new ComboBox();
            txtSearch = new TextBox();
            dgvMember = new DataGridView();
            ColumnMemberCode = new DataGridViewTextBoxColumn();
            ColumnFullName = new DataGridViewTextBoxColumn();
            ColumnTypeName = new DataGridViewTextBoxColumn();
            ColumnMaxActiveLoans = new DataGridViewTextBoxColumn();
            ColumnLoanPeriodDays = new DataGridViewTextBoxColumn();
            ColumnMaxRenewals = new DataGridViewTextBoxColumn();
            ColumnGender = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnExpireAt = new DataGridViewTextBoxColumn();
            ColumnMemberStatus = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            cboPageSize = new ComboBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnPrevPage = new Button();
            btnFirstPage = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cboStatusFilter);
            panel1.Controls.Add(cboMemberTypeFilter);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 100);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(540, 64);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 25);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(439, 64);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 25);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(338, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 25);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(439, 26);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 25);
            btnReset.TabIndex = 4;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(338, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 25);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboStatusFilter
            // 
            cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatusFilter.FormattingEnabled = true;
            cboStatusFilter.Location = new Point(175, 65);
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new Size(128, 23);
            cboStatusFilter.TabIndex = 2;
            // 
            // cboMemberTypeFilter
            // 
            cboMemberTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMemberTypeFilter.FormattingEnabled = true;
            cboMemberTypeFilter.Location = new Point(23, 65);
            cboMemberTypeFilter.Name = "cboMemberTypeFilter";
            cboMemberTypeFilter.Size = new Size(140, 23);
            cboMemberTypeFilter.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(23, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên hoặc mã bạn đọc để tìm...";
            txtSearch.Size = new Size(280, 23);
            txtSearch.TabIndex = 0;
            // 
            // dgvMember
            // 
            dgvMember.AllowUserToAddRows = false;
            dgvMember.AllowUserToDeleteRows = false;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Columns.AddRange(new DataGridViewColumn[] { ColumnMemberCode, ColumnFullName, ColumnTypeName, ColumnMaxActiveLoans, ColumnLoanPeriodDays, ColumnMaxRenewals, ColumnGender, ColumnPhone, ColumnExpireAt, ColumnMemberStatus });
            dgvMember.Dock = DockStyle.Fill;
            dgvMember.Location = new Point(0, 100);
            dgvMember.MultiSelect = false;
            dgvMember.Name = "dgvMember";
            dgvMember.ReadOnly = true;
            dgvMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMember.Size = new Size(1131, 513);
            dgvMember.TabIndex = 1;
            // 
            // ColumnMemberCode
            // 
            ColumnMemberCode.HeaderText = "Mã bạn đọc";
            ColumnMemberCode.Name = "ColumnMemberCode";
            ColumnMemberCode.ReadOnly = true;
            // 
            // ColumnFullName
            // 
            ColumnFullName.HeaderText = "Họ và tên";
            ColumnFullName.Name = "ColumnFullName";
            ColumnFullName.ReadOnly = true;
            ColumnFullName.Width = 150;
            // 
            // ColumnTypeName
            // 
            ColumnTypeName.HeaderText = "Loại độc giả";
            ColumnTypeName.Name = "ColumnTypeName";
            ColumnTypeName.ReadOnly = true;
            ColumnTypeName.Width = 120;
            // 
            // ColumnMaxActiveLoans
            // 
            ColumnMaxActiveLoans.HeaderText = "Mượn tối đa";
            ColumnMaxActiveLoans.Name = "ColumnMaxActiveLoans";
            ColumnMaxActiveLoans.ReadOnly = true;
            // 
            // ColumnLoanPeriodDays
            // 
            ColumnLoanPeriodDays.HeaderText = "Hạn mượn tối đa";
            ColumnLoanPeriodDays.Name = "ColumnLoanPeriodDays";
            ColumnLoanPeriodDays.ReadOnly = true;
            // 
            // ColumnMaxRenewals
            // 
            ColumnMaxRenewals.HeaderText = "Gia hạn tối đa";
            ColumnMaxRenewals.Name = "ColumnMaxRenewals";
            ColumnMaxRenewals.ReadOnly = true;
            // 
            // ColumnGender
            // 
            ColumnGender.HeaderText = "Giới tính";
            ColumnGender.Name = "ColumnGender";
            ColumnGender.ReadOnly = true;
            // 
            // ColumnPhone
            // 
            ColumnPhone.HeaderText = "Số điện thoại";
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.ReadOnly = true;
            ColumnPhone.Width = 110;
            // 
            // ColumnExpireAt
            // 
            ColumnExpireAt.HeaderText = "Ngày hết hạn";
            ColumnExpireAt.Name = "ColumnExpireAt";
            ColumnExpireAt.ReadOnly = true;
            ColumnExpireAt.Width = 110;
            // 
            // ColumnMemberStatus
            // 
            ColumnMemberStatus.HeaderText = "Trạng thái";
            ColumnMemberStatus.Name = "ColumnMemberStatus";
            ColumnMemberStatus.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(cboPageSize);
            panel3.Controls.Add(btnLastPage);
            panel3.Controls.Add(btnNextPage);
            panel3.Controls.Add(btnPrevPage);
            panel3.Controls.Add(btnFirstPage);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 613);
            panel3.Name = "panel3";
            panel3.Size = new Size(1131, 40);
            panel3.TabIndex = 2;
            // 
            // cboPageSize
            // 
            cboPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPageSize.FormattingEnabled = true;
            cboPageSize.Location = new Point(678, 6);
            cboPageSize.Name = "cboPageSize";
            cboPageSize.Size = new Size(80, 23);
            cboPageSize.TabIndex = 4;
            cboPageSize.SelectedIndexChanged += cboPageSize_SelectedIndexChanged;
            // 
            // btnLastPage
            // 
            btnLastPage.Location = new Point(578, 5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(75, 25);
            btnLastPage.TabIndex = 3;
            btnLastPage.Text = "Cuối >>";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(493, 5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(75, 25);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Sau >";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Location = new Point(408, 5);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(75, 25);
            btnPrevPage.TabIndex = 1;
            btnPrevPage.Text = "< Trước";
            btnPrevPage.UseVisualStyleBackColor = true;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Location = new Point(323, 5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(75, 25);
            btnFirstPage.TabIndex = 0;
            btnFirstPage.Text = "<< Đầu";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // FormMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 653);
            Controls.Add(dgvMember);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý độc giả";
            Load += FormMember_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboStatusFilter;
        private ComboBox cboMemberTypeFilter;
        private TextBox txtSearch;
        private Button btnReset;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvMember;
        private DataGridViewTextBoxColumn ColumnMemberCode;
        private DataGridViewTextBoxColumn ColumnFullName;
        private DataGridViewTextBoxColumn ColumnTypeName;
        private DataGridViewTextBoxColumn ColumnMaxActiveLoans;
        private DataGridViewTextBoxColumn ColumnLoanPeriodDays;
        private DataGridViewTextBoxColumn ColumnMaxRenewals;
        private DataGridViewTextBoxColumn ColumnGender;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnExpireAt;
        private DataGridViewTextBoxColumn ColumnMemberStatus;
        private Panel panel3;
        private Button btnFirstPage;
        private ComboBox cboPageSize;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnPrevPage;
    }
}