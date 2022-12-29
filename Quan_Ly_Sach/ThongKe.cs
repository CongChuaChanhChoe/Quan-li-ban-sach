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
    public partial class ThongKe : Form
    {
        public  ThongKe()
        {
            InitializeComponent();
          


        }
//<<<<<<< HEAD
//<<<<<<< HEAD
//=======
    
        //<<<<<<< HEAD
//>>>>>>> 790e9782c4355585bdc5973a2abb633a54308946
        public int n;
       // string connectionString;
       // SqlConnection conn;
        //SqlDataAdapter daSach;
//=======
        public string manv, Holot, ten, giol, songay, tienluong, phai;
        string connectionString;
        SqlConnection conn;
        SqlDataAdapter daSach;
//>>>>>>> e30a4cf225fa6fa2b4507811c86571a417aa4ad5
        private void sốLượngSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grbTKSach.Enabled = true;
            this.grbTKSach.Visible = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MINHANH\SQLEXPRESS;Initial Catalog=QLBS;Integrated Security=True";


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grbTKSach.Enabled = false;
            this.grbTKSach.Visible = false;
            this.grbNV.Enabled = true;
            this.grbNV.Visible = true;
            lsvNhanVien.Items.Add(manv);
            lsvNhanVien.Items.Add(Holot);
            lsvNhanVien.Items.Add(ten);
            lsvNhanVien.Items.Add(phai);
            lsvNhanVien.Items.Add(giol);
            lsvNhanVien.Items.Add(songay);
            lsvNhanVien.Items.Add(tienluong);
        }

        private void ThongKe_Load_1(object sender, EventArgs e)
        {
     
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
