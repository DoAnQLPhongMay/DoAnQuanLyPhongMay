﻿using System;
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
        /*SqlConnection conn = DBUtils.GetDBConnection();
        public User user;*/
        TaiKhoanCtrl tkctrl = new TaiKhoanCtrl();
        User user = new User();

        public frm_QLTaiKhoan()
        {
            InitializeComponent();
        }

        public frm_QLTaiKhoan(User user)
        {
            this.user = user;
            InitializeComponent();
        }

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
        void HienThiThongTin()
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
                cboQuyenHan.SelectedValue = Convert.ToInt32(dgvDSTaiKhoan.CurrentRow.Cells["LoaiTK"].Value);
            }
        }
        void checkRadio()
        {
            string gtri = dgvDSTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            radNam.Checked = (gtri == "True") ? true : false;
            radNu.Checked = (gtri == "False") ? true : false;
        }
      
        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan themtk = new frmThemTaiKhoan();
            this.Hide();
            themtk.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
           
            if (user.PhanQuyen == false)
            {
                MessageBox.Show("không được xóa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenGV = txtHoTen.Text;
            tk.Gioitinh = (radNam.Checked) ? true : false;
            tk.SDT = txtSDT.Text;
            tk.Ngaysinh = Convert.ToDateTime(dtmNgaySinh.Value);
            tk.Diachi = txtDiaChi.Text;
            tk.TenDangNhap = txtUsername.Text;
            tk.Email = txtEmail.Text;

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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rad_TenTaiKhoan.Checked)
                tieuchi = "hovaten";
            else if (rad_SDT.Checked)
                tieuchi = "sdt";
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }
            if (txt_TiemKiem.Text.Length != 0 && tieuchi != "")
            {

                tkctrl.HienThiTK(dgvDSTaiKhoan, txt_TiemKiem.Text, tieuchi);
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

        private void grpThongTinTaiKhoan_Enter(object sender, EventArgs e)
        {

        }
    }
}
