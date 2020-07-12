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
        SqlConnection conn = DBUtils.GetDBConnection();
        public User user = new User();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        //Hàm xử lý đăng nhập.
        bool login(string userName, string password)
        {
            //Lấy thông tin kết nôi sql.
                //Câu lệnh truy vấn.
                string query = "SELECT * FROM dtb_TaiKhoan WHERE TenDangNhap = '" + userName + "' AND MatKhau = '" + password + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                //Kiểm tra data sau khi truy vẫn.
                SqlDataReader dr = cmd.ExecuteReader();
                
                if(dr.Read() == true)
                {
                    //Hiển thị hộp thoại báo thành công và trả về true.
                    MessageBox.Show("Đăng Nhập Thành Công.");
                    user.DangNhap(dr[0].ToString(), dr[3].ToString(), dr[5].ToString(), dr[7].ToString(), dr[6].ToString(), Convert.ToBoolean(dr[4]), Convert.ToBoolean(dr[8]));
                    return true;
                }
                else
                {
                    //Hiển thị hộp thoại báo thất bại.
                    MessageBox.Show("Đăng Nhập Thất Bại. \nSai Tên Tài Khoản Hoặc Mật Khẩu.");
                }
            

            //Trả về false khi không thể kết nôi sql hoặc sai thông tin đăng nhập.
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
            //Lấy thông tin username + password từ frmDangNhap.
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            //Kiểm tra thông tin đăng nhập.
            if(login(userName, password))
            {
                //Nếu đăng nhập thành công thì ẩn frmDangNhap và mở frmTrangChu.
                frmTrangChu frm = new frmTrangChu(user);
                this.Hide();
                frm.Show();
            }
        }

        //Hàm xử lý khi ấn nút quên mật khẩu.
        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {

        }

        //Hàm xử lý load form.
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //Thực hiện kết nối CSDL.
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                //Xuất hộp thoại báo lỗi kết nối tới CSDL.
                MessageBox.Show("Error: " + ex);
            }
        }

        //Hàm không sử dụng.
        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
