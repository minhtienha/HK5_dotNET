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
    public partial class ThongKe : Form
    {

        DBConnection db = new DBConnection();

        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            string str = "select * from San";
            DataTable dt = db.GetDataTable(str);

            DataRow emptyRowSan = dt.NewRow();
            emptyRowSan["MaSan"] = DBNull.Value;
            emptyRowSan["TenSan"] = "";
            dt.Rows.InsertAt(emptyRowSan, 0);

            cbBox_San.DataSource = dt;
            cbBox_San.DisplayMember = "TenSan";
            cbBox_San.ValueMember = "MaSan";
            cbBox_San.SelectedIndex = 0;

            DateTime ngayHienTai = DateTime.Now;

            thoiGianTu.Value = ngayHienTai;
            thoiGianDen.Value = ngayHienTai;

            crystalReportViewer1.Visible = false;
        }

        private DataTable DataThongKe()
        {
            string msan = cbBox_San.SelectedValue.ToString();
            string tbd = thoiGianTu.Value.ToString("yyyy-MM-dd");
            string tkt = thoiGianDen.Value.ToString("yyyy-MM-dd");

            string query = "SELECT hdds.MaDatSan, MaKhachHang, MaSan, NgayDatSan, MaCaThue, ThanhTien " +
                           "FROM HoaDonDatSan hdds, ChiTietHoaDonDatSan cthd " +
                           "WHERE hdds.MaDatSan = cthd.MaDatSan AND TinhTrang = N'Đã thanh toán'";

            if (!string.IsNullOrEmpty(msan))
            {
                query += " AND MaSan = '" + msan + "' ";
            }
            query += " AND NgayDatSan BETWEEN '" + tbd + "' AND '" + tkt + "'";

            DataTable dt = db.GetDataTable(query);
            return dt;
        }

        private void HienThi()
        {
            DataTable dt = DataThongKe();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có lần đặt sân nào hết trong ngày");
                return;
            }
            dgvThongKe.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvThongKe.Rows.Add(row.ItemArray);
            }
            int sohd = dgvThongKe.Rows.Count - 1;
            txt_SoDonDat.Text = sohd.ToString();

            double tongdt = 0;

            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongdt += Convert.ToDouble(row.Cells["ThanhTien"].Value);
                }
            }
            txt_DoanhThu.Text = tongdt.ToString("N0");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (thoiGianDen.Value < thoiGianTu.Value)
            {
                MessageBox.Show("Thời gian sau phải lớn hoặc bằng thời gian trước");
                return;
            }
            crystalReportViewer1.Visible = false;
            dgvThongKe.Visible = true;
            label5.Visible = true;
            label8.Visible = true;
            txt_DoanhThu.Visible = true;
            txt_SoDonDat.Visible = true;
            HienThi();
            crystalReportViewer1.Visible = false;
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            dgvThongKe.Visible = false;
            label5.Visible = false;
            label8.Visible = false;
            txt_DoanhThu.Visible = false;
            txt_SoDonDat.Visible = false;
            DataTable dt = DataThongKe();

            if (dt.Rows.Count > 0)
            {
                CrystalReport1 report = new CrystalReport1();
                report.SetDataSource(dt);
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.DisplayStatusBar = false;
                crystalReportViewer1.DisplayToolbar = true;
                crystalReportViewer1.Refresh();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }

        }
    }
}
