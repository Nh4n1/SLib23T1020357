namespace SLib23T1020357.DesktopApp.Properties.Member
{
    partial class FormInputMemberType
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
            groupBox1 = new GroupBox();
            chkIsActive = new CheckBox();
            nudMaxRenewals = new NumericUpDown();
            label4 = new Label();
            nudLoanPeriodDays = new NumericUpDown();
            label3 = new Label();
            nudMaxActiveLoans = new NumericUpDown();
            label2 = new Label();
            txtTypeName = new TextBox();
            label1 = new Label();
            buttonCancel = new Button();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxRenewals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLoanPeriodDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxActiveLoans).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIsActive);
            groupBox1.Controls.Add(nudMaxRenewals);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudLoanPeriodDays);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nudMaxActiveLoans);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTypeName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(490, 278);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại độc giả";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(31, 239);
            chkIsActive.Margin = new Padding(3, 2, 3, 2);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(183, 19);
            chkIsActive.TabIndex = 8;
            chkIsActive.Text = "Đang sử dụng trong hệ thống";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // nudMaxRenewals
            // 
            nudMaxRenewals.Location = new Point(31, 202);
            nudMaxRenewals.Margin = new Padding(3, 2, 3, 2);
            nudMaxRenewals.Name = "nudMaxRenewals";
            nudMaxRenewals.Size = new Size(429, 23);
            nudMaxRenewals.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 183);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 6;
            label4.Text = "Số lần gia hạn tối đa:";
            // 
            // nudLoanPeriodDays
            // 
            nudLoanPeriodDays.Location = new Point(31, 150);
            nudLoanPeriodDays.Margin = new Padding(3, 2, 3, 2);
            nudLoanPeriodDays.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            nudLoanPeriodDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLoanPeriodDays.Name = "nudLoanPeriodDays";
            nudLoanPeriodDays.Size = new Size(429, 23);
            nudLoanPeriodDays.TabIndex = 5;
            nudLoanPeriodDays.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 130);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 4;
            label3.Text = "Số ngày mượn chuẩn:";
            // 
            // nudMaxActiveLoans
            // 
            nudMaxActiveLoans.Location = new Point(31, 98);
            nudMaxActiveLoans.Margin = new Padding(3, 2, 3, 2);
            nudMaxActiveLoans.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxActiveLoans.Name = "nudMaxActiveLoans";
            nudMaxActiveLoans.Size = new Size(429, 23);
            nudMaxActiveLoans.TabIndex = 3;
            nudMaxActiveLoans.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 78);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 2;
            label2.Text = "Số bản sao được mượn tối đa:";
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(31, 45);
            txtTypeName.Margin = new Padding(3, 2, 3, 2);
            txtTypeName.MaxLength = 100;
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(429, 23);
            txtTypeName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên loại độc giả:";
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(402, 314);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 25);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(293, 314);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 25);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu dữ liệu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FormInputMemberType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 356);
            Controls.Add(buttonCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "FormInputMemberType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInputMemberType";
            Load += FormInputMemberType_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxRenewals).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLoanPeriodDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxActiveLoans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkIsActive;
        private NumericUpDown nudMaxRenewals;
        private Label label4;
        private NumericUpDown nudLoanPeriodDays;
        private Label label3;
        private NumericUpDown nudMaxActiveLoans;
        private Label label2;
        private TextBox txtTypeName;
        private Label label1;
        private Button buttonCancel;
        private Button btnSave;
    }
}