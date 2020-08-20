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
        LichSuNhapCtrl lsNhapCtrl = new LichSuNhapCtrl();
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        CauHinhCtrl cauHinhCtrl = new CauHinhCtrl();
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
            if (user.TenUser != "")
            {
                txtNguoiPhuTrach.Text = user.TenUser;
            }
            else
            {
                txtNguoiPhuTrach.Text = "vmkhoi";
            }

            thanhLyCtrl.HienThiDgv(dgvDSThietBi, dgvDSCauHinh);
            thietBiCtrl.HienThiCbo(cboTenThietBi);
            cauHinhCtrl.HienThiCbo(cboCauHinh);
            cboTenThietBi.Text = "";
            cboCauHinh.Text = "";
        }

        //Hàm gán giá trị từ datagridview lên text.
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            cboCauHinh.Text = "";
            txtNSX.Clear();
            txtNamSX.Clear();

            txtMaThanhLy.Text = dgvDSThietBi.CurrentRow.Cells["MaThanhLy"].Value.ToString();
            dtmNgayThanhLy.Text = dgvDSThietBi.CurrentRow.Cells["NgayThanhLy"].Value.ToString();
            cboTenThietBi.SelectedValue = Convert.ToInt32(dgvDSThietBi.CurrentRow.Cells["MaThietBi"].Value);
            txtNSX.Text = dgvDSThietBi.CurrentRow.Cells["NhaSanXuat"].Value.ToString();
            txtNamSX.Text = dgvDSThietBi.CurrentRow.Cells["NamSanxuat"].Value.ToString();
            txtSoLuong.Text = dgvDSThietBi.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGia.Text = dgvDSThietBi.CurrentRow.Cells["DonGia"].Value.ToString();
            rtbGhiChu.Text = dgvDSThietBi.CurrentRow.Cells["GhiChu"].Value.ToString();
            txtTong.Text = (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text)).ToString();

            btnThemMoi.Enabled = false;
        }

        private void dgv_DoubleClickCH(object sender, EventArgs e)
        {
            cboTenThietBi.Text = "";
            txtNSX.Clear();
            txtNamSX.Clear();

            txtMaThanhLy.Text = dgvDSCauHinh.CurrentRow.Cells["MaTL"].Value.ToString();
            dtmNgayThanhLy.Text = dgvDSCauHinh.CurrentRow.Cells["Ngay"].Value.ToString();
            cboCauHinh.SelectedValue = Convert.ToInt32(dgvDSCauHinh.CurrentRow.Cells["MaCH"].Value);
            txtNSX.Text = dgvDSCauHinh.CurrentRow.Cells["NSX"].Value.ToString();
            txtNamSX.Text = dgvDSCauHinh.CurrentRow.Cells["NamSX"].Value.ToString();
            txtSoLuong.Text = dgvDSCauHinh.CurrentRow.Cells["SL"].Value.ToString();
            txtDonGia.Text = dgvDSCauHinh.CurrentRow.Cells["DG"].Value.ToString();
            rtbGhiChu.Text = dgvDSCauHinh.CurrentRow.Cells["GC"].Value.ToString();
            txtTong.Text = (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text)).ToString();

            btnThemMoi.Enabled = false;
        }

        //Hàm gán giá trị từ combox sang text.
        private void cbo_Selected(object sender, EventArgs e)
        {
            if (cboTenThietBi.SelectedValue != null)
            {
                txtNamSX.Enabled = false;
                txtNSX.Enabled = false;
                int maThietBi = Convert.ToInt32(cboTenThietBi.SelectedValue);
                thongTin = thietBiCtrl.LayThongTin(maThietBi);
                txtNSX.Text = thongTin.NhaSanXuat;
                txtNamSX.Text = thongTin.NamSanXuat.ToString();
            }
        }

        private void cboCH_Selected(object sender, EventArgs e)
        {
            if (cboCauHinh.SelectedValue != null)
            {
                txtNamSX.Enabled = true;
                txtNSX.Enabled = true;
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

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Hàm làm mới các text.
        private void lamMoi()
        {
            txtMaThanhLy.Clear();
            txtNSX.Clear();
            txtNamSX.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTong.Clear();
            txtTimKiem.Clear();
            rtbGhiChu.Clear();
            cboTenThietBi.Text = "";
            cboCauHinh.Text = "";

            btnThemMoi.Enabled = true;
        }

        //Hàm kiểm tra dữ liệu nhập vào.
        public bool kiemTra()
        {
            bool kTra = true;
            thongTin = thietBiCtrl.LayThongTin(Convert.ToInt32(cboTenThietBi.SelectedValue));
            int[] thietBi = new int[12];

            if (cboTenThietBi.Text == "" && cboCauHinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thanh lý thiết bị hoặc nhập cấu hình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (cboTenThietBi.Text != "" && cboCauHinh.Text != "")
            {
                MessageBox.Show("Vui lòng để trống 1 trong 2 mục thiết bị hoặc cấu hình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lương.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (Convert.ToInt32(txtDonGia.Text) <= 0)
            {
                MessageBox.Show("Đơn giá không thể âm.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (Convert.ToInt32(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (cboCauHinh.Text != "")
            {
                thietBi = cauHinhCtrl.LayCauHinh(Convert.ToInt32(cboCauHinh.SelectedValue));
                TTThietBi ttin = new TTThietBi();
                for(int i = 1; i < 12; i++)
                {
                    ttin = thietBiCtrl.LayThongTin(Convert.ToInt32(thietBi[i]));
                    if ((ttin.SoLuong - cauHinhCtrl.DemCH(Convert.ToInt32(cboCauHinh.SelectedValue)) - Convert.ToInt32(txtSoLuong.Text)) < 0)
                    {
                        MessageBox.Show("Số lượng hiện có: " + ttin.SoLuong.ToString() + "\nSố lượng sử dụng: " + cauHinhCtrl.DemCH(Convert.ToInt32(cboCauHinh.SelectedValue)).ToString() + "\nSố lượng thanh lý: " + txtSoLuong.Text + "\nSố lượng thanh lý lớn hơn số lượng thực tế.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else if(cboTenThietBi.Text != "")
            {
                if(cauHinhCtrl.KTThietbi(Convert.ToInt32(cboTenThietBi.SelectedValue)) == 0)
                {
                    int slHienCo = thongTin.SoLuong;
                    int slThanhLy = Convert.ToInt32(txtSoLuong.Text);
                    if (slHienCo < slThanhLy)
                    {
                        MessageBox.Show("Số lượng hiện có: " + slHienCo.ToString() + "\nSố lượng thanh lý: " + slThanhLy.ToString() + "\nSố lượng thanh lý lớn hơn số lượng thực tế.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kTra = false;
                    }
                }
                else
                {
                    int slHienCo = thongTin.SoLuong;
                    int slSuDung = cauHinhCtrl.DemCH(Convert.ToInt32(cboCauHinh.SelectedValue));
                    int slThanhLy = Convert.ToInt32(txtSoLuong.Text);

                    if (slHienCo - slSuDung - slThanhLy < 0)
                    {
                        MessageBox.Show("Số lượng hiện có: " + slHienCo.ToString() + "\nSố lượng sử dụng: " + slSuDung.ToString() + "\nSố lượng thanh lý: " + slThanhLy.ToString() + "\nSố lượng thanh lý lớn hơn số lượng thực tế.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kTra = false;
                    }
                }
            }

            return kTra;
        }

        public void ThanhLyThietBi()
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

            thanhLyCtrl.ThemThietBi(thanhLy);
            thanhLyCtrl.CapNhatSL(thanhLy);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lamMoi();
        }

        public void ThanhLyCauHinh()
        {
            int[] maThietBi = new int[12];
            maThietBi = cauHinhCtrl.LayCauHinh(Convert.ToInt32(cboCauHinh.SelectedValue.ToString()));

            thanhLy.MaThanhLy = thanhLyCtrl.GetID() + 1;
            thanhLy.NgayThanhLy = Convert.ToDateTime(dtmNgayThanhLy.Value);
            thanhLy.MaCauHinh = Convert.ToInt32(cboTenThietBi.SelectedValue);
            thanhLy.NhaSanXuat = txtNSX.Text;
            if(txtNamSX.Text != "")
            {
                thanhLy.NamSanXuat = Convert.ToInt32(txtNamSX.Text);
            }
            thanhLy.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            thanhLy.DonGia = Convert.ToInt32(txtDonGia.Text);
            thanhLy.NguoiPhuTrach = user.TenTK;
            thanhLy.GhiChu = rtbGhiChu.Text;

            thanhLyCtrl.ThemCauHinh(thanhLy);
            for (int i = 1; i < 12; i++)
            {
                thanhLy.MaThietBi = maThietBi[i];
                thanhLyCtrl.CapNhatSL(thanhLy);
            }
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lamMoi();
        }

        //Hàm xử lý cho button thêm mới.
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(kiemTra())
            {
                DialogResult dlg = MessageBox.Show("Lịch sử thanh lý không thể chỉnh sửa sau khi đã thêm.\nHày chắc rằng dữ liệu nhập vào là đúng.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    if (cboCauHinh.Text != "")
                    {
                        ThanhLyCauHinh();
                    }
                    else if (cboTenThietBi.Text != "")
                    {
                        ThanhLyThietBi();
                    }
                    thanhLyCtrl.HienThiDgv(dgvDSThietBi, dgvDSCauHinh);
                }
            }
        }

        //Hàm xử lý cho button tìm kiếm.
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaiTK = "";
            string key1 = "", key2 = "";

            if (radThietBi.Checked)
            {
                key1 = txtTimKiem.Text;
                loaiTK = "thietBi";
            }
            else if (radNgayThanhLy.Checked)
            {
                key1 = dtmTu.Value.ToString();
                key2 = dtmDen.Value.ToString();
                loaiTK = "ngayThanhLY";
            }
            else if (radNguoiPhuTrach.Checked)
            {
                key1 = txtTimKiem.Text;
                loaiTK = "nguoiPhuTrach";
            }
            else if (radNhaSanXuat.Checked)
            {
                key1 = txtTimKiem.Text;
                loaiTK = "nhaSanXuat";
            }
            else if (radCauHinh.Checked)
            {
                key1 = txtTimKiem.Text;
                loaiTK = "cauHinh";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }

            if (txtTimKiem.Text.Length != 0 && loaiTK != "")
            {
                if (radCauHinh.Checked != true && radThietBi.Checked != true)
                {
                    thanhLyCtrl.TimKiemTB(dgvDSThietBi, key1, key2, loaiTK);
                    thanhLyCtrl.TimKiemCH(dgvDSCauHinh, key1, key2, loaiTK);
                }
                else if (radCauHinh.Checked == true)
                {
                    thanhLyCtrl.TimKiemCH(dgvDSCauHinh, key1, key2, loaiTK);
                }
                else
                {
                    thanhLyCtrl.TimKiemTB(dgvDSThietBi, key1, key2, loaiTK);
                }
            }
            else if (radNgayThanhLy.Checked && loaiTK != "")
            {
                thanhLyCtrl.TimKiemTB(dgvDSThietBi, key1, key2, loaiTK);
                thanhLyCtrl.TimKiemCH(dgvDSCauHinh, key1, key2, loaiTK);
            }
        }

        //Hàm xử lý cho button làm mới.
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
            thanhLyCtrl.HienThiDgv(dgvDSThietBi, dgvDSCauHinh);
        }

        //-------------------------------------- Hàm không xử dụng --------------------------------------//
        private void dtmNgayThanhLy_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
