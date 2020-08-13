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
    public partial class frmQLMay : Form
    {
        TrangThaiCtrl ttctrl = new TrangThaiCtrl();
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        PhongMayCtrl phongctrl = new PhongMayCtrl();
        MayCtrl mctrl = new MayCtrl();
        TTThietBi[] thongTin = new TTThietBi[11];
        User user = new User();

        public frmQLMay()
        {
            InitializeComponent();
        }

        public frmQLMay(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        /*void HienThiThongTin()
        {
            if (dgv_DSMay.CurrentRow != null)
            {
                txt_MaMay.Text = dgv_DSMay.CurrentRow.Cells[0].Value.ToString();
                txt_TenMay.Text = dgv_DSMay.CurrentRow.Cells[1].Value.ToString();
                cbPhong.Text = dgv_DSMay.CurrentRow.Cells[2].Value.ToString();
                cbTrangThai.Text = dgv_DSMay.CurrentRow.Cells[5].Value.ToString();
                txt_GhiChu.Text = dgv_DSMay.CurrentRow.Cells[6].Value.ToString();
            }
        }*/

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            /*frmThemMay frm = new frmThemMay();
            frm.Show();
            this.Hide();*/
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                if (mctrl.Xoa(int.Parse(txtMaMay.Text)) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mctrl.HienThi(dgvDSMay);
                    //HienThiThongTin();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            May may = new May(); 
            may.TenMay = txtTenMay.Text;
            may.GhiChu = rtbGhiChu.Text;
            may.MaPhong = int.Parse(cboPhong.SelectedValue.ToString());
            may.TrangThai = int.Parse(cboTrangThai.SelectedValue.ToString());
            may.MaMay = int.Parse(txtMaMay.Text);

            string mamay = dgvDSMay.CurrentRow.Cells[0].Value.ToString();
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {

                if(mctrl.Luu(may) > 0)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mctrl.HienThi(dgvDSMay);
                    //HienThiThongTin();
                }   
            }
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
          
            if (rad_TenMay.Checked)
                tieuchi = "tenmay";
            if (txt_TimKiem.Text.Length == 0)
                mctrl.HienThi(dgvDSMay);
            else
                mctrl.TimKiem(dgvDSMay, txt_TimKiem.Text, tieuchi);
        }

        private void frmQLMay_Load(object sender, EventArgs e)
        {
            mctrl.HienThi(dgvDSMay);
            ttctrl.HienThiCbo(cboTrangThai);
            phongctrl.HienThiCbo(cboPhong);
            thietBiCtrl.HienThiCbo(cboManHinh, 1);
            thietBiCtrl.HienThiCbo(cboChuot, 2);
            thietBiCtrl.HienThiCbo(cboBanPhim, 3);
            thietBiCtrl.HienThiCbo(cboCase, 4);
            thietBiCtrl.HienThiCbo(cboCPU, 5);
            thietBiCtrl.HienThiCbo(cboMainBoard, 6);
            thietBiCtrl.HienThiCbo(cboRAM, 7);
            thietBiCtrl.HienThiCbo(cboOCung, 8);
            thietBiCtrl.HienThiCbo(cboVGA, 9);
            thietBiCtrl.HienThiCbo(cboPSU, 10);
            thietBiCtrl.HienThiCbo(cboHDH, 11);

            cboTrangThai.Text = "";
            cboPhong.Text = "";
            cboManHinh.Text = "";
            cboChuot.Text = "";
            cboBanPhim.Text = "";
            cboCase.Text = "";
            cboCPU.Text = "";
            cboMainBoard.Text = "";
            cboRAM.Text = "";
            cboOCung.Text = "";
            cboVGA.Text = "";
            cboPSU.Text = "";
            cboHDH.Text = "";

            //HienThiThongTin();
        }
        private void dgv_DSMay_Click(object sender, EventArgs e)
        {
            //HienThiThongTin();
        }

        private void dgv_DSMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //HienThiThongTin();
        }

        private void dgv_DSMay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //HienThiThongTin();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            int maMay = Convert.ToInt32(dgvDSMay.CurrentRow.Cells[0].Value);

            for (int i = 0; i < 11; i++)
            {
                thongTin[i] = new TTThietBi();
                thongTin[i] = thietBiCtrl.LayThongTinMay(maMay, i + 1);
            }

            cboManHinh.SelectedValue = thongTin[0].MaThietBi;
            cboChuot.SelectedValue = thongTin[1].MaThietBi;
            cboBanPhim.SelectedValue = thongTin[2].MaThietBi;
            cboCase.SelectedValue = thongTin[3].MaThietBi;
            cboCPU.SelectedValue = thongTin[4].MaThietBi;
            cboMainBoard.SelectedValue = thongTin[5].MaThietBi;
            cboRAM.SelectedValue = thongTin[6].MaThietBi;
            cboOCung.SelectedValue = thongTin[7].MaThietBi;
            cboVGA.SelectedValue = thongTin[8].MaThietBi;
            cboPSU.SelectedValue = thongTin[9].MaThietBi;
            cboHDH.SelectedValue = thongTin[10].MaThietBi;

            txtMaMay.Text = dgvDSMay.CurrentRow.Cells[0].Value.ToString();
            txtTenMay.Text = dgvDSMay.CurrentRow.Cells[1].Value.ToString();
            cboPhong.SelectedValue = dgvDSMay.CurrentRow.Cells[6].Value.ToString();
            cboTrangThai.SelectedValue = dgvDSMay.CurrentRow.Cells[5].Value.ToString();
            rtbGhiChu.Text = dgvDSMay.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
