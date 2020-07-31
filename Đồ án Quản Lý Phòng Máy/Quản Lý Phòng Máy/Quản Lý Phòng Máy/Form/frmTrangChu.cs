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

        Color clr = Color.Teal;
        Color declr = Color.FromArgb(0, 0, 64);
        Point p;
        bool flag = false;

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
            frm_QLTaiKhoan f = new frm_QLTaiKhoan();
            HienThiForm(f);
            LamMoiMauNen(sender); ;
        }

        private void btn_QLThanhLy_Click(object sender, EventArgs e)
        {
            frmQLThanhLy frm = new frmQLThanhLy();
            frm.Show();
        }

        private void btn_QLNhapMay_Click(object sender, EventArgs e)
        {
            frmQLNhapMay frm = new frmQLNhapMay();
            frm.Show();
        }

        private void btn_QLMay_Click(object sender, EventArgs e)
        {
            frm_QLMay frm = new frm_QLMay();
            frm.Show();
        }

        private void btn_QLPhongMay_Click(object sender, EventArgs e)
        {
            frmQLPhongMay frm = new frmQLPhongMay();
            frm.Show();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }
        void HienThiForm(object form)
        {
            this.pnShowForm.Controls.Clear();
            (form as Form).TopLevel = false;
            this.pnShowForm.Controls.Add((form as Form));
            (form as Form).Show();
            btn_TrangChu.BackColor = clr;
        }

        void LamMoiMauNen(object sender)
        {
            (sender as Button).BackColor = clr;
            Control.ControlCollection ctrls = pnMenu.Controls;
            foreach (Control c in ctrls)
            {
                if (c != sender)
                    (c as Button).BackColor = declr;
                else
                    (c as Button).BackColor = clr;
            }
        }
    }
}
