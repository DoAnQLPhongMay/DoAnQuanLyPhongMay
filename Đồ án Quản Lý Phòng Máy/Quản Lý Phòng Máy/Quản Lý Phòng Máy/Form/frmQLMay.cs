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
        LSCapNhatCtrl lsCNCtrl = new LSCapNhatCtrl();
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

            txtTenMay.ReadOnly = true;
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

            txtTenMay.ReadOnly = false;
            txtSoLuong.ReadOnly = true;
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
            txtSoLuong.Clear();
            
            for(int i = 1;i < 12; i++)
            {
                txt[i].Clear();
            }

            cboPhong.Text = "";
            cboTrangThai.Text = "";
            cboCauHinh.Text = "";

            txtTenMay.ReadOnly = true;
            txtSoLuong.ReadOnly = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;

            mayCtrl.HienThi(dgvDSMay);
        }

        private bool KiemTra()
        {
            if (txtTenMay.Text == "" && txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên máy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(txtTenMay.Text != "" && txtSoLuong.Text != "")
            {
                MessageBox.Show("Vui lòng bỏ số lượng nếu muốn thêm 1 máy hoặc bỏ trống tên máy nếu muốn thêm nhiều máy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Tên máy đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(txtSoLuong.Text != "")
            {
                if(Convert.ToInt32(txtSoLuong.Text) + phongCtrl.GetCountMay(Convert.ToInt32(cboPhong.SelectedValue)) > phongCtrl.GetSL(Convert.ToInt32(cboPhong.SelectedValue)))
                {
                    MessageBox.Show("Số lượng máy cần tạo lớn hơn số máy phòng có thể chứa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        void ThemMoi(string tenMay)
        {
            May may = new May();
            LichSuCapNhat ls = new LichSuCapNhat();

            may.MaMay = mayCtrl.GetID() + 1;
            may.TenMay = tenMay;
            may.MaPhong = Convert.ToInt32(cboPhong.SelectedValue);
            may.MaCauHinh = Convert.ToInt32(cboCauHinh.SelectedValue);
            may.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue);
            may.GhiChu = rtbGhiChu.Text;

            ls.MaCapNhat = lsCNCtrl.GetID() + 1;
            ls.TenMay = txtTenMay.Text;
            ls.MaPhongMay = may.MaPhong;
            ls.MaMay = may.MaMay;
            ls.MaCauHinh = may.MaCauHinh;
            ls.GhiChu = may.GhiChu;
            ls.TenDangNhap = user.TenTK;
            ls.NgayCapNhat = DateTime.Now;

            mayCtrl.ThemMoi(may);
            lsCNCtrl.ThemMoi(ls);
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                int slTao = Convert.ToInt32(txtSoLuong.Text);
                int slHienTai = phongCtrl.GetCountMay(Convert.ToInt32(cboPhong.SelectedValue));

                for (int i = slHienTai + 1; i <= slHienTai + slTao; i++)
                {
                    string tenMay = cboPhong.Text + "-" + i.ToString();
                    ThemMoi(tenMay);
                }
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
                LichSuCapNhat ls = new LichSuCapNhat();

                may.MaMay = Convert.ToInt32(txtMaMay.Text);
                may.TenMay = txtTenMay.Text;
                may.MaPhong = Convert.ToInt32(cboPhong.SelectedValue);
                may.MaCauHinh = Convert.ToInt32(cboCauHinh.SelectedValue);
                may.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue);
                may.GhiChu = rtbGhiChu.Text;

                ls.MaCapNhat = lsCNCtrl.GetID() + 1;
                ls.TenMay = txtTenMay.Text;
                ls.MaPhongMay = may.MaPhong;
                ls.MaMay = may.MaMay;
                ls.MaCauHinh = may.MaCauHinh;
                ls.GhiChu = may.GhiChu;
                ls.TenDangNhap = user.TenTK;
                ls.NgayCapNhat = DateTime.Now;

                MessageBox.Show("Cập nhập khoa thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mayCtrl.CapNhatMay(may);
                lsCNCtrl.ThemMoi(ls);
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

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
