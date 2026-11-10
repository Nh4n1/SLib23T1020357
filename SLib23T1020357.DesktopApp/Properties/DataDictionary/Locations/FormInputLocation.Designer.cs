namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Locations
{
    partial class FormInputLocation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            chkIsActive = new CheckBox();
            txtDescription = new TextBox();
            label6 = new Label();
            txtShelf = new TextBox();
            label5 = new Label();
            txtRoom = new TextBox();
            label4 = new Label();
            txtFloor = new TextBox();
            label3 = new Label();
            txtLocationName = new TextBox();
            label2 = new Label();
            txtLocationCode = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIsActive);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtShelf);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtRoom);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFloor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLocationName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLocationCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(709, 616);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vị trí lưu trữ";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(35, 559);
            chkIsActive.Margin = new Padding(3, 4, 3, 4);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(227, 24);
            chkIsActive.TabIndex = 12;
            chkIsActive.Text = "Đang sử dụng trong hệ thống";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(35, 461);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(637, 84);
            txtDescription.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 431);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 10;
            label6.Text = "Mô tả:";
            // 
            // txtShelf
            // 
            txtShelf.Location = new Point(35, 384);
            txtShelf.Margin = new Padding(3, 4, 3, 4);
            txtShelf.Name = "txtShelf";
            txtShelf.Size = new Size(637, 27);
            txtShelf.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 353);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 8;
            label5.Text = "Kệ:";
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(35, 307);
            txtRoom.Margin = new Padding(3, 4, 3, 4);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(637, 27);
            txtRoom.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 276);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Phòng:";
            // 
            // txtFloor
            // 
            txtFloor.Location = new Point(35, 229);
            txtFloor.Margin = new Padding(3, 4, 3, 4);
            txtFloor.Name = "txtFloor";
            txtFloor.Size = new Size(637, 27);
            txtFloor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 199);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 4;
            label3.Text = "Tầng:";
            // 
            // txtLocationName
            // 
            txtLocationName.Location = new Point(35, 152);
            txtLocationName.Margin = new Padding(3, 4, 3, 4);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(637, 27);
            txtLocationName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 121);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên vị trí:";
            // 
            // txtLocationCode
            // 
            txtLocationCode.Location = new Point(35, 75);
            txtLocationCode.Margin = new Padding(3, 4, 3, 4);
            txtLocationCode.Name = "txtLocationCode";
            txtLocationCode.Size = new Size(637, 27);
            txtLocationCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 44);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã vị trí:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(483, 643);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 33);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu dữ liệu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(605, 643);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(114, 33);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormInputLocation
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(731, 693);
            Controls.Add(buttonCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInputLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập vị trí lưu trữ";
            Load += FormInputLocation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkIsActive;
        private TextBox txtDescription;
        private Label label6;
        private TextBox txtShelf;
        private Label label5;
        private TextBox txtRoom;
        private Label label4;
        private TextBox txtFloor;
        private Label label3;
        private TextBox txtLocationName;
        private Label label2;
        private TextBox txtLocationCode;
        private Label label1;
        private Button btnSave;
        private Button buttonCancel;
    }
}
