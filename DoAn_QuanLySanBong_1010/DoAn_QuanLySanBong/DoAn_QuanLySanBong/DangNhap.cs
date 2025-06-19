using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAn_QuanLySanBong.Class;
namespace DoAn_QuanLySanBong
{
    public partial class DangNhap : Form
    {
        public static string HinhDaiDien;
        public static string UserName;
        public DangNhap()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(DBConnection.stringConnection))
            {
                DBConnection.stringConnection = @"Data Source=SHINICHIKUTIEN;Initial Catalog=DB_QLSANBONG;Integrated Security=True";
            }
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

            string sdt = txt_TaiKhoan.Text;
            string pass = txt_MatKhau.Text;

     
            DBConnection data = new DBConnection();
            string query = "Select* from NhanVien";
            query += " where SoDT = '" + sdt + "' and MatKhau = '" + pass + "'";

            DataTable dt = data.GetDataTable(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Đăng nhập thất bại!");
                txt_MatKhau.Clear();
            }
            else
            {
                UserName = dt.Rows[0]["TenNhanVien"].ToString().Trim();
                HinhDaiDien = dt.Rows[0]["HinhDaiDien"].ToString().Trim();
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_MatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }

    }
}
