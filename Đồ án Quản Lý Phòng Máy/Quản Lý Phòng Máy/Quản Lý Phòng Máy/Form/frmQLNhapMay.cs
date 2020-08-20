using System;
using System.Windows.Forms;
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmQLNhapMay : Form
    {
        //Khởi tạo các biến giá trị.
        LichSuNhapCtrl nhapCtrl = new LichSuNhapCtrl();
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        CauHinhCtrl cauHinhCtrl = new CauHinhCtrl();
        LichSuNhap nhap = new LichSuNhap();
        User user = new User();
        TTThietBi thongTin = new TTThietBi();

        //Hàm khởi tạo mặc định của form.
        public frmQLNhapMay()
        {
            InitializeComponent();
        }

        public frmQLNhapMay(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        //Hàm load dữ liệu khi mở form.
        private void frm_QLNhapMay_Load(object sender, EventArgs e)
        {
            if (user.TenUser != "")
            {
                txtNguoiPhuTrach.Text = user.TenUser;
            }
            else
            {
                txtNguoiPhuTrach.Text = "vmkhoi";
            }

            nhapCtrl.HienThiDgv(dgvDSNThietBi, dgvDSNCauHinh);
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
            txtMaNhap.Text = dgvDSNThietBi.CurrentRow.Cells["MaNhap"].Value.ToString();
            dtmNgayNhap.Text = dgvDSNThietBi.CurrentRow.Cells["NgayNhap"].Value.ToString();
            cboTenThietBi.SelectedValue = Convert.ToInt32(dgvDSNThietBi.CurrentRow.Cells["MaThietBi"].Value);
            txtNhaCungCap.Text = dgvDSNThietBi.CurrentRow.Cells["NhaCungCap"].Value.ToString();
            txtNSX.Text = dgvDSNThietBi.CurrentRow.Cells["NhaSanXuat"].Value.ToString();
            txtNamSX.Text = dgvDSNThietBi.CurrentRow.Cells["NamSanXuat"].Value.ToString();
            txtSoLuong.Text = dgvDSNThietBi.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGia.Text = dgvDSNThietBi.CurrentRow.Cells["DonGia"].Value.ToString();
            rtbGhiChu.Text = dgvDSNThietBi.CurrentRow.Cells["GhiChu"].Value.ToString();
            txtTong.Text = (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text)).ToString();

            btnThemMoi.Enabled = false;
        }

        private void dgv_DoubleClickCH(object sender, EventArgs e)
        {
            cboTenThietBi.Text = "";
            txtNSX.Clear();
            txtNamSX.Clear();
            txtMaNhap.Text = dgvDSNCauHinh.CurrentRow.Cells["ID"].Value.ToString();
            dtmNgayNhap.Text = dgvDSNCauHinh.CurrentRow.Cells["Ngay"].Value.ToString();
            cboCauHinh.SelectedValue = Convert.ToInt32(dgvDSNCauHinh.CurrentRow.Cells["MaCH"].Value);
            txtNhaCungCap.Text = dgvDSNCauHinh.CurrentRow.Cells["NCC"].Value.ToString();
            txtNSX.Text = dgvDSNCauHinh.CurrentRow.Cells["NSX"].Value.ToString();
            txtNamSX.Text = dgvDSNCauHinh.CurrentRow.Cells["NamSX"].Value.ToString();
            txtSoLuong.Text = dgvDSNCauHinh.CurrentRow.Cells["SL"].Value.ToString();
            txtDonGia.Text = dgvDSNCauHinh.CurrentRow.Cells["DG"].Value.ToString();
            rtbGhiChu.Text = dgvDSNCauHinh.CurrentRow.Cells["GC"].Value.ToString();
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
        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
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
            txtMaNhap.Clear();
            txtNhaCungCap.Clear();
            txtNSX.Clear();
            txtNamSX.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTong.Clear();
            rtbGhiChu.Clear();
            txtTimKiem.Clear();
            cboTenThietBi.Text = "";
            cboCauHinh.Text = "";

            btnThemMoi.Enabled = true;
        }

        //Hàm kiểm tra dữ liệu nhập vào.
        public bool kiemTra()
        {
            bool kTra = true;

            if (txtNamSX.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm sản xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (cboTenThietBi.Text == "" && cboCauHinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhập thiết bị hoặc nhập cấu hình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (cboTenThietBi.Text != "" && cboCauHinh.Text != "")
            {
                MessageBox.Show("Vui lòng để trống 1 trong 2 mục thiết bị hoặc cấu hình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (txtNhaCungCap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (Convert.ToInt32(txtNamSX.Text) < 2000 || Convert.ToInt32(txtNamSX.Text) > 3000)
            {
                MessageBox.Show("Năm sản xuất không hơp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (Convert.ToInt32(txtDonGia.Text) < 0)
            {
                MessageBox.Show("Đơn giá không thể âm.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }
            else if (Convert.ToInt32(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kTra = false;
            }

            return kTra;
        }

        public void NhapThietBi()
        {
            nhap.MaNhap = nhapCtrl.GetID() + 1;
            nhap.NgayNhap = Convert.ToDateTime(dtmNgayNhap.Value);
            nhap.MaThietBi = Convert.ToInt32(cboTenThietBi.SelectedValue);
            nhap.NhaCungCap = txtNhaCungCap.Text;
            nhap.NhaSanXuat = txtNSX.Text;
            nhap.NamSanXuat = Convert.ToInt32(txtNamSX.Text);
            nhap.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            nhap.DonGia = Convert.ToInt32(txtDonGia.Text);
            nhap.NguoiPhuTrach = user.TenTK;
            nhap.GhiChu = rtbGhiChu.Text;

            nhapCtrl.ThemThietBi(nhap);
            nhapCtrl.CapNhatSL(nhap);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lamMoi();
        }

        public void NhapCauHinh()
        {
            int[] maThietBi = new int[12];
            maThietBi = cauHinhCtrl.LayCauHinh(Convert.ToInt32(cboCauHinh.SelectedValue.ToString()));
            
            nhap.MaNhap = nhapCtrl.GetID() + 1;
            nhap.NgayNhap = Convert.ToDateTime(dtmNgayNhap.Value);
            nhap.MaCauHinh = Convert.ToInt32(cboCauHinh.SelectedValue.ToString());
            nhap.NhaCungCap = txtNhaCungCap.Text;
            nhap.NhaSanXuat = txtNSX.Text;
            nhap.NamSanXuat = Convert.ToInt32(txtNamSX.Text);
            nhap.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            nhap.DonGia = Convert.ToInt32(txtDonGia.Text);
            nhap.NguoiPhuTrach = user.TenTK;
            nhap.GhiChu = rtbGhiChu.Text;

            nhapCtrl.ThemCauHinh(nhap);
            for (int i = 1; i < 12; i++)
            {
                nhap.MaThietBi = maThietBi[i];
                nhapCtrl.CapNhatSL(nhap);
            }
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lamMoi();
        }

        //Hàm xử lý cho button thêm mới.
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTra())
            {
                DialogResult dlg = MessageBox.Show("Lịch sử nhập không thể chỉnh sửa sau khi đã thêm.\nHày chắc rằng dữ liệu nhập vào là đúng.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    if (cboCauHinh.Text != "")
                    {
                        NhapCauHinh();
                    }
                    else if(cboTenThietBi.Text != "")
                    {
                        NhapThietBi();
                    }
                    nhapCtrl.HienThiDgv(dgvDSNThietBi, dgvDSNCauHinh);
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
            else if (radNgayNhap.Checked)
            {
                key1 = dtmTu.Value.ToString();
                key2 = dtmDen.Value.ToString();
                loaiTK = "ngayNhap";
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
            else if(radNhaCungCap.Checked)
            {
                key1 = txtTimKiem.Text;
                loaiTK = "nhaCungCap";
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
                if(radCauHinh.Checked!=true && radThietBi.Checked != true)
                {
                    nhapCtrl.TimKiemTB(dgvDSNThietBi, key1, key2, loaiTK);
                    nhapCtrl.TimKiemCH(dgvDSNCauHinh, key1, key2, loaiTK);
                }
                else if(radCauHinh.Checked == true)
                {
                    nhapCtrl.TimKiemCH(dgvDSNCauHinh, key1, key2, loaiTK);
                }
                else
                {
                    nhapCtrl.TimKiemTB(dgvDSNThietBi, key1, key2, loaiTK);
                }
            }
            else if (radNgayNhap.Checked && loaiTK != "")
            {
                nhapCtrl.TimKiemTB(dgvDSNThietBi, key1, key2, loaiTK);
                nhapCtrl.TimKiemCH(dgvDSNCauHinh, key1, key2, loaiTK);
            }
        }
        
        //Hàm xử lý cho button làm mới.
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
            nhapCtrl.HienThiDgv(dgvDSNThietBi, dgvDSNCauHinh);
        }

        private void radNgayNhap_CheckedChanged(object sender, EventArgs e)
        {
            if(radNgayNhap.Checked == true)
            {
                dtmDen.Enabled = true;
                dtmTu.Enabled = true;
                txtTimKiem.Enabled = false;
            }
        }

        private void radNguoiPhuTrach_CheckedChanged(object sender, EventArgs e)
        {
            if (radNgayNhap.Checked == false)
            {
                dtmDen.Enabled = false;
                dtmTu.Enabled = false;
                txtTimKiem.Enabled = true;
            }
        }
    }
}
