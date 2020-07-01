namespace Quản_Lý_Phòng_Máy
{
    partial class frm_QLPhongMay
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
            this.lbl_QLPhongMay = new System.Windows.Forms.Label();
            this.grp_QLPhongMay = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_SoLuongMay = new System.Windows.Forms.TextBox();
            this.lbl_SoLuongMay = new System.Windows.Forms.Label();
            this.cbo_TenPhong = new System.Windows.Forms.ComboBox();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.lbl_MaPhong = new System.Windows.Forms.Label();
            this.dgv_DSPhongMay = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoluongMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_QLPhongMay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhongMay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_QLPhongMay
            // 
            this.lbl_QLPhongMay.AutoSize = true;
            this.lbl_QLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLPhongMay.Location = new System.Drawing.Point(12, 9);
            this.lbl_QLPhongMay.Name = "lbl_QLPhongMay";
            this.lbl_QLPhongMay.Size = new System.Drawing.Size(504, 61);
            this.lbl_QLPhongMay.TabIndex = 0;
            this.lbl_QLPhongMay.Text = "Quản Lý Phòng Máy";
            // 
            // grp_QLPhongMay
            // 
            this.grp_QLPhongMay.Controls.Add(this.btn_Sua);
            this.grp_QLPhongMay.Controls.Add(this.btn_Xoa);
            this.grp_QLPhongMay.Controls.Add(this.btn_Them);
            this.grp_QLPhongMay.Controls.Add(this.txt_SoLuongMay);
            this.grp_QLPhongMay.Controls.Add(this.lbl_SoLuongMay);
            this.grp_QLPhongMay.Controls.Add(this.cbo_TenPhong);
            this.grp_QLPhongMay.Controls.Add(this.lbl_TenPhong);
            this.grp_QLPhongMay.Controls.Add(this.txt_MaPhong);
            this.grp_QLPhongMay.Controls.Add(this.lbl_MaPhong);
            this.grp_QLPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_QLPhongMay.Location = new System.Drawing.Point(1, 92);
            this.grp_QLPhongMay.Name = "grp_QLPhongMay";
            this.grp_QLPhongMay.Size = new System.Drawing.Size(502, 189);
            this.grp_QLPhongMay.TabIndex = 1;
            this.grp_QLPhongMay.TabStop = false;
            this.grp_QLPhongMay.Text = "Quán Lý Phòng Máy";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Location = new System.Drawing.Point(289, 132);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 38);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Location = new System.Drawing.Point(289, 76);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 38);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Location = new System.Drawing.Point(289, 24);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 38);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm Mới";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // txt_SoLuongMay
            // 
            this.txt_SoLuongMay.Location = new System.Drawing.Point(113, 69);
            this.txt_SoLuongMay.Name = "txt_SoLuongMay";
            this.txt_SoLuongMay.Size = new System.Drawing.Size(100, 20);
            this.txt_SoLuongMay.TabIndex = 5;
            // 
            // lbl_SoLuongMay
            // 
            this.lbl_SoLuongMay.AutoSize = true;
            this.lbl_SoLuongMay.Location = new System.Drawing.Point(11, 76);
            this.lbl_SoLuongMay.Name = "lbl_SoLuongMay";
            this.lbl_SoLuongMay.Size = new System.Drawing.Size(92, 13);
            this.lbl_SoLuongMay.TabIndex = 4;
            this.lbl_SoLuongMay.Text = "Số Lượng Máy:";
            // 
            // cbo_TenPhong
            // 
            this.cbo_TenPhong.FormattingEnabled = true;
            this.cbo_TenPhong.Location = new System.Drawing.Point(113, 115);
            this.cbo_TenPhong.Name = "cbo_TenPhong";
            this.cbo_TenPhong.Size = new System.Drawing.Size(103, 21);
            this.cbo_TenPhong.TabIndex = 3;
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Location = new System.Drawing.Point(11, 118);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(73, 13);
            this.lbl_TenPhong.TabIndex = 2;
            this.lbl_TenPhong.Text = "Tên Phòng:";
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Location = new System.Drawing.Point(113, 32);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(100, 20);
            this.txt_MaPhong.TabIndex = 1;
            // 
            // lbl_MaPhong
            // 
            this.lbl_MaPhong.AutoSize = true;
            this.lbl_MaPhong.Location = new System.Drawing.Point(11, 35);
            this.lbl_MaPhong.Name = "lbl_MaPhong";
            this.lbl_MaPhong.Size = new System.Drawing.Size(68, 13);
            this.lbl_MaPhong.TabIndex = 0;
            this.lbl_MaPhong.Text = "Mã Phòng:";
            // 
            // dgv_DSPhongMay
            // 
            this.dgv_DSPhongMay.AllowUserToAddRows = false;
            this.dgv_DSPhongMay.AllowUserToDeleteRows = false;
            this.dgv_DSPhongMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSPhongMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.SoluongMay});
            this.dgv_DSPhongMay.Location = new System.Drawing.Point(1, 287);
            this.dgv_DSPhongMay.Name = "dgv_DSPhongMay";
            this.dgv_DSPhongMay.ReadOnly = true;
            this.dgv_DSPhongMay.Size = new System.Drawing.Size(502, 203);
            this.dgv_DSPhongMay.TabIndex = 2;
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // SoluongMay
            // 
            this.SoluongMay.HeaderText = "Số Lượng Máy";
            this.SoluongMay.Name = "SoluongMay";
            this.SoluongMay.ReadOnly = true;
            // 
            // frm_QLPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 490);
            this.Controls.Add(this.dgv_DSPhongMay);
            this.Controls.Add(this.grp_QLPhongMay);
            this.Controls.Add(this.lbl_QLPhongMay);
            this.Name = "frm_QLPhongMay";
            this.Text = "Quản Lý Phòng Máy";
            this.grp_QLPhongMay.ResumeLayout(false);
            this.grp_QLPhongMay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhongMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QLPhongMay;
        private System.Windows.Forms.GroupBox grp_QLPhongMay;
        private System.Windows.Forms.TextBox txt_SoLuongMay;
        private System.Windows.Forms.Label lbl_SoLuongMay;
        private System.Windows.Forms.ComboBox cbo_TenPhong;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.Label lbl_MaPhong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_DSPhongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoluongMay;
    }
}