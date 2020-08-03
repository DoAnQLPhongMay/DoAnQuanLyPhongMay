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
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmQLThanhLy : Form
    {
        LichSuThanhLyCtrl thanhLyCtrl = new LichSuThanhLyCtrl();
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        LichSuThanhLy thanhLy = new LichSuThanhLy();

        public frmQLThanhLy()
        {
            InitializeComponent();
        }

        private void frm_QLThanhLy_Load(object sender, EventArgs e)
        {
            thanhLyCtrl.HienThiDgv(dgvDSThanhLy);
            thietBiCtrl.HienThiCbo(cboTenThietBi);
            cboTenThietBi.Text = "";
            txtNguoiPhuTrach.Text = "vmkhoi";
        }
        
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtMaThanhLy.Text = dgvDSThanhLy.CurrentRow.Cells[0].Value.ToString();
            dtmNgayThanhLy.Text = dgvDSThanhLy.CurrentRow.Cells[1].Value.ToString();
            cboTenThietBi.SelectedItem = Convert.ToInt32(dgvDSThanhLy.CurrentRow.Cells[2].Value.ToString());
            txtNSX.Text = dgvDSThanhLy.CurrentRow.Cells[3].Value.ToString();
            txtNamSX.Text = dgvDSThanhLy.CurrentRow.Cells[4].Value.ToString();
            txtSoLuong.Text = dgvDSThanhLy.CurrentRow.Cells[5].Value.ToString();
            txtDonGia.Text = dgvDSThanhLy.CurrentRow.Cells[6].Value.ToString();
            txtNguoiPhuTrach.Text = "vmkhoi";
            rtbGhiChu.Text = dgvDSThanhLy.CurrentRow.Cells[8].Value.ToString();

            btnThemMoi.Hide();
            txtMaThanhLy.ReadOnly = true;
        }

        private void lamMoi()
        {
            txtMaThanhLy.Text = "";
            txtNSX.Text = "";
            txtNamSX.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            cboTenThietBi.Text = "";
            rtbGhiChu.Text = "";

            btnThemMoi.Show();
            txtMaThanhLy.ReadOnly = false;
            thanhLyCtrl.HienThiDgv(dgvDSThanhLy);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            thanhLy.MaThanhLy = Convert.ToInt32(txtMaThanhLy.Text);
            thanhLy.NgayThanhLy = Convert.ToDateTime(dtmNgayThanhLy.Value);
            thanhLy.MaThietBi = Convert.ToInt32(cboTenThietBi.SelectedValue.ToString());
            thanhLy.NhaSanXuat = txtNSX.Text;
            thanhLy.NamSanXuat = Convert.ToInt32(txtNamSX.Text);
            thanhLy.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            thanhLy.DonGia = Convert.ToInt32(txtDonGia.Text);
            thanhLy.NguoiPhuTrach = txtNguoiPhuTrach.Text;
            thanhLy.GhiChu = rtbGhiChu.Text;

            if (thanhLyCtrl.Them(thanhLy) > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lamMoi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaiTK = "";

            if (radMaThanhLy.Checked)
                loaiTK = "maThanhLy";
            else if (radMaThietBi.Checked)
                loaiTK = "maThietBi";
            else if (radNgayThanhLy.Checked)
                loaiTK = "ngayThanhLy";
            else if (radNguoiPhuTrach.Checked)
                loaiTK = "nguoiPhuTrach";
            else if (radNhaSanXuat.Checked)
                loaiTK = "nhaSanXuat";
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }

            if (txtTimKiem.Text.Length != 0 && loaiTK != "")
            {
                thanhLyCtrl.TimKiem(dgvDSThanhLy, txtTimKiem.Text, loaiTK);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        //Hàm không xử dụng -------------------------------------------------------------------------------------//
        private void dtmNgayThanhLy_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
