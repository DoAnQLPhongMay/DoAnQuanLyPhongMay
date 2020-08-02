namespace QuanLyPhongMay
{
    partial class frmQLThanhLy
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
            this.lblQLThanhLy = new System.Windows.Forms.Label();
            this.grpChiTietThanhLy = new System.Windows.Forms.GroupBox();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblGhiChu = new System.Windows.Forms.Label();
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
            this.dtmNgayThanhLy = new System.Windows.Forms.DateTimePicker();
            this.lblNgayThanhLy = new System.Windows.Forms.Label();
            this.txtMaThanhLy = new System.Windows.Forms.TextBox();
            this.lblMaThanhLy = new System.Windows.Forms.Label();
            this.dgvDSThanhLy = new System.Windows.Forms.DataGridView();
            this.MaThanhLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChiTietThanhLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhLy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLThanhLy
            // 
            this.lblQLThanhLy.AutoSize = true;
            this.lblQLThanhLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLThanhLy.Location = new System.Drawing.Point(12, 9);
            this.lblQLThanhLy.Name = "lblQLThanhLy";
            this.lblQLThanhLy.Size = new System.Drawing.Size(571, 61);
            this.lblQLThanhLy.TabIndex = 0;
            this.lblQLThanhLy.Text = "Quản Lý Thanh Lý Máy";
            // 
            // grpChiTietThanhLy
            // 
            this.grpChiTietThanhLy.Controls.Add(this.rtbGhiChu);
            this.grpChiTietThanhLy.Controls.Add(this.btnXoa);
            this.grpChiTietThanhLy.Controls.Add(this.btnSua);
            this.grpChiTietThanhLy.Controls.Add(this.btnThem);
            this.grpChiTietThanhLy.Controls.Add(this.lblGhiChu);
            this.grpChiTietThanhLy.Controls.Add(this.txtDonGia);
            this.grpChiTietThanhLy.Controls.Add(this.lblDonGia);
            this.grpChiTietThanhLy.Controls.Add(this.txtSoLuong);
            this.grpChiTietThanhLy.Controls.Add(this.lblSoLuong);
            this.grpChiTietThanhLy.Controls.Add(this.txtNamSX);
            this.grpChiTietThanhLy.Controls.Add(this.lblNamSX);
            this.grpChiTietThanhLy.Controls.Add(this.txtNSX);
            this.grpChiTietThanhLy.Controls.Add(this.lblNSX);
            this.grpChiTietThanhLy.Controls.Add(this.txtMaThietBi);
            this.grpChiTietThanhLy.Controls.Add(this.lblMaThietBi);
            this.grpChiTietThanhLy.Controls.Add(this.dtmNgayThanhLy);
            this.grpChiTietThanhLy.Controls.Add(this.lblNgayThanhLy);
            this.grpChiTietThanhLy.Controls.Add(this.txtMaThanhLy);
            this.grpChiTietThanhLy.Controls.Add(this.lblMaThanhLy);
            this.grpChiTietThanhLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChiTietThanhLy.Location = new System.Drawing.Point(2, 90);
            this.grpChiTietThanhLy.Name = "grpChiTietThanhLy";
            this.grpChiTietThanhLy.Size = new System.Drawing.Size(872, 201);
            this.grpChiTietThanhLy.TabIndex = 1;
            this.grpChiTietThanhLy.TabStop = false;
            this.grpChiTietThanhLy.Text = "Chi tiết Thanh Lý Máy";
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(549, 98);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(98, 73);
            this.rtbGhiChu.TabIndex = 42;
            this.rtbGhiChu.Text = "";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(708, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 40);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(708, 101);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 40);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(708, 44);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 40);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(457, 101);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(60, 13);
            this.lblGhiChu.TabIndex = 37;
            this.lblGhiChu.Text = "Ghi Chú: ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(94, 151);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 34;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(8, 154);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(61, 13);
            this.lblDonGia.TabIndex = 33;
            this.lblDonGia.Text = "Đơn Giá: ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(321, 151);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 32;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(233, 154);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(69, 13);
            this.lblSoLuong.TabIndex = 31;
            this.lblSoLuong.Text = "Số Lượng: ";
            // 
            // txtNamSX
            // 
            this.txtNamSX.Location = new System.Drawing.Point(321, 98);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(100, 20);
            this.txtNamSX.TabIndex = 30;
            // 
            // lblNamSX
            // 
            this.lblNamSX.AutoSize = true;
            this.lblNamSX.Location = new System.Drawing.Point(233, 101);
            this.lblNamSX.Name = "lblNamSX";
            this.lblNamSX.Size = new System.Drawing.Size(96, 13);
            this.lblNamSX.TabIndex = 29;
            this.lblNamSX.Text = "Năm Sản Xuất: ";
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(94, 98);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(100, 20);
            this.txtNSX.TabIndex = 28;
            // 
            // lblNSX
            // 
            this.lblNSX.AutoSize = true;
            this.lblNSX.Location = new System.Drawing.Point(8, 101);
            this.lblNSX.Name = "lblNSX";
            this.lblNSX.Size = new System.Drawing.Size(94, 13);
            this.lblNSX.TabIndex = 27;
            this.lblNSX.Text = "Nhà Sản Xuất: ";
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Location = new System.Drawing.Point(321, 52);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Size = new System.Drawing.Size(100, 20);
            this.txtMaThietBi.TabIndex = 26;
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(233, 55);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(80, 13);
            this.lblMaThietBi.TabIndex = 25;
            this.lblMaThietBi.Text = "Mã Thiết Bị: ";
            // 
            // dtmNgayThanhLy
            // 
            this.dtmNgayThanhLy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgayThanhLy.Location = new System.Drawing.Point(549, 52);
            this.dtmNgayThanhLy.Name = "dtmNgayThanhLy";
            this.dtmNgayThanhLy.Size = new System.Drawing.Size(98, 20);
            this.dtmNgayThanhLy.TabIndex = 24;
            // 
            // lblNgayThanhLy
            // 
            this.lblNgayThanhLy.AutoSize = true;
            this.lblNgayThanhLy.Location = new System.Drawing.Point(457, 55);
            this.lblNgayThanhLy.Name = "lblNgayThanhLy";
            this.lblNgayThanhLy.Size = new System.Drawing.Size(101, 13);
            this.lblNgayThanhLy.TabIndex = 23;
            this.lblNgayThanhLy.Text = "Ngày Thanh Lý: ";
            // 
            // txtMaThanhLy
            // 
            this.txtMaThanhLy.Location = new System.Drawing.Point(94, 49);
            this.txtMaThanhLy.Name = "txtMaThanhLy";
            this.txtMaThanhLy.Size = new System.Drawing.Size(100, 20);
            this.txtMaThanhLy.TabIndex = 22;
            // 
            // lblMaThanhLy
            // 
            this.lblMaThanhLy.AutoSize = true;
            this.lblMaThanhLy.Location = new System.Drawing.Point(8, 52);
            this.lblMaThanhLy.Name = "lblMaThanhLy";
            this.lblMaThanhLy.Size = new System.Drawing.Size(89, 13);
            this.lblMaThanhLy.TabIndex = 21;
            this.lblMaThanhLy.Text = "Mã Thanh Lý: ";
            // 
            // dgvDSThanhLy
            // 
            this.dgvDSThanhLy.AllowUserToAddRows = false;
            this.dgvDSThanhLy.AllowUserToDeleteRows = false;
            this.dgvDSThanhLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSThanhLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThanhLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThanhLy,
            this.MaThietBi,
            this.NgayThanhLy,
            this.NhaSanXuat,
            this.NamSanXuat,
            this.DonGia,
            this.TrangThai,
            this.GhiChu});
            this.dgvDSThanhLy.Location = new System.Drawing.Point(2, 297);
            this.dgvDSThanhLy.Name = "dgvDSThanhLy";
            this.dgvDSThanhLy.ReadOnly = true;
            this.dgvDSThanhLy.Size = new System.Drawing.Size(872, 315);
            this.dgvDSThanhLy.TabIndex = 3;
            // 
            // MaThanhLy
            // 
            this.MaThanhLy.HeaderText = "Mã Thanh Lý";
            this.MaThanhLy.Name = "MaThanhLy";
            this.MaThanhLy.ReadOnly = true;
            // 
            // MaThietBi
            // 
            this.MaThietBi.HeaderText = "Mã Thiết Bị";
            this.MaThietBi.Name = "MaThietBi";
            this.MaThietBi.ReadOnly = true;
            // 
            // NgayThanhLy
            // 
            this.NgayThanhLy.HeaderText = "Ngày Thanh Lý";
            this.NgayThanhLy.Name = "NgayThanhLy";
            this.NgayThanhLy.ReadOnly = true;
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
            // frmQLThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 614);
            this.Controls.Add(this.dgvDSThanhLy);
            this.Controls.Add(this.grpChiTietThanhLy);
            this.Controls.Add(this.lblQLThanhLy);
            this.Name = "frmQLThanhLy";
            this.Text = "Quản Lý Thanh Lý";
            this.Load += new System.EventHandler(this.frm_QLThanhLy_Load);
            this.grpChiTietThanhLy.ResumeLayout(false);
            this.grpChiTietThanhLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLThanhLy;
        private System.Windows.Forms.GroupBox grpChiTietThanhLy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblGhiChu;
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
        private System.Windows.Forms.DateTimePicker dtmNgayThanhLy;
        private System.Windows.Forms.Label lblNgayThanhLy;
        private System.Windows.Forms.TextBox txtMaThanhLy;
        private System.Windows.Forms.Label lblMaThanhLy;
        private System.Windows.Forms.DataGridView dgvDSThanhLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
    }
}