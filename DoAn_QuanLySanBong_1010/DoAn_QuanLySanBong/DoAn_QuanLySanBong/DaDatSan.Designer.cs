namespace DoAn_QuanLySanBong
{
    partial class DaDatSan
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
            this.btn_XemTatCa = new System.Windows.Forms.Button();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.thoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.thoiGianTu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_SanDaDat = new System.Windows.Forms.ListBox();
            this.btn_HuyLich = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_XemTatCa
            // 
            this.btn_XemTatCa.Location = new System.Drawing.Point(714, 58);
            this.btn_XemTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XemTatCa.Name = "btn_XemTatCa";
            this.btn_XemTatCa.Size = new System.Drawing.Size(82, 25);
            this.btn_XemTatCa.TabIndex = 35;
            this.btn_XemTatCa.Text = "Xem tất cả";
            this.btn_XemTatCa.UseVisualStyleBackColor = true;
            this.btn_XemTatCa.Click += new System.EventHandler(this.btn_XemTatCa_Click);
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(609, 58);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(82, 25);
            this.btn_Xem.TabIndex = 34;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // thoiGianDen
            // 
            this.thoiGianDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.thoiGianDen.Location = new System.Drawing.Point(444, 63);
            this.thoiGianDen.Margin = new System.Windows.Forms.Padding(2);
            this.thoiGianDen.Name = "thoiGianDen";
            this.thoiGianDen.Size = new System.Drawing.Size(122, 20);
            this.thoiGianDen.TabIndex = 33;
            // 
            // thoiGianTu
            // 
            this.thoiGianTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.thoiGianTu.Location = new System.Drawing.Point(220, 63);
            this.thoiGianTu.Margin = new System.Windows.Forms.Padding(2);
            this.thoiGianTu.Name = "thoiGianTu";
            this.thoiGianTu.Size = new System.Drawing.Size(122, 20);
            this.thoiGianTu.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Từ";
            // 
            // lst_SanDaDat
            // 
            this.lst_SanDaDat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lst_SanDaDat.FormattingEnabled = true;
            this.lst_SanDaDat.ItemHeight = 25;
            this.lst_SanDaDat.Location = new System.Drawing.Point(12, 94);
            this.lst_SanDaDat.Name = "lst_SanDaDat";
            this.lst_SanDaDat.Size = new System.Drawing.Size(1479, 254);
            this.lst_SanDaDat.TabIndex = 29;
            // 
            // btn_HuyLich
            // 
            this.btn_HuyLich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_HuyLich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_HuyLich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_HuyLich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_HuyLich.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(51)))));
            this.btn_HuyLich.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_HuyLich.ForeColor = System.Drawing.Color.White;
            this.btn_HuyLich.Location = new System.Drawing.Point(756, 377);
            this.btn_HuyLich.Name = "btn_HuyLich";
            this.btn_HuyLich.Size = new System.Drawing.Size(120, 35);
            this.btn_HuyLich.TabIndex = 28;
            this.btn_HuyLich.Text = "Hủy lịch";
            this.btn_HuyLich.Click += new System.EventHandler(this.btn_HuyLich_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.DefaultAutoSize = true;
            this.btn_ThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(51)))));
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(948, 377);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(195, 35);
            this.btn_ThanhToan.TabIndex = 27;
            this.btn_ThanhToan.Text = "Thanh toán hoá đơn";
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.label9.Location = new System.Drawing.Point(15, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "Sân đã đặt";
            // 
            // DaDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 652);
            this.Controls.Add(this.btn_XemTatCa);
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.thoiGianDen);
            this.Controls.Add(this.thoiGianTu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_SanDaDat);
            this.Controls.Add(this.btn_HuyLich);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.label9);
            this.Name = "DaDatSan";
            this.Text = "Xem sân được đặt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhanSan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_XemTatCa;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.DateTimePicker thoiGianDen;
        private System.Windows.Forms.DateTimePicker thoiGianTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_SanDaDat;
        private Guna.UI2.WinForms.Guna2Button btn_HuyLich;
        private Guna.UI2.WinForms.Guna2Button btn_ThanhToan;
        private System.Windows.Forms.Label label9;


    }
}