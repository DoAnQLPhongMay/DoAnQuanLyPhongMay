﻿namespace QuanLyPhongMay
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.radTrangThai = new System.Windows.Forms.RadioButton();
            this.radMaPhong = new System.Windows.Forms.RadioButton();
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
            // 
            // grpQLPhongMay
            // 
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
            this.grpQLPhongMay.Size = new System.Drawing.Size(575, 287);
            this.grpQLPhongMay.TabIndex = 1;
            this.grpQLPhongMay.TabStop = false;
            this.grpQLPhongMay.Text = "Quán Lý Phòng Máy";
            this.grpQLPhongMay.Enter += new System.EventHandler(this.grp_QLPhongMay_Enter);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(463, 164);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 38);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.radTrangThai);
            this.grpTimKiem.Controls.Add(this.radMaPhong);
            this.grpTimKiem.Controls.Add(this.radTenPhong);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(6, 208);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(563, 70);
            this.grpTimKiem.TabIndex = 25;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            // 
            // radTrangThai
            // 
            this.radTrangThai.AutoSize = true;
            this.radTrangThai.Location = new System.Drawing.Point(224, 43);
            this.radTrangThai.Name = "radTrangThai";
            this.radTrangThai.Size = new System.Drawing.Size(87, 17);
            this.radTrangThai.TabIndex = 32;
            this.radTrangThai.TabStop = true;
            this.radTrangThai.Text = "Trạng Thái";
            this.radTrangThai.UseVisualStyleBackColor = true;
            // 
            // radMaPhong
            // 
            this.radMaPhong.AutoSize = true;
            this.radMaPhong.Location = new System.Drawing.Point(224, 20);
            this.radMaPhong.Name = "radMaPhong";
            this.radMaPhong.Size = new System.Drawing.Size(82, 17);
            this.radMaPhong.TabIndex = 31;
            this.radMaPhong.TabStop = true;
            this.radMaPhong.Text = "Mã Phòng";
            this.radMaPhong.UseVisualStyleBackColor = true;
            // 
            // radTenPhong
            // 
            this.radTenPhong.AutoSize = true;
            this.radTenPhong.Location = new System.Drawing.Point(331, 20);
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
            this.btnTimKiem.Location = new System.Drawing.Point(460, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 34);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(298, 89);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(121, 76);
            this.rtbGhiChu.TabIndex = 13;
            this.rtbGhiChu.Text = "";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(298, 32);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(121, 21);
            this.cboTrangThai.TabIndex = 12;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(219, 92);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(56, 13);
            this.lblGhiChu.TabIndex = 11;
            this.lblGhiChu.Text = "Ghi Chú:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(219, 35);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 13);
            this.lblTrangThai.TabIndex = 10;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(113, 145);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(100, 20);
            this.txtTenPhong.TabIndex = 9;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCapNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhap.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhap.Location = new System.Drawing.Point(463, 120);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(100, 38);
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
            this.btnXoa.Location = new System.Drawing.Point(463, 76);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
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
            this.btnThemMoi.Location = new System.Drawing.Point(463, 32);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 38);
            this.btnThemMoi.TabIndex = 6;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txtSoLuongMay
            // 
            this.txtSoLuongMay.Location = new System.Drawing.Point(113, 89);
            this.txtSoLuongMay.Name = "txtSoLuongMay";
            this.txtSoLuongMay.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongMay.TabIndex = 5;
            // 
            // lblSoLuongMay
            // 
            this.lblSoLuongMay.AutoSize = true;
            this.lblSoLuongMay.Location = new System.Drawing.Point(11, 92);
            this.lblSoLuongMay.Name = "lblSoLuongMay";
            this.lblSoLuongMay.Size = new System.Drawing.Size(92, 13);
            this.lblSoLuongMay.TabIndex = 4;
            this.lblSoLuongMay.Text = "Số Lượng Máy:";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(11, 148);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(73, 13);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = "Tên Phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(113, 32);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(11, 35);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(68, 13);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã Phòng:";
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhong.Location = new System.Drawing.Point(13, 366);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.Size = new System.Drawing.Size(574, 170);
            this.dgvDSPhong.TabIndex = 2;
            this.dgvDSPhong.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // frmQLPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 545);
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
        private System.Windows.Forms.RadioButton radMaPhong;
        private System.Windows.Forms.RadioButton radTenPhong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSPhong;
        private System.Windows.Forms.Button btnLamMoi;
    }
}