namespace QuanLyPhongMay
{
    partial class frmLichSuCapNhat
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.radNgayCapNhat = new System.Windows.Forms.RadioButton();
            this.radMaMay = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvLSCapNhat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MaCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMayCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCauHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCauHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSCapNhat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Sử Cập Nhật";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.radNgayCapNhat);
            this.groupBox1.Controls.Add(this.radMaMay);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(484, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 40);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // radNgayCapNhat
            // 
            this.radNgayCapNhat.AutoSize = true;
            this.radNgayCapNhat.Location = new System.Drawing.Point(283, 39);
            this.radNgayCapNhat.Name = "radNgayCapNhat";
            this.radNgayCapNhat.Size = new System.Drawing.Size(111, 17);
            this.radNgayCapNhat.TabIndex = 2;
            this.radNgayCapNhat.TabStop = true;
            this.radNgayCapNhat.Text = "Ngày Cập Nhật";
            this.radNgayCapNhat.UseVisualStyleBackColor = true;
            // 
            // radMaMay
            // 
            this.radMaMay.AutoSize = true;
            this.radMaMay.Location = new System.Drawing.Point(208, 39);
            this.radMaMay.Name = "radMaMay";
            this.radMaMay.Size = new System.Drawing.Size(69, 17);
            this.radMaMay.TabIndex = 1;
            this.radMaMay.TabStop = true;
            this.radMaMay.Text = "Mã Máy";
            this.radMaMay.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(195, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // dgvLSCapNhat
            // 
            this.dgvLSCapNhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSCapNhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCapNhat,
            this.TenMay,
            this.TenMayCN,
            this.TenCauHinh,
            this.TenPhong,
            this.NgayCapNhat,
            this.GhiChu,
            this.MaMay,
            this.MaCauHinh,
            this.MaPhong,
            this.TenDangNhap});
            this.dgvLSCapNhat.Location = new System.Drawing.Point(12, 131);
            this.dgvLSCapNhat.Name = "dgvLSCapNhat";
            this.dgvLSCapNhat.Size = new System.Drawing.Size(597, 225);
            this.dgvLSCapNhat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Từ Khóa:";
            // 
            // MaCapNhat
            // 
            this.MaCapNhat.DataPropertyName = "MaCapNhat";
            this.MaCapNhat.HeaderText = "ID";
            this.MaCapNhat.Name = "MaCapNhat";
            this.MaCapNhat.ReadOnly = true;
            // 
            // TenMay
            // 
            this.TenMay.DataPropertyName = "TenMay";
            this.TenMay.HeaderText = "Tên Máy Hiện Tại";
            this.TenMay.Name = "TenMay";
            // 
            // TenMayCN
            // 
            this.TenMayCN.DataPropertyName = "TenMayCN";
            this.TenMayCN.HeaderText = "Tên Máy Cập Nhật";
            this.TenMayCN.Name = "TenMayCN";
            this.TenMayCN.ReadOnly = true;
            // 
            // TenCauHinh
            // 
            this.TenCauHinh.DataPropertyName = "TenCauHinh";
            this.TenCauHinh.HeaderText = "Cấu Hình";
            this.TenCauHinh.Name = "TenCauHinh";
            this.TenCauHinh.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhongMay";
            this.TenPhong.HeaderText = "Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.DataPropertyName = "NgayCapNhat";
            this.NgayCapNhat.HeaderText = "Ngày";
            this.NgayCapNhat.Name = "NgayCapNhat";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // MaMay
            // 
            this.MaMay.DataPropertyName = "MaMay";
            this.MaMay.HeaderText = "MaMay";
            this.MaMay.Name = "MaMay";
            this.MaMay.Visible = false;
            // 
            // MaCauHinh
            // 
            this.MaCauHinh.DataPropertyName = "MaCauHinh";
            this.MaCauHinh.HeaderText = "MaCH";
            this.MaCauHinh.Name = "MaCauHinh";
            this.MaCauHinh.ReadOnly = true;
            this.MaCauHinh.Visible = false;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhongMay";
            this.MaPhong.HeaderText = "MaPhong";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Visible = false;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "TenDN";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            this.TenDangNhap.Visible = false;
            // 
            // frmLichSuCapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 377);
            this.Controls.Add(this.dgvLSCapNhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmLichSuCapNhat";
            this.Text = "Lịch Sử Cập Nhật";
            this.Load += new System.EventHandler(this.frmLichSuCapNhat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSCapNhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton radNgayCapNhat;
        private System.Windows.Forms.RadioButton radMaMay;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvLSCapNhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMayCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCauHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
    }
}