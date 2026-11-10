namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Languages
{
    partial class FormLanguage
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
            ColumnLanguageCode = new DataGridViewTextBoxColumn();
            ColumnLanguageName = new DataGridViewTextBoxColumn();
            ColumnLanguageStatus = new DataGridViewCheckBoxColumn();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 87);
            panel1.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(713, 49);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(624, 49);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Sửa ";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(535, 49);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Bổ sung";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(491, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnLanguageCode, ColumnLanguageName, ColumnLanguageStatus });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 363);
            dataGridView1.TabIndex = 3;
            // 
            // ColumnLanguageCode
            // 
            ColumnLanguageCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnLanguageCode.HeaderText = "Mã ngôn ngữ";
            ColumnLanguageCode.Name = "ColumnLanguageCode";
            // 
            // ColumnLanguageName
            // 
            ColumnLanguageName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnLanguageName.HeaderText = "Tên ngôn ngữ";
            ColumnLanguageName.Name = "ColumnLanguageName";
            // 
            // ColumnLanguageStatus
            // 
            ColumnLanguageStatus.HeaderText = "Trạng thái";
            ColumnLanguageStatus.Name = "ColumnLanguageStatus";
            // 
            // FormLanguage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormLanguage";
            Text = "Quản lý ngôn ngữ";
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
        private DataGridViewTextBoxColumn ColumnLanguageCode;
        private DataGridViewTextBoxColumn ColumnLanguageName;
        private DataGridViewCheckBoxColumn ColumnLanguageStatus;
    }
}