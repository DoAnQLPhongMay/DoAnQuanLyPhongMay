using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmChiTietPhongMay : Form
    {
        //Khởi tạo các biến lưu giá trị.
        int maPhong = 0;
        MayCtrl mayCtrl = new MayCtrl();
        User user = new User();

        //Khởi tạo mặc định của form.
        public frmChiTietPhongMay()
        {
            InitializeComponent();
        }

        public frmChiTietPhongMay(int maPhong, User user)
        {
            this.maPhong = maPhong;
            this.user = user;
            InitializeComponent();
        }

        //Hàm xử lý load form.
        private void frm_QLPhongMay_Load(object sender, EventArgs e)
        {
            mayCtrl.HienThi(dgvDSMay, maPhong);
        }

        //-------------------------------------- Hàm không xử dụng --------------------------------------//
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            //frmQLPhongMay frm;

            //if (user.TenUser != "")
            //{
            //    frm = new frmQLPhongMay(user);
            //}
            //else
            //{
            //    frm = new frmQLPhongMay();
            //}

            this.Hide();
            //frm.Show();
        }
    }
}
