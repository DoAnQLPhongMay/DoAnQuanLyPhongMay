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

        private void dgv_DSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTin();
        }

        private void frm_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            /*string querry = "SELECT * FROM dtb_TaiKhoan";
            DataSet ds = DBUtils.dsTable(querry, conn);

            dgv_DSTaiKhoan.DataSource = ds.Tables[0];
            dgv_DSTaiKhoan.Refresh();*/
            tkctrl.HienThi(dgv_DSTaiKhoan);
            HienThiThongTin();
        }
        void HienThiThongTin()
        {
            if (dgv_DSTaiKhoan.CurrentRow != null)
            {
                txt_TenTaiKhoan.Text = dgv_DSTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                checkRadio();
                txt_SDT.Text = dgv_DSTaiKhoan.CurrentRow.Cells[3].Value.ToString();
                dtm_NgaySinh.Value = DateTime.Parse(dgv_DSTaiKhoan.CurrentRow.Cells[4].Value.ToString());
                txt_DiaChi.Text = dgv_DSTaiKhoan.CurrentRow.Cells[5].Value.ToString();
                txt_Username.Text = dgv_DSTaiKhoan.CurrentRow.Cells[6].Value.ToString();
                txt_Password.Text = dgv_DSTaiKhoan.CurrentRow.Cells[7].Value.ToString();
            }
        }
        void checkRadio()
        {
            string gtri = dgv_DSTaiKhoan.CurrentRow.Cells[2].Value.ToString();
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
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                if (tkctrl.Xoa(int.Parse(txt_Username.Text)) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tkctrl.HienThi(dgv_DSTaiKhoan);
                    HienThiThongTin();
                }
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            if (tkctrl.Luu(taikhoan) > 0)
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tkctrl.HienThi(dgv_DSTaiKhoan);
                HienThiThongTin();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rad_TenTaiKhoan.Checked)
                tieuchi = "tentaikhoan";
            else if (rad_SDT.Checked)
                tieuchi = "sdt";
            else
                tieuchi = "tendangnhap";

            if (txt_TiemKiem.Text.Length == 0)
                tkctrl.HienThi(dgv_DSTaiKhoan);
            else
                tkctrl.HienThiTK(dgv_DSTaiKhoan, txt_TiemKiem.Text, tieuchi);
        }
    }
}
