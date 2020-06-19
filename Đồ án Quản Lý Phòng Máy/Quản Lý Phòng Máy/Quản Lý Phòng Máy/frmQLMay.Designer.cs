namespace Quản_Lý_Phòng_Máy
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radTrangThai = new System.Windows.Forms.RadioButton();
            this.radTenMay = new System.Windows.Forms.RadioButton();
            this.radMaMay = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tbnThemMoi = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbHeDieuHanh = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbPSU = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVGA = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbOCung = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRAM = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMainBoard = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCPU = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBanPhim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbChuot = new System.Windows.Forms.Label();
            this.cbManHinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhapTenMay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapMaMay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeDieuHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Aurora", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Máy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.tbnThemMoi);
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNhapTenMay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNhapMaMay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Máy";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mới",
            "Cũ"});
            this.comboBox2.Location = new System.Drawing.Point(596, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(502, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Trạng Thái: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radTrangThai);
            this.groupBox3.Controls.Add(this.radTenMay);
            this.groupBox3.Controls.Add(this.radMaMay);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(22, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 65);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // radTrangThai
            // 
            this.radTrangThai.AutoSize = true;
            this.radTrangThai.Location = new System.Drawing.Point(537, 29);
            this.radTrangThai.Name = "radTrangThai";
            this.radTrangThai.Size = new System.Drawing.Size(87, 17);
            this.radTrangThai.TabIndex = 3;
            this.radTrangThai.TabStop = true;
            this.radTrangThai.Text = "Trạng Thái";
            this.radTrangThai.UseVisualStyleBackColor = true;
            // 
            // radTenMay
            // 
            this.radTenMay.AutoSize = true;
            this.radTenMay.Location = new System.Drawing.Point(398, 29);
            this.radTenMay.Name = "radTenMay";
            this.radTenMay.Size = new System.Drawing.Size(74, 17);
            this.radTenMay.TabIndex = 2;
            this.radTenMay.TabStop = true;
            this.radTenMay.Text = "Tên Máy";
            this.radTenMay.UseVisualStyleBackColor = true;
            // 
            // radMaMay
            // 
            this.radMaMay.AutoSize = true;
            this.radMaMay.Location = new System.Drawing.Point(252, 29);
            this.radMaMay.Name = "radMaMay";
            this.radMaMay.Size = new System.Drawing.Size(69, 17);
            this.radMaMay.TabIndex = 1;
            this.radMaMay.TabStop = true;
            this.radMaMay.Text = "Mã Máy";
            this.radMaMay.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(767, 251);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 34);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(767, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 34);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // tbnThemMoi
            // 
            this.tbnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnThemMoi.Location = new System.Drawing.Point(767, 92);
            this.tbnThemMoi.Name = "tbnThemMoi";
            this.tbnThemMoi.Size = new System.Drawing.Size(97, 34);
            this.tbnThemMoi.TabIndex = 21;
            this.tbnThemMoi.Text = "Thêm Mới";
            this.tbnThemMoi.UseVisualStyleBackColor = false;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Mới",
            "Cũ"});
            this.cbTrangThai.Location = new System.Drawing.Point(833, 34);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(112, 21);
            this.cbTrangThai.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(739, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Trạng Thái: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbHeDieuHanh);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbPSU);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbVGA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbOCung);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbRAM);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbMainBoard);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbCPU);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbCase);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbBanPhim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.cbChuot);
            this.groupBox2.Controls.Add(this.cbManHinh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(22, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 273);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Máy";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(476, 233);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(182, 20);
            this.txtGhiChu.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(395, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Ghi Chú:";
            // 
            // cbHeDieuHanh
            // 
            this.cbHeDieuHanh.FormattingEnabled = true;
            this.cbHeDieuHanh.Location = new System.Drawing.Point(108, 233);
            this.cbHeDieuHanh.Name = "cbHeDieuHanh";
            this.cbHeDieuHanh.Size = new System.Drawing.Size(181, 21);
            this.cbHeDieuHanh.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Hệ Điều Hành: ";
            // 
            // cbPSU
            // 
            this.cbPSU.FormattingEnabled = true;
            this.cbPSU.Location = new System.Drawing.Point(476, 190);
            this.cbPSU.Name = "cbPSU";
            this.cbPSU.Size = new System.Drawing.Size(182, 21);
            this.cbPSU.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "PSU: ";
            // 
            // cbVGA
            // 
            this.cbVGA.FormattingEnabled = true;
            this.cbVGA.Location = new System.Drawing.Point(476, 152);
            this.cbVGA.Name = "cbVGA";
            this.cbVGA.Size = new System.Drawing.Size(182, 21);
            this.cbVGA.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "VGA: ";
            // 
            // cbOCung
            // 
            this.cbOCung.FormattingEnabled = true;
            this.cbOCung.Location = new System.Drawing.Point(476, 112);
            this.cbOCung.Name = "cbOCung";
            this.cbOCung.Size = new System.Drawing.Size(182, 21);
            this.cbOCung.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ổ Cứng: ";
            // 
            // cbRAM
            // 
            this.cbRAM.FormattingEnabled = true;
            this.cbRAM.Location = new System.Drawing.Point(476, 71);
            this.cbRAM.Name = "cbRAM";
            this.cbRAM.Size = new System.Drawing.Size(182, 21);
            this.cbRAM.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ram: ";
            // 
            // cbMainBoard
            // 
            this.cbMainBoard.FormattingEnabled = true;
            this.cbMainBoard.Location = new System.Drawing.Point(476, 31);
            this.cbMainBoard.Name = "cbMainBoard";
            this.cbMainBoard.Size = new System.Drawing.Size(182, 21);
            this.cbMainBoard.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "MainBoard: ";
            // 
            // cbCPU
            // 
            this.cbCPU.FormattingEnabled = true;
            this.cbCPU.Location = new System.Drawing.Point(108, 190);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(181, 21);
            this.cbCPU.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "CPU: ";
            // 
            // cbCase
            // 
            this.cbCase.FormattingEnabled = true;
            this.cbCase.Location = new System.Drawing.Point(108, 152);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(181, 21);
            this.cbCase.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Case: ";
            // 
            // cbBanPhim
            // 
            this.cbBanPhim.FormattingEnabled = true;
            this.cbBanPhim.Location = new System.Drawing.Point(108, 112);
            this.cbBanPhim.Name = "cbBanPhim";
            this.cbBanPhim.Size = new System.Drawing.Size(181, 21);
            this.cbBanPhim.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bàn Phím: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // cbChuot
            // 
            this.cbChuot.AutoSize = true;
            this.cbChuot.Location = new System.Drawing.Point(7, 74);
            this.cbChuot.Name = "cbChuot";
            this.cbChuot.Size = new System.Drawing.Size(48, 13);
            this.cbChuot.TabIndex = 2;
            this.cbChuot.Text = "Chuột: ";
            // 
            // cbManHinh
            // 
            this.cbManHinh.FormattingEnabled = true;
            this.cbManHinh.Location = new System.Drawing.Point(108, 31);
            this.cbManHinh.Name = "cbManHinh";
            this.cbManHinh.Size = new System.Drawing.Size(181, 21);
            this.cbManHinh.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Màn Hình: ";
            // 
            // txtNhapTenMay
            // 
            this.txtNhapTenMay.Location = new System.Drawing.Point(328, 31);
            this.txtNhapTenMay.Name = "txtNhapTenMay";
            this.txtNhapTenMay.Size = new System.Drawing.Size(143, 20);
            this.txtNhapTenMay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Máy: ";
            // 
            // txtNhapMaMay
            // 
            this.txtNhapMaMay.Location = new System.Drawing.Point(87, 34);
            this.txtNhapMaMay.Name = "txtNhapMaMay";
            this.txtNhapMaMay.Size = new System.Drawing.Size(143, 20);
            this.txtNhapMaMay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Máy: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMay,
            this.TenMay,
            this.ManHinh,
            this.Chuot,
            this.BanPhim,
            this.Case,
            this.CPU,
            this.MainBoard,
            this.RAM,
            this.OCung,
            this.VGA,
            this.SPU,
            this.HeDieuHanh,
            this.TrangThai,
            this.GhiChu});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(1, 532);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(957, 205);
            this.dataGridView1.TabIndex = 2;
            // 
            // MaMay
            // 
            this.MaMay.HeaderText = "Mã Máy";
            this.MaMay.Name = "MaMay";
            this.MaMay.ReadOnly = true;
            this.MaMay.Width = 70;
            // 
            // TenMay
            // 
            this.TenMay.HeaderText = "Tên Máy";
            this.TenMay.Name = "TenMay";
            this.TenMay.ReadOnly = true;
            this.TenMay.Width = 74;
            // 
            // ManHinh
            // 
            this.ManHinh.HeaderText = "Màn Hình";
            this.ManHinh.Name = "ManHinh";
            this.ManHinh.ReadOnly = true;
            this.ManHinh.Width = 78;
            // 
            // Chuot
            // 
            this.Chuot.HeaderText = "Chuột";
            this.Chuot.Name = "Chuot";
            this.Chuot.ReadOnly = true;
            this.Chuot.Width = 60;
            // 
            // BanPhim
            // 
            this.BanPhim.HeaderText = "Bàn Phím";
            this.BanPhim.Name = "BanPhim";
            this.BanPhim.ReadOnly = true;
            this.BanPhim.Width = 79;
            // 
            // Case
            // 
            this.Case.HeaderText = "Case";
            this.Case.Name = "Case";
            this.Case.ReadOnly = true;
            this.Case.Width = 56;
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            this.CPU.Width = 54;
            // 
            // MainBoard
            // 
            this.MainBoard.HeaderText = "MainBoard";
            this.MainBoard.Name = "MainBoard";
            this.MainBoard.ReadOnly = true;
            this.MainBoard.Width = 83;
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.Width = 56;
            // 
            // OCung
            // 
            this.OCung.HeaderText = "Ổ Cứng";
            this.OCung.Name = "OCung";
            this.OCung.ReadOnly = true;
            this.OCung.Width = 68;
            // 
            // VGA
            // 
            this.VGA.HeaderText = "VGA";
            this.VGA.Name = "VGA";
            this.VGA.ReadOnly = true;
            this.VGA.Width = 54;
            // 
            // SPU
            // 
            this.SPU.HeaderText = "SPU";
            this.SPU.Name = "SPU";
            this.SPU.ReadOnly = true;
            this.SPU.Width = 54;
            // 
            // HeDieuHanh
            // 
            this.HeDieuHanh.HeaderText = "Hệ Điều Hành";
            this.HeDieuHanh.Name = "HeDieuHanh";
            this.HeDieuHanh.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 84;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Width = 70;
            // 
            // frmQLMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 739);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLMay";
            this.Text = "frmQLMay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapTenMay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapMaMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBanPhim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cbChuot;
        private System.Windows.Forms.ComboBox cbManHinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCPU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPSU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVGA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbOCung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRAM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMainBoard;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button tbnThemMoi;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbHeDieuHanh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radTenMay;
        private System.Windows.Forms.RadioButton radMaMay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radTrangThai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn VGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeDieuHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;
    }
}