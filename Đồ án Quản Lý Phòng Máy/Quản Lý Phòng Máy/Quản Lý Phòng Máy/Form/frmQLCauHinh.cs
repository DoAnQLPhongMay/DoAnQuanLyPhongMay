using System;
using System.Windows.Forms;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmQLCauHinh : Form
    {
        //Khởi tạo các biến giá trị và kết nối.
        CauHinh cauHinh = new CauHinh();
        CauHinhCtrl cauHinhCtrl = new CauHinhCtrl();
        ThietBiCtrl thietBiCtrl = new ThietBiCtrl();
        User user = new User();
        ComboBox[] cboCN = new ComboBox[12];
        ComboBox[] cboTemp = new ComboBox[12];
        string tenCauHinh;
        string text;

        //Hàm xử lý khởi tạo mặc định của form.
        public frmQLCauHinh()
        {
            InitializeComponent();
        }

        public frmQLCauHinh(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        //Hàm xử lý load dữ liệu khi mở form.
        private void frmThemMay_Load(object sender, EventArgs e)
        {
            LuuCbo(cboTemp);
            cauHinhCtrl.HienThiDgv(dgvDSCauHinh);

            for (int i = 1; i < 12; i++)
            {
                thietBiCtrl.HienThiCbo(cboTemp[i], i);
                cboTemp[i].Text = "";
            }

            btnCapNhat.Enabled = false;
        }

        //Hàm lấy và gán các giá trị từ Datagridview.
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            LuuCbo(cboCN);
            txtMaCauHinh.Text = dgvDSCauHinh.CurrentRow.Cells[0].Value.ToString();
            txtTenCauHinh.Text = dgvDSCauHinh.CurrentRow.Cells[1].Value.ToString();
            tenCauHinh = txtTenCauHinh.Text;

            for (int i = 1; i < 12; i++)
            {
                cboCN[i].SelectedValue = dgvDSCauHinh.CurrentRow.Cells[i+1].Value.ToString();
            }

            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        //Hàm xử lý các combobox.
        private void LuuCbo(ComboBox[] cbo)
        {
            cbo[1] = cboManHinh;
            cbo[2] = cboChuot;
            cbo[3] = cboBanPhim;
            cbo[4] = cboCase;
            cbo[5] = cboCPU;
            cbo[6] = cboMainBoard;
            cbo[7] = cboRAM;
            cbo[8] = cboOCung;
            cbo[9] = cboVGA;
            cbo[10] = cboPSU;
            cbo[11] = cboHDH;
        }

        //Hàm hiển thị thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Hàm xử lý làm mới các text.
        private void LamMoi()
        {
            LuuCbo(cboTemp);

            for (int i = 1; i < 12; i++)
            {
                cboTemp[i].Text = "";
            }

            txtMaCauHinh.Clear();
            txtTenCauHinh.Clear();
            txtTimKiem.Clear();
            radTenCauHinh.Checked = false;
            radThietBi.Checked = false;
            tenCauHinh = "";

            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
            cauHinhCtrl.HienThiDgv(dgvDSCauHinh);
        }

        //Hàm kiểm tra dữ liệu các text.
        private bool KiemTra()
        {
            LuuCbo(cboTemp);

            if (txtTenCauHinh.Text == "")
            {
                text = "Vui lòng nhập tên cấu hình!";
                ThongBao(text);
                return false;
            }
            else if (cauHinhCtrl.KTCauHinh(txtTenCauHinh.Text) && tenCauHinh != txtTenCauHinh.Text)
            {
                text = "Tên cấu hình đã tồn tại!";
                ThongBao(text);
                return false;
            }
            else
            {
                for (int i = 1; i < 12; i++)
                {
                    if (cboTemp[i].Text == "")
                    {
                        text = "Vui lòng chọn đầy đủ các thiết bị cho cấu hình!";
                        ThongBao(text);
                        return false;
                    }
                }
            }

            return true;
        }

        private void GanDuLieu(CauHinh cauHinh)
        {
            LuuCbo(cboTemp);
            cauHinh.TenCauHinh = txtTenCauHinh.Text;
            cauHinh.ManHinh = Convert.ToInt32(cboTemp[1].SelectedValue);
            cauHinh.Chuot = Convert.ToInt32(cboTemp[2].SelectedValue);
            cauHinh.BanPhim = Convert.ToInt32(cboTemp[3].SelectedValue);
            cauHinh.Case = Convert.ToInt32(cboTemp[4].SelectedValue);
            cauHinh.CPU = Convert.ToInt32(cboTemp[5].SelectedValue);
            cauHinh.MainBoard = Convert.ToInt32(cboTemp[6].SelectedValue);
            cauHinh.RAM = Convert.ToInt32(cboTemp[7].SelectedValue);
            cauHinh.OCung = Convert.ToInt32(cboTemp[8].SelectedValue);
            cauHinh.VGA = Convert.ToInt32(cboTemp[9].SelectedValue);
            cauHinh.PSU = Convert.ToInt32(cboTemp[10].SelectedValue);
            cauHinh.HDH = Convert.ToInt32(cboTemp[11].SelectedValue);
        }

        //Hàm xử lý chức năng thêm mới.
        private void btnThemMay_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                cauHinh.MaCauHinh = cauHinhCtrl.GetID() + 1;
                GanDuLieu(cauHinh);

                cauHinhCtrl.Them(cauHinh);
                MessageBox.Show("Thêm cấu hình thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LamMoi();
            }
        }

        //Hàm xử lý chức năng xóa.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (user.PhanQuyen == 1)
            {
                if (dgvDSCauHinh.CurrentRow != null)
                {
                    if(cauHinhCtrl.KTSuDung(Convert.ToInt32(dgvDSCauHinh.CurrentRow.Cells[0].Value)) == false)
                    {
                        DialogResult dlg = MessageBox.Show("Sau khi xóa sẽ không thể khôi phục.\nBạn thật sự muốn xóa cấu hình này?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dlg == System.Windows.Forms.DialogResult.Yes)
                        {
                            int maCauHinh = Convert.ToInt32(dgvDSCauHinh.CurrentRow.Cells[0].Value);
                            cauHinhCtrl.Xoa(maCauHinh);

                            MessageBox.Show("Xóa cấu hình thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LamMoi();
                        }
                    }
                    else
                    {
                        text = "Xóa thất bại. \nVẫn còn thiết bị đang sử dụng cấu hình này!";
                        ThongBao(text);
                    }
                }
                else
                {
                    text = "Vui lòng chọn cấu hình muốn xóa!";
                    ThongBao(text);
                }
            }
            else
            {
                text = "Bạn không được cấp quyền để xóa!";
                ThongBao(text);
            }
        }

        //Hàm xử lý chức năng cập nhật.
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    cauHinh.MaCauHinh = Convert.ToInt32(txtMaCauHinh.Text);
                    GanDuLieu(cauHinh);

                    MessageBox.Show("Cập nhập cấu hình thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cauHinhCtrl.CapNhat(cauHinh);
                    LamMoi();
                }
            }
        }

        //Hàm xử lý chức năng tìm kiếm.
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaiTK = "";

            if (radTenCauHinh.Checked)
            {
                loaiTK = "tenCauHinh";
            }
            else if (radThietBi.Checked)
            {
                loaiTK = "thietBi";
            }
            else
            {
                text = "Vui lòng chọn loại tìm kiếm!";
                ThongBao(text);
            }

            if (txtTimKiem.Text.Length != 0 && loaiTK != "")
            {
                cauHinhCtrl.TimKiem(dgvDSCauHinh, txtTimKiem.Text, loaiTK);
            }
        }

        //Hàm xử lý chức năng làm mới dữ liệu của các text.
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
