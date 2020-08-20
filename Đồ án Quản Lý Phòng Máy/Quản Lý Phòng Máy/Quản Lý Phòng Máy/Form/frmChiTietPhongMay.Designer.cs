namespace QuanLyPhongMay
{
    partial class frmChiTietPhongMay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSMay = new System.Windows.Forms.DataGridView();
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCauHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhongMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCauHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQLPhongMay = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDSMay);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 465);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Máy";
            // 
            // dgvDSMay
            // 
            this.dgvDSMay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMay.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSMay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMay,
            this.TenMay,
            this.TenPhongMay,
            this.TenCauHinh,
            this.TrangThai,
            this.GhiChu,
            this.MaPhongMay,
            this.MaTrangThai,
            this.MaCauHinh});
            this.dgvDSMay.Location = new System.Drawing.Point(6, 19);
            this.dgvDSMay.Name = "dgvDSMay";
            this.dgvDSMay.Size = new System.Drawing.Size(698, 440);
            this.dgvDSMay.TabIndex = 0;
            // 
            // MaMay
            // 
            this.MaMay.DataPropertyName = "MaMay";
            this.MaMay.HeaderText = "ID";
            this.MaMay.Name = "MaMay";
            this.MaMay.ReadOnly = true;
            // 
            // TenMay
            // 
            this.TenMay.DataPropertyName = "TenMay";
            this.TenMay.HeaderText = "Tên Máy";
            this.TenMay.Name = "TenMay";
            this.TenMay.ReadOnly = true;
            // 
            // TenPhongMay
            // 
            this.TenPhongMay.DataPropertyName = "TenPhongMay";
            this.TenPhongMay.HeaderText = "Phòng";
            this.TenPhongMay.Name = "TenPhongMay";
            this.TenPhongMay.ReadOnly = true;
            // 
            // TenCauHinh
            // 
            this.TenCauHinh.DataPropertyName = "TenCauHinh";
            this.TenCauHinh.HeaderText = "Cấu Hình";
            this.TenCauHinh.Name = "TenCauHinh";
            this.TenCauHinh.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TenTrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // MaPhongMay
            // 
            this.MaPhongMay.DataPropertyName = "MaPhong";
            this.MaPhongMay.HeaderText = "MaPhongMay";
            this.MaPhongMay.Name = "MaPhongMay";
            this.MaPhongMay.ReadOnly = true;
            this.MaPhongMay.Visible = false;
            // 
            // MaTrangThai
            // 
            this.MaTrangThai.DataPropertyName = "TrangThai";
            this.MaTrangThai.HeaderText = "MaTrangThai";
            this.MaTrangThai.Name = "MaTrangThai";
            this.MaTrangThai.ReadOnly = true;
            this.MaTrangThai.Visible = false;
            // 
            // MaCauHinh
            // 
            this.MaCauHinh.DataPropertyName = "MaCauHinh";
            this.MaCauHinh.HeaderText = "MaCauHinh";
            this.MaCauHinh.Name = "MaCauHinh";
            this.MaCauHinh.ReadOnly = true;
            this.MaCauHinh.Visible = false;
            // 
            // lblQLPhongMay
            // 
            this.lblQLPhongMay.AutoSize = true;
            this.lblQLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPhongMay.Location = new System.Drawing.Point(12, 9);
            this.lblQLPhongMay.Name = "lblQLPhongMay";
            this.lblQLPhongMay.Size = new System.Drawing.Size(489, 61);
            this.lblQLPhongMay.TabIndex = 62;
            this.lblQLPhongMay.Text = "Chi Tiết Phòng Máy";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuayLai.Location = new System.Drawing.Point(629, 544);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(87, 35);
            this.btnQuayLai.TabIndex = 64;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmChiTietPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 591);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lblQLPhongMay);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChiTietPhongMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phòng Máy";
            this.Load += new System.EventHandler(this.frm_QLPhongMay_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQLPhongMay;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView dgvDSMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCauHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauHinh;
    }
}