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
        //Khởi tạo các biến giá trị.
        LichSuThanhLyCtrl thanhLyCtrl = new LichSuThanhLyCtrl();
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        LichSuThanhLy thanhLy = new LichSuThanhLy();
        User user = new User();
        TTThietBi thongTin = new TTThietBi();

        //Hàm khởi tạo mặc định của form.
        public frmQLThanhLy()
        {
            InitializeComponent();
        }

        public frmQLThanhLy(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        //Hàm load dữ liệu khi mở form.
        private void frm_QLThanhLy_Load(object sender, EventArgs e)
        {
            if(user.TenUser != "")
            {
                txtNguoiPhuTrach.Text = user.TenUser;
            }
            else
            {
                txtNguoiPhuTrach.Text = "vmkhoi";
            }

            thanhLyCtrl.HienThiDgv(dgvDSThanhLy);
            thietBiCtrl.HienThiCbo(cboTenThietBi);
            cboTenThietBi.Text = "";
        }

        //Hàm gán giá trị từ datagridview lên text.
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtMaThanhLy.Text = dgvDSThanhLy.CurrentRow.Cells[0].Value.ToString();
            dtmNgayThanhLy.Text = dgvDSThanhLy.CurrentRow.Cells[1].Value.ToString();
            cboTenThietBi.SelectedValue = Convert.ToInt32(dgvDSThanhLy.CurrentRow.Cells[2].Value);
            txtNSX.Text = dgvDSThanhLy.CurrentRow.Cells[3].Value.ToString();
            txtNamSX.Text = dgvDSThanhLy.CurrentRow.Cells[4].Value.ToString();
            txtSoLuong.Text = dgvDSThanhLy.CurrentRow.Cells[5].Value.ToString();
            txtDonGia.Text = dgvDSThanhLy.CurrentRow.Cells[6].Value.ToString();
            rtbGhiChu.Text = dgvDSThanhLy.CurrentRow.Cells[8].Value.ToString();
            txtTong.Text = (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text)).ToString();

            btnThemMoi.Enabled = false;
        }

        //Hàm gán giá trị từ combox sang text.
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

        //Hàm xử lý chỉ cho nhập số.
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

        //Hàm làm mới các text.
        private void lamMoi()
        {
            txtMaThanhLy.Text = "";
            txtNSX.Text = "";
            txtNamSX.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            cboTenThietBi.Text = "";
            rtbGhiChu.Text = "";

            btnThemMoi.Enabled = true;
            thanhLyCtrl.HienThiDgv(dgvDSThanhLy);
        }

        //Hàm kiểm tra dữ liệu nhập vào.
        public bool kiemTra()
        {
            bool kTra = true;
            thongTin = thietBiCtrl.LayThongTin(Convert.ToInt32(cboTenThietBi.SelectedValue));

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
            else if(thongTin.SoLuong < Convert.ToInt32(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng thanh lý lớn hơn số lượng thực tế.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if (Convert.ToInt32(txtDonGia.Text) < 0)
            {
                MessageBox.Show("Đơn giá không thể âm.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if (Convert.ToInt32(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }

            return kTra;
        }

        //Hàm xử lý cho button thêm mới.
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(kiemTra())
            {
                DialogResult dlg = MessageBox.Show("Lịch sử thanh lý không thể chỉnh sửa sau khi đã thêm.\nHày chắc rằng dữ liệu nhập vào là đúng.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    thanhLy.MaThanhLy = thanhLyCtrl.GetID() + 1;
                    thanhLy.NgayThanhLy = Convert.ToDateTime(dtmNgayThanhLy.Value);
                    thanhLy.MaThietBi = Convert.ToInt32(cboTenThietBi.SelectedValue);
                    thanhLy.NhaSanXuat = txtNSX.Text;
                    thanhLy.NamSanXuat = Convert.ToInt32(txtNamSX.Text);
                    thanhLy.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    thanhLy.DonGia = Convert.ToInt32(txtDonGia.Text);
                    thanhLy.NguoiPhuTrach = user.TenTK;
                    thanhLy.GhiChu = rtbGhiChu.Text;

                    thanhLyCtrl.Them(thanhLy);
                    thanhLyCtrl.CapNhatSL(thanhLy);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lamMoi();
                }
            }
        }

        //Hàm xử lý cho button tìm kiếm.
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

        //Hàm xử lý cho button làm mới.
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
            if (cboTenThietBi.SelectedValue != null)
            {
                //int maThietBi = Convert.ToInt32(cboTenThietBi.SelectedValue);
                thongTin = thietBiCtrl.LayThongTin(6);
                MessageBox.Show(thongTin.NhaSanXuat);
                txtNSX.Text = thongTin.NhaSanXuat;
                txtNamSX.Text = thongTin.NamSanXuat.ToString();
            }
        }

        //-------------------------------------- Hàm không xử dụng --------------------------------------//
        private void dtmNgayThanhLy_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
