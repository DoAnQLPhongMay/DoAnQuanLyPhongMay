namespace QuanLyPhongMay
{
    partial class frmQLNhapMay
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
            this.lblNhapMay = new System.Windows.Forms.Label();
            this.grpChiTietNhapMay = new System.Windows.Forms.GroupBox();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbl_GhiChu = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtNamSX = new System.Windows.Forms.TextBox();
            this.lblNamSX = new System.Windows.Forms.Label();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.lblNSX = new System.Windows.Forms.Label();
            this.txtMaThietBi = new System.Windows.Forms.TextBox();
            this.lblMaThietBi = new System.Windows.Forms.Label();
            this.dtmNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayNhap = new System.Windows.Forms.Label();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.lblMaNhap = new System.Windows.Forms.Label();
            this.dgvDSNhap = new System.Windows.Forms.DataGridView();
            this.MaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChiTietNhapMay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNhapMay
            // 
            this.lblNhapMay.AutoSize = true;
            this.lblNhapMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMay.Location = new System.Drawing.Point(12, 9);
            this.lblNhapMay.Name = "lblNhapMay";
            this.lblNhapMay.Size = new System.Drawing.Size(266, 61);
            this.lblNhapMay.TabIndex = 0;
            this.lblNhapMay.Text = "Nhập Máy";
            // 
            // grpChiTietNhapMay
            // 
            this.grpChiTietNhapMay.Controls.Add(this.rtbGhiChu);
            this.grpChiTietNhapMay.Controls.Add(this.btnXoa);
            this.grpChiTietNhapMay.Controls.Add(this.btnCapNhat);
            this.grpChiTietNhapMay.Controls.Add(this.btnThem);
            this.grpChiTietNhapMay.Controls.Add(this.lbl_GhiChu);
            this.grpChiTietNhapMay.Controls.Add(this.txtDonGia);
            this.grpChiTietNhapMay.Controls.Add(this.lblDonGia);
            this.grpChiTietNhapMay.Controls.Add(this.txtSoLuong);
            this.grpChiTietNhapMay.Controls.Add(this.lblSoLuong);
            this.grpChiTietNhapMay.Controls.Add(this.txtNamSX);
            this.grpChiTietNhapMay.Controls.Add(this.lblNamSX);
            this.grpChiTietNhapMay.Controls.Add(this.txtNSX);
            this.grpChiTietNhapMay.Controls.Add(this.lblNSX);
            this.grpChiTietNhapMay.Controls.Add(this.txtMaThietBi);
            this.grpChiTietNhapMay.Controls.Add(this.lblMaThietBi);
            this.grpChiTietNhapMay.Controls.Add(this.dtmNgayNhap);
            this.grpChiTietNhapMay.Controls.Add(this.lbl_NgayNhap);
            this.grpChiTietNhapMay.Controls.Add(this.txtMaNhap);
            this.grpChiTietNhapMay.Controls.Add(this.lblMaNhap);
            this.grpChiTietNhapMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChiTietNhapMay.Location = new System.Drawing.Point(13, 91);
            this.grpChiTietNhapMay.Name = "grpChiTietNhapMay";
            this.grpChiTietNhapMay.Size = new System.Drawing.Size(843, 183);
            this.grpChiTietNhapMay.TabIndex = 1;
            this.grpChiTietNhapMay.TabStop = false;
            this.grpChiTietNhapMay.Text = "Chi Tiết Nhập Máy";
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(532, 80);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(98, 73);
            this.rtbGhiChu.TabIndex = 21;
            this.rtbGhiChu.Text = "";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(710, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 40);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Location = new System.Drawing.Point(710, 83);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 40);
            this.btnCapNhat.TabIndex = 19;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(710, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 40);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // lbl_GhiChu
            // 
            this.lbl_GhiChu.AutoSize = true;
            this.lbl_GhiChu.Location = new System.Drawing.Point(459, 83);
            this.lbl_GhiChu.Name = "lbl_GhiChu";
            this.lbl_GhiChu.Size = new System.Drawing.Size(60, 13);
            this.lbl_GhiChu.TabIndex = 16;
            this.lbl_GhiChu.Text = "Ghi Chú: ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(96, 133);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 13;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(10, 136);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(61, 13);
            this.lblDonGia.TabIndex = 12;
            this.lblDonGia.Text = "Đơn Giá: ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(323, 133);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 11;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(235, 136);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(69, 13);
            this.lblSoLuong.TabIndex = 10;
            this.lblSoLuong.Text = "Số Lượng: ";
            // 
            // txtNamSX
            // 
            this.txtNamSX.Location = new System.Drawing.Point(323, 80);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(100, 20);
            this.txtNamSX.TabIndex = 9;
            // 
            // lblNamSX
            // 
            this.lblNamSX.AutoSize = true;
            this.lblNamSX.Location = new System.Drawing.Point(235, 83);
            this.lblNamSX.Name = "lblNamSX";
            this.lblNamSX.Size = new System.Drawing.Size(96, 13);
            this.lblNamSX.TabIndex = 8;
            this.lblNamSX.Text = "Năm Sản Xuất: ";
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(96, 80);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(100, 20);
            this.txtNSX.TabIndex = 7;
            // 
            // lblNSX
            // 
            this.lblNSX.AutoSize = true;
            this.lblNSX.Location = new System.Drawing.Point(10, 83);
            this.lblNSX.Name = "lblNSX";
            this.lblNSX.Size = new System.Drawing.Size(94, 13);
            this.lblNSX.TabIndex = 6;
            this.lblNSX.Text = "Nhà Sản Xuất: ";
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Location = new System.Drawing.Point(323, 34);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Size = new System.Drawing.Size(100, 20);
            this.txtMaThietBi.TabIndex = 5;
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(235, 37);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(80, 13);
            this.lblMaThietBi.TabIndex = 4;
            this.lblMaThietBi.Text = "Mã Thiết Bị: ";
            // 
            // dtmNgayNhap
            // 
            this.dtmNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgayNhap.Location = new System.Drawing.Point(532, 34);
            this.dtmNgayNhap.Name = "dtmNgayNhap";
            this.dtmNgayNhap.Size = new System.Drawing.Size(98, 20);
            this.dtmNgayNhap.TabIndex = 3;
            // 
            // lbl_NgayNhap
            // 
            this.lbl_NgayNhap.AutoSize = true;
            this.lbl_NgayNhap.Location = new System.Drawing.Point(459, 37);
            this.lbl_NgayNhap.Name = "lbl_NgayNhap";
            this.lbl_NgayNhap.Size = new System.Drawing.Size(78, 13);
            this.lbl_NgayNhap.TabIndex = 2;
            this.lbl_NgayNhap.Text = "Ngày Nhập: ";
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Location = new System.Drawing.Point(96, 31);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.Size = new System.Drawing.Size(100, 20);
            this.txtMaNhap.TabIndex = 1;
            // 
            // lblMaNhap
            // 
            this.lblMaNhap.AutoSize = true;
            this.lblMaNhap.Location = new System.Drawing.Point(10, 34);
            this.lblMaNhap.Name = "lblMaNhap";
            this.lblMaNhap.Size = new System.Drawing.Size(66, 13);
            this.lblMaNhap.TabIndex = 0;
            this.lblMaNhap.Text = "Mã Nhập: ";
            // 
            // dgvDSNhap
            // 
            this.dgvDSNhap.AllowUserToAddRows = false;
            this.dgvDSNhap.AllowUserToDeleteRows = false;
            this.dgvDSNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhap,
            this.MaThietBi,
            this.NgayNhap,
            this.NhaSanXuat,
            this.NamSanXuat,
            this.DonGia,
            this.TrangThai,
            this.GhiChu});
            this.dgvDSNhap.Location = new System.Drawing.Point(1, 281);
            this.dgvDSNhap.Name = "dgvDSNhap";
            this.dgvDSNhap.ReadOnly = true;
            this.dgvDSNhap.Size = new System.Drawing.Size(855, 227);
            this.dgvDSNhap.TabIndex = 2;
            // 
            // MaNhap
            // 
            this.MaNhap.HeaderText = "Mã Nhập";
            this.MaNhap.Name = "MaNhap";
            this.MaNhap.ReadOnly = true;
            // 
            // MaThietBi
            // 
            this.MaThietBi.HeaderText = "Mã Thiết Bị";
            this.MaThietBi.Name = "MaThietBi";
            this.MaThietBi.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // NhaSanXuat
            // 
            this.NhaSanXuat.HeaderText = "Nhà Sản Xuất";
            this.NhaSanXuat.Name = "NhaSanXuat";
            this.NhaSanXuat.ReadOnly = true;
            // 
            // NamSanXuat
            // 
            this.NamSanXuat.HeaderText = "Năm Sản Xuất";
            this.NamSanXuat.Name = "NamSanXuat";
            this.NamSanXuat.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "ĐơnGiá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // frmQLNhapMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 510);
            this.Controls.Add(this.dgvDSNhap);
            this.Controls.Add(this.grpChiTietNhapMay);
            this.Controls.Add(this.lblNhapMay);
            this.Name = "frmQLNhapMay";
            this.Text = "Quản Lý Nhập Máy";
            this.Load += new System.EventHandler(this.frm_QLNhapMay_Load);
            this.grpChiTietNhapMay.ResumeLayout(false);
            this.grpChiTietNhapMay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapMay;
        private System.Windows.Forms.GroupBox grpChiTietNhapMay;
        private System.Windows.Forms.Label lbl_NgayNhap;
        private System.Windows.Forms.TextBox txtMaNhap;
        private System.Windows.Forms.Label lblMaNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbl_GhiChu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtNamSX;
        private System.Windows.Forms.Label lblNamSX;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.Label lblNSX;
        private System.Windows.Forms.TextBox txtMaThietBi;
        private System.Windows.Forms.Label lblMaThietBi;
        private System.Windows.Forms.DateTimePicker dtmNgayNhap;
        private System.Windows.Forms.DataGridView dgvDSNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
    }
}