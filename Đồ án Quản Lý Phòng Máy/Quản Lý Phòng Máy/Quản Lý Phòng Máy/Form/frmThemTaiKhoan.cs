using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmThemTaiKhoan : Form
    {
        //Khởi tạo các biến giá trị.
        TaiKhoanCtrl tkctrl = new TaiKhoanCtrl();
        User user = new User();
        string text;

        //Hàm khởi tạo mặc định.
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        public frmThemTaiKhoan(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        //Hàm xử lý load giao diện.
        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "User");
            test.Add(1, "Admin");
            cboLoaiTaiKhoan.DataSource = new BindingSource(test, null);
            cboLoaiTaiKhoan.DisplayMember = "Value";
            cboLoaiTaiKhoan.ValueMember = "Key";
        }

        //Hàm xử lý chỉ cho nhập dữ liệu số.
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Hàm xử lý kiểm tra dữ liệu.
        private bool KiemTra()
        {
            bool ktra = true;

            if (txtTenTaiKhoan.Text == "")
            {
                text = "Vui lòng nhập họ & tên!";
                ThongBao(text);
                ktra = false;
            }
            else if (txtMaTaiKhoan.Text == "")
            {
                text = "Vui lòng nhập mã tài khoản!";
                ThongBao(text);
                ktra = false;
            }
            else if (txtSDT.Text == "")
            {
                text = "Vui lòng nhập Số điện thoại!";
                ThongBao(text);
                ktra = false;
            }
            else if(txtSDT.TextLength < 10)
            {
                text = "SĐT không hợp lệ!";
                ThongBao(text);
                ktra = false;
            }
            else if (txtEmail.Text == "")
            {
                text = "Vui lòng nhập Email!";
                ThongBao(text);
                ktra = false;
            }
            else if (dtNgaySinh.Text == "")
            {
                text = "Vui lòng nhập ngày sinh!";
                ThongBao(text);
                ktra = false;
            }
            else if (cboLoaiTaiKhoan.Text == "")
            {
                text = "Vui lòng chọn loại TK!";
                ThongBao(text);
                ktra = false;
            }
            else if (txtTenDangNhap.Text == "")
            {
                text = "Vui lòng nhập Tên đăng nhập!";
                ThongBao(text);
                ktra = false;
            }
            else if (txtMatKhau.Text == "")
            {
                text = "Vui lòng nhập mật khẩu!";
                ThongBao(text);
                ktra = false;
            }

            return ktra;
        }

        //Hàm làm mới các text.
        private void LamMoi()
        {
            txtTenDangNhap.Clear();
            txtTenTaiKhoan.Clear();
            txtSDT.Clear();
            txtMatKhau.Clear();
            txtMaTaiKhoan.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            cboLoaiTaiKhoan.Text = "";
        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(TaiKhoan tk)
        {

            tk.TenGV = txtTenTaiKhoan.Text;
            tk.MaGV = txtMaTaiKhoan.Text;
            tk.Gioitinh = (rdNam.Checked) ? true : false;
            tk.SDT = txtSDT.Text;
            tk.Email = txtEmail.Text;
            tk.Ngaysinh = Convert.ToDateTime(dtNgaySinh.Value);
            tk.Diachi = txtDiaChi.Text;
            tk.TenDangNhap = txtTenDangNhap.Text;
            tk.MatKhau = txtMatKhau.Text;
            tk.Loaitaikhoan = Convert.ToInt32(cboLoaiTaiKhoan.SelectedValue);
        }

        //Hàm xử lý thêm mới.
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                TaiKhoan tk = new TaiKhoan();
                GanDuLieu(tk);

                {
                    switch (tkctrl.Them(tk))
                    {
                        case -1:
                            text = "Tên đăng nhập đã tồn tại!";
                            ThongBao(text);
                            break;
                        case 0:
                            text = "Số điện thoại không hợp lệ!";
                            ThongBao(text);
                            break;
                        case 2:
                            text = "Mã Tài Khoản đã tồn tại";
                            ThongBao(text);
                            break;
                        case 1:
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoi();
                            break;
                    }
                }
            }
        }

        //Hàm xử lý đóng giao diện.
        private void btnThoat_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        //Hàm xử lý làm mới text.
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
