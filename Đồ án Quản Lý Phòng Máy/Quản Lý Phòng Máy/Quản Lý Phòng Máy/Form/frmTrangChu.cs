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
using QuanLyPhongMay.Class;

namespace QuanLyPhongMay
{
    public partial class frmTrangChu : Form
    {
       // SqlConnection conn = DBUtils.GetDBConnection();
        public User user;

        public frmTrangChu(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
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
            frm_QLTaiKhoan frmtk = new frm_QLTaiKhoan(user);
            //frmtk.MdiParent = this;
            frmtk.Show();
        }

        private void btn_QLThanhLy_Click(object sender, EventArgs e)
        {
            frm_QLThanhLy frm = new frm_QLThanhLy(user);
            //this.Hide();
            frm.Show();
        }

        private void btn_QLNhapMay_Click(object sender, EventArgs e)
        {
            frm_QLNhapMay frm = new frm_QLNhapMay(user);
            //this.Hide();
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

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}
