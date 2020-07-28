using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyPhongMay
{
    public partial class frmDangNhap : Form
    {

        CaiDat clsCD = new CaiDat();
        DataProvider cls = new DataProvider();
        Login log = new Login();
        public frmDangNhap()
        {
            InitializeComponent();
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
            if (log.XacThuc(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                frmTrangChu frm = new frmTrangChu();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
