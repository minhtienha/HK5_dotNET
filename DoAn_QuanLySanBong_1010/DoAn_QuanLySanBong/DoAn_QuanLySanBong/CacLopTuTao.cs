using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLySanBong
{
    public class LoaiSan
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public decimal GiaThue { get; set; }

        public static List<LoaiSan> dsLoaiSan = new List<LoaiSan>
        {
            new LoaiSan { MaLoai = "LS001", TenLoai = "Sân 5 người", GiaThue = 200000 },
            new LoaiSan { MaLoai = "LS002", TenLoai = "Sân 7 người", GiaThue = 300000 },
            new LoaiSan { MaLoai = "LS003", TenLoai = "Sân 9 người", GiaThue = 500000 }
        };
    }

    public class San
    {
        public string MaSan { get; set; }
        public string MaLoai { get; set; }
        public string TenSan { get; set; }
        public string TinhTrang { get; set; }

        public static List<San> dsSan = new List<San>()
        {
            new San { MaSan = "S001", MaLoai = "LS001", TenSan = "Sân A 5 Người", TinhTrang = "Trống" },
            new San { MaSan = "S002", MaLoai = "LS002", TenSan = "Sân B 7 Người", TinhTrang = "Đã đặt" },
            new San { MaSan = "S003", MaLoai = "LS003", TenSan = "Sân C 9 Người", TinhTrang = "Bảo trì" },
            new San { MaSan = "S004", MaLoai = "LS001", TenSan = "Sân D 5 Người", TinhTrang = "Trống" },
            new San { MaSan = "S005", MaLoai = "LS002", TenSan = "Sân E 7 Người", TinhTrang = "Đã đặt" }
        };
    }

    public class CaThue
    {
        public string MaCaThue { get; set; }
        public string ThoiGianBD { get; set; }
        public string ThoiGianKT { get; set; }
    }

    public class HoaDonDatSan
    {
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayDat { get; set; }
        public string TinhTrang { get; set; }
    }

    public class ChiTietHoaDonDatSan
    {
        public string MaHD { get; set; }
        public string MaSan { get; set; }
        public string MaCaThue { get; set; }
        public decimal ThanhTien { get; set; }
    }

    public partial class DatSan
    {
        public string MaSan { get; set; }
        public string TenSan { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayThue { get; set; }
        public string CaThue { get; set; }
        public string TrangThai { get; set; }

        public DatSan(string maSan, string tenSan, string soDienThoai, DateTime ngayThue, string caThue, string trangThai)
        {
            MaSan = maSan;
            TenSan = tenSan;
            SoDienThoai = soDienThoai;
            NgayThue = ngayThue;
            CaThue = caThue;
            TrangThai = trangThai;
        }

        public List<DatSan> KhoiTao()
        {
            List<DatSan> danhSachDatSan = new List<DatSan>();
            danhSachDatSan.Add(new DatSan("S001", "Sân A 5 Người", "Nguyễn Văn A", new DateTime(2024, 10, 10), "8h00 - 9h30", "Đã thanh toán"));
            danhSachDatSan.Add(new DatSan("S002", "Sân B 7 Người", "Lê Văn B", new DateTime(2024, 10, 11), "16h00 - 18h30", "Chưa thanh toán"));
            return danhSachDatSan;
        }
    }
}