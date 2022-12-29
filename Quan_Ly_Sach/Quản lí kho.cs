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
    public partial class Quản_lí_kho : Form
    {
        public Quản_lí_kho()
        {
            InitializeComponent();
        }

        //String connectingString;
        //SqlConnection conn;

        DataSet ds = new DataSet("dsQLBS");

        SqlDataAdapter daKho;
        SqlDataAdapter daSach;
        private void Quản_lí_kho_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLBS;Integrated Security=True";

            //Dử liệu datagrid kho
            string sQueryKHO = @"select k.*, s.MaSach,s.TenSach,s.SLTon from KHO k, Sach s where s.MaKho=k.MaKho";
            daKho = new SqlDataAdapter(sQueryKHO, conn);
            daKho.Fill(ds, "tblDSKHO");

            dtgvQLK.DataSource = ds.Tables["tblDSKHO"];
            dtgvQLK.Columns["MaKHO"].HeaderText = "Mã Kho";
            dtgvQLK.Columns["MaKHO"].Width = 100;

            dtgvQLK.Columns["TenKHO"].HeaderText = "Tên Kho";
            dtgvQLK.Columns["TenKHO"].Width = 100;

            dtgvQLK.Columns["DC"].HeaderText = "Địa chỉ";
            dtgvQLK.Columns["DC"].Width = 100;

            dtgvQLK.Columns["SoDT"].HeaderText = "Sồ Điện thoại";
            dtgvQLK.Columns["SoDT"].Width = 100;

            dtgvQLK.Columns["NVK"].HeaderText = "Nhân Viên Kho";
            dtgvQLK.Columns["NVK"].Width = 100;

            dtgvQLK.Columns["MaSach"].HeaderText = "Mã Sách";
            dtgvQLK.Columns["MaSach"].Width = 100;

            dtgvQLK.Columns["TenSach"].HeaderText = "Tên Sách";
            dtgvQLK.Columns["TenSach"].Width = 100;

            dtgvQLK.Columns["SLTon"].HeaderText = "Số lượng tồn";
            dtgvQLK.Columns["SLTon"].Width = 100;

            string sThemKHO = @"insert into KHO values(@MaKHO, @TenKHO, @DC, @SoDT, @NVK)";
            SqlCommand cmThemKho = new SqlCommand(sThemKHO, conn);
            cmThemKho.Parameters.Add("@MaKHO", SqlDbType.NVarChar, 15, "MaKHO");
            cmThemKho.Parameters.Add("@TenKHO", SqlDbType.NVarChar, 20, "TenKHO");
            cmThemKho.Parameters.Add("@DC", SqlDbType.NVarChar, 40, "DC");
            cmThemKho.Parameters.Add("@SoDT", SqlDbType.VarChar, 20, "SoDT");
            cmThemKho.Parameters.Add("@NVK", SqlDbType.VarChar, 20, "NVK");
            cmThemKho.Parameters.Add("@MaSach", SqlDbType.Char, 5, "MaSach");
            cmThemKho.Parameters.Add("@TenSach", SqlDbType.VarChar, 40, "TenSach");
            cmThemKho.Parameters.Add("@SLTon", SqlDbType.SmallInt, 0, "SLTon");
            daKho.InsertCommand = cmThemKho;

            //Dử liệu datagrid Sach
            string sQuerySach = @"select  MaSach, TenSach, TacGia, MaLoai, DonGia, SLTon from Sach ";
            daSach = new SqlDataAdapter(sQuerySach, conn);
            daSach.Fill(ds, "tblDSSach");
        }

        private void dtgvQLK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dtgvQLK.SelectedRows[0];
            txtMK.Text = dr.Cells["MaKHO"].Value.ToString();
            txtTK.Text = dr.Cells["TenKHO"].Value.ToString();
            cmbDCK.SelectedValue = dr.Cells["DC"].Value.ToString();
            cmbDCK.Text = dr.Cells["DC"].Value.ToString();
            txtSDT.Text = dr.Cells["SoDT"].Value.ToString();
            txtMS.Text = dr.Cells["MaSach"].Value.ToString();
            txtTS.Text = dr.Cells["TenSach"].Value.ToString();
            txtSL.Text = dr.Cells["SLTon"].Value.ToString();
            cmbNVK.SelectedValue = dr.Cells["NVK"].Value.ToString();
            cmbNVK.Text = dr.Cells["NVK" +
                ""].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                //Thêm kho
                DataRow row = ds.Tables["tblDSKHO"].NewRow();
                row["MaKHO"] = txtMK.Text;
                row["TenKHO"] = txtTK.Text;
                row["DC"] = cmbDCK.SelectedValue;
                row["DC"] = cmbDCK.Text;
                row["SoDT"] = txtSDT.Text;
                row["MaSach"] = txtMS.Text;
                row["TenSach"] = txtTS.Text;
                row["SLTon"] = txtSL.Text;
                row["NVK"] = cmbNVK.SelectedValue;
                row["NVK"] = cmbNVK.Text;
                ds.Tables["tblDSKHO"].Rows.Add(row);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                this.txtMK.ResetText();
                this.txtTK.ResetText();
                this.cmbDCK.ResetText();
                this.txtSDT.ResetText();
                this.txtMS.ResetText();
                this.txtTS.ResetText();
                this.txtSL.ResetText();

                /*foreach (DataGridViewRow dr in this.dtgvS.SelectedRows)
                {
                    this.dtgvS.Rows.RemoveAt(dr.Index);
                }*/
                foreach (DataGridViewRow dr in this.dtgvQLK.SelectedRows)
                {
                    this.dtgvQLK.Rows.RemoveAt(dr.Index);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            {
                if (dtgvQLK.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr2 = dtgvQLK.SelectedRows[0];
                    dr2.Cells["MaKho"].Value = txtMK.Text;
                    dr2.Cells["TenKho"].Value = txtTK.Text;
                    dr2.Cells["DC"].Value = cmbDCK.SelectedValue;
                    dr2.Cells["DC"].Value = cmbDCK.Text;
                    dr2.Cells["SoDT"].Value = txtSDT.Text;
                    dr2.Cells["MaSach"].Value = txtMS.Text;
                    dr2.Cells["TenSach"].Value = txtTS.Text;
                    dr2.Cells["SLTon"].Value = txtSL.Text;
                    dr2.Cells["NVK"].Value = cmbNVK.SelectedValue;
                    dr2.Cells["NVK"].Value = cmbNVK.Text;
                    ds.Tables["tblDSKhO"].Rows.Add(dr2);
                }
                /*else if (dtgvS.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dtgvS.SelectedRows[0];
                    dr.Cells["MaSach"].Value = txtMS.Text;
                    dr.Cells["TenSach"].Value = txtTS.Text;
                    ds.Tables["tblDSSach"].Rows.Add(dr);
                    dr.Cells["SLTon"].Value = txtSL.Text;


                }*/
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                this.BindingContext[ds, "tblDSKHO"].EndCurrentEdit();
                //this.BindingContext[ds, "tblDSSach"].EndCurrentEdit();
                if (ds.HasChanges() == true)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn lưu các thay đổi trên bảng dữ liệu Danh sách nhân viên ?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            daKho.Update(ds.Tables["tblDSKHO"]);
                            //daSach.Update(ds.Tables["tblDSSach"]);
                            MessageBox.Show("Đã cập nhật");
                        }
                        catch (Exception x) { MessageBox.Show(x.Message); }
                    }
                }
                else
                {
                    MessageBox.Show("Cơ sở dữ liệu chưa có sự thay đổi.", "Thông báo người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                loadData();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMK_MouseClick(object sender, MouseEventArgs e)
        {
            this.dtgvQLK.Visible = true;
            this.dtgvQLK.Enabled = true;
        }

        private void txtMS_MouseClick(object sender, MouseEventArgs e)
        {
            /*this.dtgvS.Visible = true;
           this.dtgvS.Enabled = true;*/
        }
    }
}