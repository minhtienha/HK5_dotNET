namespace DoAn_QuanLySanBong
{
    partial class DatSan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gr_ChiTieThoaDon = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_TenSan = new System.Windows.Forms.Label();
            this.cbo_TenSan = new System.Windows.Forms.ComboBox();
            this.lbl_LoaiSan = new System.Windows.Forms.Label();
            this.cbo_LoaiSan = new System.Windows.Forms.ComboBox();
            this.datetime_NgayDatSan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.CTT002 = new System.Windows.Forms.CheckBox();
            this.CTT001 = new System.Windows.Forms.CheckBox();
            this.CTC002 = new System.Windows.Forms.CheckBox();
            this.CTC001 = new System.Windows.Forms.CheckBox();
            this.CTS002 = new System.Windows.Forms.CheckBox();
            this.CTS001 = new System.Windows.Forms.CheckBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_SanDaDat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.ckThanhToan = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.cbo_KhachHang = new System.Windows.Forms.ComboBox();
            this.cbBox_NhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDatSan = new System.Windows.Forms.TextBox();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.gr_ChiTieThoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanDaDat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr_ChiTieThoaDon
            // 
            this.gr_ChiTieThoaDon.Controls.Add(this.btn_Them);
            this.gr_ChiTieThoaDon.Controls.Add(this.lbl_TenSan);
            this.gr_ChiTieThoaDon.Controls.Add(this.cbo_TenSan);
            this.gr_ChiTieThoaDon.Controls.Add(this.lbl_LoaiSan);
            this.gr_ChiTieThoaDon.Controls.Add(this.cbo_LoaiSan);
            this.gr_ChiTieThoaDon.Controls.Add(this.datetime_NgayDatSan);
            this.gr_ChiTieThoaDon.Controls.Add(this.label5);
            this.gr_ChiTieThoaDon.Controls.Add(this.CTT002);
            this.gr_ChiTieThoaDon.Controls.Add(this.CTT001);
            this.gr_ChiTieThoaDon.Controls.Add(this.CTC002);
            this.gr_ChiTieThoaDon.Controls.Add(this.CTC001);
            this.gr_ChiTieThoaDon.Controls.Add(this.CTS002);
            this.gr_ChiTieThoaDon.Controls.Add(this.CTS001);
            this.gr_ChiTieThoaDon.Controls.Add(this.txtThanhTien);
            this.gr_ChiTieThoaDon.Controls.Add(this.label10);
            this.gr_ChiTieThoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gr_ChiTieThoaDon.Location = new System.Drawing.Point(35, 21);
            this.gr_ChiTieThoaDon.Name = "gr_ChiTieThoaDon";
            this.gr_ChiTieThoaDon.Size = new System.Drawing.Size(846, 198);
            this.gr_ChiTieThoaDon.TabIndex = 4;
            this.gr_ChiTieThoaDon.TabStop = false;
            this.gr_ChiTieThoaDon.Text = "Chi tiết hóa đơn";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(661, 84);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(122, 33);
            this.btn_Them.TabIndex = 35;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_TenSan
            // 
            this.lbl_TenSan.AutoSize = true;
            this.lbl_TenSan.Location = new System.Drawing.Point(355, 40);
            this.lbl_TenSan.Name = "lbl_TenSan";
            this.lbl_TenSan.Size = new System.Drawing.Size(66, 20);
            this.lbl_TenSan.TabIndex = 33;
            this.lbl_TenSan.Text = "Tên sân";
            // 
            // cbo_TenSan
            // 
            this.cbo_TenSan.FormattingEnabled = true;
            this.cbo_TenSan.Location = new System.Drawing.Point(462, 37);
            this.cbo_TenSan.Name = "cbo_TenSan";
            this.cbo_TenSan.Size = new System.Drawing.Size(339, 28);
            this.cbo_TenSan.TabIndex = 32;
            this.cbo_TenSan.SelectedIndexChanged += new System.EventHandler(this.cbo_TenSan_SelectedIndexChanged);
            // 
            // lbl_LoaiSan
            // 
            this.lbl_LoaiSan.AutoSize = true;
            this.lbl_LoaiSan.Location = new System.Drawing.Point(41, 40);
            this.lbl_LoaiSan.Name = "lbl_LoaiSan";
            this.lbl_LoaiSan.Size = new System.Drawing.Size(69, 20);
            this.lbl_LoaiSan.TabIndex = 33;
            this.lbl_LoaiSan.Text = "Loại sân";
            // 
            // cbo_LoaiSan
            // 
            this.cbo_LoaiSan.FormattingEnabled = true;
            this.cbo_LoaiSan.Location = new System.Drawing.Point(135, 37);
            this.cbo_LoaiSan.Name = "cbo_LoaiSan";
            this.cbo_LoaiSan.Size = new System.Drawing.Size(197, 28);
            this.cbo_LoaiSan.TabIndex = 32;
            this.cbo_LoaiSan.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiSan_SelectedIndexChanged);
            // 
            // datetime_NgayDatSan
            // 
            this.datetime_NgayDatSan.Checked = true;
            this.datetime_NgayDatSan.FillColor = System.Drawing.Color.White;
            this.datetime_NgayDatSan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_NgayDatSan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime_NgayDatSan.Location = new System.Drawing.Point(359, 84);
            this.datetime_NgayDatSan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_NgayDatSan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_NgayDatSan.Name = "datetime_NgayDatSan";
            this.datetime_NgayDatSan.Size = new System.Drawing.Size(262, 36);
            this.datetime_NgayDatSan.TabIndex = 25;
            this.datetime_NgayDatSan.Value = new System.DateTime(2024, 10, 5, 23, 0, 43, 896);
            this.datetime_NgayDatSan.ValueChanged += new System.EventHandler(this.datetime_NgayDatSan_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(47, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ca thuê:";
            // 
            // CTT002
            // 
            this.CTT002.AutoSize = true;
            this.CTT002.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTT002.Location = new System.Drawing.Point(676, 137);
            this.CTT002.Name = "CTT002";
            this.CTT002.Size = new System.Drawing.Size(107, 20);
            this.CTT002.TabIndex = 26;
            this.CTT002.Text = "21h00 - 22h30";
            this.CTT002.UseVisualStyleBackColor = true;
            this.CTT002.CheckedChanged += new System.EventHandler(this.CTS001_CheckedChanged);
            // 
            // CTT001
            // 
            this.CTT001.AutoSize = true;
            this.CTT001.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTT001.Location = new System.Drawing.Point(563, 137);
            this.CTT001.Name = "CTT001";
            this.CTT001.Size = new System.Drawing.Size(107, 20);
            this.CTT001.TabIndex = 27;
            this.CTT001.Text = "19h00 - 20h30";
            this.CTT001.UseVisualStyleBackColor = true;
            this.CTT001.CheckedChanged += new System.EventHandler(this.CTS001_CheckedChanged);
            // 
            // CTC002
            // 
            this.CTC002.AutoSize = true;
            this.CTC002.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTC002.Location = new System.Drawing.Point(454, 137);
            this.CTC002.Name = "CTC002";
            this.CTC002.Size = new System.Drawing.Size(107, 20);
            this.CTC002.TabIndex = 28;
            this.CTC002.Text = "16h00 - 18h30";
            this.CTC002.UseVisualStyleBackColor = true;
            this.CTC002.CheckedChanged += new System.EventHandler(this.CTS001_CheckedChanged);
            // 
            // CTC001
            // 
            this.CTC001.AutoSize = true;
            this.CTC001.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTC001.Location = new System.Drawing.Point(344, 137);
            this.CTC001.Name = "CTC001";
            this.CTC001.Size = new System.Drawing.Size(107, 20);
            this.CTC001.TabIndex = 29;
            this.CTC001.Text = "14h00 - 15h30";
            this.CTC001.UseVisualStyleBackColor = true;
            this.CTC001.CheckedChanged += new System.EventHandler(this.CTS001_CheckedChanged);
            // 
            // CTS002
            // 
            this.CTS002.AutoSize = true;
            this.CTS002.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTS002.Location = new System.Drawing.Point(233, 137);
            this.CTS002.Name = "CTS002";
            this.CTS002.Size = new System.Drawing.Size(104, 20);
            this.CTS002.TabIndex = 30;
            this.CTS002.Text = "10h00 -11h30";
            this.CTS002.UseVisualStyleBackColor = true;
            this.CTS002.CheckedChanged += new System.EventHandler(this.CTS001_CheckedChanged);
            // 
            // CTS001
            // 
            this.CTS001.AutoSize = true;
            this.CTS001.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTS001.Location = new System.Drawing.Point(134, 137);
            this.CTS001.Name = "CTS001";
            this.CTS001.Size = new System.Drawing.Size(93, 20);
            this.CTS001.TabIndex = 31;
            this.CTS001.Text = "8h00 - 9h30";
            this.CTS001.UseVisualStyleBackColor = true;
            this.CTS001.CheckedChanged += new System.EventHandler(this.CTS001_CheckedChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(135, 84);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(197, 26);
            this.txtThanhTien.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Thành tiền";
            // 
            // dgv_SanDaDat
            // 
            this.dgv_SanDaDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanDaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanDaDat.Location = new System.Drawing.Point(35, 245);
            this.dgv_SanDaDat.Name = "dgv_SanDaDat";
            this.dgv_SanDaDat.Size = new System.Drawing.Size(365, 283);
            this.dgv_SanDaDat.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ThanhTien);
            this.groupBox1.Controls.Add(this.ckThanhToan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnTaoHoaDon);
            this.groupBox1.Controls.Add(this.cbo_KhachHang);
            this.groupBox1.Controls.Add(this.cbBox_NhanVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaDatSan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(429, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hoá đơn đặt sân";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Location = new System.Drawing.Point(231, 162);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(124, 20);
            this.lbl_ThanhTien.TabIndex = 12;
            this.lbl_ThanhTien.Text = "Tổng hóa đơn: 0";
            // 
            // ckThanhToan
            // 
            this.ckThanhToan.AutoSize = true;
            this.ckThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ckThanhToan.Location = new System.Drawing.Point(37, 161);
            this.ckThanhToan.Name = "ckThanhToan";
            this.ckThanhToan.Size = new System.Drawing.Size(130, 24);
            this.ckThanhToan.TabIndex = 9;
            this.ckThanhToan.Text = "Đã thanh toán";
            this.ckThanhToan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhân viên";
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Location = new System.Drawing.Point(169, 200);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(122, 36);
            this.btnTaoHoaDon.TabIndex = 11;
            this.btnTaoHoaDon.Text = "Tạo hoá đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // cbo_KhachHang
            // 
            this.cbo_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbo_KhachHang.FormattingEnabled = true;
            this.cbo_KhachHang.Location = new System.Drawing.Point(137, 72);
            this.cbo_KhachHang.Name = "cbo_KhachHang";
            this.cbo_KhachHang.Size = new System.Drawing.Size(285, 28);
            this.cbo_KhachHang.TabIndex = 4;
            // 
            // cbBox_NhanVien
            // 
            this.cbBox_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbBox_NhanVien.FormattingEnabled = true;
            this.cbBox_NhanVien.Location = new System.Drawing.Point(136, 109);
            this.cbBox_NhanVien.Name = "cbBox_NhanVien";
            this.cbBox_NhanVien.Size = new System.Drawing.Size(286, 28);
            this.cbBox_NhanVien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đặt sân";
            // 
            // txtMaDatSan
            // 
            this.txtMaDatSan.Location = new System.Drawing.Point(137, 32);
            this.txtMaDatSan.Multiline = true;
            this.txtMaDatSan.Name = "txtMaDatSan";
            this.txtMaDatSan.Size = new System.Drawing.Size(285, 26);
            this.txtMaDatSan.TabIndex = 0;
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHoaDon.Location = new System.Drawing.Point(711, 544);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(170, 36);
            this.btnLuuHoaDon.TabIndex = 12;
            this.btnLuuHoaDon.Text = "Lưu hoá đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click_1);
            // 
            // DatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(932, 605);
            this.Controls.Add(this.btnLuuHoaDon);
            this.Controls.Add(this.gr_ChiTieThoaDon);
            this.Controls.Add(this.dgv_SanDaDat);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatSan";
            this.Text = "DatSan";
            this.Load += new System.EventHandler(this.DatSan_Load);
            this.gr_ChiTieThoaDon.ResumeLayout(false);
            this.gr_ChiTieThoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanDaDat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_ChiTieThoaDon;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBox_NhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDatSan;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Label lbl_TenSan;
        private System.Windows.Forms.ComboBox cbo_TenSan;
        private System.Windows.Forms.Label lbl_LoaiSan;
        private System.Windows.Forms.ComboBox cbo_LoaiSan;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_NgayDatSan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CTT002;
        private System.Windows.Forms.CheckBox CTT001;
        private System.Windows.Forms.CheckBox CTC002;
        private System.Windows.Forms.CheckBox CTC001;
        private System.Windows.Forms.CheckBox CTS002;
        private System.Windows.Forms.CheckBox CTS001;
        private System.Windows.Forms.DataGridView dgv_SanDaDat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cbo_KhachHang;
        private System.Windows.Forms.Label lbl_ThanhTien;

    }
}