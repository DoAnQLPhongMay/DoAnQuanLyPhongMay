﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyPhongMay.Class;
using System.Windows.Forms;

namespace QuanLyPhongMay
{
    public partial class frmDoiMatKhau : Form
    {
        SqlConnection conn = DBUtils.GetDBConnection();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        //Hàm xử lý khi ấn nút thoát.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        //Hàm không sử dụng.
        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }
    }
}
