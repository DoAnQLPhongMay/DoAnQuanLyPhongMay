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
    public partial class frmQLMay : Form
    {
        MayCtrl mctrl = new MayCtrl();

        public frmQLMay()
        {
            InitializeComponent();
        }

        void HienThiThongTin()
        {
            if (dgv_DSMay.CurrentRow != null)
            {
                txt_MaMay.Text = dgv_DSMay.CurrentRow.Cells[0].Value.ToString();
                txt_TenMay.Text = dgv_DSMay.CurrentRow.Cells[1].Value.ToString();
                txtMaPhong.Text = dgv_DSMay.CurrentRow.Cells[2].Value.ToString();
                txtTrangThai.Text = dgv_DSMay.CurrentRow.Cells[5].Value.ToString();
                txt_GhiChu.Text = dgv_DSMay.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            frmThemMay frm = new frmThemMay();
            frm.Show();
            this.Hide();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                if (mctrl.Xoa(int.Parse(txt_MaMay.Text)) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mctrl.HienThi(dgv_DSMay);
                    HienThiThongTin();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            May may = new May(); 
            may.TenMay = txt_TenMay.Text;
            may.GhiChu = txt_GhiChu.Text;
            may.MaMay = int.Parse(txt_MaMay.Text);

            string mamay = dgv_DSMay.CurrentRow.Cells[0].Value.ToString();
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {

                if (mctrl.Luu(may) > 0)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mctrl.HienThi(dgv_DSMay);
                    HienThiThongTin();
                }
            }
            
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
          
            if (rad_TenMay.Checked)
                tieuchi = "tenmay";
            if (txt_TimKiem.Text.Length == 0)
                mctrl.HienThi(dgv_DSMay);
            else
                mctrl.TimKiem(dgv_DSMay, txt_TimKiem.Text, tieuchi);
        }

        private void frmQLMay_Load(object sender, EventArgs e)
        {
            mctrl.HienThi(dgv_DSMay);
            HienThiThongTin();
        }
        private void dgv_DSMay_Click(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void dgv_DSMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTin();
        }

        private void dgv_DSMay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTin();
        }
    }
}
