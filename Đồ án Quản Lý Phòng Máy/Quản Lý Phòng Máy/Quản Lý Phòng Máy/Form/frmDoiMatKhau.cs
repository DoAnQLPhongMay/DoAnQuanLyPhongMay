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
    public partial class frmDoiMatKhau : Form
    {
        SqlConnection conn = DBUtils.GetDBConnection();
        string taiKhoan;

        public frmDoiMatKhau(string tenTK)
        {
            InitializeComponent();
            MessageBox.Show("Để đổi mới mật khẩu vui lòng nhập:\n -Mật khẩu mới.\n -Nhập lại mật khẩu.\nLưu ý:\n- Độ dài mật khẩu từ 6->20 ký tự.\n- Hai mật khẩu phải được nhập giống nhau.");
            taiKhoan = tenTK;
        }

        private bool doiMatKhau()
        {
            string query = "UPDATE dtb_TaiKhoan SET MatKhau = '" + txtMatKhau1.Text + "' WHERE TenDangNhap = '" + taiKhoan + "'";
            if(DBUtils.exeNonQueryData(query, conn))
            {
                MessageBox.Show("Thay đổi mật khẩu thành công.");
                return true;
            }
            return false;
        }

        //Hàm xử lý khi ấn nút thoát.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if(txtMatKhau1.Text == "" || txtMatKhau2.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống mật khẩu.");
            }
            else if(txtMatKhau1.TextLength < 6 || txtMatKhau2.TextLength < 6 || txtMatKhau2.TextLength > 20 || txtMatKhau1.TextLength > 20)
            {
                MessageBox.Show("Mật khẩu chi được từ 6->20 ký tự.");
            }
            else if(txtMatKhau1.Text != txtMatKhau2.Text)
            {
                MessageBox.Show("Hai mật khẩu không trùng khớp.\nVui lòng kiểm tra và nhập lại.");
            }
            else if (doiMatKhau())
            {
                frmDangNhap frm = new frmDangNhap();
                this.Hide();
                frm.Show();
            }
        }

        //Hàm không sử dụng.
        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }
    }
}
