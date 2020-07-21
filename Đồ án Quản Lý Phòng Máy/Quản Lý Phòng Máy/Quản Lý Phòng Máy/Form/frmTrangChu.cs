using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản_Lý_Phòng_Máy.Class;

namespace Quản_Lý_Phòng_Máy
{
    public partial class frmTrangChu : Form
    {
        SqlConnection conn = DBUtils.GetDBConnection();
        public User user;

        public frmTrangChu(User user)
        {
            this.user = new User(user);
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
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

            lblUsername.Text = user.getTenUser();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        private void btn_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_QLTaiKhoan frm = new frm_QLTaiKhoan(user);
            this.Hide();
            frm.Show();
        }

        private void btn_QLThanhLy_Click(object sender, EventArgs e)
        {
            frm_QLThanhLy frm = new frm_QLThanhLy(user);
            this.Hide();
            frm.Show();
        }

        private void btn_QLNhapMay_Click(object sender, EventArgs e)
        {
            frm_QLNhapMay frm = new frm_QLNhapMay(user);
            this.Hide();
            frm.Show();
        }

        private void btn_QLMay_Click(object sender, EventArgs e)
        {
            frm_QLMay frm = new frm_QLMay(user);
            //this.Hide();
            frm.Show();
        }

        private void btn_QLPhongMay_Click(object sender, EventArgs e)
        {
            frmQLPhongMay frm = new frmQLPhongMay(user);
            //this.Hide();
            frm.Show();
        }
    }
}
