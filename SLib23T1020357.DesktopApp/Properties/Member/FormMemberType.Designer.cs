namespace SLib23T1020357.DesktopApp.Properties.Member
{
    partial class FormMemberType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvMemberType = new DataGridView();
            ColumnTypeName = new DataGridViewTextBoxColumn();
            ColumnMaxActiveLoans = new DataGridViewTextBoxColumn();
            ColumnLoanPeriodDays = new DataGridViewTextBoxColumn();
            ColumnMaxRenewals = new DataGridViewTextBoxColumn();
            ColumnIsActive = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberType).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(568, 53);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(487, 53);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(406, 53);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvMemberType
            // 
            dgvMemberType.AllowUserToAddRows = false;
            dgvMemberType.AllowUserToDeleteRows = false;
            dgvMemberType.AllowUserToResizeRows = false;
            dgvMemberType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberType.Columns.AddRange(new DataGridViewColumn[] { ColumnTypeName, ColumnMaxActiveLoans, ColumnLoanPeriodDays, ColumnMaxRenewals, ColumnIsActive });
            dgvMemberType.Dock = DockStyle.Fill;
            dgvMemberType.Location = new Point(0, 100);
            dgvMemberType.Margin = new Padding(3, 2, 3, 2);
            dgvMemberType.Name = "dgvMemberType";
            dgvMemberType.RowHeadersWidth = 51;
            dgvMemberType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberType.Size = new Size(800, 350);
            dgvMemberType.TabIndex = 2;
            // 
            // ColumnTypeName
            // 
            ColumnTypeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnTypeName.HeaderText = "Tên loại độc giả";
            ColumnTypeName.MinimumWidth = 6;
            ColumnTypeName.Name = "ColumnTypeName";
            // 
            // ColumnMaxActiveLoans
            // 
            ColumnMaxActiveLoans.HeaderText = "Số sách mượn tối đa";
            ColumnMaxActiveLoans.MinimumWidth = 6;
            ColumnMaxActiveLoans.Name = "ColumnMaxActiveLoans";
            ColumnMaxActiveLoans.Width = 170;
            // 
            // ColumnLoanPeriodDays
            // 
            ColumnLoanPeriodDays.HeaderText = "Số ngày mượn";
            ColumnLoanPeriodDays.MinimumWidth = 6;
            ColumnLoanPeriodDays.Name = "ColumnLoanPeriodDays";
            ColumnLoanPeriodDays.Width = 140;
            // 
            // ColumnMaxRenewals
            // 
            ColumnMaxRenewals.HeaderText = "Số lần gia hạn";
            ColumnMaxRenewals.MinimumWidth = 6;
            ColumnMaxRenewals.Name = "ColumnMaxRenewals";
            ColumnMaxRenewals.Width = 140;
            // 
            // ColumnIsActive
            // 
            ColumnIsActive.HeaderText = "Đang sử dụng";
            ColumnIsActive.MinimumWidth = 6;
            ColumnIsActive.Name = "ColumnIsActive";
            ColumnIsActive.Width = 125;
            // 
            // FormMemberType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMemberType);
            Controls.Add(panel1);
            Name = "FormMemberType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMemberType";
            Load += FormMemberType_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMemberType).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvMemberType;
        private DataGridViewTextBoxColumn ColumnTypeName;
        private DataGridViewTextBoxColumn ColumnMaxActiveLoans;
        private DataGridViewTextBoxColumn ColumnLoanPeriodDays;
        private DataGridViewTextBoxColumn ColumnMaxRenewals;
        private DataGridViewCheckBoxColumn ColumnIsActive;
    }
}