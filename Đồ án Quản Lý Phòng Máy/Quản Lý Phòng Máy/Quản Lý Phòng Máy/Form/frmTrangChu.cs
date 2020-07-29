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
        /*SqlConnection conn = DBUtils.GetDBConnection();
        public User user;*/

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        private void btn_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_QLTaiKhoan frmtk = new frm_QLTaiKhoan();
            //frmtk.MdiParent = this;
            frmtk.Show();
        }

        private void btn_QLThanhLy_Click(object sender, EventArgs e)
        {
            frm_QLThanhLy frm = new frm_QLThanhLy();
            //this.Hide();
            frm.Show();
        }

        private void btn_QLNhapMay_Click(object sender, EventArgs e)
        {
            frm_QLNhapMay frm = new frm_QLNhapMay();
            //this.Hide();
            frm.Show();
        }

        private void btn_QLMay_Click(object sender, EventArgs e)
        {
            frm_QLMay frm = new frm_QLMay();
            //this.Hide();
            frm.Show();
        }

        private void btn_QLPhongMay_Click(object sender, EventArgs e)
        {
            frmQLPhongMay frm = new frmQLPhongMay();
            //this.Hide();
            frm.Show();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}
