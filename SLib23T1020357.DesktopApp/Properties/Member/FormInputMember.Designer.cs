namespace SLib23T1020357.DesktopApp.Properties.Member
{
    partial class FormInputMember
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
            groupBox1 = new GroupBox();
            txtNotes = new TextBox();
            label12 = new Label();
            cboMemberStatus = new ComboBox();
            label11 = new Label();
            dtpExpiredAt = new DateTimePicker();
            label10 = new Label();
            dtpRegisteredAt = new DateTimePicker();
            label9 = new Label();
            txtOrganization = new TextBox();
            label8 = new Label();
            cboMemberType = new ComboBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            cboGender = new ComboBox();
            label3 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label2 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            txtMemberCode = new TextBox();
            lblMemberCode = new Label();
            btnSave = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cboMemberStatus);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dtpExpiredAt);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpRegisteredAt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtOrganization);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboMemberType);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboGender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMemberCode);
            groupBox1.Controls.Add(lblMemberCode);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết độc giả";
            // 
            // lblMemberCode
            // 
            lblMemberCode.AutoSize = true;
            lblMemberCode.Location = new Point(20, 30);
            lblMemberCode.Name = "lblMemberCode";
            lblMemberCode.Size = new Size(93, 15);
            lblMemberCode.TabIndex = 0;
            lblMemberCode.Text = "Mã bạn đọc (*):";
            // 
            // txtMemberCode
            // 
            txtMemberCode.Location = new Point(20, 50);
            txtMemberCode.Name = "txtMemberCode";
            txtMemberCode.Size = new Size(300, 23);
            txtMemberCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 85);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Họ và tên (*):";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(20, 105);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 23);
            txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 140);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Ngày sinh:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(20, 160);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.ShowCheckBox = true;
            dtpDateOfBirth.Size = new Size(300, 23);
            dtpDateOfBirth.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 195);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Giới tính:";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(20, 215);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(300, 23);
            cboGender.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 250);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 270);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 305);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 10;
            label5.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(20, 325);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 23);
            txtPhone.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 30);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 12;
            label6.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(360, 50);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 23);
            txtAddress.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 85);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 14;
            label7.Text = "Loại độc giả (*):";
            // 
            // cboMemberType
            // 
            cboMemberType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMemberType.FormattingEnabled = true;
            cboMemberType.Location = new Point(360, 105);
            cboMemberType.Name = "cboMemberType";
            cboMemberType.Size = new Size(300, 23);
            cboMemberType.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(360, 140);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 16;
            label8.Text = "Đơn vị / Cơ quan / Lớp:";
            // 
            // txtOrganization
            // 
            txtOrganization.Location = new Point(360, 160);
            txtOrganization.Name = "txtOrganization";
            txtOrganization.Size = new Size(300, 23);
            txtOrganization.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(360, 195);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 18;
            label9.Text = "Ngày đăng ký:";
            // 
            // dtpRegisteredAt
            // 
            dtpRegisteredAt.CustomFormat = "dd/MM/yyyy";
            dtpRegisteredAt.Format = DateTimePickerFormat.Custom;
            dtpRegisteredAt.Location = new Point(360, 215);
            dtpRegisteredAt.Name = "dtpRegisteredAt";
            dtpRegisteredAt.Size = new Size(140, 23);
            dtpRegisteredAt.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(520, 195);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 20;
            label10.Text = "Ngày hết hạn:";
            // 
            // dtpExpiredAt
            // 
            dtpExpiredAt.CustomFormat = "dd/MM/yyyy";
            dtpExpiredAt.Format = DateTimePickerFormat.Custom;
            dtpExpiredAt.Location = new Point(520, 215);
            dtpExpiredAt.Name = "dtpExpiredAt";
            dtpExpiredAt.ShowCheckBox = true;
            dtpExpiredAt.Size = new Size(140, 23);
            dtpExpiredAt.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(360, 250);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 22;
            label11.Text = "Trạng thái:";
            // 
            // cboMemberStatus
            // 
            cboMemberStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMemberStatus.FormattingEnabled = true;
            cboMemberStatus.Location = new Point(360, 270);
            cboMemberStatus.Name = "cboMemberStatus";
            cboMemberStatus.Size = new Size(300, 23);
            cboMemberStatus.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(360, 305);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 24;
            label12.Text = "Ghi chú:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(360, 325);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(300, 45);
            txtNotes.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(482, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu dữ liệu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(592, 415);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 30);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Đóng";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormInputMember
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(704, 460);
            Controls.Add(buttonCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInputMember";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin độc giả";
            Load += FormInputMember_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblMemberCode;
        private TextBox txtMemberCode;
        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private ComboBox cboGender;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtAddress;
        private Label label7;
        private ComboBox cboMemberType;
        private Label label8;
        private TextBox txtOrganization;
        private Label label9;
        private DateTimePicker dtpRegisteredAt;
        private Label label10;
        private DateTimePicker dtpExpiredAt;
        private Label label11;
        private ComboBox cboMemberStatus;
        private Label label12;
        private TextBox txtNotes;
        private Button btnSave;
        private Button buttonCancel;
    }
}