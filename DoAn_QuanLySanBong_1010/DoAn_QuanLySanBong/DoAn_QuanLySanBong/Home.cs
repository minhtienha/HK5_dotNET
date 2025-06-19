using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DoAn_QuanLySanBong.Class;
namespace DoAn_QuanLySanBong
{
    public partial class Home : Form
    {
        DBConnection db = new DBConnection();
        DataTable dt = new DataTable();
        private string userName = DangNhap.UserName;
        public Home()
        {
            InitializeComponent();

            //dt = db.GetDataTable("select * from NhanVien where TenNhanVien = N'" + userName+"'");

            //ẩn mục quản lý nhân sự nếu là nhân viên
            //PhanQuyen();
        }
        public void PhanQuyen()
        {
            DBConnection db = new DBConnection();
            DataTable dt = db.GetDataTable("SELECT ChucVu FROM NhanVien WHERE TenNhanVien = N'" + userName + "'");

            if (dt.Rows.Count > 0)
            {
                string maQuanLy = dt.Rows[0]["ChucVu"].ToString();

                if (maQuanLy != "Quản lý")
                {
                    btn_QlyNhanVien.Visible = false;
                }
            }
        }
        private Form currentFormChild;

        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false; // Đặt form con không phải là top-level
            childForm.FormBorderStyle = FormBorderStyle.None; // Không hiển thị viền form
            childForm.Dock = DockStyle.Fill; // Đổ đầy panel_Body
            panel_Body.Controls.Add(childForm); // Thêm form vào panel_Body
            panel_Body.Tag = childForm; // Lưu tag để tham chiếu
            childForm.BringToFront(); // Đưa form con lên trên
            childForm.Show(); // Hiển thị form con
        }

        private void btn_DatSan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DatSan());
        }

        private void btn_QlyNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanSu());
        }

        private void btn_QlyKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = null;
            label1.Text += "Chào mừng, " + userName;
            HienThiHinhDaiDien(DangNhap.HinhDaiDien);
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
            pB_Hinh.Image = Image.FromFile(des);
        }
        private void btn_QuanLySan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLySan());
        }

        private void btn_NhanSan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DaDatSan());
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dnForm = new DangNhap();
                dnForm.Show();
                this.Close();
            }
        }
    }
}
