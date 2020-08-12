namespace QuanLyPhongMay
{
    partial class frmQLMay
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
            this.dgv_DSMay = new System.Windows.Forms.DataGridView();
            this.lbl_QLMay = new System.Windows.Forms.Label();
            this.grp_QLMay = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtNgayCapNhat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.btnTiemKiem = new System.Windows.Forms.Button();
            this.rad_TenMay = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.grp_ChiTietMay = new System.Windows.Forms.GroupBox();
            this.cb_PSU = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_VGA = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_OCung = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_RAM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_MainBoard = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Case = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_BanPhim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_HDH = new System.Windows.Forms.ComboBox();
            this.lbl_RAM = new System.Windows.Forms.Label();
            this.cb_CPU = new System.Windows.Forms.ComboBox();
            this.lbl_MainBoard = new System.Windows.Forms.Label();
            this.cbo_Chuot = new System.Windows.Forms.ComboBox();
            this.lbl_Chuot = new System.Windows.Forms.Label();
            this.cbo_ManHinh = new System.Windows.Forms.ComboBox();
            this.lbl_ManHinh = new System.Windows.Forms.Label();
            this.txt_TenMay = new System.Windows.Forms.TextBox();
            this.lbl_TenMay = new System.Windows.Forms.Label();
            this.txt_MaMay = new System.Windows.Forms.TextBox();
            this.lbl_MaMay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSMay)).BeginInit();
            this.grp_QLMay.SuspendLayout();
            this.grp_TimKiem.SuspendLayout();
            this.grp_ChiTietMay.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DSMay
            // 
            this.dgv_DSMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DSMay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DSMay.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_DSMay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_DSMay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_DSMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSMay.EnableHeadersVisualStyles = false;
            this.dgv_DSMay.Location = new System.Drawing.Point(0, 481);
            this.dgv_DSMay.Name = "dgv_DSMay";
            this.dgv_DSMay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_DSMay.Size = new System.Drawing.Size(844, 266);
            this.dgv_DSMay.TabIndex = 5;
            this.dgv_DSMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSMay_CellClick);
            this.dgv_DSMay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSMay_CellContentClick);
            this.dgv_DSMay.Click += new System.EventHandler(this.dgv_DSMay_Click);
            // 
            // lbl_QLMay
            // 
            this.lbl_QLMay.AutoSize = true;
            this.lbl_QLMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLMay.Location = new System.Drawing.Point(12, 9);
            this.lbl_QLMay.Name = "lbl_QLMay";
            this.lbl_QLMay.Size = new System.Drawing.Size(339, 61);
            this.lbl_QLMay.TabIndex = 3;
            this.lbl_QLMay.Text = "Quản Lý Máy";
            // 
            // grp_QLMay
            // 
            this.grp_QLMay.Controls.Add(this.cbPhong);
            this.grp_QLMay.Controls.Add(this.cbTrangThai);
            this.grp_QLMay.Controls.Add(this.label11);
            this.grp_QLMay.Controls.Add(this.dtNgayCapNhat);
            this.grp_QLMay.Controls.Add(this.label1);
            this.grp_QLMay.Controls.Add(this.lbl_TrangThai);
            this.grp_QLMay.Controls.Add(this.grp_TimKiem);
            this.grp_QLMay.Controls.Add(this.btn_Xoa);
            this.grp_QLMay.Controls.Add(this.btn_Sua);
            this.grp_QLMay.Controls.Add(this.btn_ThemMoi);
            this.grp_QLMay.Controls.Add(this.grp_ChiTietMay);
            this.grp_QLMay.Controls.Add(this.txt_TenMay);
            this.grp_QLMay.Controls.Add(this.lbl_TenMay);
            this.grp_QLMay.Controls.Add(this.txt_MaMay);
            this.grp_QLMay.Controls.Add(this.lbl_MaMay);
            this.grp_QLMay.Controls.Add(this.label2);
            this.grp_QLMay.Controls.Add(this.txt_GhiChu);
            this.grp_QLMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_QLMay.Location = new System.Drawing.Point(12, 73);
            this.grp_QLMay.Name = "grp_QLMay";
            this.grp_QLMay.Size = new System.Drawing.Size(832, 402);
            this.grp_QLMay.TabIndex = 4;
            this.grp_QLMay.TabStop = false;
            this.grp_QLMay.Text = "Quản Lý Máy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(473, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ngày: ";
            // 
            // dtNgayCapNhat
            // 
            this.dtNgayCapNhat.Enabled = false;
            this.dtNgayCapNhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCapNhat.Location = new System.Drawing.Point(556, 75);
            this.dtNgayCapNhat.Name = "dtNgayCapNhat";
            this.dtNgayCapNhat.Size = new System.Drawing.Size(114, 20);
            this.dtNgayCapNhat.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Phòng: ";
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Location = new System.Drawing.Point(246, 82);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(77, 13);
            this.lbl_TrangThai.TabIndex = 25;
            this.lbl_TrangThai.Text = "Trạng Thái: ";
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.btnTiemKiem);
            this.grp_TimKiem.Controls.Add(this.rad_TenMay);
            this.grp_TimKiem.Controls.Add(this.txt_TimKiem);
            this.grp_TimKiem.Location = new System.Drawing.Point(22, 327);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(668, 65);
            this.grp_TimKiem.TabIndex = 24;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // btnTiemKiem
            // 
            this.btnTiemKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTiemKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiemKiem.Location = new System.Drawing.Point(551, 20);
            this.btnTiemKiem.Name = "btnTiemKiem";
            this.btnTiemKiem.Size = new System.Drawing.Size(97, 34);
            this.btnTiemKiem.TabIndex = 30;
            this.btnTiemKiem.Text = "Tìm Kiếm";
            this.btnTiemKiem.UseVisualStyleBackColor = false;
            this.btnTiemKiem.Click += new System.EventHandler(this.btnTiemKiem_Click);
            // 
            // rad_TenMay
            // 
            this.rad_TenMay.AutoSize = true;
            this.rad_TenMay.Location = new System.Drawing.Point(408, 29);
            this.rad_TenMay.Name = "rad_TenMay";
            this.rad_TenMay.Size = new System.Drawing.Size(74, 17);
            this.rad_TenMay.TabIndex = 2;
            this.rad_TenMay.TabStop = true;
            this.rad_TenMay.Text = "Tên Máy";
            this.rad_TenMay.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(10, 28);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(307, 20);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Location = new System.Drawing.Point(717, 259);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(97, 34);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Location = new System.Drawing.Point(717, 204);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(97, 34);
            this.btn_Sua.TabIndex = 22;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemMoi.Location = new System.Drawing.Point(717, 141);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(97, 34);
            this.btn_ThemMoi.TabIndex = 21;
            this.btn_ThemMoi.Text = "Thêm Mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = false;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // grp_ChiTietMay
            // 
            this.grp_ChiTietMay.Controls.Add(this.cb_PSU);
            this.grp_ChiTietMay.Controls.Add(this.label8);
            this.grp_ChiTietMay.Controls.Add(this.cb_VGA);
            this.grp_ChiTietMay.Controls.Add(this.label9);
            this.grp_ChiTietMay.Controls.Add(this.cb_OCung);
            this.grp_ChiTietMay.Controls.Add(this.label10);
            this.grp_ChiTietMay.Controls.Add(this.cb_RAM);
            this.grp_ChiTietMay.Controls.Add(this.label3);
            this.grp_ChiTietMay.Controls.Add(this.cb_MainBoard);
            this.grp_ChiTietMay.Controls.Add(this.label4);
            this.grp_ChiTietMay.Controls.Add(this.cb_Case);
            this.grp_ChiTietMay.Controls.Add(this.label5);
            this.grp_ChiTietMay.Controls.Add(this.cb_BanPhim);
            this.grp_ChiTietMay.Controls.Add(this.label6);
            this.grp_ChiTietMay.Controls.Add(this.cb_HDH);
            this.grp_ChiTietMay.Controls.Add(this.lbl_RAM);
            this.grp_ChiTietMay.Controls.Add(this.cb_CPU);
            this.grp_ChiTietMay.Controls.Add(this.lbl_MainBoard);
            this.grp_ChiTietMay.Controls.Add(this.cbo_Chuot);
            this.grp_ChiTietMay.Controls.Add(this.lbl_Chuot);
            this.grp_ChiTietMay.Controls.Add(this.cbo_ManHinh);
            this.grp_ChiTietMay.Controls.Add(this.lbl_ManHinh);
            this.grp_ChiTietMay.Location = new System.Drawing.Point(22, 121);
            this.grp_ChiTietMay.Name = "grp_ChiTietMay";
            this.grp_ChiTietMay.Size = new System.Drawing.Size(668, 192);
            this.grp_ChiTietMay.TabIndex = 4;
            this.grp_ChiTietMay.TabStop = false;
            this.grp_ChiTietMay.Text = "Chi Tiết Máy";
            // 
            // cb_PSU
            // 
            this.cb_PSU.FormattingEnabled = true;
            this.cb_PSU.Location = new System.Drawing.Point(540, 111);
            this.cb_PSU.Name = "cb_PSU";
            this.cb_PSU.Size = new System.Drawing.Size(108, 21);
            this.cb_PSU.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "PSU: ";
            // 
            // cb_VGA
            // 
            this.cb_VGA.FormattingEnabled = true;
            this.cb_VGA.Location = new System.Drawing.Point(540, 71);
            this.cb_VGA.Name = "cb_VGA";
            this.cb_VGA.Size = new System.Drawing.Size(108, 21);
            this.cb_VGA.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "VGA:";
            // 
            // cb_OCung
            // 
            this.cb_OCung.FormattingEnabled = true;
            this.cb_OCung.Location = new System.Drawing.Point(540, 31);
            this.cb_OCung.Name = "cb_OCung";
            this.cb_OCung.Size = new System.Drawing.Size(108, 21);
            this.cb_OCung.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ổ Cứng: ";
            // 
            // cb_RAM
            // 
            this.cb_RAM.FormattingEnabled = true;
            this.cb_RAM.Location = new System.Drawing.Point(311, 151);
            this.cb_RAM.Name = "cb_RAM";
            this.cb_RAM.Size = new System.Drawing.Size(108, 21);
            this.cb_RAM.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "RAM:";
            // 
            // cb_MainBoard
            // 
            this.cb_MainBoard.FormattingEnabled = true;
            this.cb_MainBoard.Location = new System.Drawing.Point(311, 111);
            this.cb_MainBoard.Name = "cb_MainBoard";
            this.cb_MainBoard.Size = new System.Drawing.Size(108, 21);
            this.cb_MainBoard.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "MainBoard: ";
            // 
            // cb_Case
            // 
            this.cb_Case.FormattingEnabled = true;
            this.cb_Case.Location = new System.Drawing.Point(80, 151);
            this.cb_Case.Name = "cb_Case";
            this.cb_Case.Size = new System.Drawing.Size(114, 21);
            this.cb_Case.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Case: ";
            // 
            // cb_BanPhim
            // 
            this.cb_BanPhim.FormattingEnabled = true;
            this.cb_BanPhim.Location = new System.Drawing.Point(80, 111);
            this.cb_BanPhim.Name = "cb_BanPhim";
            this.cb_BanPhim.Size = new System.Drawing.Size(114, 21);
            this.cb_BanPhim.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bàn Phím: ";
            // 
            // cb_HDH
            // 
            this.cb_HDH.FormattingEnabled = true;
            this.cb_HDH.Location = new System.Drawing.Point(311, 71);
            this.cb_HDH.Name = "cb_HDH";
            this.cb_HDH.Size = new System.Drawing.Size(108, 21);
            this.cb_HDH.TabIndex = 13;
            // 
            // lbl_RAM
            // 
            this.lbl_RAM.AutoSize = true;
            this.lbl_RAM.Location = new System.Drawing.Point(231, 74);
            this.lbl_RAM.Name = "lbl_RAM";
            this.lbl_RAM.Size = new System.Drawing.Size(38, 13);
            this.lbl_RAM.TabIndex = 12;
            this.lbl_RAM.Text = "HĐH:";
            // 
            // cb_CPU
            // 
            this.cb_CPU.FormattingEnabled = true;
            this.cb_CPU.Location = new System.Drawing.Point(311, 31);
            this.cb_CPU.Name = "cb_CPU";
            this.cb_CPU.Size = new System.Drawing.Size(108, 21);
            this.cb_CPU.TabIndex = 11;
            // 
            // lbl_MainBoard
            // 
            this.lbl_MainBoard.AutoSize = true;
            this.lbl_MainBoard.Location = new System.Drawing.Point(231, 34);
            this.lbl_MainBoard.Name = "lbl_MainBoard";
            this.lbl_MainBoard.Size = new System.Drawing.Size(40, 13);
            this.lbl_MainBoard.TabIndex = 10;
            this.lbl_MainBoard.Text = "CPU: ";
            // 
            // cbo_Chuot
            // 
            this.cbo_Chuot.FormattingEnabled = true;
            this.cbo_Chuot.Location = new System.Drawing.Point(80, 71);
            this.cbo_Chuot.Name = "cbo_Chuot";
            this.cbo_Chuot.Size = new System.Drawing.Size(114, 21);
            this.cbo_Chuot.TabIndex = 3;
            // 
            // lbl_Chuot
            // 
            this.lbl_Chuot.AutoSize = true;
            this.lbl_Chuot.Location = new System.Drawing.Point(7, 74);
            this.lbl_Chuot.Name = "lbl_Chuot";
            this.lbl_Chuot.Size = new System.Drawing.Size(48, 13);
            this.lbl_Chuot.TabIndex = 2;
            this.lbl_Chuot.Text = "Chuột: ";
            // 
            // cbo_ManHinh
            // 
            this.cbo_ManHinh.FormattingEnabled = true;
            this.cbo_ManHinh.Location = new System.Drawing.Point(80, 31);
            this.cbo_ManHinh.Name = "cbo_ManHinh";
            this.cbo_ManHinh.Size = new System.Drawing.Size(114, 21);
            this.cbo_ManHinh.TabIndex = 1;
            // 
            // lbl_ManHinh
            // 
            this.lbl_ManHinh.AutoSize = true;
            this.lbl_ManHinh.Location = new System.Drawing.Point(7, 34);
            this.lbl_ManHinh.Name = "lbl_ManHinh";
            this.lbl_ManHinh.Size = new System.Drawing.Size(69, 13);
            this.lbl_ManHinh.TabIndex = 0;
            this.lbl_ManHinh.Text = "Màn Hình: ";
            // 
            // txt_TenMay
            // 
            this.txt_TenMay.Location = new System.Drawing.Point(326, 34);
            this.txt_TenMay.Name = "txt_TenMay";
            this.txt_TenMay.Size = new System.Drawing.Size(105, 20);
            this.txt_TenMay.TabIndex = 3;
            // 
            // lbl_TenMay
            // 
            this.lbl_TenMay.AutoSize = true;
            this.lbl_TenMay.Location = new System.Drawing.Point(246, 37);
            this.lbl_TenMay.Name = "lbl_TenMay";
            this.lbl_TenMay.Size = new System.Drawing.Size(64, 13);
            this.lbl_TenMay.TabIndex = 2;
            this.lbl_TenMay.Text = "Tên Máy: ";
            // 
            // txt_MaMay
            // 
            this.txt_MaMay.Enabled = false;
            this.txt_MaMay.Location = new System.Drawing.Point(102, 34);
            this.txt_MaMay.Name = "txt_MaMay";
            this.txt_MaMay.Size = new System.Drawing.Size(104, 20);
            this.txt_MaMay.TabIndex = 1;
            // 
            // lbl_MaMay
            // 
            this.lbl_MaMay.AutoSize = true;
            this.lbl_MaMay.Location = new System.Drawing.Point(29, 37);
            this.lbl_MaMay.Name = "lbl_MaMay";
            this.lbl_MaMay.Size = new System.Drawing.Size(59, 13);
            this.lbl_MaMay.TabIndex = 0;
            this.lbl_MaMay.Text = "Mã Máy: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ghi Chú: ";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(556, 34);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(114, 20);
            this.txt_GhiChu.TabIndex = 15;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(326, 79);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(105, 21);
            this.cbTrangThai.TabIndex = 32;
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(102, 79);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(104, 21);
            this.cbPhong.TabIndex = 33;
            // 
            // frmQLMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 749);
            this.Controls.Add(this.dgv_DSMay);
            this.Controls.Add(this.lbl_QLMay);
            this.Controls.Add(this.grp_QLMay);
            this.Name = "frmQLMay";
            this.Text = "Quản Lý Máy";
            this.Load += new System.EventHandler(this.frmQLMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSMay)).EndInit();
            this.grp_QLMay.ResumeLayout(false);
            this.grp_QLMay.PerformLayout();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            this.grp_ChiTietMay.ResumeLayout(false);
            this.grp_ChiTietMay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DSMay;
        private System.Windows.Forms.Label lbl_QLMay;
        private System.Windows.Forms.GroupBox grp_QLMay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.Button btnTiemKiem;
        private System.Windows.Forms.RadioButton rad_TenMay;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox grp_ChiTietMay;
        private System.Windows.Forms.ComboBox cb_HDH;
        private System.Windows.Forms.Label lbl_RAM;
        private System.Windows.Forms.ComboBox cb_CPU;
        private System.Windows.Forms.Label lbl_MainBoard;
        private System.Windows.Forms.ComboBox cbo_Chuot;
        private System.Windows.Forms.Label lbl_Chuot;
        private System.Windows.Forms.ComboBox cbo_ManHinh;
        private System.Windows.Forms.Label lbl_ManHinh;
        private System.Windows.Forms.TextBox txt_TenMay;
        private System.Windows.Forms.Label lbl_TenMay;
        private System.Windows.Forms.TextBox txt_MaMay;
        private System.Windows.Forms.Label lbl_MaMay;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.ComboBox cb_PSU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_VGA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_OCung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_RAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_MainBoard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Case;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_BanPhim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtNgayCapNhat;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.ComboBox cbTrangThai;
    }
}