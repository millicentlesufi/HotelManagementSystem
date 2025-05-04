namespace HotelManagementSystem.Presentation
{
    partial class MDI_HomeScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_HomeScreen));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Accounts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_changePW = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookingMenue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newBookingsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.currentBookingsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_oReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_occupancyReport = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ManageStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Accounts,
            this.BookingMenue,
            this.ReportMenu,
            this.StaffMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Accounts
            // 
            this.Accounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btn_Login,
            this.btn_LogOut,
            this.btn_changePW,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.Accounts.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(83, 24);
            this.Accounts.Text = "&Accounts";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(204, 6);
            // 
            // btn_Login
            // 
            this.btn_Login.ImageTransparentColor = System.Drawing.Color.Black;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(207, 26);
            this.btn_Login.Text = "Log &in";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(207, 26);
            this.btn_LogOut.Text = "Log &out";
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_changePW
            // 
            this.btn_changePW.Name = "btn_changePW";
            this.btn_changePW.Size = new System.Drawing.Size(207, 26);
            this.btn_changePW.Text = "Change Password";
            this.btn_changePW.Click += new System.EventHandler(this.btn_changePW_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(204, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // BookingMenue
            // 
            this.BookingMenue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.newBookingsOpen,
            this.currentBookingsOpen,
            this.toolStripSeparator7});
            this.BookingMenue.Name = "BookingMenue";
            this.BookingMenue.Size = new System.Drawing.Size(84, 24);
            this.BookingMenue.Text = "&Bookings";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(202, 6);
            // 
            // newBookingsOpen
            // 
            this.newBookingsOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.newBookingsOpen.Name = "newBookingsOpen";
            this.newBookingsOpen.Size = new System.Drawing.Size(205, 26);
            this.newBookingsOpen.Text = "&New Bookings";
            this.newBookingsOpen.Click += new System.EventHandler(this.newBookingsOpen_Click);
            // 
            // currentBookingsOpen
            // 
            this.currentBookingsOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.currentBookingsOpen.Name = "currentBookingsOpen";
            this.currentBookingsOpen.Size = new System.Drawing.Size(205, 26);
            this.currentBookingsOpen.Text = "&Current Bookings";
            this.currentBookingsOpen.Click += new System.EventHandler(this.currentBookingsOpen_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(202, 6);
            // 
            // ReportMenu
            // 
            this.ReportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_oReport,
            this.btn_occupancyReport});
            this.ReportMenu.Name = "ReportMenu";
            this.ReportMenu.Size = new System.Drawing.Size(74, 24);
            this.ReportMenu.Text = "Reports";
            // 
            // btn_oReport
            // 
            this.btn_oReport.Name = "btn_oReport";
            this.btn_oReport.Size = new System.Drawing.Size(224, 26);
            this.btn_oReport.Text = "Operational Report";
            this.btn_oReport.Click += new System.EventHandler(this.btn_oReport_Click);
            // 
            // btn_occupancyReport
            // 
            this.btn_occupancyReport.Name = "btn_occupancyReport";
            this.btn_occupancyReport.Size = new System.Drawing.Size(224, 26);
            this.btn_occupancyReport.Text = "Occupancy Report";
            this.btn_occupancyReport.Click += new System.EventHandler(this.btn_occupancyReport_Click);
            // 
            // StaffMenu
            // 
            this.StaffMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ManageStaff});
            this.StaffMenu.Name = "StaffMenu";
            this.StaffMenu.Size = new System.Drawing.Size(107, 24);
            this.StaffMenu.Text = "Staff Control";
            // 
            // btn_ManageStaff
            // 
            this.btn_ManageStaff.Name = "btn_ManageStaff";
            this.btn_ManageStaff.Size = new System.Drawing.Size(181, 26);
            this.btn_ManageStaff.Text = "Manage Staff";
            this.btn_ManageStaff.Click += new System.EventHandler(this.btn_ManageStaff_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDI_HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel management sys";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem btn_LogOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem Accounts;
        private System.Windows.Forms.ToolStripMenuItem btn_Login;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookingMenue;
        private System.Windows.Forms.ToolStripMenuItem newBookingsOpen;
        private System.Windows.Forms.ToolStripMenuItem currentBookingsOpen;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ReportMenu;
        private System.Windows.Forms.ToolStripMenuItem btn_oReport;
        private System.Windows.Forms.ToolStripMenuItem btn_occupancyReport;
        private System.Windows.Forms.ToolStripMenuItem StaffMenu;
        private System.Windows.Forms.ToolStripMenuItem btn_ManageStaff;
        private System.Windows.Forms.ToolStripMenuItem btn_changePW;
    }
}



