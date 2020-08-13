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
        TTThietBi[] thongTin = new TTThietBi[11];
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();

        //Khởi tạo mặc định của form.
        public frmChiTietPhongMay()
        {
            InitializeComponent();
        }

        public frmChiTietPhongMay(int maPhong)
        {
            this.maPhong = maPhong;
            InitializeComponent();
        }

        //Hàm xử lý load form.
        private void frm_QLPhongMay_Load(object sender, EventArgs e)
        {
            mayCtrl.HienThi(dgvDSMay, maPhong);
        }

        //Hàm xử lý gán dữ liệu sang textbox.
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            int maMay = Convert.ToInt32(dgvDSMay.CurrentRow.Cells[0].Value);

            for (int i = 0; i < 11; i++)
            {
                thongTin[i] = new TTThietBi();
                thongTin[i] = thietBiCtrl.LayThongTinMay(maMay, i + 1);
            }

            txtManHinh.Text = thongTin[0].TenThietBi;
            txtChuot.Text = thongTin[1].TenThietBi;
            txtBanPhim.Text = thongTin[2].TenThietBi;
            txtThung.Text = thongTin[3].TenThietBi;
            txtCPU.Text = thongTin[4].TenThietBi;
            txtMainBoard.Text = thongTin[5].TenThietBi;
            txtRAM.Text = thongTin[6].TenThietBi;
            txtOCung.Text = thongTin[7].TenThietBi;
            txtVGA.Text = thongTin[8].TenThietBi;
            txtPSU.Text = thongTin[9].TenThietBi;
            txtHDH.Text = thongTin[10].TenThietBi;

            txtMaMay.Text = dgvDSMay.CurrentRow.Cells[0].Value.ToString();
            txtTenMay.Text = dgvDSMay.CurrentRow.Cells[1].Value.ToString();
            txtTenPhong.Text = dgvDSMay.CurrentRow.Cells[2].Value.ToString();
            txtTrangThai.Text = dgvDSMay.CurrentRow.Cells[3].Value.ToString();
            rtbGhiChu.Text = dgvDSMay.CurrentRow.Cells[4].Value.ToString();
        }

        //-------------------------------------- Hàm không xử dụng --------------------------------------//
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
