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
            this.dgvDSMay = new System.Windows.Forms.DataGridView();
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaMay = new System.Windows.Forms.TextBox();
            this.lbl_MaMay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TenMay = new System.Windows.Forms.Label();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.lbl_ManHinh = new System.Windows.Forms.Label();
            this.lbl_Chuot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MainBoard = new System.Windows.Forms.Label();
            this.lbl_RAM = new System.Windows.Forms.Label();
            this.txtTenMay = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtManHinh = new System.Windows.Forms.TextBox();
            this.txtChuot = new System.Windows.Forms.TextBox();
            this.txtBanPhim = new System.Windows.Forms.TextBox();
            this.txtThung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMainBoard = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtHDH = new System.Windows.Forms.TextBox();
            this.txtOCung = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtVGA = new System.Windows.Forms.TextBox();
            this.txtPSU = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.lblQLPhongMay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSMay
            // 
            this.dgvDSMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMay,
            this.TenMay,
            this.TenPhongMay,
            this.TrangThai,
            this.GhiChu});
            this.dgvDSMay.Location = new System.Drawing.Point(6, 19);
            this.dgvDSMay.Name = "dgvDSMay";
            this.dgvDSMay.Size = new System.Drawing.Size(283, 440);
            this.dgvDSMay.TabIndex = 0;
            this.dgvDSMay.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
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
            // txtMaMay
            // 
            this.txtMaMay.Enabled = false;
            this.txtMaMay.Location = new System.Drawing.Point(379, 19);
            this.txtMaMay.Name = "txtMaMay";
            this.txtMaMay.ReadOnly = true;
            this.txtMaMay.Size = new System.Drawing.Size(104, 20);
            this.txtMaMay.TabIndex = 2;
            // 
            // lbl_MaMay
            // 
            this.lbl_MaMay.AutoSize = true;
            this.lbl_MaMay.Location = new System.Drawing.Point(322, 22);
            this.lbl_MaMay.Name = "lbl_MaMay";
            this.lbl_MaMay.Size = new System.Drawing.Size(51, 13);
            this.lbl_MaMay.TabIndex = 3;
            this.lbl_MaMay.Text = "Mã Máy: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên phòng:";
            // 
            // lbl_TenMay
            // 
            this.lbl_TenMay.AutoSize = true;
            this.lbl_TenMay.Location = new System.Drawing.Point(318, 48);
            this.lbl_TenMay.Name = "lbl_TenMay";
            this.lbl_TenMay.Size = new System.Drawing.Size(55, 13);
            this.lbl_TenMay.TabIndex = 29;
            this.lbl_TenMay.Text = "Tên Máy: ";
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Location = new System.Drawing.Point(308, 386);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(65, 13);
            this.lbl_TrangThai.TabIndex = 30;
            this.lbl_TrangThai.Text = "Trạng Thái: ";
            // 
            // lbl_ManHinh
            // 
            this.lbl_ManHinh.AutoSize = true;
            this.lbl_ManHinh.Location = new System.Drawing.Point(314, 100);
            this.lbl_ManHinh.Name = "lbl_ManHinh";
            this.lbl_ManHinh.Size = new System.Drawing.Size(59, 13);
            this.lbl_ManHinh.TabIndex = 31;
            this.lbl_ManHinh.Text = "Màn Hình: ";
            // 
            // lbl_Chuot
            // 
            this.lbl_Chuot.AutoSize = true;
            this.lbl_Chuot.Location = new System.Drawing.Point(332, 126);
            this.lbl_Chuot.Name = "lbl_Chuot";
            this.lbl_Chuot.Size = new System.Drawing.Size(41, 13);
            this.lbl_Chuot.TabIndex = 32;
            this.lbl_Chuot.Text = "Chuột: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ghi Chú: ";
            // 
            // lbl_MainBoard
            // 
            this.lbl_MainBoard.AutoSize = true;
            this.lbl_MainBoard.Location = new System.Drawing.Point(309, 230);
            this.lbl_MainBoard.Name = "lbl_MainBoard";
            this.lbl_MainBoard.Size = new System.Drawing.Size(64, 13);
            this.lbl_MainBoard.TabIndex = 34;
            this.lbl_MainBoard.Text = "MainBoard: ";
            // 
            // lbl_RAM
            // 
            this.lbl_RAM.AutoSize = true;
            this.lbl_RAM.Location = new System.Drawing.Point(339, 256);
            this.lbl_RAM.Name = "lbl_RAM";
            this.lbl_RAM.Size = new System.Drawing.Size(34, 13);
            this.lbl_RAM.TabIndex = 35;
            this.lbl_RAM.Text = "RAM:";
            // 
            // txtTenMay
            // 
            this.txtTenMay.Enabled = false;
            this.txtTenMay.Location = new System.Drawing.Point(379, 45);
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.ReadOnly = true;
            this.txtTenMay.Size = new System.Drawing.Size(104, 20);
            this.txtTenMay.TabIndex = 36;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Enabled = false;
            this.txtTenPhong.Location = new System.Drawing.Point(379, 71);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(104, 20);
            this.txtTenPhong.TabIndex = 37;
            // 
            // txtManHinh
            // 
            this.txtManHinh.Enabled = false;
            this.txtManHinh.Location = new System.Drawing.Point(379, 97);
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.ReadOnly = true;
            this.txtManHinh.Size = new System.Drawing.Size(104, 20);
            this.txtManHinh.TabIndex = 38;
            // 
            // txtChuot
            // 
            this.txtChuot.Enabled = false;
            this.txtChuot.Location = new System.Drawing.Point(379, 123);
            this.txtChuot.Name = "txtChuot";
            this.txtChuot.ReadOnly = true;
            this.txtChuot.Size = new System.Drawing.Size(104, 20);
            this.txtChuot.TabIndex = 39;
            // 
            // txtBanPhim
            // 
            this.txtBanPhim.Enabled = false;
            this.txtBanPhim.Location = new System.Drawing.Point(379, 149);
            this.txtBanPhim.Name = "txtBanPhim";
            this.txtBanPhim.ReadOnly = true;
            this.txtBanPhim.Size = new System.Drawing.Size(104, 20);
            this.txtBanPhim.TabIndex = 40;
            // 
            // txtThung
            // 
            this.txtThung.Enabled = false;
            this.txtThung.Location = new System.Drawing.Point(379, 175);
            this.txtThung.Name = "txtThung";
            this.txtThung.ReadOnly = true;
            this.txtThung.Size = new System.Drawing.Size(104, 20);
            this.txtThung.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Bàn Phím:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "CPU:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Thùng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Ổ Cứng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "PSU:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "VGA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Hệ Điều Hành:";
            // 
            // txtMainBoard
            // 
            this.txtMainBoard.Enabled = false;
            this.txtMainBoard.Location = new System.Drawing.Point(379, 227);
            this.txtMainBoard.Name = "txtMainBoard";
            this.txtMainBoard.ReadOnly = true;
            this.txtMainBoard.Size = new System.Drawing.Size(104, 20);
            this.txtMainBoard.TabIndex = 50;
            // 
            // txtCPU
            // 
            this.txtCPU.Enabled = false;
            this.txtCPU.Location = new System.Drawing.Point(379, 201);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.ReadOnly = true;
            this.txtCPU.Size = new System.Drawing.Size(104, 20);
            this.txtCPU.TabIndex = 49;
            // 
            // txtHDH
            // 
            this.txtHDH.Enabled = false;
            this.txtHDH.Location = new System.Drawing.Point(379, 357);
            this.txtHDH.Name = "txtHDH";
            this.txtHDH.ReadOnly = true;
            this.txtHDH.Size = new System.Drawing.Size(104, 20);
            this.txtHDH.TabIndex = 53;
            // 
            // txtOCung
            // 
            this.txtOCung.Enabled = false;
            this.txtOCung.Location = new System.Drawing.Point(379, 279);
            this.txtOCung.Name = "txtOCung";
            this.txtOCung.ReadOnly = true;
            this.txtOCung.Size = new System.Drawing.Size(104, 20);
            this.txtOCung.TabIndex = 52;
            // 
            // txtRAM
            // 
            this.txtRAM.Enabled = false;
            this.txtRAM.Location = new System.Drawing.Point(379, 253);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.ReadOnly = true;
            this.txtRAM.Size = new System.Drawing.Size(104, 20);
            this.txtRAM.TabIndex = 51;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Location = new System.Drawing.Point(379, 383);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(104, 20);
            this.txtTrangThai.TabIndex = 56;
            // 
            // txtVGA
            // 
            this.txtVGA.Enabled = false;
            this.txtVGA.Location = new System.Drawing.Point(379, 305);
            this.txtVGA.Name = "txtVGA";
            this.txtVGA.ReadOnly = true;
            this.txtVGA.Size = new System.Drawing.Size(104, 20);
            this.txtVGA.TabIndex = 55;
            // 
            // txtPSU
            // 
            this.txtPSU.Enabled = false;
            this.txtPSU.Location = new System.Drawing.Point(379, 331);
            this.txtPSU.Name = "txtPSU";
            this.txtPSU.ReadOnly = true;
            this.txtPSU.Size = new System.Drawing.Size(104, 20);
            this.txtPSU.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbGhiChu);
            this.groupBox1.Controls.Add(this.dgvDSMay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaMay);
            this.groupBox1.Controls.Add(this.lbl_MaMay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_TenMay);
            this.groupBox1.Controls.Add(this.lbl_TrangThai);
            this.groupBox1.Controls.Add(this.lbl_ManHinh);
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.lbl_Chuot);
            this.groupBox1.Controls.Add(this.txtVGA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPSU);
            this.groupBox1.Controls.Add(this.lbl_MainBoard);
            this.groupBox1.Controls.Add(this.txtHDH);
            this.groupBox1.Controls.Add(this.lbl_RAM);
            this.groupBox1.Controls.Add(this.txtOCung);
            this.groupBox1.Controls.Add(this.txtTenMay);
            this.groupBox1.Controls.Add(this.txtRAM);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.txtMainBoard);
            this.groupBox1.Controls.Add(this.txtManHinh);
            this.groupBox1.Controls.Add(this.txtCPU);
            this.groupBox1.Controls.Add(this.txtChuot);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBanPhim);
            this.groupBox1.Controls.Add(this.txtThung);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 465);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Máy";
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(379, 410);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.ReadOnly = true;
            this.rtbGhiChu.Size = new System.Drawing.Size(104, 49);
            this.rtbGhiChu.TabIndex = 57;
            this.rtbGhiChu.Text = "";
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
            // frmChiTietPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 550);
            this.Controls.Add(this.lblQLPhongMay);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChiTietPhongMay";
            this.Text = "Chi Tiết Phòng Máy";
            this.Load += new System.EventHandler(this.frm_QLPhongMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSMay;
        private System.Windows.Forms.TextBox txtMaMay;
        private System.Windows.Forms.Label lbl_MaMay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TenMay;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.Label lbl_ManHinh;
        private System.Windows.Forms.Label lbl_Chuot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MainBoard;
        private System.Windows.Forms.Label lbl_RAM;
        private System.Windows.Forms.TextBox txtTenMay;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtManHinh;
        private System.Windows.Forms.TextBox txtChuot;
        private System.Windows.Forms.TextBox txtBanPhim;
        private System.Windows.Forms.TextBox txtThung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMainBoard;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtHDH;
        private System.Windows.Forms.TextBox txtOCung;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtVGA;
        private System.Windows.Forms.TextBox txtPSU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQLPhongMay;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}