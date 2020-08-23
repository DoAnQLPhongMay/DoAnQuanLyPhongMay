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
    public partial class frm_QLTaiKhoan : Form
    {
        //Khởi tạo các biến giá trị.
        TaiKhoanCtrl tkctrl = new TaiKhoanCtrl();
        User user = new User();
        string text;
        int loaiTK;

        //Hàm khởi tạo mặc định.
        public frm_QLTaiKhoan()
        {
            InitializeComponent();
        }

        public frm_QLTaiKhoan(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        //Hàm xử lý load giao diện.
        private void frm_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            tkctrl.HienThi(dgvDSTaiKhoan);
            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "User");
            test.Add(1, "Admin");
            cboQuyenHan.DataSource = new BindingSource(test, null);
            cboQuyenHan.DisplayMember = "Value";
            cboQuyenHan.ValueMember = "Key";
            HienThiThongTin();
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvDSTaiKhoan.CurrentRow != null)
            {
                txtUsername.Text = dgvDSTaiKhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
                txtMaTK.Text = dgvDSTaiKhoan.CurrentRow.Cells["MaTaiKhoan"].Value.ToString();
                txtHoTen.Text = dgvDSTaiKhoan.CurrentRow.Cells["HoVaTen"].Value.ToString();
                checkRadio();
                txtSDT.Text = dgvDSTaiKhoan.CurrentRow.Cells["SDT"].Value.ToString();
                txtEmail.Text = dgvDSTaiKhoan.CurrentRow.Cells["Email"].Value.ToString();
                dtmNgaySinh.Value = Convert.ToDateTime(dgvDSTaiKhoan.CurrentRow.Cells["NgaySinh"].Value);
                txtDiaChi.Text = dgvDSTaiKhoan.CurrentRow.Cells["DiaChi"].Value.ToString();
                cboQuyenHan.SelectedValue = Convert.ToInt32(dgvDSTaiKhoan.CurrentRow.Cells["LTK"].Value);
                loaiTK = Convert.ToInt32(dgvDSTaiKhoan.CurrentRow.Cells["LTK"].Value);
            }
        }

        private void dgvDSTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTin();
        }

        private void dgvDSTaiKhoan_Click(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void dgvDSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTin();
        }

        //Hàm xử lý làm mới các text.
        private void LamMoi()
        {
            txtUsername.Clear();
            txtMaTK.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txt_TiemKiem.Clear();

            radHoTen.Checked = false;
            radNam.Checked = false;
            radNu.Checked = false;
            radSDT.Checked = false;
            cboQuyenHan.Text = "";

            tkctrl.HienThi(dgvDSTaiKhoan);
        }

        //Hàm hiển thị thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Hàm xử lý kiểm tra dữ liệu.
        private bool KiemTra()
        {
            if(txtSDT.TextLength < 10)
            {
                text = "Bạn không được cấp quyền!";
                ThongBao(text);
                return false;
            }
            else if(txtEmail.Text == "")
            {
                text = "Vui lòng nhập Email!";
                ThongBao(text);
                return false;
            }
            else if (txtHoTen.Text == "")
            {
                text = "Vui lòng nhập Họ & Tên!";
                ThongBao(text);
                return false;
            }

            return true;
        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(TaiKhoan tk)
        {
            tk.TenGV = txtHoTen.Text;
            tk.Gioitinh = (radNam.Checked) ? true : false;
            tk.SDT = txtSDT.Text;
            tk.Ngaysinh = Convert.ToDateTime(dtmNgaySinh.Value);
            tk.Diachi = txtDiaChi.Text;
            tk.TenDangNhap = txtUsername.Text;
            tk.Email = txtEmail.Text;
            tk.Loaitaikhoan = Convert.ToInt32(cboQuyenHan.SelectedValue);
        }

        //Hàm chỉ cho phép nhập số từ bàn phím.
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Hàm xử lý chọn giới tính.
        void checkRadio()
        {
            string gtri = dgvDSTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            radNam.Checked = (gtri == "True") ? true : false;
            radNu.Checked = (gtri == "False") ? true : false;
        }

        //Hàm gọi giao diện thêm mới.
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (user.PhanQuyen == 1)
            {
                frmThemTaiKhoan themtk = new frmThemTaiKhoan(user);
                themtk.Show();
            }
            else
            {
                text = "Bạn không được cấp quyền!";
                ThongBao(text);
            }
        }

        //Hàm xử lý xóa.
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (user.PhanQuyen == 0)
            {
                text = "Bạn không được cấp quyền!";
                ThongBao(text);
            }
            else if (dgvDSTaiKhoan.CurrentRow != null)
            {
                string tendn = dgvDSTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (dlg == System.Windows.Forms.DialogResult.Yes)
                {
                    tkctrl.Xoa(tendn);
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tkctrl.HienThi(dgvDSTaiKhoan);
                    }
                }
            }

        }

        //Hàm xử lý cập nhật.
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            //3 if kiểm tra phân quyền.
            if (user.PhanQuyen == 1 || user.TenTK == txtUsername.Text)
            {
                if ((loaiTK == 0 && loaiTK == Convert.ToInt32(cboQuyenHan.SelectedValue) || user.PhanQuyen == 1 || loaiTK == 1))
                {
                    if(user.TenTK == txtUsername.Text && loaiTK != Convert.ToInt32(cboQuyenHan.SelectedValue))
                    {
                        user.PhanQuyen = Convert.ToInt32(cboQuyenHan.SelectedValue);
                    }

                    if (KiemTra())
                    {
                        TaiKhoan tk = new TaiKhoan();
                        GanDuLieu(tk);

                        string tendn = dgvDSTaiKhoan.CurrentRow.Cells[0].Value.ToString();

                        DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlg == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (tkctrl.Luu(tk) > 0)
                            {
                                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tkctrl.HienThi(dgvDSTaiKhoan);
                                HienThiThongTin();
                            }
                        }
                    }
                }
                else
                {
                    text = "User không thể thay đổi quyền!";
                    ThongBao(text);
                }
            }
            else
            {
                text = "Bạn không được cấp quyền!";
                ThongBao(text);
            }
        }

        //Hàm xử lý tìm kiếm.
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (radHoTen.Checked)
                tieuchi = "hoTen";
            else if (radSDT.Checked)
                tieuchi = "sdt";
            else
            {
                text = "Vui lòng chọn loại tìm kiếm!";
                ThongBao(text);
            }

            if (txt_TiemKiem.Text.Length != 0 && tieuchi != "")
            {

                tkctrl.HienThiTK(dgvDSTaiKhoan, txt_TiemKiem.Text, tieuchi);
            }


        }

        //Hàm xử lý làm mới text.
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
