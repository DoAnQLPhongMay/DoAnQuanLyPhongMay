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
    public partial class frmDangNhap : Form
    {
        /*CaiDat clsCD = new CaiDat();
        DataProvider cls = new DataProvider();
        Login log = new Login();*/

        SqlConnection conn = DBUtils.GetDBConnection();
        User user = new User();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        //Hàm xử lý đăng nhập.
        private bool login()
        {
            //Thực hiện kết nối CSDL.
            DBUtils.openConnection(conn);

            //Câu lệnh truy vấn.
            string query = "SELECT * FROM dtb_TaiKhoan WHERE TenDangNhap = '" + txtTenDangNhap.Text + "' AND MatKhau = '" + txtMatKhau.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

            //Chạy truy vấn.

            SqlDataReader dr = cmd.ExecuteReader();

            //Kiểm tra kết quả truy vấn, xuất hộp thoại thông báo và lưu lại dữ liệu.
            if (dr.Read())
            {
                //Hiển thị hộp thoại báo thành công và trả về true.
                MessageBox.Show("Đăng Nhập Thành Công.");
                user.DangNhap(dr[0].ToString(), dr[3].ToString(), Convert.ToBoolean(dr[9]));
                return true;
            }

            //Thực hiên đóng kết nối CSDL.
            DBUtils.closeConnection(conn);

            //Hiển thị hộp thoại báo thất bại.
            MessageBox.Show("Đăng Nhập Thất Bại. \nSai Tên Tài Khoản Hoặc Mật Khẩu.");
            return false;
        }

        //Hàm xử lý khi ấn nút thoát.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Thoát khỏi chương trình.
            Application.Exit();
        }

        //Hàm xử lý khi ấn nút đăng nhập.
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra thông tin đăng nhập.
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin đăng nhập!");
            }
            else if (login())
            {
                //Nếu đăng nhập thành công thì ẩn frmDangNhap và mở frmTrangChu.
                frmTrangChu frm = new frmTrangChu(user);
                this.Hide();
                frm.Show();
            }
        }

        private void btnQuenMatKhau_Click_1(object sender, EventArgs e)
        {
            //Ẩn frmDangNhap và mở frmQuenMatKhau.
            frmQuenMatKhau frm = new frmQuenMatKhau();
            this.Hide();
            frm.Show();
        }

        //Hàm không sử dụng. --------------------------------------------------------------------------------------------------//
        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
        }
        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }
    }
}
