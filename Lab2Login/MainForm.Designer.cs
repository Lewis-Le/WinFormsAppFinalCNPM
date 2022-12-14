
namespace Lab2Login
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAgentReceiveAndCreateReceiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêNhậpKhoXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageOrderToolStripMenuItem,
            this.manageAgentReceiveAndCreateReceiveToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.usersToolStripMenuItem.Text = "Quản Lý";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(377, 22);
            this.manageUsersToolStripMenuItem.Text = "Quản Lý Hàng Hóa";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageOrderToolStripMenuItem
            // 
            this.manageOrderToolStripMenuItem.Name = "manageOrderToolStripMenuItem";
            this.manageOrderToolStripMenuItem.Size = new System.Drawing.Size(377, 22);
            this.manageOrderToolStripMenuItem.Text = "Quản Lý Đơn Hàng Của Đại Lý và Tạo Phiếu Xuất Kho";
            this.manageOrderToolStripMenuItem.Click += new System.EventHandler(this.manageOrderToolStripMenuItem_Click);
            // 
            // manageAgentReceiveAndCreateReceiveToolStripMenuItem
            // 
            this.manageAgentReceiveAndCreateReceiveToolStripMenuItem.Name = "manageAgentReceiveAndCreateReceiveToolStripMenuItem";
            this.manageAgentReceiveAndCreateReceiveToolStripMenuItem.Size = new System.Drawing.Size(377, 22);
            this.manageAgentReceiveAndCreateReceiveToolStripMenuItem.Text = "Quản Lý Nhập Hàng Của Công Ty và Tạo Phiếu Nhập Kho";
            this.manageAgentReceiveAndCreateReceiveToolStripMenuItem.Click += new System.EventHandler(this.manageAgentReceiveAndCreateReceiveToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêNhậpKhoXuấtKhoToolStripMenuItem,
            this.thốngKêĐơnHàngToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // thốngKêNhậpKhoXuấtKhoToolStripMenuItem
            // 
            this.thốngKêNhậpKhoXuấtKhoToolStripMenuItem.Name = "thốngKêNhậpKhoXuấtKhoToolStripMenuItem";
            this.thốngKêNhậpKhoXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.thốngKêNhậpKhoXuấtKhoToolStripMenuItem.Text = "Thống Kê Nhập Kho Xuất Kho";
            // 
            // thốngKêĐơnHàngToolStripMenuItem
            // 
            this.thốngKêĐơnHàngToolStripMenuItem.Name = "thốngKêĐơnHàngToolStripMenuItem";
            this.thốngKêĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.thốngKêĐơnHàngToolStripMenuItem.Text = "Thống Kê Đơn Hàng";
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống Kê Doanh Thu";
            this.thốngKêDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.thốngKêDoanhThuToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleVerticalToolStripMenuItem,
            this.titleHorizontalToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // titleVerticalToolStripMenuItem
            // 
            this.titleVerticalToolStripMenuItem.Name = "titleVerticalToolStripMenuItem";
            this.titleVerticalToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.titleVerticalToolStripMenuItem.Text = "Title Vertical";
            this.titleVerticalToolStripMenuItem.Click += new System.EventHandler(this.titleVerticalToolStripMenuItem_Click);
            // 
            // titleHorizontalToolStripMenuItem
            // 
            this.titleHorizontalToolStripMenuItem.Name = "titleHorizontalToolStripMenuItem";
            this.titleHorizontalToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.titleHorizontalToolStripMenuItem.Text = "Title Horizontal";
            this.titleHorizontalToolStripMenuItem.Click += new System.EventHandler(this.titleHorizontalToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 512);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Agent Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAgentReceiveAndCreateReceiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêNhậpKhoXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
    }
}

