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
    public partial class frmQLPhongMay : Form
    {
        PhongMayCtrl phongCtrl = new PhongMayCtrl();
        PhongMay phong = new PhongMay();
        TrangThaiCtrl trangThaiCtrl = new TrangThaiCtrl();
        bool doubleClick = false;

        public frmQLPhongMay()
        {
            InitializeComponent();
        }

        private void frm_QLPhongMay_Load(object sender, EventArgs e)
        {
            phongCtrl.HienThiDgv(dgvDSPhong);
            trangThaiCtrl.HienThiCbo(cboTrangThai);
            cboTrangThai.Text = "";
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtMaPhong.Text = dgvDSPhong.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dgvDSPhong.CurrentRow.Cells[1].Value.ToString();
            txtSoLuongMay.Text = dgvDSPhong.CurrentRow.Cells[2].Value.ToString();
            cboTrangThai.SelectedItem = Convert.ToInt32(dgvDSPhong.CurrentRow.Cells[3].Value.ToString());
            rtbGhiChu.Text = dgvDSPhong.CurrentRow.Cells[4].Value.ToString();

            btnThemMoi.Hide();
            doubleClick = true;
            txtMaPhong.ReadOnly = true;
        }

        private void lamMoi()
        {
            txtMaPhong.Text = "";
            txtSoLuongMay.Text = "";
            txtTenPhong.Text = "";
            rtbGhiChu.Text = "";
            cboTrangThai.Text = "";

            btnThemMoi.Show();
            txtMaPhong.ReadOnly = false;
            doubleClick = false;
            phongCtrl.HienThiDgv(dgvDSPhong);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            phong.MaPhong = Convert.ToInt32(txtMaPhong.Text);
            phong.TenPhong = txtTenPhong.Text;
            phong.SoLuongMay = Convert.ToInt32(txtSoLuongMay.Text);
            phong.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue.ToString());
            phong.GhiChu = rtbGhiChu.Text;

            if (phongCtrl.Them(phong) > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lamMoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSPhong.CurrentRow != null)
            {
                int maPhong = Convert.ToInt32(dgvDSPhong.CurrentRow.Cells[0].Value);
                phongCtrl.Xoa(maPhong);
                MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK);
                phongCtrl.HienThiDgv(dgvDSPhong);
                lamMoi();
            }
            else
            {
                MessageBox.Show("Vùi lòng chọn thiết bị muốn xóa ở danh sách thiết bị!", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (doubleClick)
            {
                phong.MaPhong = Convert.ToInt32(txtMaPhong.Text);
                phong.TenPhong = txtTenPhong.Text;
                phong.SoLuongMay = Convert.ToInt32(txtSoLuongMay.Text);
                phong.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue.ToString());
                phong.GhiChu = rtbGhiChu.Text;

                phongCtrl.CapNhat(phong);
                phongCtrl.HienThiDgv(dgvDSPhong);
                lamMoi();
            }
            else
            {
                MessageBox.Show("Vùi lòng chọn thiết bị muốn cập nhật ở danh sách thiết bị!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaiTK = "";

            if (radMaPhong.Checked)
                loaiTK = "maPhong";
            else if (radTenPhong.Checked)
                loaiTK = "tenPhong";
            else if (radTrangThai.Checked)
                loaiTK = "trangThai";
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }

            if (txtTimKiem.Text.Length != 0 && loaiTK != "")
            {
                phongCtrl.TimKiem(dgvDSPhong, txtTimKiem.Text, loaiTK);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        //Hàm không xử dụng -------------------------------------------------------------------------------------//
        private void grp_QLPhongMay_Enter(object sender, EventArgs e)
        {

        }
    }
}
