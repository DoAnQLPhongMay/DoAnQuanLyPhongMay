namespace QuanLyPhongMay
{
    partial class frmQuenMatKhau
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblQuenMatKhau = new System.Windows.Forms.Label();
            this.lblQLPhongMay = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(169, 131);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picLogo.Image = global::QuanLyPhongMay.Properties.Resources.logo_cao_thang;
            this.picLogo.Location = new System.Drawing.Point(12, 96);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(119, 191);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Blue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(137, 250);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(211, 37);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // picPassword
            // 
            this.picPassword.Image = global::QuanLyPhongMay.Properties.Resources._lock;
            this.picPassword.Location = new System.Drawing.Point(137, 129);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(26, 25);
            this.picPassword.TabIndex = 3;
            this.picPassword.TabStop = false;
            // 
            // picUsername
            // 
            this.picUsername.Image = global::QuanLyPhongMay.Properties.Resources.user;
            this.picUsername.Location = new System.Drawing.Point(137, 98);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(26, 25);
            this.picUsername.TabIndex = 1;
            this.picUsername.TabStop = false;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(169, 100);
            this.txtTenTaiKhoan.MaxLength = 20;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(179, 23);
            this.txtTenTaiKhoan.TabIndex = 2;
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.AutoSize = true;
            this.lblQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMatKhau.ForeColor = System.Drawing.Color.White;
            this.lblQuenMatKhau.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuenMatKhau.Location = new System.Drawing.Point(81, 40);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(215, 31);
            this.lblQuenMatKhau.TabIndex = 0;
            this.lblQuenMatKhau.Text = "Quên Mật Khẩu";
            this.lblQuenMatKhau.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuenMatKhau.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // lblQLPhongMay
            // 
            this.lblQLPhongMay.AutoSize = true;
            this.lblQLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPhongMay.ForeColor = System.Drawing.Color.White;
            this.lblQLPhongMay.Location = new System.Drawing.Point(58, 9);
            this.lblQLPhongMay.Name = "lblQLPhongMay";
            this.lblQLPhongMay.Size = new System.Drawing.Size(276, 31);
            this.lblQLPhongMay.TabIndex = 1;
            this.lblQLPhongMay.Text = "Quản Lý Phòng Máy";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.Blue;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.ForeColor = System.Drawing.Color.White;
            this.btnKiemTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiemTra.Location = new System.Drawing.Point(137, 207);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(211, 37);
            this.btnKiemTra.TabIndex = 9;
            this.btnKiemTra.Text = "Kiểm Tra Tài Khoản";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtSDT.Location = new System.Drawing.Point(169, 160);
            this.txtSDT.MaxLength = 20;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(179, 23);
            this.txtSDT.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyPhongMay.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(137, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(373, 322);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.lblQuenMatKhau);
            this.Controls.Add(this.lblQLPhongMay);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.picUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lblQuenMatKhau;
        private System.Windows.Forms.Label lblQLPhongMay;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

