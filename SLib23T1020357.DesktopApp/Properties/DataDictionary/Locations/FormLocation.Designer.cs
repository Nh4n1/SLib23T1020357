namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Locations
{
    partial class FormLocation
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
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColumnLocationCode = new DataGridViewTextBoxColumn();
            ColumnLocationName = new DataGridViewTextBoxColumn();
            ColumnFloor = new DataGridViewTextBoxColumn();
            ColumnRoom = new DataGridViewTextBoxColumn();
            ColumnShelf = new DataGridViewTextBoxColumn();
            ColumnLocationStatus = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 116);
            panel1.TabIndex = 3;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(815, 65);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(86, 31);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(713, 65);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(86, 31);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Sửa ";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(611, 65);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(86, 31);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Bổ sung";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 65);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(561, 27);
            textBox1.TabIndex = 1;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnLocationCode, ColumnLocationName, ColumnFloor, ColumnRoom, ColumnShelf, ColumnLocationStatus });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 116);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(914, 484);
            dataGridView1.TabIndex = 4;
            // 
            // ColumnLocationCode
            // 
            ColumnLocationCode.HeaderText = "Mã vị trí";
            ColumnLocationCode.MinimumWidth = 6;
            ColumnLocationCode.Name = "ColumnLocationCode";
            ColumnLocationCode.Width = 125;
            // 
            // ColumnLocationName
            // 
            ColumnLocationName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnLocationName.HeaderText = "Tên vị trí";
            ColumnLocationName.MinimumWidth = 6;
            ColumnLocationName.Name = "ColumnLocationName";
            // 
            // ColumnFloor
            // 
            ColumnFloor.HeaderText = "Tầng";
            ColumnFloor.MinimumWidth = 6;
            ColumnFloor.Name = "ColumnFloor";
            ColumnFloor.Width = 125;
            // 
            // ColumnRoom
            // 
            ColumnRoom.HeaderText = "Phòng";
            ColumnRoom.MinimumWidth = 6;
            ColumnRoom.Name = "ColumnRoom";
            ColumnRoom.Width = 125;
            // 
            // ColumnShelf
            // 
            ColumnShelf.HeaderText = "Kệ";
            ColumnShelf.MinimumWidth = 6;
            ColumnShelf.Name = "ColumnShelf";
            ColumnShelf.Width = 125;
            // 
            // ColumnLocationStatus
            // 
            ColumnLocationStatus.HeaderText = "Trạng thái";
            ColumnLocationStatus.MinimumWidth = 6;
            ColumnLocationStatus.Name = "ColumnLocationStatus";
            ColumnLocationStatus.Width = 125;
            // 
            // FormLocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý vị trí lưu trữ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnLocationCode;
        private DataGridViewTextBoxColumn ColumnLocationName;
        private DataGridViewTextBoxColumn ColumnFloor;
        private DataGridViewTextBoxColumn ColumnRoom;
        private DataGridViewTextBoxColumn ColumnShelf;
        private DataGridViewCheckBoxColumn ColumnLocationStatus;
    }
}