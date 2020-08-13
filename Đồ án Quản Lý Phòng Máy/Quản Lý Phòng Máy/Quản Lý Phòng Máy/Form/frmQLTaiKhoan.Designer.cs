namespace QuanLyPhongMay
{
    partial class frm_QLTaiKhoan
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
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.grp_ThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtMaQuyen = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.rad_SDT = new System.Windows.Forms.RadioButton();
            this.rad_TenTaiKhoan = new System.Windows.Forms.RadioButton();
            this.txt_TiemKiem = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.dtm_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.txt_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbl_TenTaiKhoan = new System.Windows.Forms.Label();
            this.lblQuyenHan = new System.Windows.Forms.Label();
            this.dgvDSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.grp_ThongTinTaiKhoan.SuspendLayout();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(1, 9);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(478, 61);
            this.lbl_QLTaiKhoan.TabIndex = 0;
            this.lbl_QLTaiKhoan.Text = "Quản Lý Tài Khoản";
            // 
            // grp_ThongTinTaiKhoan
            // 
            this.grp_ThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_ThongTinTaiKhoan.Controls.Add(this.txtMaQuyen);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.btn_Xoa);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.btn_CapNhat);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.btn_Them);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.grp_TimKiem);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.txt_Password);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.lbl_Password);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.txt_Username);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.lbl_Username);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.dtm_NgaySinh);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.txt_DiaChi);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.lbl_DiaChi);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.lbl_NgaySinh);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.txt_SDT);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.lbl_SDT);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.lbl_GioiTinh);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.rad_Nu);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.rad_Nam);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.txt_TenTaiKhoan);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.lbl_TenTaiKhoan);
            this.grp_ThongTinTaiKhoan.Controls.Add(this.lblQuyenHan);
            this.grp_ThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinTaiKhoan.Location = new System.Drawing.Point(13, 94);
            this.grp_ThongTinTaiKhoan.Name = "grp_ThongTinTaiKhoan";
            this.grp_ThongTinTaiKhoan.Size = new System.Drawing.Size(709, 280);
            this.grp_ThongTinTaiKhoan.TabIndex = 1;
            this.grp_ThongTinTaiKhoan.TabStop = false;
            this.grp_ThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Enabled = false;
            this.txtMaQuyen.Location = new System.Drawing.Point(122, 33);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(136, 21);
            this.txtMaQuyen.TabIndex = 22;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Location = new System.Drawing.Point(567, 117);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(101, 37);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Location = new System.Drawing.Point(567, 74);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(101, 37);
            this.btn_CapNhat.TabIndex = 20;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Location = new System.Drawing.Point(567, 31);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(101, 37);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.Text = "Thêm Mới";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.btn_TimKiem);
            this.grp_TimKiem.Controls.Add(this.rad_SDT);
            this.grp_TimKiem.Controls.Add(this.rad_TenTaiKhoan);
            this.grp_TimKiem.Controls.Add(this.txt_TiemKiem);
            this.grp_TimKiem.Location = new System.Drawing.Point(13, 196);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(690, 78);
            this.grp_TimKiem.TabIndex = 18;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Location = new System.Drawing.Point(552, 20);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(101, 37);
            this.btn_TimKiem.TabIndex = 3;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // rad_SDT
            // 
            this.rad_SDT.AutoSize = true;
            this.rad_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_SDT.Location = new System.Drawing.Point(408, 28);
            this.rad_SDT.Name = "rad_SDT";
            this.rad_SDT.Size = new System.Drawing.Size(103, 19);
            this.rad_SDT.TabIndex = 2;
            this.rad_SDT.TabStop = true;
            this.rad_SDT.Text = "Số Điện Thoại";
            this.rad_SDT.UseVisualStyleBackColor = true;
            // 
            // rad_TenTaiKhoan
            // 
            this.rad_TenTaiKhoan.AutoSize = true;
            this.rad_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TenTaiKhoan.Location = new System.Drawing.Point(275, 28);
            this.rad_TenTaiKhoan.Name = "rad_TenTaiKhoan";
            this.rad_TenTaiKhoan.Size = new System.Drawing.Size(105, 19);
            this.rad_TenTaiKhoan.TabIndex = 1;
            this.rad_TenTaiKhoan.TabStop = true;
            this.rad_TenTaiKhoan.Text = "Tên Tài Khoản";
            this.rad_TenTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // txt_TiemKiem
            // 
            this.txt_TiemKiem.Location = new System.Drawing.Point(7, 28);
            this.txt_TiemKiem.Name = "txt_TiemKiem";
            this.txt_TiemKiem.Size = new System.Drawing.Size(238, 21);
            this.txt_TiemKiem.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Enabled = false;
            this.txt_Password.Location = new System.Drawing.Point(407, 156);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(136, 21);
            this.txt_Password.TabIndex = 17;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(295, 159);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(63, 15);
            this.lbl_Password.TabIndex = 16;
            this.lbl_Password.Text = "Mật Khẩu:";
            // 
            // txt_Username
            // 
            this.txt_Username.Enabled = false;
            this.txt_Username.Location = new System.Drawing.Point(407, 113);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(136, 21);
            this.txt_Username.TabIndex = 15;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(295, 116);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(97, 15);
            this.lbl_Username.TabIndex = 14;
            this.lbl_Username.Text = "Tên Đăng Nhập:";
            // 
            // dtm_NgaySinh
            // 
            this.dtm_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_NgaySinh.Location = new System.Drawing.Point(407, 31);
            this.dtm_NgaySinh.Name = "dtm_NgaySinh";
            this.dtm_NgaySinh.Size = new System.Drawing.Size(136, 21);
            this.dtm_NgaySinh.TabIndex = 13;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(407, 74);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(136, 21);
            this.txt_DiaChi.TabIndex = 12;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(295, 77);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(50, 15);
            this.lbl_DiaChi.TabIndex = 11;
            this.lbl_DiaChi.Text = "Địa Chỉ:";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(295, 34);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(66, 15);
            this.lbl_NgaySinh.TabIndex = 9;
            this.lbl_NgaySinh.Text = "Ngày Sinh:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(122, 157);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(136, 21);
            this.txt_SDT.TabIndex = 8;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(6, 160);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(88, 15);
            this.lbl_SDT.TabIndex = 7;
            this.lbl_SDT.Text = "Số Điện Thoại:";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(9, 119);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(59, 15);
            this.lbl_GioiTinh.TabIndex = 6;
            this.lbl_GioiTinh.Text = "Giới Tính:";
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Nu.Location = new System.Drawing.Point(183, 117);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(41, 19);
            this.rad_Nu.TabIndex = 5;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Nam.Location = new System.Drawing.Point(122, 117);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(52, 19);
            this.rad_Nam.TabIndex = 4;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_TenTaiKhoan
            // 
            this.txt_TenTaiKhoan.Location = new System.Drawing.Point(122, 74);
            this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            this.txt_TenTaiKhoan.Size = new System.Drawing.Size(136, 21);
            this.txt_TenTaiKhoan.TabIndex = 3;
            // 
            // lbl_TenTaiKhoan
            // 
            this.lbl_TenTaiKhoan.AutoSize = true;
            this.lbl_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTaiKhoan.Location = new System.Drawing.Point(10, 77);
            this.lbl_TenTaiKhoan.Name = "lbl_TenTaiKhoan";
            this.lbl_TenTaiKhoan.Size = new System.Drawing.Size(90, 15);
            this.lbl_TenTaiKhoan.TabIndex = 2;
            this.lbl_TenTaiKhoan.Text = "Tên Tài Khoản:";
            // 
            // lblQuyenHan
            // 
            this.lblQuyenHan.AutoSize = true;
            this.lblQuyenHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyenHan.Location = new System.Drawing.Point(10, 34);
            this.lblQuyenHan.Name = "lblQuyenHan";
            this.lblQuyenHan.Size = new System.Drawing.Size(71, 15);
            this.lblQuyenHan.TabIndex = 0;
            this.lblQuyenHan.Text = "Quyền Hạn:";
            // 
            // dgvDSTaiKhoan
            // 
            this.dgvDSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTaiKhoan.Location = new System.Drawing.Point(13, 381);
            this.dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
            this.dgvDSTaiKhoan.Size = new System.Drawing.Size(709, 243);
            this.dgvDSTaiKhoan.TabIndex = 2;
            // 
            // frm_QLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 636);
            this.Controls.Add(this.dgvDSTaiKhoan);
            this.Controls.Add(this.grp_ThongTinTaiKhoan);
            this.Controls.Add(this.lbl_QLTaiKhoan);
            this.Name = "frm_QLTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frm_QLTaiKhoan_Load);
            this.grp_ThongTinTaiKhoan.ResumeLayout(false);
            this.grp_ThongTinTaiKhoan.PerformLayout();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.GroupBox grp_ThongTinTaiKhoan;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.TextBox txt_TenTaiKhoan;
        private System.Windows.Forms.Label lbl_TenTaiKhoan;
        private System.Windows.Forms.Label lblQuyenHan;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.RadioButton rad_SDT;
        private System.Windows.Forms.RadioButton rad_TenTaiKhoan;
        private System.Windows.Forms.TextBox txt_TiemKiem;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.DateTimePicker dtm_NgaySinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtMaQuyen;
        private System.Windows.Forms.DataGridView dgvDSTaiKhoan;
    }
}