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
using Quản_Lý_Phòng_Máy.Class;

namespace Quản_Lý_Phòng_Máy
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        bool Login(string userName, string password)
        {
            //Lấy thông tin kết nôi sql.
            SqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                //Thực hiện kết tới sql.
                conn.Open();

                //Câu lệnh truy vấn.
                string query = "SELECT * FROM dtb_TaiKhoan WHERE TenDangNhap = '" + userName + "' AND MatKhau = '" + password + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                //Kiểm tra data sau khi truy vẫn.
                SqlDataReader dt = cmd.ExecuteReader();
                if(dt.Read() == true)
                {
                    //Hiển thị hộp thoại báo thành công và trả về true.
                    MessageBox.Show("Đăng Nhập Thành Công.");
                    return true;
                }
                else
                {
                    //Hiển thị hộp thoại báo thất bại.
                    MessageBox.Show("Đăng Nhập Thất Bại. \nSai Tên Tài Khoản Hoặc Mật Khẩu.");
                }
            }
            catch (Exception e)
            {
                //Xuất hộp thoại báo lỗi kết nối tới sql.
                MessageBox.Show("Error: " + e);
            }

            //Trả về false khi không thể kết nôi sql hoặc sai thông tin đăng nhập.
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Thoát khỏi chương trình.
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //Lấy thông tin username + password từ frmDangNhap.
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            //Kiểm tra thông tin đăng nhập.
            if(Login(userName, password))
            {
                //Nếu đăng nhập thành công thì ẩn frmDangNhap và mở frmTrangChu.
                frmTrangChu frm = new frmTrangChu();
                this.Hide();
                frm.Show();
            }
        }
    }
}
