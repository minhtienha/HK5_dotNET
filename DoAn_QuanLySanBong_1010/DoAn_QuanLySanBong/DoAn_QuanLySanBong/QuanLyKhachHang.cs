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
using DoAn_QuanLySanBong.Class;

namespace DoAn_QuanLySanBong
{
    public partial class QuanLyKhachHang : Form
    {
        DBConnection db = new DBConnection();
        DataTable dsKhachHang = new DataTable();

        public QuanLyKhachHang()
        {
            InitializeComponent();
            dsKhachHang = db.GetDataTable("select * from KhachHang");
        }
        private void HienThiKhachHang()
        {
            //tao khoa chinh cho dt
            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = dsKhachHang.Columns["MaKhachHang"];
            dsKhachHang.PrimaryKey = primaryKey;

            dgv_KhachHang.DataSource = dsKhachHang;
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            //HienThiKhachHang();
            dgv_KhachHang.Rows.Clear();
            string str = "select * from KhachHang";
            dsKhachHang = db.GetDataTable(str);

            foreach (DataRow row in dsKhachHang.Rows)
            {
                dgv_KhachHang.Rows.Add(row.ItemArray);
            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtSoDT.Text = row.Cells["LienHe"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();

                string gt = row.Cells["GioiTinh"].Value.ToString();
                foreach (Control c in gr_ThongTin_KH.Controls)
                {
                    if (c is RadioButton)
                    {
                        RadioButton rb = (RadioButton)c;
                        rb.Checked = rb.Text == gt;
                    }
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM KhachHang";
            DataTable dt = db.GetDataTable(str);

            DataRow dr = dt.NewRow();

            dr["MaKhachHang"] = txtMaKH.Text;
            dr["TenKhachHang"] = txtTenKH.Text;
            dr["LienHe"] = txtSoDT.Text;
            dr["CCCD"] = txtCCCD.Text;

            string gt = "";
            foreach (Control c in gr_ThongTin_KH.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked)
                    {
                        gt = rb.Text;
                        break;
                    }
                }
            }
            dr["GioiTinh"] = gt;

            dt.Rows.Add(dr);

            int kq = db.UpdateTable(dt, str);

            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM KhachHang";
            DataTable dt = db.GetDataTable(str);

            foreach (DataRow row in dt.Rows)
            {
                if (row["MaKhachHang"].ToString() == txtMaKH.Text)
                {
                    row["TenKhachHang"] = txtTenKH.Text;
                    row["LienHe"] = txtSoDT.Text;
                    row["CCCD"] = txtCCCD.Text;

                    string gt = "";
                    foreach (Control c in gr_ThongTin_KH.Controls)
                    {
                        if (c is RadioButton)
                        {
                            RadioButton rb = (RadioButton)c;
                            if (rb.Checked)
                            {
                                gt = rb.Text;
                                break;
                            }
                        }
                    }
                    row["GioiTinh"] = gt;

                    break;
                }
            }

            int kq = db.UpdateTable(dt, str);

            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công!");
                QuanLyKhachHang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại.");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string str = "DELETE FROM KhachHang WHERE MaKhachHang = '" + maKH + "'";

                int kq = db.GetNonQuery(str);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    QuanLyKhachHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void txtTimKiemKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = txtTimKiemKH.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {
                    TimKiemKhachHang(keyword);
                }
                else
                {
                    QuanLyKhachHang_Load(sender, e);
                    MessageBox.Show("Vui lòng nhập tên hoặc mã khách hàng để tìm kiếm.");
                }

                e.SuppressKeyPress = true;
            }
        }
        private void TimKiemKhachHang(string keyword)
        {
            string str = "SELECT * FROM KhachHang WHERE MaKhachHang LIKE '%" + keyword + "%' OR TenKhachHang LIKE '%" + keyword + "%'";

            DataTable dt = db.GetDataTable(str);

            dgv_KhachHang.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dgv_KhachHang.Rows.Add(row.ItemArray);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng nào!");
            }
        }

        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {

            string keyword = txtTimKiemKH.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                dsKhachHang = db.GetDataTable("SELECT * FROM KhachHang");
            }
            else
            {
                string query = "SELECT * FROM KhachHang WHERE MaKhachHang LIKE N'%" + keyword + "%' OR TenKhachHang LIKE N'%" + keyword + "%'";
                dsKhachHang = db.GetDataTable(query);
            }

            dgv_KhachHang.Rows.Clear();

            foreach (DataRow row in dsKhachHang.Rows)
            {
                dgv_KhachHang.Rows.Add(row.ItemArray);
            }
        }



    }
}
