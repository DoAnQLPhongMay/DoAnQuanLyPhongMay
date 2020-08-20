namespace QuanLyPhongMay
{
    partial class frmQLPhongMay
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
            this.lblQLPhongMay = new System.Windows.Forms.Label();
            this.grpQLPhongMay = new System.Windows.Forms.GroupBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.radTenKhoa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radTrangThai = new System.Windows.Forms.RadioButton();
            this.radTenPhong = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txtSoLuongMay = new System.Windows.Forms.TextBox();
            this.lblSoLuongMay = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.dgvDSPhong = new System.Windows.Forms.DataGridView();
            this.MaPhongMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpQLPhongMay.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLPhongMay
            // 
            this.lblQLPhongMay.AutoSize = true;
            this.lblQLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPhongMay.Location = new System.Drawing.Point(12, 9);
            this.lblQLPhongMay.Name = "lblQLPhongMay";
            this.lblQLPhongMay.Size = new System.Drawing.Size(504, 61);
            this.lblQLPhongMay.TabIndex = 0;
            this.lblQLPhongMay.Text = "Quản Lý Phòng Máy";
            this.lblQLPhongMay.Click += new System.EventHandler(this.lblQLPhongMay_Click);
            // 
            // grpQLPhongMay
            // 
            this.grpQLPhongMay.Controls.Add(this.cboKhoa);
            this.grpQLPhongMay.Controls.Add(this.label1);
            this.grpQLPhongMay.Controls.Add(this.btnChiTiet);
            this.grpQLPhongMay.Controls.Add(this.btnLamMoi);
            this.grpQLPhongMay.Controls.Add(this.grpTimKiem);
            this.grpQLPhongMay.Controls.Add(this.rtbGhiChu);
            this.grpQLPhongMay.Controls.Add(this.cboTrangThai);
            this.grpQLPhongMay.Controls.Add(this.lblGhiChu);
            this.grpQLPhongMay.Controls.Add(this.lblTrangThai);
            this.grpQLPhongMay.Controls.Add(this.txtTenPhong);
            this.grpQLPhongMay.Controls.Add(this.btnCapNhap);
            this.grpQLPhongMay.Controls.Add(this.btnXoa);
            this.grpQLPhongMay.Controls.Add(this.btnThemMoi);
            this.grpQLPhongMay.Controls.Add(this.txtSoLuongMay);
            this.grpQLPhongMay.Controls.Add(this.lblSoLuongMay);
            this.grpQLPhongMay.Controls.Add(this.lblTenPhong);
            this.grpQLPhongMay.Controls.Add(this.txtMaPhong);
            this.grpQLPhongMay.Controls.Add(this.lblMaPhong);
            this.grpQLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQLPhongMay.Location = new System.Drawing.Point(12, 73);
            this.grpQLPhongMay.Name = "grpQLPhongMay";
            this.grpQLPhongMay.Size = new System.Drawing.Size(533, 331);
            this.grpQLPhongMay.TabIndex = 1;
            this.grpQLPhongMay.TabStop = false;
            this.grpQLPhongMay.Text = "Quán Lý Phòng Máy";
            this.grpQLPhongMay.Enter += new System.EventHandler(this.grp_QLPhongMay_Enter);
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(103, 110);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(201, 21);
            this.cboKhoa.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Khoa:";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.Location = new System.Drawing.Point(413, 32);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(100, 38);
            this.btnChiTiet.TabIndex = 27;
            this.btnChiTiet.Text = "Chi Tiết Phòng";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(413, 76);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 38);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.radTenKhoa);
            this.grpTimKiem.Controls.Add(this.label2);
            this.grpTimKiem.Controls.Add(this.radTrangThai);
            this.grpTimKiem.Controls.Add(this.radTenPhong);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(6, 242);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(517, 83);
            this.grpTimKiem.TabIndex = 25;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // radTenKhoa
            // 
            this.radTenKhoa.AutoSize = true;
            this.radTenKhoa.Location = new System.Drawing.Point(224, 56);
            this.radTenKhoa.Name = "radTenKhoa";
            this.radTenKhoa.Size = new System.Drawing.Size(54, 17);
            this.radTenKhoa.TabIndex = 33;
            this.radTenKhoa.TabStop = true;
            this.radTenKhoa.Text = "Khoa";
            this.radTenKhoa.UseVisualStyleBackColor = true;
            this.radTenKhoa.CheckedChanged += new System.EventHandler(this.radTenKhoa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Từ Khóa:";
            // 
            // radTrangThai
            // 
            this.radTrangThai.AutoSize = true;
            this.radTrangThai.Location = new System.Drawing.Point(224, 33);
            this.radTrangThai.Name = "radTrangThai";
            this.radTrangThai.Size = new System.Drawing.Size(87, 17);
            this.radTrangThai.TabIndex = 32;
            this.radTrangThai.TabStop = true;
            this.radTrangThai.Text = "Trạng Thái";
            this.radTrangThai.UseVisualStyleBackColor = true;
            // 
            // radTenPhong
            // 
            this.radTenPhong.AutoSize = true;
            this.radTenPhong.Location = new System.Drawing.Point(317, 33);
            this.radTenPhong.Name = "radTenPhong";
            this.radTenPhong.Size = new System.Drawing.Size(87, 17);
            this.radTenPhong.TabIndex = 1;
            this.radTenPhong.TabStop = true;
            this.radTenPhong.Text = "Tên Phòng";
            this.radTenPhong.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(410, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 34);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 32);
            this.txtTimKiem.MaxLength = 50;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(104, 164);
            this.rtbGhiChu.MaxLength = 100;
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(200, 76);
            this.rtbGhiChu.TabIndex = 13;
            this.rtbGhiChu.Text = "";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(104, 137);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(200, 21);
            this.cboTrangThai.TabIndex = 12;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(6, 167);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(56, 13);
            this.lblGhiChu.TabIndex = 11;
            this.lblGhiChu.Text = "Ghi Chú:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(6, 140);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 13);
            this.lblTrangThai.TabIndex = 10;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(103, 58);
            this.txtTenPhong.MaxLength = 50;
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(200, 20);
            this.txtTenPhong.TabIndex = 9;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCapNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhap.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhap.Location = new System.Drawing.Point(310, 120);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(97, 38);
            this.btnCapNhap.TabIndex = 8;
            this.btnCapNhap.Text = "Cập Nhập";
            this.btnCapNhap.UseVisualStyleBackColor = false;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(310, 76);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemMoi.Location = new System.Drawing.Point(310, 32);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(97, 38);
            this.btnThemMoi.TabIndex = 6;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txtSoLuongMay
            // 
            this.txtSoLuongMay.Location = new System.Drawing.Point(104, 84);
            this.txtSoLuongMay.MaxLength = 3;
            this.txtSoLuongMay.Name = "txtSoLuongMay";
            this.txtSoLuongMay.Size = new System.Drawing.Size(200, 20);
            this.txtSoLuongMay.TabIndex = 5;
            // 
            // lblSoLuongMay
            // 
            this.lblSoLuongMay.AutoSize = true;
            this.lblSoLuongMay.Location = new System.Drawing.Point(6, 87);
            this.lblSoLuongMay.Name = "lblSoLuongMay";
            this.lblSoLuongMay.Size = new System.Drawing.Size(92, 13);
            this.lblSoLuongMay.TabIndex = 4;
            this.lblSoLuongMay.Text = "Số Lượng Máy:";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(6, 61);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(73, 13);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = "Tên Phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(104, 32);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(200, 20);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(6, 35);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(68, 13);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã Phòng:";
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhongMay,
            this.TenPhongMay,
            this.SoLuongMay,
            this.TenKhoa,
            this.TenTrangThai,
            this.GhiChu,
            this.TrangThai,
            this.MaKhoa});
            this.dgvDSPhong.Location = new System.Drawing.Point(13, 410);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.Size = new System.Drawing.Size(532, 170);
            this.dgvDSPhong.TabIndex = 2;
            this.dgvDSPhong.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // MaPhongMay
            // 
            this.MaPhongMay.DataPropertyName = "MaPhongMay";
            this.MaPhongMay.HeaderText = "ID";
            this.MaPhongMay.Name = "MaPhongMay";
            this.MaPhongMay.ReadOnly = true;
            // 
            // TenPhongMay
            // 
            this.TenPhongMay.DataPropertyName = "TenPhongMay";
            this.TenPhongMay.HeaderText = "Tên Phòng";
            this.TenPhongMay.Name = "TenPhongMay";
            this.TenPhongMay.ReadOnly = true;
            // 
            // SoLuongMay
            // 
            this.SoLuongMay.DataPropertyName = "SoLuongMay";
            this.SoLuongMay.HeaderText = "Số Máy";
            this.SoLuongMay.Name = "SoLuongMay";
            this.SoLuongMay.ReadOnly = true;
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            // 
            // TenTrangThai
            // 
            this.TenTrangThai.DataPropertyName = "TenTrangThai";
            this.TenTrangThai.HeaderText = "Trạng Thái";
            this.TenTrangThai.Name = "TenTrangThai";
            this.TenTrangThai.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "MaTT";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "Khoa";
            this.MaKhoa.HeaderText = "MaKhoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Visible = false;
            // 
            // frmQLPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 592);
            this.Controls.Add(this.dgvDSPhong);
            this.Controls.Add(this.grpQLPhongMay);
            this.Controls.Add(this.lblQLPhongMay);
            this.Name = "frmQLPhongMay";
            this.Text = "Quản Lý Phòng Máy";
            this.Load += new System.EventHandler(this.frm_QLPhongMay_Load);
            this.grpQLPhongMay.ResumeLayout(false);
            this.grpQLPhongMay.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLPhongMay;
        private System.Windows.Forms.GroupBox grpQLPhongMay;
        private System.Windows.Forms.TextBox txtSoLuongMay;
        private System.Windows.Forms.Label lblSoLuongMay;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.RadioButton radTrangThai;
        private System.Windows.Forms.RadioButton radTenPhong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSPhong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
    }
}