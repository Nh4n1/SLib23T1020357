namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Categories
{
    partial class FormInputCategory
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
            comboParentCategory = new ComboBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            chkIsActive = new CheckBox();
            txtCategoryName = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboParentCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chkIsActive);
            groupBox1.Controls.Add(txtCategoryName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(709, 440);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thể loại";
            // 
            // comboParentCategory
            // 
            comboParentCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboParentCategory.FormattingEnabled = true;
            comboParentCategory.Location = new Point(35, 159);
            comboParentCategory.Margin = new Padding(3, 4, 3, 4);
            comboParentCategory.Name = "comboParentCategory";
            comboParentCategory.Size = new Size(637, 28);
            comboParentCategory.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 128);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 3;
            label3.Text = "Thể loại cha:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(35, 236);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(637, 161);
            txtDescription.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 205);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 5;
            label2.Text = "Mô tả:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(35, 97);
            chkIsActive.Margin = new Padding(3, 4, 3, 4);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(227, 24);
            chkIsActive.TabIndex = 2;
            chkIsActive.Text = "Đang sử dụng trong hệ thống";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(35, 59);
            txtCategoryName.Margin = new Padding(3, 4, 3, 4);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(637, 27);
            txtCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên thể loại:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(483, 467);
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
            buttonCancel.Location = new Point(605, 467);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(114, 33);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormInputCategory
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(731, 516);
            Controls.Add(buttonCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInputCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập thể loại";
            Load += FormInputCategory_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboParentCategory;
        private Label label3;
        private TextBox txtDescription;
        private Label label2;
        private CheckBox chkIsActive;
        private TextBox txtCategoryName;
        private Label label1;
        private Button btnSave;
        private Button buttonCancel;
    }
}
