namespace SLib23T1020357.DesktopApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mniSystem = new ToolStripMenuItem();
            mniLogin = new ToolStripMenuItem();
            mniRegister = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mniConfig = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mniExit = new ToolStripMenuItem();
            mniDataDictionary = new ToolStripMenuItem();
            mniPublisher = new ToolStripMenuItem();
            mniAuthor = new ToolStripMenuItem();
            mniCategory = new ToolStripMenuItem();
            mniLanguage = new ToolStripMenuItem();
            mniLocation = new ToolStripMenuItem();
            mniBook = new ToolStripMenuItem();
            mniMemberData = new ToolStripMenuItem();
            mniMemberType = new ToolStripMenuItem();
            mniMember = new ToolStripMenuItem();
            mniManageLoan = new ToolStripMenuItem();
            mniLoanBorrow = new ToolStripMenuItem();
            mniLoanReturn = new ToolStripMenuItem();
            mniExtractData = new ToolStripMenuItem();
            mniExtractBook = new ToolStripMenuItem();
            mniExtractAuthor = new ToolStripMenuItem();
            mniDataReport = new ToolStripMenuItem();
            tlsMain = new ToolStrip();
            stsMain = new StatusStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { mniSystem, mniDataDictionary, mniBook, mniMemberData, mniManageLoan, mniExtractData, mniDataReport });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(931, 24);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mniSystem
            // 
            mniSystem.DropDownItems.AddRange(new ToolStripItem[] { mniLogin, mniRegister, toolStripMenuItem2, mniConfig, toolStripMenuItem1, mniExit });
            mniSystem.Name = "mniSystem";
            mniSystem.Size = new Size(69, 20);
            mniSystem.Text = "Hệ thống";
            // 
            // mniLogin
            // 
            mniLogin.Name = "mniLogin";
            mniLogin.Size = new Size(161, 22);
            mniLogin.Text = "Đăng nhập";
            // 
            // mniRegister
            // 
            mniRegister.Name = "mniRegister";
            mniRegister.Size = new Size(161, 22);
            mniRegister.Text = "Đăng ký";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(158, 6);
            // 
            // mniConfig
            // 
            mniConfig.Name = "mniConfig";
            mniConfig.Size = new Size(161, 22);
            mniConfig.Text = "Cấu hình kết nối";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(158, 6);
            // 
            // mniExit
            // 
            mniExit.Name = "mniExit";
            mniExit.Size = new Size(161, 22);
            mniExit.Text = "Thoát";
            // 
            // mniDataDictionary
            // 
            mniDataDictionary.DropDownItems.AddRange(new ToolStripItem[] { mniPublisher, mniAuthor, mniCategory, mniLanguage, mniLocation });
            mniDataDictionary.Name = "mniDataDictionary";
            mniDataDictionary.Size = new Size(77, 20);
            mniDataDictionary.Text = "&Danh mục ";
            // 
            // mniPublisher
            // 
            mniPublisher.Name = "mniPublisher";
            mniPublisher.Size = new Size(158, 22);
            mniPublisher.Text = "Nhà xuất bản";
            mniPublisher.Click += mniPublisher_Click;
            // 
            // mniAuthor
            // 
            mniAuthor.Name = "mniAuthor";
            mniAuthor.Size = new Size(158, 22);
            mniAuthor.Text = "Tác giả";
            mniAuthor.Click += mniAuthor_Click;
            // 
            // mniCategory
            // 
            mniCategory.Name = "mniCategory";
            mniCategory.Size = new Size(158, 22);
            mniCategory.Text = "Thể loại sách";
            mniCategory.Click += mniCategory_Click;
            // 
            // mniLanguage
            // 
            mniLanguage.Name = "mniLanguage";
            mniLanguage.Size = new Size(158, 22);
            mniLanguage.Text = "Ngôn ngữ";
            mniLanguage.Click += mniLanguage_Click;
            // 
            // mniLocation
            // 
            mniLocation.Name = "mniLocation";
            mniLocation.Size = new Size(158, 22);
            mniLocation.Text = "Nơi lưu trữ sách";
            mniLocation.Click += mniLocation_Click;
            // 
            // mniBook
            // 
            mniBook.Name = "mniBook";
            mniBook.Size = new Size(87, 20);
            mniBook.Text = "&Quản lý sách";
            // 
            // mniMemberData
            // 
            mniMemberData.DropDownItems.AddRange(new ToolStripItem[] { mniMemberType, mniMember });
            mniMemberData.Name = "mniMemberData";
            mniMemberData.Size = new Size(59, 20);
            mniMemberData.Text = "Độc giả";
            // 
            // mniMemberType
            // 
            mniMemberType.Name = "mniMemberType";
            mniMemberType.Size = new Size(165, 22);
            mniMemberType.Text = "Phân loại độc giả";
            // 
            // mniMember
            // 
            mniMember.Name = "mniMember";
            mniMember.Size = new Size(165, 22);
            mniMember.Text = "Hồ sơ độc giả";
            // 
            // mniManageLoan
            // 
            mniManageLoan.DropDownItems.AddRange(new ToolStripItem[] { mniLoanBorrow, mniLoanReturn });
            mniManageLoan.Name = "mniManageLoan";
            mniManageLoan.Size = new Size(112, 20);
            mniManageLoan.Text = "Quản lý mượn trả";
            // 
            // mniLoanBorrow
            // 
            mniLoanBorrow.Name = "mniLoanBorrow";
            mniLoanBorrow.Size = new Size(161, 22);
            mniLoanBorrow.Text = "Lập phiếu mượn";
            // 
            // mniLoanReturn
            // 
            mniLoanReturn.Name = "mniLoanReturn";
            mniLoanReturn.Size = new Size(161, 22);
            mniLoanReturn.Text = "Trả sách";
            // 
            // mniExtractData
            // 
            mniExtractData.DropDownItems.AddRange(new ToolStripItem[] { mniExtractBook, mniExtractAuthor });
            mniExtractData.Name = "mniExtractData";
            mniExtractData.Size = new Size(58, 20);
            mniExtractData.Text = "&Tra cứu";
            // 
            // mniExtractBook
            // 
            mniExtractBook.Name = "mniExtractBook";
            mniExtractBook.Size = new Size(155, 22);
            mniExtractBook.Text = "Tra cứu sách ";
            // 
            // mniExtractAuthor
            // 
            mniExtractAuthor.Name = "mniExtractAuthor";
            mniExtractAuthor.Size = new Size(155, 22);
            mniExtractAuthor.Text = "Tra cứu độc giả";
            // 
            // mniDataReport
            // 
            mniDataReport.Name = "mniDataReport";
            mniDataReport.Size = new Size(111, 20);
            mniDataReport.Text = "Báo cáo thống kê";
            // 
            // tlsMain
            // 
            tlsMain.Location = new Point(0, 24);
            tlsMain.Name = "tlsMain";
            tlsMain.Size = new Size(931, 25);
            tlsMain.TabIndex = 2;
            tlsMain.Text = "toolStrip1";
            // 
            // stsMain
            // 
            stsMain.Location = new Point(0, 444);
            stsMain.Name = "stsMain";
            stsMain.Size = new Size(931, 22);
            stsMain.TabIndex = 3;
            stsMain.Text = "statusStrip1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 466);
            Controls.Add(stsMain);
            Controls.Add(tlsMain);
            Controls.Add(mnuMain);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thư viện";
            WindowState = FormWindowState.Maximized;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnuMain;
        private ToolStripMenuItem mniSystem;
        private ToolStripMenuItem mniDataDictionary;
        private ToolStripMenuItem mniBook;
        private ToolStripMenuItem mniMemberData;
        private ToolStripMenuItem mniManageLoan;
        private ToolStripMenuItem mniExtractData;
        private ToolStripMenuItem mniDataReport;
        private ToolStripMenuItem mniLogin;
        private ToolStripMenuItem mniRegister;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mniConfig;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mniExit;
        private ToolStripMenuItem mniPublisher;
        private ToolStripMenuItem mniAuthor;
        private ToolStripMenuItem mniCategory;
        private ToolStripMenuItem mniLanguage;
        private ToolStripMenuItem mniMemberType;
        private ToolStripMenuItem mniMember;
        private ToolStripMenuItem mniLoanBorrow;
        private ToolStripMenuItem mniLoanReturn;
        private ToolStripMenuItem mniExtractBook;
        private ToolStripMenuItem mniExtractAuthor;
        private ToolStrip tlsMain;
        private StatusStrip stsMain;
        private ToolStripMenuItem mniLocation;
    }
}
