namespace QuanLyPhongMay
{
    partial class frmDangNhap
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lblQLPhongMay = new System.Windows.Forms.Label();
            this.btnQuenMatKhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPassword.Location = new System.Drawing.Point(169, 131);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Image = global::QuanLyPhongMay.Properties.Resources.logo_cao_thang;
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Blue;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(137, 160);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(211, 39);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
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
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtUsername.Location = new System.Drawing.Point(169, 100);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("UTM Aurora", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.White;
            this.lblDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDangNhap.Location = new System.Drawing.Point(131, 42);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(125, 33);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "Đăng Nhập";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDangNhap.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // lblQLPhongMay
            // 
            this.lblQLPhongMay.AutoSize = true;
            this.lblQLPhongMay.Font = new System.Drawing.Font("UTM Aurora", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPhongMay.ForeColor = System.Drawing.Color.White;
            this.lblQLPhongMay.Location = new System.Drawing.Point(81, 9);
            this.lblQLPhongMay.Name = "lblQLPhongMay";
            this.lblQLPhongMay.Size = new System.Drawing.Size(217, 33);
            this.lblQLPhongMay.TabIndex = 1;
            this.lblQLPhongMay.Text = "Quản Lý Phòng Máy";
            // 
            // btnQuenMatKhau
            // 
            this.btnQuenMatKhau.BackColor = System.Drawing.Color.Blue;
            this.btnQuenMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMatKhau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuenMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuenMatKhau.Location = new System.Drawing.Point(137, 205);
            this.btnQuenMatKhau.Name = "btnQuenMatKhau";
            this.btnQuenMatKhau.Size = new System.Drawing.Size(211, 39);
            this.btnQuenMatKhau.TabIndex = 9;
            this.btnQuenMatKhau.Text = "Quên Mật Khẩu";
            this.btnQuenMatKhau.UseVisualStyleBackColor = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(373, 322);
            this.Controls.Add(this.btnQuenMatKhau);
            this.Controls.Add(this.lblDangNhap);
            this.Controls.Add(this.lblQLPhongMay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.picUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblQLPhongMay;
        private System.Windows.Forms.Button btnQuenMatKhau;
    }
}

