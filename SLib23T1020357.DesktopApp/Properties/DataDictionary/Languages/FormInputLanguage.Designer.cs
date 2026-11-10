namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Languages
{
    partial class FormInputLanguage
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
            txtLanguageName = new TextBox();
            label2 = new Label();
            txtLanguageCode = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIsActive);
            groupBox1.Controls.Add(txtLanguageName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLanguageCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 175);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ngôn ngữ";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(31, 145);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(183, 19);
            chkIsActive.TabIndex = 4;
            chkIsActive.Text = "Đang sử dụng trong hệ thống";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtLanguageName
            // 
            txtLanguageName.Location = new Point(31, 111);
            txtLanguageName.Name = "txtLanguageName";
            txtLanguageName.Size = new Size(458, 23);
            txtLanguageName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 88);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên ngôn ngữ:";
            // 
            // txtLanguageCode
            // 
            txtLanguageCode.Location = new Point(31, 57);
            txtLanguageCode.Name = "txtLanguageCode";
            txtLanguageCode.Size = new Size(458, 23);
            txtLanguageCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã ngôn ngữ:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(316, 194);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 25);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu dữ liệu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(422, 194);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(108, 25);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormInputLanguage
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(540, 230);
            Controls.Add(buttonCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInputLanguage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập ngôn ngữ";
            Load += FormInputLanguage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkIsActive;
        private TextBox txtLanguageName;
        private Label label2;
        private TextBox txtLanguageCode;
        private Label label1;
        private Button btnSave;
        private Button buttonCancel;
    }
}
