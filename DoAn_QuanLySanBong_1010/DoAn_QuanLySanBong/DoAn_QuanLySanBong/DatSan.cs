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
using System.Data.SqlClient;
using System.Globalization;

namespace DoAn_QuanLySanBong
{
    public partial class DatSan : Form
    {
        List<CheckBox> listCheckBoxes; // list này gồm các ca thuê
        DataTable dt_LoaiSan;
        DataTable dt_TenSan;
        public DatSan()
        {
            InitializeComponent();
            listCheckBoxes = new List<CheckBox> { CTS001, CTS002, CTC001, CTC002, CTT001, CTT002 };
            dt_LoaiSan = new DataTable();
            dt_TenSan = new DataTable();
            datetime_NgayDatSan.ValueChanged -= datetime_NgayDatSan_ValueChanged;
            datetime_NgayDatSan.Value = DateTime.Now.Date;

            cbo_TenSan.SelectedIndexChanged -= cbo_TenSan_SelectedIndexChanged;
        }
        DBConnection db = new DBConnection();
        private void AddDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSan");
            dt.Columns.Add("MaCaThue");
            dt.Columns.Add("ThanhTien");
            DataColumn[] key = new DataColumn[2];
            key[0] = dt.Columns["MaSan"];
            key[1] = dt.Columns["MaCaThue"];
            dt.PrimaryKey = key;
            dgv_SanDaDat.DataSource = dt;
        }
        private void HienThiLoaiSan()
        {

            cbo_LoaiSan.SelectedIndexChanged -= cbo_LoaiSan_SelectedIndexChanged;
            // loại bỏ sự kiên trên để cho combobox có thể load lên hết, sau đó thêm lại sự 
            dt_LoaiSan = db.GetDataTable("select * from LoaiSan");

            cbo_LoaiSan.DataSource = dt_LoaiSan;
            cbo_LoaiSan.DisplayMember = "TenLoai";
            cbo_LoaiSan.ValueMember = "MaLoai";
            cbo_LoaiSan.SelectedIndex = 0;

            // khởi tạo sự kiện lần đầu tiên
            HienThiTenSan(cbo_LoaiSan.SelectedValue.ToString());
            HienThiThanhTien(cbo_LoaiSan.SelectedIndex);
            HienThiCaThue(cbo_TenSan.SelectedValue.ToString().Trim(), datetime_NgayDatSan.Value.ToString("yyyy/MM/dd"));
            // thêm lại sự kiện
            cbo_LoaiSan.SelectedIndexChanged += cbo_LoaiSan_SelectedIndexChanged;
            datetime_NgayDatSan.ValueChanged += datetime_NgayDatSan_ValueChanged;
            cbo_TenSan.SelectedIndexChanged += cbo_TenSan_SelectedIndexChanged;

        }
        private void HienThiTenSan(string MaLoaiSan)
        {

            string query = "select * from San where MaLoai = '" + MaLoaiSan + "' and TinhTrang = N'Bình thường'";
            dt_TenSan = db.GetDataTable(query);

            cbo_TenSan.DataSource = dt_TenSan;
            cbo_TenSan.DisplayMember = "TenSan";
            cbo_TenSan.ValueMember = "MaSan";
        }
        private void HienThiThanhTien(int index)
        {
            DataRow dr = dt_LoaiSan.Rows[index];
            txtThanhTien.Text = dr["Gia"].ToString().Trim();
        }
        private void cbo_TenSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCaThue(cbo_TenSan.SelectedValue.ToString().Trim(), datetime_NgayDatSan.Value.ToString("yyyy/MM/dd"));
        }
        private void cbo_LoaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaLoaiSan = cbo_LoaiSan.SelectedValue.ToString();
            HienThiTenSan(MaLoaiSan);
            HienThiThanhTien(cbo_LoaiSan.SelectedIndex);
        }
        private void datetime_NgayDatSan_ValueChanged(object sender, EventArgs e)
        {
            string MaSan = cbo_TenSan.SelectedValue.ToString().Trim();
            string NgayDatSan = datetime_NgayDatSan.Value.ToString("yyyy/MM/dd");
            HienThiCaThue(MaSan, NgayDatSan);
        }
        private void HienThiCaThue(string MaSan, string NgayDatSan)
        {
            List<string> ds_CaDatTrongNgay = new List<string>();
            string query = "select * from HoaDonDatSan hd,  ChiTietHoaDonDatSan cthd " +
                            "where hd.MaDatSan = cthd.MaDatSan and " +
                            "NgayDatSan = '" + NgayDatSan + "' and cthd.MaSan = '" + MaSan + "'";
            DataTable dt_test = db.GetDataTable(query);
            foreach (DataRow dr in dt_test.Rows)
            {
                string TenCa = dr["MaCaThue"].ToString().Trim();
                ds_CaDatTrongNgay.Add(TenCa);
            }
            foreach (CheckBox caThue in listCheckBoxes)
            {
                string tenCa = caThue.Name;

                if (ds_CaDatTrongNgay.Contains(tenCa))
                {
                    caThue.Enabled = false;
                }
                else
                {
                    caThue.Enabled = true;
                }
            }
            ds_CaDatTrongNgay.Clear();
        }

        List<string> selected_CaThue = new List<string>();
        private void CTS001_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    // Nếu CheckBox được chọn, thêm Text vào danh sách
                    selected_CaThue.Add(checkBox.Name);
                }
                else
                {
                    // Nếu CheckBox bị bỏ chọn, xóa Text khỏi danh sách
                    selected_CaThue.Remove(checkBox.Name);
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (selected_CaThue.Count == 0)
            {
                MessageBox.Show("Hãy chọn ca thuê");
                return;
            }

            DataTable dt = dgv_SanDaDat.DataSource as DataTable;

            foreach (string CaThue in selected_CaThue)
            {
                DataRow dr = dt.NewRow();
                object[] primaryKey = new object[] { cbo_TenSan.SelectedValue.ToString().Trim(), CaThue };
                // Khóa chính 2 thuộc tính
                DataRow foundRow = dt.Rows.Find(primaryKey);
                if (foundRow != null)
                {
                    MessageBox.Show("Ca thuê " + CaThue + " đã được này trong danh sách, hãy kiểm tra lại");
                    return;
                }
                else
                {
                    dr["MaSan"] = cbo_TenSan.SelectedValue.ToString().Trim();
                    dr["MaCaThue"] = CaThue;
                    dr["ThanhTien"] = txtThanhTien.Text;
                    dt.Rows.Add(dr);
                }
            }

        }
        void TinhTongTien()
        {
            long ThanhTien = 0;

            int rows = dgv_SanDaDat.Rows.Count;

            for (int i = 0; i < rows - 1; i++)
            {
                string thanhTienStr = dgv_SanDaDat.Rows[i].Cells["ThanhTien"].Value.ToString();
                int GiaTrenDong = Convert.ToInt32(decimal.Parse(thanhTienStr));

                ThanhTien += GiaTrenDong;
            }
            lbl_ThanhTien.Text = ThanhTien.ToString("N0") + " VNĐ";
        }
        //G1
        //Hiển thị nhân viên 
        void HTNhanVien()
        {
            string str = "select *from NhanVien";
            DataTable dt = db.GetDataTable(str);
            dt.Columns.Add("TenVaMa", typeof(string), "TenNhanVien + ' - ' + MaNhanVien + ''");

            cbBox_NhanVien.DataSource = dt;
            cbBox_NhanVien.DisplayMember = "TenVaMa";

            cbBox_NhanVien.ValueMember = "MaNhanVien";
            cbBox_NhanVien.SelectedIndex = -1;
        }
        void HTKhacHang()
        {
            string str = "select *from KhachHang";
            DataTable dt = db.GetDataTable(str);
            dt.Columns.Add("TenVaMaKH", typeof(string), "TenKhachHang + ' - ' + MaKhachHang + ''");

            cbo_KhachHang.DataSource = dt;
            cbo_KhachHang.DisplayMember = "TenVaMaKH";

            cbo_KhachHang.ValueMember = "MaKhachHang";
            cbo_KhachHang.SelectedIndex = -1;
        }
        //button tạo hoá đơn - ngày tạo
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            string MaHoaDon = "HD";

            DateTime date = datetime_NgayDatSan.Value;
            MaHoaDon += date.ToString("ddMMyyyy");

            string query = "SELECT TOP 1 MaDatSan FROM HoaDonDatSan where MaDatSan like '" + MaHoaDon + "%' ORDER BY MaDatSan DESC";
            string maCuoi = (string)db.GetScalar(query);


            if (maCuoi == null)
            {
                MaHoaDon += "001";
            }
            else
            {
                string Lay3KyTuCuoi = maCuoi.Trim().Substring(10);
                long stt = long.Parse(Lay3KyTuCuoi) + 1;

                if (stt.ToString().Length == 1)
                    MaHoaDon += "00" + stt;
                else if (stt.ToString().Length == 2)
                    MaHoaDon += "0" + stt;
                else
                    MaHoaDon += stt;
            }

            txtMaDatSan.Text = MaHoaDon;
            TinhTongTien();
        }
        int Insert_HoaDon(string MaDatSan, string MaNhanVien, string MaKhachHang, string NgayDatSan, string TinhTrang)
        {
            string query = "INSERT INTO HoaDonDatSan " +
                         "VALUES ('" + MaDatSan + "', '" + MaNhanVien + "', '" + MaKhachHang + "', '" + NgayDatSan + "', N'" + TinhTrang + "')";
            return db.GetNonQuery(query);
        }
        int Insert_CTHoaDon(string MaDatSan, string MaSan, string MaCaThue, string ThanhTien)
        {
            string query = "insert into ChiTietHoaDonDatSan values('" + MaDatSan + "','" + MaSan + "','" + MaCaThue + "'," + ThanhTien + ")";
            return db.GetNonQuery(query);
        }
        //Lưu Hoá Đơn
        private void btnLuuHoaDon_Click_1(object sender, EventArgs e)
        {
            string maDatSan = txtMaDatSan.Text;
            string maNhanVien = cbBox_NhanVien.SelectedValue.ToString().Trim();
            string maKhachHang = cbo_KhachHang.SelectedValue.ToString().Trim();
            string ngayDatSan = datetime_NgayDatSan.Value.ToString("yyyy/MM/dd");
            string tinhTrang = ckThanhToan.Checked ? "Đã thanh toán" : "Chưa thanh toán";

            bool flag = true; //flag này để lưu nếu thêm chi tiết hóa đơn thành công

            int k = Insert_HoaDon(maDatSan, maNhanVien, maKhachHang, ngayDatSan, tinhTrang);
            if (k != 1)
            {
                MessageBox.Show("Thêm hóa đơn không thành công, xin hãy thử lại");
                return;
            }
            else
            {
                DataTable dt = dgv_SanDaDat.DataSource as DataTable;

                foreach (DataRow dr in dt.Rows)
                {
                    string MaSan = dr["MaSan"].ToString();
                    string CaThue = dr["MaCaThue"].ToString();
                    string ThanhTien = dr["ThanhTien"].ToString();

                    int r = Insert_CTHoaDon(maDatSan, MaSan, CaThue, ThanhTien);
                    if (r != 1)
                        flag = false;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Thêm thất bại!!!");
                return;
            }
            else
            {
                MessageBox.Show("Thêm Thành công!!");
                foreach (Control c in gr_ChiTieThoaDon.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;
                        if (cb.Checked)
                            cb.Checked = false;
                    }
                }
                txtMaDatSan.Text = "";
                cbo_KhachHang.SelectedItem = null;
                cbBox_NhanVien.SelectedItem = null;
                ckThanhToan.Checked = false;
                lbl_ThanhTien.Text = "Tổng hóa đơn: 0";
                HienThiLoaiSan();
                DataTable dt = dgv_SanDaDat.DataSource as DataTable;
                if (dt!=null)
                {
                    dt.Clear();
                    dgv_SanDaDat.DataSource = dt;
                }
            }
        }

        private void DatSan_Load(object sender, EventArgs e)
        {
            HTNhanVien();
            HTKhacHang();
            HienThiLoaiSan();
            AddDataGridView();
        }

        
    }
}
