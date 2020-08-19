using System;
using System.Windows.Forms;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmQLMay : Form
    {
        TrangThaiCtrl trangThaiCtrl = new TrangThaiCtrl();
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        PhongMayCtrl phongCtrl = new PhongMayCtrl();
        CauHinhCtrl cauHinhCtrl = new CauHinhCtrl();
        MayCtrl mayCtrl = new MayCtrl();
        User user = new User();
        TextBox[] txt = new TextBox[12];
        string tenMay;

        public frmQLMay()
        {
            InitializeComponent();
        }

        public frmQLMay(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void frmQLMay_Load(object sender, EventArgs e)
        {
            mayCtrl.HienThi(dgvDSMay);
            trangThaiCtrl.HienThiCbo(cboTrangThai);
            phongCtrl.HienThiCbo(cboPhong);
            cauHinhCtrl.HienThiCbo(cboCauHinh);

            cboPhong.Text = "";
            cboTrangThai.Text = "";
            cboCauHinh.Text = "";
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tenMay = dgvDSMay.CurrentRow.Cells["TenMay"].Value.ToString();
            txtMaMay.Text = dgvDSMay.CurrentRow.Cells["MaMay"].Value.ToString();
            txtTenMay.Text = dgvDSMay.CurrentRow.Cells["TenMay"].Value.ToString();
            cboPhong.SelectedValue = dgvDSMay.CurrentRow.Cells["MaPhong"].Value.ToString();
            cboTrangThai.SelectedValue = dgvDSMay.CurrentRow.Cells["MaTrangThai"].Value.ToString();
            cboCauHinh.SelectedValue = dgvDSMay.CurrentRow.Cells["MaCauHinh"].Value.ToString();
            rtbGhiChu.Text = dgvDSMay.CurrentRow.Cells["GhiChu"].Value.ToString();

            btnCapNhat.Enabled = true;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void LuuTxt(TextBox[] txt)
        {
            txt[1] = txtManHinh;
            txt[2] = txtChuot;
            txt[3] = txtBanPhim;
            txt[4] = txtCase;
            txt[5] = txtCPU;
            txt[6] = txtMainBoard;
            txt[7] = txtRAM;
            txt[8] = txtOCung;
            txt[9] = txtVGA;
            txt[10] = txtPSU;
            txt[11] = txtHDH;
        }

        private void LamMoi()
        {
            LuuTxt(txt);
            rtbGhiChu.Clear();
            txtMaMay.Clear();
            txtTenMay.Clear();
            
            for(int i = 1;i < 12; i++)
            {
                txt[i].Clear();
            }

            cboPhong.Text = "";
            cboTrangThai.Text = "";
            cboCauHinh.Text = "";

            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;

            mayCtrl.HienThi(dgvDSMay);
        }

        private bool KiemTra()
        {
            if (txtTenMay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên máy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cboPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cboTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn trạng thái máy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cboCauHinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn cấu hình máy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (mayCtrl.KTTenMay(txtTenMay.Text) && tenMay != txtTenMay.Text)
            {
                MessageBox.Show("Tên máy đã tồn tại.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                May may = new May();
                may.MaMay = mayCtrl.GetID() + 1;
                may.TenMay = txtTenMay.Text;
                may.MaPhong = Convert.ToInt32(cboPhong.SelectedValue);
                may.MaCauHinh = Convert.ToInt32(cboCauHinh.SelectedValue);
                may.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue);
                may.GhiChu = rtbGhiChu.Text;

                mayCtrl.ThemMoi(may);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (user.PhanQuyen)
            {
                if (dgvDSMay.CurrentRow != null)
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dlg == System.Windows.Forms.DialogResult.Yes)
                    {
                        int maMay = Convert.ToInt32(dgvDSMay.CurrentRow.Cells["MaMay"].Value);
                        mayCtrl.Xoa(maMay);

                        MessageBox.Show("Xóa khoa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LamMoi();
                    }
                }
                else
                {
                    MessageBox.Show("Vùi lòng chọn khoa muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn không được cấp quyền để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                May may = new May();
                may.MaMay = Convert.ToInt32(txtMaMay.Text);
                may.TenMay = txtTenMay.Text;
                may.MaPhong = Convert.ToInt32(cboPhong.SelectedValue);
                may.MaCauHinh = Convert.ToInt32(cboCauHinh.SelectedValue);
                may.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue);
                may.GhiChu = rtbGhiChu.Text;

                MessageBox.Show("Cập nhập khoa thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mayCtrl.CapNhatMay(may);
                LamMoi();
            }
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
          
            if (radTenMay.Checked)
                tieuchi = "tenmay";
            if (txtTimKiem.Text.Length == 0)
                mayCtrl.HienThi(dgvDSMay);
            else
                mayCtrl.TimKiem(dgvDSMay, txtTimKiem.Text, tieuchi);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
