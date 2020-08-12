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
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
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
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_RAM = new System.Windows.Forms.ComboBox();
            this.lbl_RAM = new System.Windows.Forms.Label();
            this.cbo_MainBoard = new System.Windows.Forms.ComboBox();
            this.lbl_MainBoard = new System.Windows.Forms.Label();
            this.cbo_Chuot = new System.Windows.Forms.ComboBox();
            this.lbl_Chuot = new System.Windows.Forms.Label();
            this.cbo_ManHinh = new System.Windows.Forms.ComboBox();
            this.lbl_ManHinh = new System.Windows.Forms.Label();
            this.txt_TenMay = new System.Windows.Forms.TextBox();
            this.lbl_TenMay = new System.Windows.Forms.Label();
            this.txt_MaMay = new System.Windows.Forms.TextBox();
            this.lbl_MaMay = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.grp_QLMay.Controls.Add(this.txtTrangThai);
            this.grp_QLMay.Controls.Add(this.txtMaPhong);
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
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Location = new System.Drawing.Point(326, 79);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(105, 20);
            this.txtTrangThai.TabIndex = 29;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Location = new System.Drawing.Point(102, 79);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(105, 20);
            this.txtMaPhong.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã Phòng: ";
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
            this.grp_ChiTietMay.Controls.Add(this.comboBox5);
            this.grp_ChiTietMay.Controls.Add(this.label7);
            this.grp_ChiTietMay.Controls.Add(this.comboBox6);
            this.grp_ChiTietMay.Controls.Add(this.label8);
            this.grp_ChiTietMay.Controls.Add(this.comboBox7);
            this.grp_ChiTietMay.Controls.Add(this.label9);
            this.grp_ChiTietMay.Controls.Add(this.comboBox8);
            this.grp_ChiTietMay.Controls.Add(this.label10);
            this.grp_ChiTietMay.Controls.Add(this.comboBox1);
            this.grp_ChiTietMay.Controls.Add(this.label3);
            this.grp_ChiTietMay.Controls.Add(this.comboBox2);
            this.grp_ChiTietMay.Controls.Add(this.label4);
            this.grp_ChiTietMay.Controls.Add(this.comboBox3);
            this.grp_ChiTietMay.Controls.Add(this.label5);
            this.grp_ChiTietMay.Controls.Add(this.comboBox4);
            this.grp_ChiTietMay.Controls.Add(this.label6);
            this.grp_ChiTietMay.Controls.Add(this.cbo_RAM);
            this.grp_ChiTietMay.Controls.Add(this.lbl_RAM);
            this.grp_ChiTietMay.Controls.Add(this.cbo_MainBoard);
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
            // txt_GhiChu
            // 
            this.txt_GhiChu.Enabled = false;
            this.txt_GhiChu.Location = new System.Drawing.Point(556, 34);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(114, 20);
            this.txt_GhiChu.TabIndex = 15;
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
            // cbo_RAM
            // 
            this.cbo_RAM.FormattingEnabled = true;
            this.cbo_RAM.Location = new System.Drawing.Point(311, 71);
            this.cbo_RAM.Name = "cbo_RAM";
            this.cbo_RAM.Size = new System.Drawing.Size(108, 21);
            this.cbo_RAM.TabIndex = 13;
            // 
            // lbl_RAM
            // 
            this.lbl_RAM.AutoSize = true;
            this.lbl_RAM.Location = new System.Drawing.Point(231, 74);
            this.lbl_RAM.Name = "lbl_RAM";
            this.lbl_RAM.Size = new System.Drawing.Size(38, 13);
            this.lbl_RAM.TabIndex = 12;
            this.lbl_RAM.Text = "RAM:";
            // 
            // cbo_MainBoard
            // 
            this.cbo_MainBoard.FormattingEnabled = true;
            this.cbo_MainBoard.Location = new System.Drawing.Point(311, 31);
            this.cbo_MainBoard.Name = "cbo_MainBoard";
            this.cbo_MainBoard.Size = new System.Drawing.Size(108, 21);
            this.cbo_MainBoard.TabIndex = 11;
            // 
            // lbl_MainBoard
            // 
            this.lbl_MainBoard.AutoSize = true;
            this.lbl_MainBoard.Location = new System.Drawing.Point(231, 34);
            this.lbl_MainBoard.Name = "lbl_MainBoard";
            this.lbl_MainBoard.Size = new System.Drawing.Size(75, 13);
            this.lbl_MainBoard.TabIndex = 10;
            this.lbl_MainBoard.Text = "MainBoard: ";
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
            this.txt_TenMay.Enabled = false;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(311, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 23;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(311, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2.TabIndex = 21;
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(80, 151);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(114, 21);
            this.comboBox3.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Chuột: ";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(80, 111);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(114, 21);
            this.comboBox4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Màn Hình: ";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(540, 151);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(108, 21);
            this.comboBox5.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "RAM:";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(540, 111);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(108, 21);
            this.comboBox6.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "MainBoard: ";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(540, 71);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(108, 21);
            this.comboBox7.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "RAM:";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(540, 31);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(108, 21);
            this.comboBox8.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "MainBoard: ";
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
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.Button btnTiemKiem;
        private System.Windows.Forms.RadioButton rad_TenMay;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox grp_ChiTietMay;
        private System.Windows.Forms.ComboBox cbo_RAM;
        private System.Windows.Forms.Label lbl_RAM;
        private System.Windows.Forms.ComboBox cbo_MainBoard;
        private System.Windows.Forms.Label lbl_MainBoard;
        private System.Windows.Forms.ComboBox cbo_Chuot;
        private System.Windows.Forms.Label lbl_Chuot;
        private System.Windows.Forms.ComboBox cbo_ManHinh;
        private System.Windows.Forms.Label lbl_ManHinh;
        private System.Windows.Forms.TextBox txt_TenMay;
        private System.Windows.Forms.Label lbl_TenMay;
        private System.Windows.Forms.TextBox txt_MaMay;
        private System.Windows.Forms.Label lbl_MaMay;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
    }
}