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
    public partial class DaDatSan : Form
    {

        DBConnection db = new DBConnection();

        public DaDatSan()
        {
            InitializeComponent();
        }

        private void HienThiSanDat(DateTime? thoiGianTu = null, DateTime? thoiGianDen = null)
        {
            lst_SanDaDat.Items.Clear();

            string query = "Select hdds.MaDatSan, s.MaSan, ct.MaCaThue, s.TenSan, TenKhachHang, LienHe, NgayDatSan, ThoiGianBD, ThoiGianKT, hdds.TinhTrang " +
                        "from San s, CaThue ct, KhachHang kh, HoaDonDatSan hdds, ChiTietHoaDonDatSan cthd " +
                        "where hdds.MaDatSan = cthd.MaDatSan " +
                        "and cthd.MaSan = s.MaSan " +
                        "and hdds.MaKhachHang = kh.MaKhachHang " +
                        "and cthd.MaCaThue = ct.MaCaThue";

            if (thoiGianTu.HasValue && thoiGianDen.HasValue)
            {
                query += " and NgayDatSan BETWEEN '" + thoiGianTu.Value.ToString("yyyy-MM-dd") +
                     "' AND '" + thoiGianDen.Value.ToString("yyyy-MM-dd") + "'";
            }

            DataTable dt = db.GetDataTable(query);

            string title = string.Format("{0}\t\t | {1}\t\t | {2}\t\t | {3}\t | {4}\t | {5}\t\t\t\t | {6}",
                    "Mã HD", "Tên sân", "Tên Khách Hàng", "Số Điện Thoại", "Ngày Đặt", "Ca Thuê", "Trạng Thái");
            lst_SanDaDat.Items.Add(title);

            foreach (DataRow row in dt.Rows)
            {
                DateTime ngayDatSan = (DateTime)row["NgayDatSan"];
                TimeSpan thoiGianBD = (TimeSpan)row["ThoiGianBD"];
                TimeSpan thoiGianKT = (TimeSpan)row["ThoiGianKT"];

                string item = string.Format("{0}\t | {1}\t | {2}\t\t | {3}\t | {4}\t | {5} - {6}\t | {7} | {8}\t | {9}",
                    row["MaDatSan"].ToString().Trim(),
                    row["TenSan"].ToString().Trim(),
                    row["TenKhachHang"].ToString().Trim(),
                    row["LienHe"].ToString().Trim(),
                    ngayDatSan.ToString("dd/MM/yyyy").ToString().Trim(),
                    thoiGianBD.ToString(@"hh\:mm").ToString().Trim(),
                    thoiGianKT.ToString(@"hh\:mm").ToString().Trim(),
                    row["MaSan"].ToString().Trim(),
                    row["MaCaThue"].ToString().Trim(),
                    row["TinhTrang"]);

                lst_SanDaDat.Items.Add(item);
            }
        }

        private void NhanSan_Load(object sender, EventArgs e)
        {
            HienThiSanDat();
        }

        private void btn_Xem_Click(object sender, System.EventArgs e)
        {
            DateTime tbd = thoiGianTu.Value.Date;
            DateTime tkt = thoiGianDen.Value.Date;

            if (tkt < tbd)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hoặc bằng ngày bắt đầu tìm");
                return;
            }

            HienThiSanDat(tbd, tkt);
        }

        private void btn_XemTatCa_Click(object sender, System.EventArgs e)
        {
            HienThiSanDat();
        }

        private void btn_HuyLich_Click(object sender, System.EventArgs e)
        {
            string curItem = lst_SanDaDat.SelectedItem.ToString();

            string[] item = curItem.Split(new string[] { " | " }, StringSplitOptions.None);

            string maHD = item[0].Trim();
            string maSan = item[6].Trim();
            string caThue = item[7].Trim();
            string nd = item[4].ToString();
            DateTime ngayDat = DateTime.Parse(nd);

            if (ngayDat.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Chỉ có thể huỷ lịch trong tương lai");
                return;
            }

            string str_deleteChiTiet = "DELETE FROM ChiTietHoaDonDatSan " +
                           "WHERE MaDatSan = '" + maHD + "' " +
                           "AND MaSan = '" + maSan + "' " +
                           "AND MaCaThue = '" + caThue + "'";

            string str_checkChiTiet = "SELECT COUNT(*) FROM ChiTietHoaDonDatSan " +
                "WHERE MaDatSan LIKE '%" + maHD + "%'";

            db.Open();

            int kq = db.GetNonQuery(str_deleteChiTiet);
            if (kq > 0)
            {
                MessageBox.Show("Đã xóa một lịch thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy một lịch cần xóa!");
            }

            int count = (int)db.GetScalar(str_checkChiTiet);

            if (count == 0)
            {
                string str_deleteHoaDon = "delete HoaDonDatSan " +
                        "where MaDatSan LIKE '%" + maHD + "%'";
                int kq2 = db.GetNonQuery(str_deleteHoaDon);
                if (kq2 > 0)
                {
                    MessageBox.Show("Đã huỷ lịch và hoá đơn thành công");
                    HienThiSanDat();
                }
                else
                {
                    MessageBox.Show("Huỷ lịch thất bại");
                }
            }
            HienThiSanDat();
            db.Close();
        }

        private void btn_ThanhToan_Click(object sender, System.EventArgs e)
        {
            string curItem = lst_SanDaDat.SelectedItem.ToString();

            string[] item = curItem.Split(new string[] { " | " }, StringSplitOptions.None);

            string maHD = item[0].Trim();
            string maSan = item[6].Trim();
            string caThue = item[7].Trim();

            string str_checkStatus = "SELECT TinhTrang FROM HoaDonDatSan hd, ChiTietHoaDonDatSan cthd " +
                                      "WHERE hd.MaDatSan = cthd.MaDatSan AND hd.MaDatSan = '" + maHD + "' " +
                                      "AND MaSan = '" + maSan + "' " +
                                      "AND MaCaThue = '" + caThue + "'";

            db.Open();
            string currentStatus = (string)db.GetScalar(str_checkStatus);

            if (currentStatus == "Đã thanh toán")
            {
                MessageBox.Show("Trạng thái đã là 'Đã thanh toán'. Không cần cập nhật nữa.");
            }
            else
            {
                string str_update = "UPDATE HoaDonDatSan " +
                                    "SET TinhTrang = N'Đã thanh toán' " +
                                    "WHERE MaDatSan = '" + maHD + "' ";

                int kq = db.GetNonQuery(str_update);

                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật trạng thái thành công!");
                    HienThiSanDat();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn để cập nhật.");
                }
            }

            db.Close();
        }
    }
}