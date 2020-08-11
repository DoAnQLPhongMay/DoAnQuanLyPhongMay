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
        //Khởi tạo các biến giá trị và kết nối.
        PhongMayCtrl phongCtrl = new PhongMayCtrl();
        PhongMay phong = new PhongMay();
        TrangThaiCtrl trangThaiCtrl = new TrangThaiCtrl();
        User user = new User();

        public frmQLPhongMay()
        {
            InitializeComponent();
        }

        public frmQLPhongMay(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        //Hàm xử lý load dữ liệu khi mở form.
        private void frm_QLPhongMay_Load(object sender, EventArgs e)
        {
            phongCtrl.HienThiDgv(dgvDSPhong);
            trangThaiCtrl.HienThiCbo(cboTrangThai);
            cboTrangThai.Text = "";
            btnCapNhap.Enabled = false;
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtMaPhong.Text = dgvDSPhong.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dgvDSPhong.CurrentRow.Cells[1].Value.ToString();
            txtSoLuongMay.Text = dgvDSPhong.CurrentRow.Cells[2].Value.ToString();
            cboTrangThai.SelectedValue = dgvDSPhong.CurrentRow.Cells[3].Value.ToString();
            rtbGhiChu.Text = dgvDSPhong.CurrentRow.Cells[4].Value.ToString();

            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnChiTiet.Enabled = false;
            btnCapNhap.Enabled = true;
        }

        private void lamMoi()
        {
            txtMaPhong.Clear();
            txtSoLuongMay.Clear();
            txtTenPhong.Clear();
            rtbGhiChu.Clear();
            cboTrangThai.Text = "";
            radMaPhong.Checked = false;
            radTenPhong.Checked = false;
            radTrangThai.Checked = false;

            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnChiTiet.Enabled = true;
            btnCapNhap.Enabled = false;
            phongCtrl.HienThiDgv(dgvDSPhong);
        }

        public bool kiemTra()
        {
            bool kTra = true;

            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if (cboTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn trạng thái phòng.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if (phongCtrl.KTTenPhong(txtTenPhong.Text))
            {
                MessageBox.Show("Tên phòng máy đã tồn tại.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else
            {
                if (txtSoLuongMay.Text == "")
                {
                    txtSoLuongMay.Text = "0";
                }
            }

            return kTra;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (kiemTra())
            {
                phong.MaPhong = phongCtrl.GetID() + 1;
                phong.TenPhong = txtTenPhong.Text;
                phong.SoLuongMay = Convert.ToInt32(txtSoLuongMay.Text);
                phong.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue.ToString());
                phong.GhiChu = rtbGhiChu.Text;

                phongCtrl.Them(phong);
                MessageBox.Show("Thêm phòng máy thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lamMoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSPhong.CurrentRow != null)
            {
                int maPhong = Convert.ToInt32(dgvDSPhong.CurrentRow.Cells[0].Value);
                phongCtrl.Xoa(maPhong);
                MessageBox.Show("Xóa phòng máy thành công.", "Thông Báo", MessageBoxButtons.OK);
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
            if (kiemTra())
            {
                phong.MaPhong = Convert.ToInt32(txtMaPhong.Text);
                phong.TenPhong = txtTenPhong.Text;
                phong.SoLuongMay = Convert.ToInt32(txtSoLuongMay.Text);
                phong.TrangThai = Convert.ToInt32(cboTrangThai.SelectedValue.ToString());
                phong.GhiChu = rtbGhiChu.Text;

                phongCtrl.CapNhat(phong);
                MessageBox.Show("Cập nhật phòng máy thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lamMoi();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgvDSPhong.CurrentRow != null)
            {
                int maPhong = Convert.ToInt32(dgvDSPhong.CurrentRow.Cells[0].Value.ToString());
                frmChiTietPhongMay frm = new frmChiTietPhongMay(maPhong);
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 phòng trong danh sách.", "Thông báo", MessageBoxButtons.OK);
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
