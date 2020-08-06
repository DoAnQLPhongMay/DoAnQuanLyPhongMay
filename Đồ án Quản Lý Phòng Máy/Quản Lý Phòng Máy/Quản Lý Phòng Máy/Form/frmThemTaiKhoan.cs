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
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmThemTaiKhoan : Form
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }
        TaiKhoanCtrl tkctrl = new TaiKhoanCtrl();
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
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
            //tk.LoaiTaiKhoan = (cbLoaiTaiKhoan.Click) ? true : false ;
            if (txtTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtNgaySinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                        break;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                frm_QLTaiKhoan frm = new frm_QLTaiKhoan();
                frm.Show();
                this.Hide();
            }    
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTaiKhoan.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtMatKhau.Text = "";
            txtSDT.Text = "";
            txtTenDangNhap.Text = "";
        }

        public bool txtLoaiTaiKhoan { get; set; }
    }
}
