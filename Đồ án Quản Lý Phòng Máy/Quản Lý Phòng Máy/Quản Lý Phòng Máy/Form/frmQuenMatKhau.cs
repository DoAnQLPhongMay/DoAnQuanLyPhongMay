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
        SqlConnection conn = DBUtils.GetDBConnection();

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
            string query = "SELECT * FROM dtb_TaiKhoan WHERE TenDangNhap = '" + txtTenTaiKhoan.Text + "' AND SDT = '" + txtSDT.Text + "' AND Email = '" + txtEmail.Text + "'";

            if (DBUtils.exeReaderData(query, conn))
            {

                //Hiển thị hộp thoại báo thành công và trả về true.
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
    }
}
