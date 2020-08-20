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
    public partial class frmQuenMatKhau : Form
    {
        Login log = new Login();

        public frmQuenMatKhau()
        {
            InitializeComponent();
            MessageBox.Show("Để khôi phục mật khẩu vui lòng nhập:\n -Tên tài khoản.\n -Email.\n -Số điện thoại.");
        }

        //Hàm xử lý khi ấn nút thoát.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        private bool kiemTra()
        {
            if (log.XacThuc(Convert.ToInt32(txtSDT.Text), txtEmail.Text, txtTenTaiKhoan.Text))
            {
                MessageBox.Show("Kiểm tra thành công.");
                return true;
            }

            MessageBox.Show("Thông tin tài khoản không khớp.");
            return false;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if(txtTenTaiKhoan.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin kiểm tra tài khoản!");
            }
            else if (kiemTra())
            {
                frmDoiMatKhau frm = new frmDoiMatKhau(txtTenTaiKhoan.Text);
                this.Hide();
                frm.Show();
            }
        }

        //Hàm không sử dụng. ------------------------------------------------------------------------------------------------------//
        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
