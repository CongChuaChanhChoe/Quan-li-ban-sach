namespace Quan_Ly_Sach
{
    partial class Chức_năng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chức_năng));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmTke = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTluong = new System.Windows.Forms.ToolStripMenuItem();
            this.stmQLNVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQLSach = new System.Windows.Forms.ToolStripMenuItem();
            this.stmKho = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHDBS = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(245, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí cửa hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTke,
            this.tsmTluong,
            this.stmQLNVien,
            this.tsmQLSach,
            this.stmKho,
            this.tsmHDBS,
            this.quảnLýSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTke
            // 
            this.tsmTke.Image = ((System.Drawing.Image)(resources.GetObject("tsmTke.Image")));
            this.tsmTke.Name = "tsmTke";
            this.tsmTke.Size = new System.Drawing.Size(126, 29);
            this.tsmTke.Text = "Thống kê";
            this.tsmTke.Click += new System.EventHandler(this.tsmTke_Click);
            // 
            // tsmTluong
            // 
            this.tsmTluong.Image = ((System.Drawing.Image)(resources.GetObject("tsmTluong.Image")));
            this.tsmTluong.Name = "tsmTluong";
            this.tsmTluong.Size = new System.Drawing.Size(137, 29);
            this.tsmTluong.Text = "Tính lương";
            this.tsmTluong.Click += new System.EventHandler(this.tsmTluong_Click);
            // 
            // stmQLNVien
            // 
            this.stmQLNVien.Image = ((System.Drawing.Image)(resources.GetObject("stmQLNVien.Image")));
            this.stmQLNVien.Name = "stmQLNVien";
            this.stmQLNVien.Size = new System.Drawing.Size(189, 29);
            this.stmQLNVien.Text = "Quản lí nhân viên";
            this.stmQLNVien.Click += new System.EventHandler(this.stmQLNVien_Click);
            // 
            // tsmQLSach
            // 
            this.tsmQLSach.Image = ((System.Drawing.Image)(resources.GetObject("tsmQLSach.Image")));
            this.tsmQLSach.Name = "tsmQLSach";
            this.tsmQLSach.Size = new System.Drawing.Size(148, 29);
            this.tsmQLSach.Text = "Quản lí sách";
            this.tsmQLSach.Click += new System.EventHandler(this.tsmQLSach_Click);
            // 
            // stmKho
            // 
            this.stmKho.Image = ((System.Drawing.Image)(resources.GetObject("stmKho.Image")));
            this.stmKho.Name = "stmKho";
            this.stmKho.Size = new System.Drawing.Size(143, 29);
            this.stmKho.Text = "Quản lí kho";
            this.stmKho.Click += new System.EventHandler(this.stmKho_Click);
            // 
            // tsmHDBS
            // 
            this.tsmHDBS.Name = "tsmHDBS";
            this.tsmHDBS.Size = new System.Drawing.Size(175, 29);
            this.tsmHDBS.Text = "Hóa đơn bán Sách";
            this.tsmHDBS.Click += new System.EventHandler(this.tsmHDBS_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // Chức_năng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Chức_năng";
            this.Text = "Chức năng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmTke;
        private ToolStripMenuItem tsmTluong;
        private ToolStripMenuItem stmQLNVien;
        private ToolStripMenuItem tsmQLSach;
        private ToolStripMenuItem stmKho;
        private ToolStripMenuItem tsmHDBS;
        private ToolStripMenuItem quảnLýSáchToolStripMenuItem;
    }
}