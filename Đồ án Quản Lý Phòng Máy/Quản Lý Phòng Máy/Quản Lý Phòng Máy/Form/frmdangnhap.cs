using System;
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
        //Khởi tạo các biến lưu trữ.
        Login log = new Login();
        User user = new User();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        //Hàm xử lý quên mật khẩu.
        private void btnQuenMatKhau_Click_1(object sender, EventArgs e)
        {
            //Ẩn frmDangNhap và mở frmQuenMatKhau.
            frmQuenMatKhau frm = new frmQuenMatKhau();
            this.Hide();
            frm.Show();
        }

        //Hàm xử lý khi ấn nút thoát.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }

        //Hàm xử lý khi ấn nút đăng nhập.
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra thông tin đăng nhập.
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin đăng nhập!", "Đăng Nhập Thất Bại");
            }
            else if (log.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text, user))
            {
                //Nếu đăng nhập thành công thì ẩn frmDangNhap và mở frmTrangChu.
                //FormTrangChu frm = new FormTrangChu(user);
                FormTrangChu frm = new FormTrangChu();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.", "Đăng Nhập Thất Bại");
            }
        }
    }
}
