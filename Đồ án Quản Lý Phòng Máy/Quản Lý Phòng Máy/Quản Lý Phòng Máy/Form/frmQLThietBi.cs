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
    public partial class frmQLThietBi : Form
    {
        //Khởi tạo các biến giá trị và kết nối.
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        ThietBi thietBi = new ThietBi();
        LoaiThietBiCtrl loaiThietBiCtrl = new LoaiThietBiCtrl();
        string loaiThietBi = "";
        User user = new User();

        //Hàm xử lý khởi tạo mặc định của form.
        public frmQLThietBi()
        {
            InitializeComponent();
        }

        public frmQLThietBi(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        //Hàm xử lý load dữ liệu khi mở form.
        private void frm_QLMay_Load(object sender, EventArgs e)
        {
            thietBiCtrl.HienThiDgv(dgvDSThietBi);
            loaiThietBiCtrl.HienThiCbo(cboLoaiThietBi);
            cboLoaiThietBi.Text = "";
            btnCapNhat.Enabled = false;
        }

        //Hàm lấy và gán các giá trị từ Datagridview.
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtMaThietBi.Text = dgvDSThietBi.CurrentRow.Cells[0].Value.ToString();
            txtTenThietBi.Text = dgvDSThietBi.CurrentRow.Cells[1].Value.ToString();
            rtbThongSo.Text = dgvDSThietBi.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvDSThietBi.CurrentRow.Cells[3].Value.ToString();
            cboLoaiThietBi.SelectedValue = dgvDSThietBi.CurrentRow.Cells[4].Value.ToString();
            txtNhaSanXuat.Text = dgvDSThietBi.CurrentRow.Cells[6].Value.ToString();
            txtNamSanXuat.Text = dgvDSThietBi.CurrentRow.Cells[5].Value.ToString();
            txtHanThanhLy.Text = dgvDSThietBi.CurrentRow.Cells[7].Value.ToString();
            rtbGhiChu.Text = dgvDSThietBi.CurrentRow.Cells[8].Value.ToString();

            loaiThietBi = cboLoaiThietBi.Text;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        //Hàm xử lý làm mới các text.
        private void lamMoi()
        {
            txtMaThietBi.Clear();
            txtTenThietBi.Clear();
            rtbThongSo.Clear();
            txtSoLuong.Clear();
            cboLoaiThietBi.Text = "";
            txtNhaSanXuat.Clear();
            txtNamSanXuat.Clear();
            txtHanThanhLy.Clear();
            rtbGhiChu.Clear();
            radLoaiThietBi.Checked = false;
            radMaThietBi.Checked = false;
            radNhaSanXuat.Checked = false;
            radTenThietBi.Checked = false;

            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
            thietBiCtrl.HienThiDgv(dgvDSThietBi);
        }

        //Hàm kiểm tra dữ liệu các text.
        public bool kiemTra()
        {
            bool kTra = true;

            if(txtTenThietBi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else if(cboLoaiThietBi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại thiết bị.", "Thông báo!", MessageBoxButtons.OK);
                kTra = false;
            }
            else
            {
                if (txtSoLuong.Text == "")
                {
                    txtSoLuong.Text = "0";
                }
                if (txtHanThanhLy.Text == "")
                {
                    txtHanThanhLy.Text = "0";
                }
                if (txtNamSanXuat.Text == "")
                {
                    txtNamSanXuat.Text = DateTime.Now.Year.ToString();
                }
            }

            return kTra;
        }

        //Hàm xử lý chức năng thêm mới 1 thiết bị.
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemTra())
            {
                thietBi.MaThietBi = thietBiCtrl.GetID() + 1;
                thietBi.TenThietBi = txtTenThietBi.Text;
                thietBi.ThongSoThietBi = rtbThongSo.Text;
                thietBi.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                thietBi.MaLoai = Convert.ToInt32(cboLoaiThietBi.SelectedValue.ToString());
                thietBi.NhaSanXuat = txtNhaSanXuat.Text;
                thietBi.NamSanXuat = Convert.ToInt32(txtNamSanXuat.Text);
                thietBi.HanThanhLy = Convert.ToInt32(txtHanThanhLy.Text);
                thietBi.GhiChu = rtbGhiChu.Text;

                thietBiCtrl.Them(thietBi);
                MessageBox.Show("Thêm thiết bị thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lamMoi();
            }
        }

        //Hàm xử lý chức năng xóa 1 thiết bị.
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(dgvDSThietBi.CurrentRow != null)
            {
                int maThietBi = Convert.ToInt32(dgvDSThietBi.CurrentRow.Cells[0].Value);
                thietBiCtrl.Xoa(maThietBi);
                MessageBox.Show("Xóa thiết bị thành công!", "Thông Báo", MessageBoxButtons.OK);
                thietBiCtrl.HienThiDgv(dgvDSThietBi);
                lamMoi();
            }
            else
            {
                MessageBox.Show("Vùi lòng chọn thiết bị muốn xóa ở danh sách thiết bị!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        //Hàm xử lý chức năng cập nhật 1 thiết bị.
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (thietBiCtrl.KTThietBi(Convert.ToInt32(txtMaThietBi.Text)) && loaiThietBi != cboLoaiThietBi.Text)
            {
                MessageBox.Show("Thiết bị đang được sử dụng không thể thay loại thiết bị.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (kiemTra())
            {
                thietBi.MaThietBi = Convert.ToInt32(txtMaThietBi.Text);
                thietBi.TenThietBi = txtTenThietBi.Text;
                thietBi.ThongSoThietBi = rtbThongSo.Text;
                thietBi.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                thietBi.MaLoai = Convert.ToInt32(cboLoaiThietBi.SelectedValue.ToString());
                thietBi.NhaSanXuat = txtNhaSanXuat.Text;
                thietBi.NamSanXuat = Convert.ToInt32(txtNamSanXuat.Text);
                thietBi.HanThanhLy = Convert.ToInt32(txtHanThanhLy.Text);
                thietBi.GhiChu = rtbGhiChu.Text;

                MessageBox.Show("Cập nhập thiết bị thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thietBiCtrl.CapNhat(thietBi);
                lamMoi();
            }
            else
            {
                MessageBox.Show("Cập nhập thiết bị thất bại.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Hàm xử lý chức năng tìm kiếm 1 thiết bị.
        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            string loaiTK = "";

            if (radMaThietBi.Checked)
                loaiTK = "maThietBi";
            else if (radTenThietBi.Checked)
                loaiTK = "tenThietBi";
            else if (radNhaSanXuat.Checked)
                loaiTK = "nhaSanXuat";
            else if (radLoaiThietBi.Checked)
                loaiTK = "maLoai";
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }

            if (txtTimKiem.Text.Length != 0 && loaiTK != "")
            {
                thietBiCtrl.TimKiem(dgvDSThietBi, txtTimKiem.Text, loaiTK);
            }
        }

        //Hàm xử lý chức năng làm mới dữ liệu của các text.
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        //-------------------------------------- Hàm không xử dụng --------------------------------------//
        private void grp_TimKiem_Enter(object sender, EventArgs e)
        {

        }
        private void dgv_DSMay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dgv_Click(object sender, EventArgs e)
        {
        }
    }
}
