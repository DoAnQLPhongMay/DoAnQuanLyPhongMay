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
    public partial class frmQLNhapMay : Form
    {
        LichSuNhapCtrl nhapCtrl = new LichSuNhapCtrl();
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        LichSuNhap nhap = new LichSuNhap();
        User user = new User();
        TTThietBi thongTin = new TTThietBi();

        public frmQLNhapMay()
        {
            InitializeComponent();
        }

        public frmQLNhapMay(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void frm_QLNhapMay_Load(object sender, EventArgs e)
        {
            if (user.TenTK != "")
            {
                txtNguoiPhuTrach.Text = user.TenUser;
            }
            else
            {
                txtNguoiPhuTrach.Text = "vmkhoi";
            }
            nhapCtrl.HienThiDgv(dgvDSNhap);
            thietBiCtrl.HienThiCbo(cboTenThietBi);
            cboTenThietBi.Text = "";
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtMaNhap.Text = dgvDSNhap.CurrentRow.Cells[0].Value.ToString();
            dtmNgayNhap.Text = dgvDSNhap.CurrentRow.Cells[1].Value.ToString();
            cboTenThietBi.SelectedItem = Convert.ToInt32(dgvDSNhap.CurrentRow.Cells[2].Value.ToString());
            txtNhaCungCap.Text = dgvDSNhap.CurrentRow.Cells[3].Value.ToString();
            txtNSX.Text = dgvDSNhap.CurrentRow.Cells[4].Value.ToString();
            txtNamSX.Text = dgvDSNhap.CurrentRow.Cells[5].Value.ToString();
            txtSoLuong.Text = dgvDSNhap.CurrentRow.Cells[6].Value.ToString();
            txtDonGia.Text = dgvDSNhap.CurrentRow.Cells[7].Value.ToString();
            rtbGhiChu.Text = dgvDSNhap.CurrentRow.Cells[8].Value.ToString();

            btnThemMoi.Enabled = false;
        }

        private void cbo_Selected(object sender, EventArgs e)
        {
            if (cboTenThietBi.SelectedValue != null)
            {
                int maThietBi = Convert.ToInt32(cboTenThietBi.SelectedValue);
                thongTin = thietBiCtrl.LayThongTin(maThietBi);
                txtNSX.Text = thongTin.NhaSanXuat;
                txtNamSX.Text = thongTin.NamSanXuat.ToString();
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Cho phép nhập số thực.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void lamMoi()
        {
            txtMaNhap.Text = "";
            txtNSX.Text = "";
            txtNamSX.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            cboTenThietBi.Text = "";
            txtNhaCungCap.Text = "";
            rtbGhiChu.Text = "";

            btnThemMoi.Enabled = true;
            nhapCtrl.HienThiDgv(dgvDSNhap);
        }

        public bool kiemTra()
        {
            bool kTra = true;
            int namSX = Convert.ToInt32(txtNamSX.Text);

            if (txtNamSX.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lại thiết bị.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if (cboTenThietBi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thiết bị.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lương.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if (txtNhaCungCap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhà cung cấp.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if (namSX < 2000 || namSX > 3000)
            {
                MessageBox.Show("Năm sản xuất không hơp lệ.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }

            return kTra;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTra())
            {
                nhap.MaNhap = nhapCtrl.GetID() + 1;
                nhap.NgayNhap = Convert.ToDateTime(dtmNgayNhap.Value);
                nhap.MaThietBi = Convert.ToInt32(cboTenThietBi.SelectedValue.ToString());
                nhap.NhaCungCap = txtNhaCungCap.Text;
                nhap.NhaSanXuat = txtNSX.Text;
                nhap.NamSanXuat = Convert.ToInt32(txtNamSX.Text);
                nhap.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                nhap.DonGia = Convert.ToInt32(txtDonGia.Text);
                nhap.NguoiPhuTrach = txtNguoiPhuTrach.Text;
                nhap.GhiChu = rtbGhiChu.Text;

                nhapCtrl.Them(nhap);
                nhapCtrl.CapNhatSL(nhap);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lamMoi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaiTK = "";

            if (radMaNhap.Checked)
                loaiTK = "maNhap";
            else if (radMaThietBi.Checked)
                loaiTK = "maThietBi";
            else if (radNgayNhap.Checked)
                loaiTK = "ngayNhap";
            else if (radNguoiPhuTrach.Checked)
                loaiTK = "nguoiPhuTrach";
            else if (radNhaSanXuat.Checked)
                loaiTK = "nhaSanXuat";
            else if(radNhaCungCap.Checked)
                loaiTK = "nhaCungCap";
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }

            if (txtTimKiem.Text.Length != 0 && loaiTK != "")
            {
                nhapCtrl.TimKiem(dgvDSNhap, txtTimKiem.Text, loaiTK);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
    }
}
