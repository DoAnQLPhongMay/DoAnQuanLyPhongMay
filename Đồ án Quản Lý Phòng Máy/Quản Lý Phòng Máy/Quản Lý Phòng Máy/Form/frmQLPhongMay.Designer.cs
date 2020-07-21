namespace Quản_Lý_Phòng_Máy
{
    partial class frmQLPhongMay
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
            this.lblQLPhongMay = new System.Windows.Forms.Label();
            this.grpQLPhongMay = new System.Windows.Forms.GroupBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuongMay = new System.Windows.Forms.TextBox();
            this.lblSoLuongMay = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.dgvDSPhongMay = new System.Windows.Forms.DataGridView();
            this.grpQLPhongMay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongMay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLPhongMay
            // 
            this.lblQLPhongMay.AutoSize = true;
            this.lblQLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPhongMay.Location = new System.Drawing.Point(12, 9);
            this.lblQLPhongMay.Name = "lblQLPhongMay";
            this.lblQLPhongMay.Size = new System.Drawing.Size(504, 61);
            this.lblQLPhongMay.TabIndex = 0;
            this.lblQLPhongMay.Text = "Quản Lý Phòng Máy";
            // 
            // grpQLPhongMay
            // 
            this.grpQLPhongMay.Controls.Add(this.txtTenPhong);
            this.grpQLPhongMay.Controls.Add(this.btnSua);
            this.grpQLPhongMay.Controls.Add(this.btnXoa);
            this.grpQLPhongMay.Controls.Add(this.btnThem);
            this.grpQLPhongMay.Controls.Add(this.txtSoLuongMay);
            this.grpQLPhongMay.Controls.Add(this.lblSoLuongMay);
            this.grpQLPhongMay.Controls.Add(this.lblTenPhong);
            this.grpQLPhongMay.Controls.Add(this.txtMaPhong);
            this.grpQLPhongMay.Controls.Add(this.lblMaPhong);
            this.grpQLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQLPhongMay.Location = new System.Drawing.Point(1, 92);
            this.grpQLPhongMay.Name = "grpQLPhongMay";
            this.grpQLPhongMay.Size = new System.Drawing.Size(502, 189);
            this.grpQLPhongMay.TabIndex = 1;
            this.grpQLPhongMay.TabStop = false;
            this.grpQLPhongMay.Text = "Quán Lý Phòng Máy";
            this.grpQLPhongMay.Enter += new System.EventHandler(this.grp_QLPhongMay_Enter);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(113, 115);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(100, 20);
            this.txtTenPhong.TabIndex = 9;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(289, 132);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 38);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(289, 76);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(289, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 38);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txtSoLuongMay
            // 
            this.txtSoLuongMay.Location = new System.Drawing.Point(113, 69);
            this.txtSoLuongMay.Name = "txtSoLuongMay";
            this.txtSoLuongMay.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongMay.TabIndex = 5;
            // 
            // lblSoLuongMay
            // 
            this.lblSoLuongMay.AutoSize = true;
            this.lblSoLuongMay.Location = new System.Drawing.Point(11, 76);
            this.lblSoLuongMay.Name = "lblSoLuongMay";
            this.lblSoLuongMay.Size = new System.Drawing.Size(92, 13);
            this.lblSoLuongMay.TabIndex = 4;
            this.lblSoLuongMay.Text = "Số Lượng Máy:";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(11, 118);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(73, 13);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = "Tên Phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(113, 32);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(11, 35);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(68, 13);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã Phòng:";
            // 
            // dgvDSPhongMay
            // 
            this.dgvDSPhongMay.AllowUserToAddRows = false;
            this.dgvDSPhongMay.AllowUserToDeleteRows = false;
            this.dgvDSPhongMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhongMay.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDSPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhongMay.Location = new System.Drawing.Point(1, 287);
            this.dgvDSPhongMay.Name = "dgvDSPhongMay";
            this.dgvDSPhongMay.ReadOnly = true;
            this.dgvDSPhongMay.Size = new System.Drawing.Size(502, 203);
            this.dgvDSPhongMay.TabIndex = 2;
            // 
            // frmQLPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 490);
            this.Controls.Add(this.dgvDSPhongMay);
            this.Controls.Add(this.grpQLPhongMay);
            this.Controls.Add(this.lblQLPhongMay);
            this.Name = "frmQLPhongMay";
            this.Text = "Quản Lý Phòng Máy";
            this.Load += new System.EventHandler(this.frm_QLPhongMay_Load);
            this.grpQLPhongMay.ResumeLayout(false);
            this.grpQLPhongMay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLPhongMay;
        private System.Windows.Forms.GroupBox grpQLPhongMay;
        private System.Windows.Forms.TextBox txtSoLuongMay;
        private System.Windows.Forms.Label lblSoLuongMay;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvDSPhongMay;
        private System.Windows.Forms.TextBox txtTenPhong;
    }
}