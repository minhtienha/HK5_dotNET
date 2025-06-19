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
using System.IO;
using DoAn_QuanLySanBong.Class;

namespace DoAn_QuanLySanBong
{
    public partial class QuanLyNhanVien : Form
    {
        DBConnection db = new DBConnection();
        DataTable dsNhanVien;

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void HienThiNhanVien()
        {
            //tao khoa chinh cho dt
            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = dsNhanVien.Columns["MaNhanVien"];
            dsNhanVien.PrimaryKey = primaryKey;

            dgv_NhanVien.DataSource = dsNhanVien;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dsNhanVien = db.GetDataTable("select MaNhanVien, TenNhanVien, SoDT, ChucVu,DiaChi, NgaySinh, GioiTinh, HinhDaiDien from NhanVien");
            dgv_NhanVien.DataSource = dsNhanVien;
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_NhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtSoDT.Text = row.Cells["SoDT"].Value.ToString();
                cbo_ChucVu.SelectedItem = row.Cells["ChucVu"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                dtt_NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txt_AnhDaiDien.Text = row.Cells["HinhDaiDien"].Value.ToString().Trim();
                string gt = row.Cells["GioiTinh"].Value.ToString();
                foreach (Control c in gr_ThongTinNV.Controls)
                {
                    if (c is RadioButton)
                    {
                        RadioButton rb = (RadioButton)c;
                        string t = rb.Text;
                        if (t == gt)
                            rb.Checked = true;
                        else
                        {
                            rb.Checked = false;
                        }
                    }
                }
                HienThiHinhDaiDien(row.Cells["HinhDaiDien"].Value.ToString().Trim());
            }
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM NhanVien";
            DataTable dt = db.GetDataTable(str);

            DataRow dr = dt.NewRow();

            dr["MaNhanVien"] = txtMaNV.Text;
            dr["TenNhanVien"] = txtTenNV.Text;
            dr["SoDT"] = txtSoDT.Text;
            dr["DiaChi"] = txtDiaChi.Text;
            dr["NgaySinh"] = dtt_NgaySinh.Value;
            dr["ChucVu"] = cbo_ChucVu.SelectedItem.ToString().Trim();
            dr["HinhDaiDien"] = txt_AnhDaiDien.Text;
            dr["MatKhau"] = "123";
            string gt = "";
            foreach (Control c in gr_ThongTinNV.Controls)
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
                QuanLyNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM NhanVien";
            DataTable dt = db.GetDataTable(str);

            foreach (DataRow row in dt.Rows)
            {
                if (row["MaNhanVien"].ToString().Trim() == txtMaNV.Text.Trim())
                {
                    row["TenNhanVien"] = txtTenNV.Text;
                    row["SoDT"] = txtSoDT.Text;
                    row["DiaChi"] = txtDiaChi.Text;
                    row["NgaySinh"] = dtt_NgaySinh.Value;
                    row["ChucVu"] = cbo_ChucVu.SelectedItem.ToString().Trim();
                    row["HinhDaiDien"] = txt_AnhDaiDien.Text;
                    row["MatKhau"] = "123";

                    string gt = "";
                    foreach (Control c in gr_ThongTinNV.Controls)
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
                QuanLyNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại.");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;

            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string str = "delete from NhanVien where MaNhanVien = '" + maNV + "'";

                int kq = db.GetNonQuery(str);

                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    QuanLyNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            dlg.InitialDirectory = @"E:\";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] dsHinhAnh = dlg.FileNames;
                {
                    foreach (var tenFile in dsHinhAnh)
                    {
                        FileInfo fi = new FileInfo(tenFile);
                        string[] xxx = tenFile.Split('\\');

                        string ddl = Directory.GetParent(Application.StartupPath).Parent.FullName;

                        string des = ddl + @"\HinhAnhDaiDien\" + xxx[xxx.Length - 1];

                        if (File.Exists(des))
                            File.Delete(des);

                        fi.CopyTo(des);

                        pB_HinhAnhNhanVien.Image = Image.FromFile(des);
                        txt_AnhDaiDien.Text = Path.GetFileName(tenFile);
                    }
                    MessageBox.Show("Thêm thành công!");
                    dlg.Dispose();
                }
            }
        }

        private void txt_searchbox_TextChanged(object sender, EventArgs e)
        {

            string keyword = txt_searchbox.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                dsNhanVien = db.GetDataTable("select MaNhanVien, TenNhanVien, SoDT, ChucVu,DiaChi, NgaySinh, GioiTinh, HinhDaiDien FROM NhanVien");
            }
            else
            {
                string query = "select MaNhanVien, TenNhanVien, SoDT, ChucVu,DiaChi, NgaySinh, GioiTinh, HinhDaiDien FROM NhanVien WHERE MaNhanVien LIKE N'%" + keyword + "%' OR TenNhanVien LIKE N'%" + keyword + "%'";
                dsNhanVien = db.GetDataTable(query);
            }

            DataTable dt = dgv_NhanVien.DataSource as DataTable;
            if (dt != null)
            {
                dt.Clear();
            }
            dgv_NhanVien.DataSource = dsNhanVien;

            //foreach (DataRow row in dsNhanVien.Rows)
            //{
            //    dgv_NhanVien.Rows.Add(row.ItemArray);
            //}
        }
        private void HienThiHinhDaiDien(string HinhAnh)
        {
            string ddl = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string des = "";
            if (!string.IsNullOrEmpty(HinhAnh))
            {

                des = ddl + @"\HinhAnhDaiDien\" + HinhAnh;
            }
            else
            {
                des = ddl + @"\HinhAnhDaiDien\unknown.png";
            }
            pB_HinhAnhNhanVien.Image = Image.FromFile(des);
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = TaoMaNhanVien();
            txt_AnhDaiDien.Clear();
            cbo_ChucVu.SelectedItem = "Nhân viên";
            foreach (Control c in gr_ThongTinNV.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked)
                    {
                        rb.Checked = false;
                        break;
                    }
                }
            }
            txtTenNV.Clear();
            txtSoDT.Clear();
            txtDiaChi.Clear();
            HienThiHinhDaiDien("");
        }
        private string TaoMaNhanVien()
        {
            string MaNhanVien = "NV";
            string query = @"select top 1 MaNhanVien from NhanVien where MaNhanVien like '" + MaNhanVien + "%' order by MaNhanVien desc";
            string MaNhanVienCuoiCung = (string)db.GetScalar(query);

            if (MaNhanVienCuoiCung == null)
            {
                MaNhanVien += "001";
            }
            else
            {
                string Lay3KyTuCuoi = MaNhanVienCuoiCung.Substring(2);
                int stt = int.Parse(Lay3KyTuCuoi) + 1;

                if (stt.ToString().Length == 1)
                    MaNhanVien += "00" + stt;
                else if (stt.ToString().Length == 2)
                    MaNhanVien += "0" + stt;
                else
                    MaNhanVien += stt;
            }
            return MaNhanVien;
        }
    }
}
