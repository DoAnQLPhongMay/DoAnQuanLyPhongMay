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
        int maPhong = 0;
        MayCtrl mayCtrl = new MayCtrl();

        public frmChiTietPhongMay()
        {
            InitializeComponent();
        }

        public frmChiTietPhongMay(int maPhong)
        {
            this.maPhong = maPhong;
            InitializeComponent();
        }

        private void frm_QLPhongMay_Load(object sender, EventArgs e)
        {
            mayCtrl.HienThi(dgvDSMay, maPhong);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
