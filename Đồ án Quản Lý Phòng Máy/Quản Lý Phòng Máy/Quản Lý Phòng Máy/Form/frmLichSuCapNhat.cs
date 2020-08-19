using System;
using System.Windows.Forms;
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmLichSuCapNhat : Form
    {
        LSCapNhatCtrl lsCtrl = new LSCapNhatCtrl();
        User user = new User();

        public frmLichSuCapNhat()
        {
            InitializeComponent();
        }

        public frmLichSuCapNhat(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void frmLichSuCapNhat_Load(object sender, EventArgs e)
        {
            lsCtrl.HienThi(dgvLSCapNhat);
        }
    }
}
