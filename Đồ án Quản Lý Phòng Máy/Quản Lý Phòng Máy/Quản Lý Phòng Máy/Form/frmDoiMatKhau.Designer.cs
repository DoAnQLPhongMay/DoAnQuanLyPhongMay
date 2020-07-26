namespace QuanLyPhongMay
{
    partial class frmDoiMatKhau
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
            this.txtMatKhau2 = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.picMatKhau2 = new System.Windows.Forms.PictureBox();
            this.txtMatKhau1 = new System.Windows.Forms.TextBox();
            this.lblKhoiPhuc = new System.Windows.Forms.Label();
            this.lblQLPhongMay = new System.Windows.Forms.Label();
            this.picMatKhau1 = new System.Windows.Forms.PictureBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatKhau2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMatKhau2.Location = new System.Drawing.Point(169, 131);
            this.txtMatKhau2.MaxLength = 20;
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.PasswordChar = '*';
            this.txtMatKhau2.Size = new System.Drawing.Size(179, 23);
            this.txtMatKhau2.TabIndex = 4;
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
            // picMatKhau2
            // 
            this.picMatKhau2.Image = global::QuanLyPhongMay.Properties.Resources._lock;
            this.picMatKhau2.Location = new System.Drawing.Point(137, 129);
            this.picMatKhau2.Name = "picMatKhau2";
            this.picMatKhau2.Size = new System.Drawing.Size(26, 25);
            this.picMatKhau2.TabIndex = 3;
            this.picMatKhau2.TabStop = false;
            // 
            // txtMatKhau1
            // 
            this.txtMatKhau1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatKhau1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMatKhau1.Location = new System.Drawing.Point(169, 100);
            this.txtMatKhau1.MaxLength = 20;
            this.txtMatKhau1.Name = "txtMatKhau1";
            this.txtMatKhau1.Size = new System.Drawing.Size(179, 23);
            this.txtMatKhau1.TabIndex = 2;
            // 
            // lblKhoiPhuc
            // 
            this.lblKhoiPhuc.AutoSize = true;
            this.lblKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.lblKhoiPhuc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKhoiPhuc.Location = new System.Drawing.Point(47, 40);
            this.lblKhoiPhuc.Name = "lblKhoiPhuc";
            this.lblKhoiPhuc.Size = new System.Drawing.Size(277, 31);
            this.lblKhoiPhuc.TabIndex = 0;
            this.lblKhoiPhuc.Text = "Khôi Phục Mật Khẩu";
            this.lblKhoiPhuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKhoiPhuc.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // lblQLPhongMay
            // 
            this.lblQLPhongMay.AutoSize = true;
            this.lblQLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPhongMay.ForeColor = System.Drawing.Color.White;
            this.lblQLPhongMay.Location = new System.Drawing.Point(48, 9);
            this.lblQLPhongMay.Name = "lblQLPhongMay";
            this.lblQLPhongMay.Size = new System.Drawing.Size(276, 31);
            this.lblQLPhongMay.TabIndex = 1;
            this.lblQLPhongMay.Text = "Quản Lý Phòng Máy";
            // 
            // picMatKhau1
            // 
            this.picMatKhau1.Image = global::QuanLyPhongMay.Properties.Resources._lock;
            this.picMatKhau1.Location = new System.Drawing.Point(137, 96);
            this.picMatKhau1.Name = "picMatKhau1";
            this.picMatKhau1.Size = new System.Drawing.Size(26, 25);
            this.picMatKhau1.TabIndex = 9;
            this.picMatKhau1.TabStop = false;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.Blue;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(137, 207);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(211, 37);
            this.btnKhoiPhuc.TabIndex = 10;
            this.btnKhoiPhuc.Text = "Khôi Phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(373, 322);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.picMatKhau1);
            this.Controls.Add(this.lblKhoiPhuc);
            this.Controls.Add(this.lblQLPhongMay);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMatKhau2);
            this.Controls.Add(this.picMatKhau2);
            this.Controls.Add(this.txtMatKhau1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMatKhau2;
        private System.Windows.Forms.PictureBox picMatKhau2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtMatKhau1;
        private System.Windows.Forms.Label lblKhoiPhuc;
        private System.Windows.Forms.Label lblQLPhongMay;
        private System.Windows.Forms.PictureBox picMatKhau1;
        private System.Windows.Forms.Button btnKhoiPhuc;
    }
}

