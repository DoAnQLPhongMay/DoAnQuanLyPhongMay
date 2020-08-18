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
            int maMay = Convert.ToInt32(dgvDSMay.CurrentRow.Cells[0].Value);

            txtMaMay.Text = dgvDSMay.CurrentRow.Cells[0].Value.ToString();
            txtTenMay.Text = dgvDSMay.CurrentRow.Cells[1].Value.ToString();
            cboPhong.SelectedValue = dgvDSMay.CurrentRow.Cells[6].Value.ToString();
            cboTrangThai.SelectedValue = dgvDSMay.CurrentRow.Cells[5].Value.ToString();
            rtbGhiChu.Text = dgvDSMay.CurrentRow.Cells[4].Value.ToString();

            btnCapNhat.Enabled = true;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void LamMoi()
        {
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
            May may = new May();
            may.MaMay = mayCtrl.GetID() + 1;
            may.TenMay = txtTenMay.Text;
            may.MaPhong = Convert.ToInt32(cboPhong.SelectedValue);
            may.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue);
            may.GhiChu = rtbGhiChu.Text;

            if (txtTenMay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên Máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cboPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn trạng thái máy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(mayCtrl.ThemMoi(may) == 0)
            {
                MessageBox.Show("Tên Máy đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mayCtrl.ThemLSCapNhat(may, user.TenTK);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
                mayCtrl.ThemLSCapNhat(may, user.TenTK);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
