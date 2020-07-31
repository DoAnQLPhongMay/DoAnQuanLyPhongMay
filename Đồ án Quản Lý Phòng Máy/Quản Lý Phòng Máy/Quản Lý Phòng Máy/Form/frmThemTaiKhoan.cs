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
            tk.Ngaysinh = dtNgaySinh.Value;
            tk.Diachi = txtDiaChi.Text;
            tk.TenDangNhap = txtTenDangNhap.Text;
            tk.MatKhau = txtMatKhau.Text;
            //tk.LoaiTaiKhoan = (cbLoaiTaiKhoan.Click) ? true : false ;
            switch (tkctrl.Them(tk))
            {
                case -1:
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 0:
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 1:
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
