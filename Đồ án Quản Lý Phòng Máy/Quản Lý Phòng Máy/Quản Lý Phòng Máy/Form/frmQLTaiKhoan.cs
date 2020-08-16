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
            HienThiThongTin();
        }
        void HienThiThongTin()
        {
            if (dgvDSTaiKhoan.CurrentRow != null)
            {
                txt_Username.Text = dgvDSTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                txt_TenTaiKhoan.Text = dgvDSTaiKhoan.CurrentRow.Cells[2].Value.ToString();
                checkRadio();
                txt_SDT.Text = dgvDSTaiKhoan.CurrentRow.Cells[4].Value.ToString();
                dtm_NgaySinh.Value = DateTime.Parse(dgvDSTaiKhoan.CurrentRow.Cells[6].Value.ToString());
                txt_DiaChi.Text = dgvDSTaiKhoan.CurrentRow.Cells[7].Value.ToString();
                txtMaQuyen.Text = dgvDSTaiKhoan.CurrentRow.Cells[8].Value.ToString();
            }
        }
        void checkRadio()
        {
            string gtri = dgvDSTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            rad_Nam.Checked = (gtri == "True") ? true : false;
            rad_Nu.Checked = (gtri == "False") ? true : false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan themtk = new frmThemTaiKhoan();
            this.Hide();
            themtk.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(tkctrl.KiemTraMaQuyen(Convert.ToInt32(txtMaQuyen.Text)) != true)
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
            tk.TenGV = txt_TenTaiKhoan.Text;
            tk.Gioitinh = (rad_Nam.Checked) ? true : false;
            tk.SDT = txt_SDT.Text;
            tk.Ngaysinh = Convert.ToDateTime(dtm_NgaySinh.Value);
            tk.Diachi = txt_DiaChi.Text;
            tk.TenDangNhap = txt_Username.Text;

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
