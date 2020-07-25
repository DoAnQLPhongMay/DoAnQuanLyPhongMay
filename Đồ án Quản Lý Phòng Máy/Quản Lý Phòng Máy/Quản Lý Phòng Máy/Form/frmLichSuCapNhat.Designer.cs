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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.radMaMay = new System.Windows.Forms.RadioButton();
            this.radNgayCapNhat = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgLichSuCapNhat = new System.Windows.Forms.DataGridView();
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichSuCapNhat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Aurora", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Sử Cập Nhật";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.radNgayCapNhat);
            this.groupBox1.Controls.Add(this.radMaMay);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(7, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(195, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // radMaMay
            // 
            this.radMaMay.AutoSize = true;
            this.radMaMay.Location = new System.Drawing.Point(251, 39);
            this.radMaMay.Name = "radMaMay";
            this.radMaMay.Size = new System.Drawing.Size(69, 17);
            this.radMaMay.TabIndex = 1;
            this.radMaMay.TabStop = true;
            this.radMaMay.Text = "Mã Máy";
            this.radMaMay.UseVisualStyleBackColor = true;
            // 
            // radNgayCapNhat
            // 
            this.radNgayCapNhat.AutoSize = true;
            this.radNgayCapNhat.Location = new System.Drawing.Point(367, 39);
            this.radNgayCapNhat.Name = "radNgayCapNhat";
            this.radNgayCapNhat.Size = new System.Drawing.Size(111, 17);
            this.radNgayCapNhat.TabIndex = 2;
            this.radNgayCapNhat.TabStop = true;
            this.radNgayCapNhat.Text = "Ngày Cập Nhật";
            this.radNgayCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Lime;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(523, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dtgLichSuCapNhat
            // 
            this.dtgLichSuCapNhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLichSuCapNhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMay,
            this.TenMay,
            this.Phong,
            this.ChiTietMay,
            this.NgayCapNhat,
            this.GhiChu});
            this.dtgLichSuCapNhat.Location = new System.Drawing.Point(2, 152);
            this.dtgLichSuCapNhat.Name = "dtgLichSuCapNhat";
            this.dtgLichSuCapNhat.Size = new System.Drawing.Size(619, 225);
            this.dtgLichSuCapNhat.TabIndex = 2;
            // 
            // MaMay
            // 
            this.MaMay.HeaderText = "Mã Máy";
            this.MaMay.Name = "MaMay";
            // 
            // TenMay
            // 
            this.TenMay.HeaderText = "TenMay";
            this.TenMay.Name = "TenMay";
            // 
            // Phong
            // 
            this.Phong.HeaderText = "Phòng";
            this.Phong.Name = "Phong";
            // 
            // ChiTietMay
            // 
            this.ChiTietMay.HeaderText = "Chi Tiết Máy";
            this.ChiTietMay.Name = "ChiTietMay";
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.HeaderText = "Ngày Cập Nhật";
            this.NgayCapNhat.Name = "NgayCapNhat";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "GhiChú";
            this.GhiChu.Name = "GhiChu";
            // 
            // frmLichSuCapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 377);
            this.Controls.Add(this.dtgLichSuCapNhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmLichSuCapNhat";
            this.Text = "frmLichSuCapNhat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichSuCapNhat)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgLichSuCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTietMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}