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
    public partial class QuanLySan : Form
    {
        private DataTable dsLoaiSan;
        private DataTable dsSan;
        DBConnection db = new DBConnection();
        public QuanLySan()
        {
            InitializeComponent();
            // Đăng ký sự kiện cho TreeView
            treeViewDs_San.NodeMouseClick += treeViewDs_San_NodeMouseClick;
            dsLoaiSan = db.GetDataTable("select * from LoaiSan");
            dsSan = db.GetDataTable("select * from San");
        }
        //
        private void HienThiDSLoaiSan()
        {
            cbo_LoaiSan.DataSource = dsLoaiSan;
            cbo_LoaiSan.DisplayMember = "TenLoai";
            cbo_LoaiSan.ValueMember = "MaLoai";
            cbo_LoaiSan.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private void HienThiSan()
        {
            treeViewDs_San.Nodes.Clear();

            foreach (DataRow loaiSanRow in dsLoaiSan.Rows)
            {
                TreeNode node = new TreeNode(loaiSanRow["TenLoai"].ToString())
                {
                    Tag = loaiSanRow["MaLoai"].ToString()
                };

                foreach (DataRow sanRow in dsSan.Select("MaLoai = '" + loaiSanRow["MaLoai"].ToString() + "'"))
                {
                    TreeNode childNode = new TreeNode(sanRow["TenSan"].ToString());
                    node.Nodes.Add(childNode);
                }

                treeViewDs_San.Nodes.Add(node);
            }

            treeViewDs_San.ExpandAll();
        }
        private void QuanLySan_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiSan();
            if (cbo_LoaiSan.Items.Count > 0)
            {
                cbo_LoaiSan.SelectedIndex = 0; // Chọn loại sân đầu tiên
            }
            HienThiSan();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maSan = txtMaSan.Text;
            string tenSan = txtTenSan.Text;
            string maLoai = cbo_LoaiSan.SelectedValue.ToString(); // Lấy mã loại từ ComboBox
            string tinhTrang = cb_TinhTrangSan.SelectedItem.ToString();
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(maSan) || string.IsNullOrEmpty(tenSan) || string.IsNullOrEmpty(maLoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sân.");
                return;
            }

            // Tạo DataRow mới để thêm vào DataTable
            DataRow newRow = dsSan.NewRow();
            newRow["MaSan"] = maSan;
            newRow["TenSan"] = tenSan;
            newRow["MaLoai"] = maLoai;
            newRow["TinhTrang"] = tinhTrang;

            dsSan.Rows.Add(newRow);

            string query = "SELECT * FROM San";
            int rowsAffected = db.UpdateTable(dsSan, query); // Cập nhật lại cơ sở dữ liệu

            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm sân thành công.");
                HienThiSan(); // Load lại treeview
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Không thể thêm sân.");
            }
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có node nào được chọn không
            if (treeViewDs_San.SelectedNode != null && treeViewDs_San.SelectedNode.Parent != null)
            {
                string maSan = txtMaSan.Text;
                string tenSan = txtTenSan.Text;
                string maLoai = txtMaLoai.Text;
                string tinhTrang = cb_TinhTrangSan.SelectedItem.ToString();


                if (string.IsNullOrEmpty(maSan) || string.IsNullOrEmpty(tenSan) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng chọn sân và điền đầy đủ thông tin để sửa.");
                    return;
                }

                // Tìm hàng cần sửa trong DataTable
                DataRow rowToUpdate = dsSan.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("MaSan") == maSan);

                if (rowToUpdate != null)
                {
                    // Cập nhật thông tin trong DataTable
                    rowToUpdate["TenSan"] = tenSan;
                    rowToUpdate["MaLoai"] = maLoai;
                    rowToUpdate["TinhTrang"] = tinhTrang;


                    string query = "SELECT * FROM San";
                    int rowsAffected = db.UpdateTable(dsSan, query); // Cập nhật lại table dưới Sql

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin sân thành công.");
                        HienThiSan();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sân để sửa.");
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSan = txtMaSan.Text;

            if (string.IsNullOrEmpty(maSan))
            {
                MessageBox.Show("Vui lòng chọn sân để xóa.");
                return;
            }

            // Xác nhận việc xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sân này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Tìm hàng cần xóa trong DataTable
                DataRow rowToDelete = dsSan.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("MaSan") == maSan);

                if (rowToDelete != null)
                {
                    // Xóa hàng từ DataTable
                    rowToDelete.Delete();


                    string query = "SELECT * FROM San";
                    int rowsAffected = db.UpdateTable(dsSan, query);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã xóa sân thành công.");
                        HienThiSan();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sân.");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sân để xóa.");
                }
            }
        }
        private void treeViewDs_San_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Parent != null) // Kiểm tra nếu là node con
            {
                string tenSan = selectedNode.Text;
                // Tìm thông tin sân từ dsSan dựa vào TenSan được chọn
                SqlConnection Conn = DBConnection.getConnection();
                Conn.Open();
                string query = "SELECT * FROM San WHERE TenSan = @TenSan";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@TenSan", tenSan);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Gán giá trị vào các TextBox
                    txtMaSan.Text = reader["MaSan"].ToString();
                    txtTenSan.Text = reader["TenSan"].ToString();
                    txtMaLoai.Text = reader["MaLoai"].ToString();
                    if (cbo_LoaiSan.Items.Count > 0)
                    {
                        cbo_LoaiSan.SelectedValue = txtMaLoai.Text; // Gán giá trị MaLoai cho ComboBox
                    }
                    cb_TinhTrangSan.SelectedItem = reader["TinhTrang"].ToString();

                }
                Conn.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_LoaiSan.SelectedItem != null)
            {
                DataRowView selectedRow = cbo_LoaiSan.SelectedItem as DataRowView;

                if (selectedRow != null)
                {
                    txtMaLoai.Text = selectedRow["MaLoai"].ToString();
                    // Có thể thêm hành động khác để cập nhật TreeView hoặc các xử lý khác
                }
            }
            //////---------------- VỪA THÊM MỚI -------------------
            //Xóa tên mỗi khi cần thêm mới
            txtTenSan.Clear();
            //tạo mã tự động cho mã sân mỗi khi chọn loại sân mới
            string maCuoi = "SELECT TOP 1 MaSan FROM San ORDER BY MaSan DESC";
            DataTable dt = db.GetDataTable(maCuoi);

            string maMoi = "S001";

            if (dt.Rows.Count > 0)
            {
                string maCu = dt.Rows[0]["MaSan"].ToString();
                long soCuoi = long.Parse(maCu.Substring(1));
                maMoi = "S" + (soCuoi + 1).ToString("D3");
            }
            txtMaSan.Text = maMoi;
        }
        private void ClearInputFields()
        {
            txtMaSan.Clear();
            txtTenSan.Clear();
            txtMaLoai.Clear();
            cbo_LoaiSan.SelectedIndex = -1;

            txt_LoaiSan.Clear();
            txt_TenLoai.Clear();
            txt_Gia.Clear();
        }

        private void btn_TaoMaLoaiSan_Click(object sender, EventArgs e)
        {
            string maCuoi = "SELECT TOP 1 MaLoai FROM LoaiSan ORDER BY MaLoai DESC";
            DataTable dt = db.GetDataTable(maCuoi);

            string maMoi = "LS001";

            if (dt.Rows.Count > 0)
            {
                string maCu = dt.Rows[0]["MaLoai"].ToString();
                long soCuoi = long.Parse(maCu.Substring(2));
                maMoi = "LS" + (soCuoi + 1).ToString("D3");
            }
            txt_LoaiSan.Text = maMoi;
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e)
        {
            string maLoai = txt_LoaiSan.Text;
            string tenLoai = txt_TenLoai.Text;
            string gia = txt_Gia.Text;
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(maLoai) || string.IsNullOrEmpty(tenLoai) || string.IsNullOrEmpty(gia))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin loại sân.");
                return;
            }

            // Tạo DataRow mới để thêm vào DataTable
            DataRow newRow = dsLoaiSan.NewRow();
            newRow["MaLoai"] = maLoai;
            newRow["TenLoai"] = tenLoai;
            newRow["Gia"] = gia;

            dsLoaiSan.Rows.Add(newRow);

            string query = "SELECT * FROM LoaiSan";
            int rowsAffected = db.UpdateTable(dsLoaiSan, query); // Cập nhật lại cơ sở dữ liệu

            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm loại sân thành công.");
                HienThiSan(); // Load lại treeview
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Không thể thêm loại sân.");
            }
        }
    }
}
