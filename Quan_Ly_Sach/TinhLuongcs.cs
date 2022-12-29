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
    public partial class TinhLuongcs : Form
    {
        public TinhLuongcs()
        {
            InitializeComponent();
        }
        string connectionString;
        SqlConnection conn;

        DataSet ds = new DataSet("dsQLBS");

        SqlDataAdapter danhanvien;

        public void loadData1()
        {
//<<<<<<< HEAD
//<<<<<<< HEAD
            //<<<<<<< HEAD
            //<<<<<<< HEAD
//=======
//<<<<<<< HEAD
          
//=======
//<<<<<<< HEAD
//<<<<<<< HEAD
//>>>>>>> e30a4cf225fa6fa2b4507811c86571a417aa4ad5
//=======

//>>>>>>> 790e9782c4355585bdc5973a2abb633a54308946
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLBS;Integrated Security=True";

            // dữ liệu nhân viên
            string sQueryNhanVien = @"select  MaNV, HoLot, TenNV, Phai from NhanVien ";
            danhanvien = new SqlDataAdapter(sQueryNhanVien, conn);
            danhanvien.Fill(ds, "tblDSNhanVien");
            dtgThongTinNV.DataSource = ds.Tables["tblDSNhanVien"];
            dtgThongTinNV.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dtgThongTinNV.Columns["MaNV"].Width = 120;

            dtgThongTinNV.Columns["HoLot"].HeaderText = "Họ Lót";
            dtgThongTinNV.Columns["HoLot"].Width = 180;

            dtgThongTinNV.Columns["TenNV"].HeaderText = "Tên";
            dtgThongTinNV.Columns["TenNV"].Width = 100;

            dtgThongTinNV.Columns["Phai"].HeaderText = "Phái";
            dtgThongTinNV.Columns["Phai"].Width = 150;
//<<<<<<< HEAD
//<<<<<<< HEAD
//=======




//=======
//=======
//>>>>>>> b59db69b7e2d208ad4c3c17ca5e7a60d6b75af14
          
//>>>>>>> 6d0918d395fba912607a68f1e872937bd3dee7d2
          
//<<<<<<< HEAD
//>>>>>>> 2ee12e6565f25437245f4c03eb1b977c1fd0760a
//=======
//>>>>>>> b59db69b7e2d208ad4c3c17ca5e7a60d6b75af14
//>>>>>>> e30a4cf225fa6fa2b4507811c86571a417aa4ad5
//=======
//>>>>>>> 790e9782c4355585bdc5973a2abb633a54308946
        }
        public void TienLuong()
        {
            double sum1 = 0;
            double sum2 = 0;
            radbFullTime.Text = "12";
            radbPartTime.Text = "5";
            double f = double.Parse(radbFullTime.Text);
            double p = double.Parse(radbPartTime.Text);
            double n = double.Parse(txtSoNgayLmVC.Text);
            if (radbFullTime.Checked == true)
            {
                radbFullTime.Text = "12" + "h";
                radbPartTime.Text = "5" + "h";
                sum1 = (f * n) * 25000;
                txttienluong.Text = sum1.ToString();
            }
            else if (radbPartTime.Checked == true)
            {
                radbFullTime.Text = "12" + "h";
                radbPartTime.Text = "5" + "h";
                sum2 = (p * n) * 20000;
                txttienluong.Text = sum2.ToString();
            }
            
        }


        private void btnTinhLuon_Click(object sender, EventArgs e)
        {       
            TienLuong();
            Add();
        }

        private void lsvTTNv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTTNv.SelectedItems.Count > 0)
            {
                txtMaNV.Text = lsvTTNv.SelectedItems[0].SubItems[0].Text;
                txtHoLotNV.Text = lsvTTNv.SelectedItems[0].SubItems[1].Text;
                txtTenNV.Text = lsvTTNv.SelectedItems[0].SubItems[2].Text;
                txtSoNgayLmVC.Text = lsvTTNv.SelectedItems[0].SubItems[3].Text;
                txttienluong.Text = lsvTTNv.SelectedItems[0].SubItems[4].Text;
            }
            
            
        }
        public void Add()
        {
            ListViewItem item = new ListViewItem();
            item.Text = txtMaNV.Text;


            ListViewItem.ListViewSubItem Holot = new ListViewItem.ListViewSubItem();
            Holot.Text = txtHoLotNV.Text;


            ListViewItem.ListViewSubItem tennv = new ListViewItem.ListViewSubItem();
            tennv.Text = txtTenNV.Text;

            ListViewItem.ListViewSubItem phai = new ListViewItem.ListViewSubItem();
            phai.Text = radbNam.Checked ? "Nam" : "Nữ";

            ListViewItem.ListViewSubItem Fulltime = new ListViewItem.ListViewSubItem();
            Fulltime.Text = radbFullTime.Checked ? "12h" : "5h";

         
            ListViewItem.ListViewSubItem ngaylam = new ListViewItem.ListViewSubItem();
            ngaylam.Text = txtSoNgayLmVC.Text;


            ListViewItem.ListViewSubItem tienL = new ListViewItem.ListViewSubItem();
            tienL.Text = txttienluong.Text;

      
            item.SubItems.Add(Holot);
            item.SubItems.Add(tennv);
            item.SubItems.Add(phai);
            item.SubItems.Add(Fulltime);
            item.SubItems.Add(ngaylam);
            item.SubItems.Add(tienL);

            lsvTTNv.Items.Add(item);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {


            DataGridViewRow dr3 = dtgThongTinNV.SelectedRows[0];
            dr3.Cells["MaNV"].Value = txtMaNV.Text;
            dr3.Cells["HoLot"].Value = txtHoLotNV.Text;
            dr3.Cells["TenNV"].Value = txtTenNV.Text;
            dr3.Cells["Phai"].Value = radbNam.Checked;
            dr3.Cells["Phai"].Value = radbNu.Checked;
            ds.Tables["tblDSNhanVien"].Rows.Add(dr3);
            //dr3.Cells["SoDT"].Value = txtSDTKho.Text;


        }

        



        private void btnTK_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
//<<<<<<< HEAD
//<<<<<<< HEAD

            tk.n = int.Parse(txttienluong.Text);



//=======
//=======
            tk.n = int.Parse(txttienluong.Text);
            lsvTTNv.Items.Add(tk.manv);
//>>>>>>> 790e9782c4355585bdc5973a2abb633a54308946
            tk.manv = String.Format(this.txtMaNV.Text);
            tk.Holot = String.Format(this.txtHoLotNV.Text);
            tk.ten = String.Format(this.txtTenNV.Text);
            //tk.phai = String.Format(this.txtTenNV.Text);
            tk.giol = String.Format(this.radbFullTime.Text);
            tk.songay = String.Format(this.txtSoNgayLmVC.Text);
            tk.tienluong = String.Format(this.txttienluong.Text);
//<<<<<<< HEAD
//>>>>>>> e30a4cf225fa6fa2b4507811c86571a417aa4ad5
            tk.ShowDialog();
//=======
            tk.Show();

            
//>>>>>>> 790e9782c4355585bdc5973a2abb633a54308946
        }

        private void dtgThongTinNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dtgThongTinNV.SelectedRows[0];
            txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();
            txtHoLotNV.Text = dr.Cells["HoLot"].Value.ToString();
            txtTenNV.Text = dr.Cells["TenNV"].Value.ToString();

            if (radbNam.Checked == true)
            {
                dr.Cells["Phai"].Value.ToString();
            }
            else if (radbNu.Checked == true)
            {
                dr.Cells["Phai"].Value.ToString();
            }
        }

//<<<<<<< HEAD
//<<<<<<< HEAD
//=======

//>>>>>>> 790e9782c4355585bdc5973a2abb633a54308946
        private void TinhLuongcs_Load_1(object sender, EventArgs e)
        {
            loadData1();
          

        }
//<<<<<<< HEAD
//=======
        /*private void TinhLuongcs_Load(object sender, EventArgs e)
        {

        }*/

    
//>>>>>>> e30a4cf225fa6fa2b4507811c86571a417aa4ad5
//=======

   
        
//>>>>>>> 790e9782c4355585bdc5973a2abb633a54308946
    }
}






       
            
        

       
    

