using System;
using System.Windows.Forms;
using QuanLyPhongMay.Class;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay
{
    public partial class frmTrangChu : Form
    {
        /*SqlConnection conn = DBUtils.GetDBConnection();
        public User user;*/

        /*Color clr = Color.Teal;
        Color declr = Color.FromArgb(0, 0, 64);*/
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
            frm_QLTaiKhoan frm;

            if (user.TenUser != "")
            {
                frm = new frm_QLTaiKhoan(user);
            }
            else
            {
                frm = new frm_QLTaiKhoan();
            }

            frm.Show();
        }

        private void btn_QLThanhLy_Click(object sender, EventArgs e)
        {
            frmQLThanhLy frm;

            if (user.TenUser != "")
            {
                frm = new frmQLThanhLy(user);
            }
            else
            {
                frm = new frmQLThanhLy();
            }

            frm.Show();
        }

        private void btn_QLNhapMay_Click(object sender, EventArgs e)
        {
            frmQLNhapMay frm;

            if (user.TenUser != "")
            {
                frm = new frmQLNhapMay(user);
            }
            else
            {
                frm = new frmQLNhapMay();
            }

            frm.Show();
            
        }

        private void btn_QLMay_Click(object sender, EventArgs e)
        {
            frmQLMay frm;

            if (user.TenUser != "")
            {
                frm = new frmQLMay(user);
            }
            else
            {
                frm = new frmQLMay();
            }

            frm.Show();
        }

        private void btn_QLPhongMay_Click(object sender, EventArgs e)
        {
            frmQLPhongMay frm;

            if (user.TenUser != "")
            {
                frm = new frmQLPhongMay(user);
            }
            else
            {
                frm = new frmQLPhongMay();
            }

            frm.Show();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            frmQLThietBi frm = new frmQLThietBi(user);
            frm.Show();
        }
        /*void HienThiForm(object form)
        {
            this.pnShowForm.Controls.Clear();
            (form as Form).TopLevel = false;
            this.pnShowForm.Controls.Add((form as Form));
            (form as Form).Show();
            btnQLThietBi.BackColor = clr;
        }*/

        /*void LamMoiMauNen(object sender)
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
        }*/

        private void btnQLThietBi_Click(object sender, EventArgs e)
        {
            frmQLThietBi frm;
            if(user.TenUser != "")
            {
                frm = new frmQLThietBi(user);
            }
            else
            {
                frm = new frmQLThietBi();
            }

            frm.Show();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btn_LichSu_Click(object sender, EventArgs e)
        {
            frmLichSuCapNhat frm;

            if (user.TenUser != "")
            {
                frm = new frmLichSuCapNhat(user);
            }
            else
            {
                frm = new frmLichSuCapNhat();
            }

            frm.Show();
        }

        private void btnQLCauHinh_Click(object sender, EventArgs e)
        {
            frmQLCauHinh frm;

            if (user.TenUser != "")
            {
                frm = new frmQLCauHinh(user);
            }
            else
            {
                frm = new frmQLCauHinh();
            }

            frm.Show();
        }

        private void btnQLKhoa_Click(object sender, EventArgs e)
        {
            frmQLKhoa frm;

            if (user.TenUser != "")
            {
                frm = new frmQLKhoa(user);
            }
            else
            {
                frm = new frmQLKhoa();
            }

            frm.Show();
        }
    }
}
