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
        /*SqlConnection conn = DBUtils.GetDBConnection();
        public User user;*/
        TaiKhoanCtrl tkctrl = new TaiKhoanCtrl();

        public frm_QLTaiKhoan()
        {
            InitializeComponent();
        }

        

        private void frm_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            tkctrl.HienThi(dgvDSTaiKhoan);
            cboQuyenHan.Items.Insert(0, "User");
            cboQuyenHan.Items.Insert(1, "Admin");
            HienThiThongTin();
        }
        void HienThiThongTin()
        {
            if (dgvDSTaiKhoan.CurrentRow != null)
            {
                txtUsername.Text = dgvDSTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                txtMaTK.Text = dgvDSTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                txtHoTen.Text = dgvDSTaiKhoan.CurrentRow.Cells[2].Value.ToString();
                checkRadio();
                txtSDT.Text = dgvDSTaiKhoan.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvDSTaiKhoan.CurrentRow.Cells[5].Value.ToString();
                dtmNgaySinh.Value = Convert.ToDateTime(dgvDSTaiKhoan.CurrentRow.Cells[6].Value);
                txtDiaChi.Text = dgvDSTaiKhoan.CurrentRow.Cells[7].Value.ToString();
                cboQuyenHan.SelectedValue = Convert.ToInt32(dgvDSTaiKhoan.CurrentRow.Cells[8].Value);
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
            /*if(tkctrl.KiemTraMaQuyen(Convert.ToInt32(txtMaQuyen.Text)) != true)
                {
                                MessageBox.Show("không được xóa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }*/
            if (Convert.ToInt32(cboQuyenHan.SelectedValue) == 0)
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
    }
}
