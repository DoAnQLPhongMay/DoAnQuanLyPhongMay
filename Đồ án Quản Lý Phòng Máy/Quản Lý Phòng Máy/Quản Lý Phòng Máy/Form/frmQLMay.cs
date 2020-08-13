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
        MayCtrl mayCtrl = new MayCtrl();
        User user = new User();
        TTThietBi[] thongTin = new TTThietBi[11];
        ComboBox[] cbo = new ComboBox[11];

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

        private void LuuCbo()
        {
            cbo[0] = cboManHinh;
            cbo[1] = cboChuot;
            cbo[2] = cboBanPhim;
            cbo[3] = cboCase;
            cbo[4] = cboCPU;
            cbo[5] = cboMainBoard;
            cbo[6] = cboRAM;
            cbo[7] = cboOCung;
            cbo[8] = cboVGA;
            cbo[9] = cboPSU;
            cbo[10] = cboHDH;
        }

        private void LamMoi()
        {
            LuuCbo();

            for (int i = 0; i < 11; i++)
            {
                cbo[i].Text = "";
            }

            rtbGhiChu.Clear();
            txtMaMay.Clear();
            txtTenMay.Clear();
            cboPhong.Text = "";
            cboTrangThai.Text = "";

            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;

            mayCtrl.HienThi(dgvDSMay);
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            /*frmThemMay frm = new frmThemMay();
            frm.Show();
            this.Hide();*/

            May may = new May();
            may.MaMay = mayCtrl.GetID() + 1;
            may.TenMay = txtTenMay.Text;
            may.MaPhong = Convert.ToInt32(cboPhong.SelectedValue);
            may.TrangThai = Convert.ToInt32(cboPhong.SelectedValue);
            may.GhiChu = rtbGhiChu.Text;

            if (txtTenMay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên Máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(mayCtrl.ThemMoi(may) == 0)
            {
                MessageBox.Show("Tên Máy đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LuuCbo();
                for(int i = 0; i < 11; i++)
                {
                    if (cbo[i].Text != "")
                    {
                        mayCtrl.ThemChiTietMay(may.MaMay, i+1, Convert.ToInt32(cbo[i].SelectedValue));
                    }
                }

                mayCtrl.ThemLSCapNhat(may, user.TenTK);
                LamMoi();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dgvDSMay.CurrentRow != null)
            {
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    if (mayCtrl.Xoa(Convert.ToInt32(dgvDSMay.CurrentRow.Cells[0].Value)) > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LamMoi();
                        //HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            LuuCbo();
            May may = new May();
            may.MaMay = Convert.ToInt32(txtMaMay.Text);
            may.TenMay = txtTenMay.Text;
            may.MaPhong = Convert.ToInt32(cboPhong.SelectedValue);
            may.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue);
            may.GhiChu = rtbGhiChu.Text;

            string mamay = dgvDSMay.CurrentRow.Cells[0].Value.ToString();
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                mayCtrl.CapNhatMay(may);
                for(int i = 0; i < 11; i++)
                {
                    if(cbo[i].Text != "")
                    {
                        mayCtrl.CapNhatChiTiet(may.MaMay, i + 1, Convert.ToInt32(cbo[i].SelectedValue));
                    }
                }
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
            }
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
          
            if (rad_TenMay.Checked)
                tieuchi = "tenmay";
            if (txt_TimKiem.Text.Length == 0)
                mayCtrl.HienThi(dgvDSMay);
            else
                mayCtrl.TimKiem(dgvDSMay, txt_TimKiem.Text, tieuchi);
        }

        private void frmQLMay_Load(object sender, EventArgs e)
        {
            LuuCbo();
            mayCtrl.HienThi(dgvDSMay);
            ttctrl.HienThiCbo(cboTrangThai);
            phongctrl.HienThiCbo(cboPhong);
            cboPhong.Refresh();
            cboTrangThai.Refresh();

            cboPhong.Text = "";
            cboTrangThai.Text = "";

            for(int i = 0; i < 11; i++)
            {
                thietBiCtrl.HienThiCbo(cbo[i], i + 1);
                cbo[i].Refresh();
                cbo[i].Text = "";
            }

            //HienThiThongTin();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            LuuCbo();
            int maMay = Convert.ToInt32(dgvDSMay.CurrentRow.Cells[0].Value);

            for (int i = 0; i < 11; i++)
            {
                thongTin[i] = new TTThietBi();
                thongTin[i] = thietBiCtrl.LayThongTinMay(maMay, i + 1);
            }

            for(int i = 0; i< 11; i++)
            {
                cbo[i].SelectedValue = thongTin[i].MaThietBi;
            }

            txtMaMay.Text = dgvDSMay.CurrentRow.Cells[0].Value.ToString();
            txtTenMay.Text = dgvDSMay.CurrentRow.Cells[1].Value.ToString();
            cboPhong.SelectedValue = dgvDSMay.CurrentRow.Cells[6].Value.ToString();
            cboTrangThai.SelectedValue = dgvDSMay.CurrentRow.Cells[5].Value.ToString();
            rtbGhiChu.Text = dgvDSMay.CurrentRow.Cells[4].Value.ToString();

            btnCapNhat.Enabled = true;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
