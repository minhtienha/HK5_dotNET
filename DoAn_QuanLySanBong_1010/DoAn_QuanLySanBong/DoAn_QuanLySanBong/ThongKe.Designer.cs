namespace DoAn_QuanLySanBong
{
    partial class ThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDatSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DoanhThu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SoDonDat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gr_ThongKe = new System.Windows.Forms.GroupBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.thoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.thoiGianTu = new System.Windows.Forms.DateTimePicker();
            this.cbBox_San = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.gr_ThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKhachHang,
            this.MaSan,
            this.NgayDatSan,
            this.MaCaThue,
            this.ThanhTien});
            this.dgvThongKe.Location = new System.Drawing.Point(11, 178);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(890, 312);
            this.dgvThongKe.TabIndex = 10;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.Name = "MaHD";
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Tên KH";
            this.MaKhachHang.Name = "MaKhachHang";
            // 
            // MaSan
            // 
            this.MaSan.HeaderText = "Mã Sân";
            this.MaSan.Name = "MaSan";
            // 
            // NgayDatSan
            // 
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.NgayDatSan.DefaultCellStyle = dataGridViewCellStyle5;
            this.NgayDatSan.HeaderText = "Ngày Đặt";
            this.NgayDatSan.Name = "NgayDatSan";
            // 
            // MaCaThue
            // 
            this.MaCaThue.HeaderText = "Ca Thuê";
            this.MaCaThue.Name = "MaCaThue";
            // 
            // ThanhTien
            // 
            dataGridViewCellStyle6.Format = "N0";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(762, 497);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doanh thu:";
            // 
            // txt_DoanhThu
            // 
            this.txt_DoanhThu.AutoSize = true;
            this.txt_DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DoanhThu.ForeColor = System.Drawing.Color.Blue;
            this.txt_DoanhThu.Location = new System.Drawing.Point(866, 497);
            this.txt_DoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_DoanhThu.Name = "txt_DoanhThu";
            this.txt_DoanhThu.Size = new System.Drawing.Size(20, 22);
            this.txt_DoanhThu.TabIndex = 12;
            this.txt_DoanhThu.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(474, 497);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số đơn đặt:";
            // 
            // txt_SoDonDat
            // 
            this.txt_SoDonDat.AutoSize = true;
            this.txt_SoDonDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDonDat.ForeColor = System.Drawing.Color.Blue;
            this.txt_SoDonDat.Location = new System.Drawing.Point(578, 497);
            this.txt_SoDonDat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_SoDonDat.Name = "txt_SoDonDat";
            this.txt_SoDonDat.Size = new System.Drawing.Size(20, 22);
            this.txt_SoDonDat.TabIndex = 17;
            this.txt_SoDonDat.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.label9.Location = new System.Drawing.Point(266, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 37);
            this.label9.TabIndex = 23;
            this.label9.Text = "Thống Kê Doanh Thu";
            // 
            // gr_ThongKe
            // 
            this.gr_ThongKe.Controls.Add(this.btn_Report);
            this.gr_ThongKe.Controls.Add(this.thoiGianDen);
            this.gr_ThongKe.Controls.Add(this.thoiGianTu);
            this.gr_ThongKe.Controls.Add(this.cbBox_San);
            this.gr_ThongKe.Controls.Add(this.label3);
            this.gr_ThongKe.Controls.Add(this.label4);
            this.gr_ThongKe.Controls.Add(this.label2);
            this.gr_ThongKe.Controls.Add(this.btnThongKe);
            this.gr_ThongKe.Location = new System.Drawing.Point(115, 48);
            this.gr_ThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.gr_ThongKe.Name = "gr_ThongKe";
            this.gr_ThongKe.Padding = new System.Windows.Forms.Padding(2);
            this.gr_ThongKe.Size = new System.Drawing.Size(600, 115);
            this.gr_ThongKe.TabIndex = 24;
            this.gr_ThongKe.TabStop = false;
            this.gr_ThongKe.Text = "Thông tin thống kê";
            // 
            // btn_Report
            // 
            this.btn_Report.AutoSize = true;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.ForeColor = System.Drawing.Color.Black;
            this.btn_Report.Location = new System.Drawing.Point(472, 71);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(95, 27);
            this.btn_Report.TabIndex = 17;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // thoiGianDen
            // 
            this.thoiGianDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.thoiGianDen.Location = new System.Drawing.Point(113, 75);
            this.thoiGianDen.Margin = new System.Windows.Forms.Padding(2);
            this.thoiGianDen.Name = "thoiGianDen";
            this.thoiGianDen.Size = new System.Drawing.Size(122, 20);
            this.thoiGianDen.TabIndex = 16;
            // 
            // thoiGianTu
            // 
            this.thoiGianTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.thoiGianTu.Location = new System.Drawing.Point(113, 32);
            this.thoiGianTu.Margin = new System.Windows.Forms.Padding(2);
            this.thoiGianTu.Name = "thoiGianTu";
            this.thoiGianTu.Size = new System.Drawing.Size(122, 20);
            this.thoiGianTu.TabIndex = 15;
            // 
            // cbBox_San
            // 
            this.cbBox_San.FormattingEnabled = true;
            this.cbBox_San.Location = new System.Drawing.Point(350, 32);
            this.cbBox_San.Margin = new System.Windows.Forms.Padding(2);
            this.cbBox_San.Name = "cbBox_San";
            this.cbBox_San.Size = new System.Drawing.Size(122, 21);
            this.cbBox_San.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSize = true;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(350, 71);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(95, 27);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(11, 178);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1233, 592);
            this.crystalReportViewer1.TabIndex = 25;
            this.crystalReportViewer1.Visible = false;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 799);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.gr_ThongKe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_SoDonDat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_DoanhThu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvThongKe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.gr_ThongKe.ResumeLayout(false);
            this.gr_ThongKe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_DoanhThu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txt_SoDonDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDatSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gr_ThongKe;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.DateTimePicker thoiGianDen;
        private System.Windows.Forms.DateTimePicker thoiGianTu;
        private System.Windows.Forms.ComboBox cbBox_San;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}