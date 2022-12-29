namespace Quan_Ly_Sach
{
    partial class Quản_lí_kho
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
            this.lblQLKHO = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.cmbNVK = new System.Windows.Forms.ComboBox();
            this.cmbDCK = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblNVKho = new System.Windows.Forms.Label();
            this.lblTenKho = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.lblMaKho = new System.Windows.Forms.Label();
            this.lblMaS = new System.Windows.Forms.Label();
            this.dtgvQLK = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLKHO
            // 
            this.lblQLKHO.AutoSize = true;
            this.lblQLKHO.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQLKHO.ForeColor = System.Drawing.Color.Blue;
            this.lblQLKHO.Location = new System.Drawing.Point(459, 24);
            this.lblQLKHO.Name = "lblQLKHO";
            this.lblQLKHO.Size = new System.Drawing.Size(218, 45);
            this.lblQLKHO.TabIndex = 0;
            this.lblQLKHO.Text = "Quản lí kho";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.lblSoluong);
            this.groupBox1.Controls.Add(this.cmbNVK);
            this.groupBox1.Controls.Add(this.cmbDCK);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.lblsdt);
            this.groupBox1.Controls.Add(this.txtTS);
            this.groupBox1.Controls.Add(this.lbldiachi);
            this.groupBox1.Controls.Add(this.lblNVKho);
            this.groupBox1.Controls.Add(this.lblTenKho);
            this.groupBox1.Controls.Add(this.lblTenSach);
            this.groupBox1.Controls.Add(this.txtMS);
            this.groupBox1.Controls.Add(this.lblMaKho);
            this.groupBox1.Controls.Add(this.lblMaS);
            this.groupBox1.Location = new System.Drawing.Point(207, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kho";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(385, 159);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(103, 27);
            this.lblSoluong.TabIndex = 0;
            this.lblSoluong.Text = "Số lượng:";
            // 
            // cmbNVK
            // 
            this.cmbNVK.FormattingEnabled = true;
            this.cmbNVK.Items.AddRange(new object[] {
            "Như Quỳnh",
            "Hoàng Hưng",
            "Minh Anh"});
            this.cmbNVK.Location = new System.Drawing.Point(165, 159);
            this.cmbNVK.Name = "cmbNVK";
            this.cmbNVK.Size = new System.Drawing.Size(166, 35);
            this.cmbNVK.TabIndex = 2;
            // 
            // cmbDCK
            // 
            this.cmbDCK.FormattingEnabled = true;
            this.cmbDCK.Items.AddRange(new object[] {
            "An Giang",
            "Bà rịa – Vũng tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội ",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Thành phố Hồ Chí Minh",
            "Trà Vinh",
            "uyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cmbDCK.Location = new System.Drawing.Point(89, 202);
            this.cmbDCK.Name = "cmbDCK";
            this.cmbDCK.Size = new System.Drawing.Size(242, 35);
            this.cmbDCK.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(534, 210);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(250, 35);
            this.txtSDT.TabIndex = 1;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(109, 99);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(222, 35);
            this.txtTK.TabIndex = 1;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(490, 154);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(294, 35);
            this.txtSL.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(109, 50);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(222, 35);
            this.txtMK.TabIndex = 1;
            this.txtMK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMK_MouseClick);
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(385, 218);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(143, 27);
            this.lblsdt.TabIndex = 0;
            this.lblsdt.Text = "Số điện thoại:";
            // 
            // txtTS
            // 
            this.txtTS.Location = new System.Drawing.Point(490, 99);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(294, 35);
            this.txtTS.TabIndex = 1;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(6, 210);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(87, 27);
            this.lbldiachi.TabIndex = 0;
            this.lbldiachi.Text = "Địa chỉ:";
            // 
            // lblNVKho
            // 
            this.lblNVKho.AutoSize = true;
            this.lblNVKho.Location = new System.Drawing.Point(0, 162);
            this.lblNVKho.Name = "lblNVKho";
            this.lblNVKho.Size = new System.Drawing.Size(159, 27);
            this.lblNVKho.TabIndex = 0;
            this.lblNVKho.Text = "Nhân viên kho:";
            // 
            // lblTenKho
            // 
            this.lblTenKho.AutoSize = true;
            this.lblTenKho.Location = new System.Drawing.Point(6, 107);
            this.lblTenKho.Name = "lblTenKho";
            this.lblTenKho.Size = new System.Drawing.Size(97, 27);
            this.lblTenKho.TabIndex = 0;
            this.lblTenKho.Text = "Tên kho:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(380, 102);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(104, 27);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(490, 42);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(294, 35);
            this.txtMS.TabIndex = 1;
            this.txtMS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMS_MouseClick);
            // 
            // lblMaKho
            // 
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Location = new System.Drawing.Point(11, 50);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(92, 27);
            this.lblMaKho.TabIndex = 0;
            this.lblMaKho.Text = "Mã kho:";
            // 
            // lblMaS
            // 
            this.lblMaS.AutoSize = true;
            this.lblMaS.Location = new System.Drawing.Point(385, 50);
            this.lblMaS.Name = "lblMaS";
            this.lblMaS.Size = new System.Drawing.Size(99, 27);
            this.lblMaS.TabIndex = 0;
            this.lblMaS.Text = "Mã sách:";
            // 
            // dtgvQLK
            // 
            this.dtgvQLK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvQLK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLK.Location = new System.Drawing.Point(63, 470);
            this.dtgvQLK.Name = "dtgvQLK";
            this.dtgvQLK.RowHeadersWidth = 62;
            this.dtgvQLK.RowTemplate.Height = 33;
            this.dtgvQLK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLK.Size = new System.Drawing.Size(1099, 286);
            this.dtgvQLK.TabIndex = 2;
            this.dtgvQLK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQLK_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(63, 401);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 63);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(286, 401);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 63);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(530, 401);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(165, 63);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(764, 401);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(172, 63);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(999, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 63);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Quản_lí_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1217, 783);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvQLK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQLKHO);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Quản_lí_kho";
            this.Text = "Quản_lí_kho";
            this.Load += new System.EventHandler(this.Quản_lí_kho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQLKHO;
        private GroupBox groupBox1;
        private Label lblMaKho;
        private Label lblsdt;
        private Label lbldiachi;
        private Label lblNVKho;
        private Label lblTenKho;
        private ComboBox cmbDCK;
        private TextBox txtSDT;
        private TextBox txtTK;
        private TextBox txtMK;
        private Label lblTenSach;
        private Label lblMaS;
        private Label lblSoluong;
        private TextBox txtTS;
        private TextBox txtMS;
        private DataGridView dtgvQLK;
        private TextBox txtSL;
        private Button btnThem;
        private Button btnXoa;
        private Button btnsua;
        private Button btnLuu;
        private Button btnThoat;
        private ComboBox cmbNVK;
    }
}