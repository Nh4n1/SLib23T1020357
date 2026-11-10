namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Publishers
{
    partial class FormInputPublisher
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
            txtWebsite = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            txtPublisherName = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIsActive);
            groupBox1.Controls.Add(txtWebsite);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPublisherName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(709, 560);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà xuất bản";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(35, 517);
            chkIsActive.Margin = new Padding(3, 4, 3, 4);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(227, 24);
            chkIsActive.TabIndex = 10;
            chkIsActive.Text = "Đang sử dụng trong hệ thống";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(35, 469);
            txtWebsite.Margin = new Padding(3, 4, 3, 4);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(637, 27);
            txtWebsite.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 439);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "Website:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 392);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(637, 27);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 361);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(35, 315);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(637, 27);
            txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 284);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 4;
            label3.Text = "Điện thoại:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(35, 131);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(637, 132);
            txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 100);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Địa chỉ:";
            // 
            // txtPublisherName
            // 
            txtPublisherName.Location = new Point(35, 56);
            txtPublisherName.Margin = new Padding(3, 4, 3, 4);
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(637, 27);
            txtPublisherName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhà xuất bản:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(483, 587);
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
            buttonCancel.Location = new Point(605, 587);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(114, 33);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormInputPublisher
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(731, 637);
            Controls.Add(buttonCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInputPublisher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập nhà xuất bản";
            Load += FormInputPublisher_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkIsActive;
        private TextBox txtWebsite;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAddress;
        private Label label2;
        private TextBox txtPublisherName;
        private Label label1;
        private Button btnSave;
        private Button buttonCancel;
    }
}
