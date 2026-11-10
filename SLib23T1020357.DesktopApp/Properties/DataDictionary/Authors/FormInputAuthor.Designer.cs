namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Authors
{
    partial class FormInputAuthor
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
            dtpDeadDate = new DateTimePicker();
            label5 = new Label();
            dtpBirthDate = new DateTimePicker();
            label4 = new Label();
            txtBiography = new TextBox();
            label3 = new Label();
            chkIsActive = new CheckBox();
            label2 = new Label();
            txtAuthorName = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDeadDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBiography);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(chkIsActive);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAuthorName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(947, 491);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin về tác giả";
            // 
            // dtpDeadDate
            // 
            dtpDeadDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpDeadDate.CustomFormat = "dd/MM/yyyy";
            dtpDeadDate.Format = DateTimePickerFormat.Custom;
            dtpDeadDate.Location = new Point(375, 396);
            dtpDeadDate.Name = "dtpDeadDate";
            dtpDeadDate.Size = new Size(250, 27);
            dtpDeadDate.TabIndex = 9;
            dtpDeadDate.ValueChanged += FormInputAuthor_Load;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 349);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày mất:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(35, 396);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 7;
            dtpBirthDate.ValueChanged += FormInputAuthor_Load;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 349);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Ngày sinh:";
            // 
            // txtBiography
            // 
            txtBiography.ImeMode = ImeMode.NoControl;
            txtBiography.Location = new Point(35, 179);
            txtBiography.Multiline = true;
            txtBiography.Name = "txtBiography";
            txtBiography.Size = new Size(863, 121);
            txtBiography.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 155);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 4;
            label3.Text = "Tiểu sử";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(35, 121);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(227, 24);
            chkIsActive.TabIndex = 3;
            chkIsActive.Text = "Đang sử dụng trong hệ thống";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 115);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(35, 75);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(863, 27);
            txtAuthorName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 40);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên tác giả:";
            // 
            // btnSave
            // 
            btnSave.Image = Resources.add;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(706, 513);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu dữ liệu (F2)";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Image = Resources.cancel;
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(849, 513);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormInputAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 551);
            Controls.Add(buttonCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInputAuthor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập tác giả";
            Load += FormInputAuthor_Load;
            KeyDown += FormInputAuthor_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtAuthorName;
        private Label label1;
        private DateTimePicker dtpBirthDate;
        private Label label4;
        private TextBox txtBiography;
        private Label label3;
        private CheckBox chkIsActive;
        private DateTimePicker dtpDeadDate;
        private Label label5;
        private Button btnSave;
        private Button buttonCancel;
    }
}