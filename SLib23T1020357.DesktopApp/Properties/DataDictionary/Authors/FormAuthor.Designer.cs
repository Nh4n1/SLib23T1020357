namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Authors
{
    partial class FormAuthor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvAuthor = new DataGridView();
            ColumnAuthorName = new DataGridViewTextBoxColumn();
            ColumnBirthDay = new DataGridViewTextBoxColumn();
            ColumnDeadDate = new DataGridViewTextBoxColumn();
            ColumnAuthorStatus = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 116);
            panel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = Resources.delete;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(851, 65);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(86, 31);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Image = Resources.edit;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(742, 65);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(86, 31);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Sửa ";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = Resources.add;
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(608, 65);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 31);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Bổ sung";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(30, 65);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(561, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
            // 
            // dgvAuthor
            // 
            dgvAuthor.AllowUserToAddRows = false;
            dgvAuthor.AllowUserToDeleteRows = false;
            dgvAuthor.AllowUserToResizeRows = false;
            dgvAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthor.Columns.AddRange(new DataGridViewColumn[] { ColumnAuthorName, ColumnBirthDay, ColumnDeadDate, ColumnAuthorStatus });
            dgvAuthor.Dock = DockStyle.Fill;
            dgvAuthor.Location = new Point(0, 116);
            dgvAuthor.Margin = new Padding(3, 4, 3, 4);
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.RowHeadersWidth = 51;
            dgvAuthor.Size = new Size(963, 620);
            dgvAuthor.TabIndex = 5;
            dgvAuthor.CellContentDoubleClick += dgvAuthor_CellContentDoubleClick;
            dgvAuthor.DoubleClick += dgvAuthor_DoubleClick;
            // 
            // ColumnAuthorName
            // 
            ColumnAuthorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnAuthorName.HeaderText = "Tên tác giả";
            ColumnAuthorName.MinimumWidth = 6;
            ColumnAuthorName.Name = "ColumnAuthorName";
            // 
            // ColumnBirthDay
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            ColumnBirthDay.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnBirthDay.HeaderText = "Ngày sinh";
            ColumnBirthDay.MinimumWidth = 6;
            ColumnBirthDay.Name = "ColumnBirthDay";
            ColumnBirthDay.Width = 125;
            // 
            // ColumnDeadDate
            // 
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            ColumnDeadDate.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnDeadDate.HeaderText = "Ngày mất";
            ColumnDeadDate.MinimumWidth = 6;
            ColumnDeadDate.Name = "ColumnDeadDate";
            ColumnDeadDate.Width = 125;
            // 
            // ColumnAuthorStatus
            // 
            ColumnAuthorStatus.HeaderText = "Hoạt động";
            ColumnAuthorStatus.MinimumWidth = 6;
            ColumnAuthorStatus.Name = "ColumnAuthorStatus";
            ColumnAuthorStatus.Resizable = DataGridViewTriState.True;
            ColumnAuthorStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnAuthorStatus.Width = 125;
            // 
            // FormAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(963, 736);
            Controls.Add(dgvAuthor);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAuthor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tác giả";
            Load += FormAuthor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvAuthor;
        private DataGridViewTextBoxColumn ColumnAuthorName;
        private DataGridViewTextBoxColumn ColumnBirthDay;
        private DataGridViewTextBoxColumn ColumnDeadDate;
        private DataGridViewCheckBoxColumn ColumnAuthorStatus;
    }
}