using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sach
{
    public partial class HD : Form
    {
        public HD()
        {
            InitializeComponent();
        }
        String connectingString;
        SqlConnection conn;

        DataSet ds = new DataSet("dsQLHD");

        SqlDataAdapter daHD;

        private void HD_Load(object sender, EventArgs e)
        {
            /*ListViewItem item = lsvHoaDon.Items.Add(tenNV);
            item.SubItems.Add(ms);
            item.SubItems.Add(tensach);
            item.SubItems.Add(dongia);
            item.SubItems.Add(sol);
            item.SubItems.Add(mkh);
            item.SubItems.Add(ngm);
 
            //2
            ListViewItem item1 = lsvHoaDon.Items.Add(tenNV2);
            item1.SubItems.Add(ms2);
            item1.SubItems.Add(tensach2);
            item1.SubItems.Add(dongia2);
            item1.SubItems.Add(sol2);
            item1.SubItems.Add(mkh2);
            item1.SubItems.Add(ngm2);
     
            //3
            ListViewItem item2 = lsvHoaDon.Items.Add(tenNV3);
            item2.SubItems.Add(ms3);
            item2.SubItems.Add(tensach3);
            item2.SubItems.Add(dongia3);
            item2.SubItems.Add(sol3);
            item2.SubItems.Add(mkh3);
            item2.SubItems.Add(ngm3);
          
            //4
            ListViewItem item3 = lsvHoaDon.Items.Add(tenNV4);
            item3.SubItems.Add(ms4);
            item3.SubItems.Add(tensach4);
            item3.SubItems.Add(dongia4);
            item3.SubItems.Add(sol4);
            item3.SubItems.Add(mkh4);
            item3.SubItems.Add(ngm4);
    
            //5
            ListViewItem item4 = lsvHoaDon.Items.Add(tenNV5);     
            item4.SubItems.Add(ms5);
            item4.SubItems.Add(tensach5);
            item4.SubItems.Add(dongia5);
            item4.SubItems.Add(sol5);
            item4.SubItems.Add(mkh5);
            item4.SubItems.Add(ngm5);*/
            loadData1();


        }
        public void loadData1()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MINHANH\SQLEXPRESS;Initial Catalog=QLBS;Integrated Security=True";

            //Dử liệu datagrid kho
            string sQueryHD = @"select hd.*,n.TenNV,s.DonGia,s.TenSach,s.MaSach,s.SLTon,k.HoTenKH,k.MaKH,k.SoDT from NhanVien n,Sach s,Hoadon hd,KhachHang k where hd.MaHD=s.MaHD and n.MaNV=hd.MaNV   ";
            daHD = new SqlDataAdapter(sQueryHD, conn);
            daHD.Fill(ds, "tblDSHoadon");

            dgvTTHD.DataSource = ds.Tables["tblDSHoadon"];
            dgvTTHD.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
            dgvTTHD.Columns["MaHD"].Width = 100;

            dgvTTHD.Columns["NgayBan"].HeaderText = "Ngày Bán";
            dgvTTHD.Columns["NgayBan"].Width = 100;

            dgvTTHD.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dgvTTHD.Columns["MaNV"].Width = 100;

            dgvTTHD.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvTTHD.Columns["ThanhTien"].Width = 100;

            //dgvTTHD.Columns["MaSach"].HeaderText = "Mã Sách";
            //dgvTTHD.Columns["MaSach"].Width = 100;

            string sThemHD = @"insert into HD values(@MaSach, @TenSach, @TacGia, @MaLoai, @SLTon)";
            SqlCommand cmThemHD = new SqlCommand(sThemHD, conn);
            cmThemHD.Parameters.Add("@MaHD", SqlDbType.Char, 5, "MaHD");
            cmThemHD.Parameters.Add("@NgayBan", SqlDbType.Date, 20, "NgayBan");
            cmThemHD.Parameters.Add("@MaNV", SqlDbType.Char, 5, "MaNV");
            cmThemHD.Parameters.Add("@ThanhTien", SqlDbType.Money, 20, "ThanhTien");
            /*cmThemKho.Parameters.Add("@SLTon", SqlDbType.VarChar, 20, "SLTon");
            cmThemKho.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "TenNV");
            cmThemKho.Parameters.Add("@MaKH", SqlDbType.Char, 5, "MaKH");
            cmThemKho.Parameters.Add("@HoTenKH", SqlDbType.NVarChar, 20, "HoTenKH");*/
            daHD.InsertCommand = cmThemHD;
        }
        public string tenNV, ms, tensach, dongia, sol, mkh, ngm;
        public string tenNV2, ms2, tensach2, dongia2, sol2, mkh2, ngm2;

        private void btnTongTT_Click(object sender, EventArgs e)
        {
            Sum();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            this.txtSL.Focus();
            ListViewItem item = lsvHoaDon.Items.Add(txtSL.Text);
            item.SubItems.Add(txtMS.Text.ToString());
            item.SubItems.Add(txtMS.Text.ToString());
            item.SubItems.Add(txtDG.Text.ToString());
            item.SubItems.Add(txtSL.Text.ToString());
            item.SubItems.Add(txtMaKhach.Text.ToString());
            item.SubItems.Add(txttenKhach.Text.ToString());
            item.SubItems.Add(txtSDT.Text.ToString());
            item.SubItems.Add(txtTongTT.Text.ToString());
            item.SubItems.Add(dtpNgayMua.Value.ToShortDateString());
        }

        private void dgvTTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvTTHD.SelectedRows[0];
            txtSL.Text = dr.Cells["TenNV"].Value.ToString();
            txtMS.Text = dr.Cells["MaSach"].Value.ToString();
            txtDG.Text = dr.Cells["DonGia"].Value.ToString();
            txtMS.Text = dr.Cells["TenSach"].Value.ToString();
            txtSL.Text = dr.Cells["SLTon"].Value.ToString();
            txtSDT.Text = dr.Cells["SoDT"].Value.ToString();
            txtMaKhach.Text = dr.Cells["MaKH"].Value.ToString();
            txttenKhach.Text = dr.Cells["HoTenKH"].Value.ToString();
            txtTongTT.Text = dr.Cells["ThanhTien"].Value.ToString();
            dtpNgayMua.Text = dr.Cells["NgayBan"].Value.ToString();


        }

        public string tenNV3, ms3, tensach3, dongia3, sol3, mkh3, ngm3;
        public string tenNV4, ms4, tensach4, dongia4, sol4, mkh4, ngm4;
        public string tenNV5, ms5, tensach5, dongia5, sol5, mkh5, ngm5;
        public string tenNV6, ms6, tensach6, dongia6, sol6, mkh6, ngm6;
        public string tenNV7, ms7, tensach7, dongia7, sol7, mkh7, ngm7;
        public string tenNV8, ms8, tensach8, dongia8, sol8, mkh8, ngm8;

        public void Sum()
        {
            int s, s1, s2, s3, s4, s5, s6;
            int t, t1, t2, t3, t4, t5, t6;
            t1 = int.Parse(lsvHoaDon.SelectedItems[0].SubItems[8].Text);
            t2 = int.Parse(lsvHoaDon.SelectedItems[1].SubItems[8].Text);
            t3 = int.Parse(lsvHoaDon.SelectedItems[2].SubItems[8].Text);
            t4 = int.Parse(lsvHoaDon.SelectedItems[3].SubItems[8].Text);
            t5 = int.Parse(lsvHoaDon.SelectedItems[4].SubItems[8].Text);
            /*s1 = int.Parse(t1);
            s2 = int.Parse(t2);
            s3 = int.Parse(t3);
            s4 = int.Parse(t4);
            s5 = int.Parse(t5);*/
            s = t1 + t2 + t3 + t4 + t5;
            string t7 = Convert.ToString(s);
            this.txtTongTT.Text = t7;

        }
    }
    }

