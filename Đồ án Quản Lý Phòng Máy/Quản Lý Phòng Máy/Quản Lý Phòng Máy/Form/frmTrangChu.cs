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
        User user = new User();


        public frmTrangChu(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if(user.TenUser != "")
            {
                lblUsername.Text = user.TenUser;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            user.dangXuat();
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        private void btn_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_QLTaiKhoan frm = new frm_QLTaiKhoan();
            frm.Show();
            
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
            frmQLMay frm = new frmQLMay();
            frm.Show();
           
        }

        private void btn_QLPhongMay_Click(object sender, EventArgs e)
        {
            frmQLPhongMay frm = new frmQLPhongMay();
            frm.Show();
            
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            frmQLThietBi frm = new frmQLThietBi();
            frm.Show();
           
        }
        void HienThiForm(object form)
        {
            this.pnShowForm.Controls.Clear();
            (form as Form).TopLevel = false;
            this.pnShowForm.Controls.Add((form as Form));
            (form as Form).Show();
            btnQLThietBi.BackColor = clr;
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

        private void btnQLThietBi_Click(object sender, EventArgs e)
        {
            frmQLThietBi frm = new frmQLThietBi();
            frm.Show();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
