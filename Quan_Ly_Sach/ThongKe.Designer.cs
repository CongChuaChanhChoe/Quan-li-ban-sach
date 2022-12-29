namespace Quan_Ly_Sach
{
    partial class ThongKe
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
            this.grbTKSach = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbNV = new System.Windows.Forms.GroupBox();
            this.lsvNhanVien = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemTKLuongNV = new System.Windows.Forms.ToolStripMenuItem();
            this.slsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTKSach.SuspendLayout();
            this.grbNV.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTKSach
            // 
            this.grbTKSach.BackColor = System.Drawing.Color.LightBlue;
            this.grbTKSach.Controls.Add(this.listView1);
            this.grbTKSach.Controls.Add(this.label2);
            this.grbTKSach.Enabled = false;
            this.grbTKSach.Location = new System.Drawing.Point(12, 100);
            this.grbTKSach.Name = "grbTKSach";
            this.grbTKSach.Size = new System.Drawing.Size(803, 528);
            this.grbTKSach.TabIndex = 0;
            this.grbTKSach.TabStop = false;
            this.grbTKSach.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thống Kê Sách";
            // 
            // grbNV
            // 
            this.grbNV.BackColor = System.Drawing.Color.LightBlue;
            this.grbNV.Controls.Add(this.groupBox1);
            this.grbNV.Controls.Add(this.lsvNhanVien);
            this.grbNV.Controls.Add(this.label6);
            this.grbNV.Enabled = false;
            this.grbNV.Location = new System.Drawing.Point(821, 100);
            this.grbNV.Name = "grbNV";
            this.grbNV.Size = new System.Drawing.Size(834, 528);
            this.grbNV.TabIndex = 1;
            this.grbNV.TabStop = false;
            this.grbNV.Visible = false;
            this.grbNV.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lsvNhanVien
            // 
            this.lsvNhanVien.FullRowSelect = true;
            this.lsvNhanVien.GridLines = true;
            this.lsvNhanVien.Location = new System.Drawing.Point(19, 46);
            this.lsvNhanVien.Name = "lsvNhanVien";
            this.lsvNhanVien.Size = new System.Drawing.Size(800, 466);
            this.lsvNhanVien.TabIndex = 6;
            this.lsvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lsvNhanVien_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.Location = new System.Drawing.Point(350, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thống Kê Nhân Viên";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTKLuongNV});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1684, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemTKLuongNV
            // 
            this.MenuItemTKLuongNV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slsMenuItem,
            this.nhânViênToolStripMenuItem});
            this.MenuItemTKLuongNV.Name = "MenuItemTKLuongNV";
            this.MenuItemTKLuongNV.Size = new System.Drawing.Size(73, 29);
            this.MenuItemTKLuongNV.Text = "Menu";
            // 
            // slsMenuItem
            // 
            this.slsMenuItem.Name = "slsMenuItem";
            this.slsMenuItem.Size = new System.Drawing.Size(274, 34);
            this.slsMenuItem.Text = "Thống Kê Sách";
            this.slsMenuItem.Click += new System.EventHandler(this.sốLượngSáchToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.nhânViênToolStripMenuItem.Text = "Thống Kê Lương NV";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(678, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thống Kê Doanh Số";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(769, 466);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.lsvNhanVien_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(16, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 528);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(16, 46);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(769, 466);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống Kê Sách";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1684, 640);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbNV);
            this.Controls.Add(this.grbTKSach);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load_1);
            this.grbTKSach.ResumeLayout(false);
            this.grbTKSach.PerformLayout();
            this.grbNV.ResumeLayout(false);
            this.grbNV.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbTKSach;
        private Label label2;
        private GroupBox grbNV;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItemTKLuongNV;
        private ToolStripMenuItem slsMenuItem;
        private ListView lsvNhanVien;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private Label label3;
        private ListView listView1;
        private GroupBox groupBox1;
        private ListView listView2;
        private Label label1;
    }
}