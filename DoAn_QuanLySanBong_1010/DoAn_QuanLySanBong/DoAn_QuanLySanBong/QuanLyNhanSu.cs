using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QuanLySanBong.Class;
namespace DoAn_QuanLySanBong
{
    public partial class QuanLyNhanSu : Form
    {
        private string UserName = DangNhap.UserName;
        public QuanLyNhanSu()
        {
            InitializeComponent();
            PhanQuyen();
        }

        public void PhanQuyen()
        {
            DBConnection db = new DBConnection();
            DataTable dt = db.GetDataTable("SELECT ChucVu FROM NhanVien WHERE TenNhanVien = N'" + UserName + "'");

            if (dt.Rows.Count > 0)
            {
                string maQuanLy = dt.Rows[0]["ChucVu"].ToString();

                if (maQuanLy != "Quản lý")
                {
                    nhânViênToolStripMenuItem.Enabled= false;
                }
            }
        }
        private void OpenChildForm(Form childForm)
        {
            // Xóa các form con cũ trong panel
            panelQuanLy_body.Controls.Clear();

            // Thiết lập form con
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Thêm form con vào panel
            panelQuanLy_body.Controls.Add(childForm);
            panelQuanLy_body.Tag = childForm;

            // Hiển thị form con
            childForm.Show();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
        }
    }
}
