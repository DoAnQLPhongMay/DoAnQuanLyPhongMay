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
        TaiKhoanCtrl tkctrl = new TaiKhoanCtrl();
        Quyenctrl quyenctrl = new Quyenctrl();
        User user = new User();

        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        public frmThemTaiKhoan(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        bool KiemTra()
        {
            bool ktra = true;

            if (txtTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ & tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else if (txtMaTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else if (dtNgaySinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else if (cboLoaiTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại TK.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }

            return ktra;
        }

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

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                TaiKhoan tk = new TaiKhoan();
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

                {
                    switch (tkctrl.Them(tk))
                    {
                        case -1:
                            MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 0:
                            MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("Mã Tài Khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 1:
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoi();
                            break;
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        public bool txtLoaiTaiKhoan { get; set; }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            Dictionary<int,string> test = new Dictionary<int, string>();
            test.Add(0, "User");
            test.Add(1, "Admin");
            cboLoaiTaiKhoan.DataSource = new BindingSource(test, null);
            cboLoaiTaiKhoan.DisplayMember = "Value";
            cboLoaiTaiKhoan.ValueMember = "Key";
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
