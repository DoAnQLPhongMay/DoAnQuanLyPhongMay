namespace Quản_Lý_Phòng_Máy
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.panel_Vang = new System.Windows.Forms.Panel();
            this.lbl_QLPhongMay = new System.Windows.Forms.Label();
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.pic_Password = new System.Windows.Forms.PictureBox();
            this.pic_Username = new System.Windows.Forms.PictureBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panel_Vang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Username)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Vang
            // 
            this.panel_Vang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_Vang.Controls.Add(this.lbl_QLPhongMay);
            this.panel_Vang.Controls.Add(this.lbl_DangNhap);
            this.panel_Vang.Location = new System.Drawing.Point(0, 0);
            this.panel_Vang.Name = "panel_Vang";
            this.panel_Vang.Size = new System.Drawing.Size(283, 62);
            this.panel_Vang.TabIndex = 0;
            // 
            // lbl_QLPhongMay
            // 
            this.lbl_QLPhongMay.AutoSize = true;
            this.lbl_QLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLPhongMay.ForeColor = System.Drawing.Color.Navy;
            this.lbl_QLPhongMay.Location = new System.Drawing.Point(12, 9);
            this.lbl_QLPhongMay.Name = "lbl_QLPhongMay";
            this.lbl_QLPhongMay.Size = new System.Drawing.Size(225, 25);
            this.lbl_QLPhongMay.TabIndex = 1;
            this.lbl_QLPhongMay.Text = "Quản Lý Phòng Máy";
            // 
            // lbl_DangNhap
            // 
            this.lbl_DangNhap.AutoSize = true;
            this.lbl_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DangNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_DangNhap.Location = new System.Drawing.Point(75, 39);
            this.lbl_DangNhap.Name = "lbl_DangNhap";
            this.lbl_DangNhap.Size = new System.Drawing.Size(99, 20);
            this.lbl_DangNhap.TabIndex = 0;
            this.lbl_DangNhap.Text = "Đăng Nhập";
            this.lbl_DangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_Username.Location = new System.Drawing.Point(67, 94);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(125, 19);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.Text = "UserName";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_Password.Location = new System.Drawing.Point(64, 139);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(125, 19);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.Text = "PassWord";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.Image")));
            this.btn_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangNhap.Location = new System.Drawing.Point(53, 179);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(136, 29);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            // 
            // pic_Password
            // 
            this.pic_Password.Image = global::Quản_Lý_Phòng_Máy.Properties.Resources._lock;
            this.pic_Password.Location = new System.Drawing.Point(32, 132);
            this.pic_Password.Name = "pic_Password";
            this.pic_Password.Size = new System.Drawing.Size(26, 25);
            this.pic_Password.TabIndex = 3;
            this.pic_Password.TabStop = false;
            // 
            // pic_Username
            // 
            this.pic_Username.Image = global::Quản_Lý_Phòng_Máy.Properties.Resources.user;
            this.pic_Username.Location = new System.Drawing.Point(35, 87);
            this.pic_Username.Name = "pic_Username";
            this.pic_Username.Size = new System.Drawing.Size(26, 25);
            this.pic_Username.TabIndex = 1;
            this.pic_Username.TabStop = false;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Red;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(53, 224);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(136, 29);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(256, 291);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.pic_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.pic_Username);
            this.Controls.Add(this.panel_Vang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel_Vang.ResumeLayout(false);
            this.panel_Vang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Username)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Vang;
        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.Label lbl_QLPhongMay;
        private System.Windows.Forms.PictureBox pic_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pic_Password;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

