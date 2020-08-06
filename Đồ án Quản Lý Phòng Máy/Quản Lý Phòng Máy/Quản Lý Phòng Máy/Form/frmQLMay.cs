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
                txtTrangThai.Text = dgv_DSMay.CurrentRow.Cells[13].Value.ToString();
                txt_GhiChu.Text = dgv_DSMay.CurrentRow.Cells[14].Value.ToString();

            }
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            May may = new May();

            may.MaMay = int.Parse(txt_MaMay.Text);
            may.MaPhong = int.Parse(txtMaPhong.Text);
            may.TenMay = txt_TenMay.Text;
            may.GhiChu = txt_GhiChu.Text;
            may.TrangThai = int.Parse(txtTrangThai.Text);

            if (txt_MaMay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_TenMay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mctrl.Them(may) > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            May may = new May();

            may.MaMay = int.Parse(txt_MaMay.Text);
            may.TenMay = txt_TenMay.Text;
            may.TrangThai = int.Parse(txtTrangThai.Text);
            may.GhiChu = txt_GhiChu.Text;

            if (mctrl.Luu(may) > 0)
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mctrl.HienThi(dgv_DSMay);
                HienThiThongTin();
            }
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rad_MaMay.Checked)
                tieuchi = "mamay";
            else if (rad_TenMay.Checked)
                tieuchi = "tenmay";
            else
                tieuchi = "trangthai";

            if (txt_TimKiem.Text.Length == 0)
                mctrl.HienThi(dgv_DSMay);
            else
                mctrl.TimKiem(dgv_DSMay, txt_TimKiem.Text, tieuchi);
        }

        private void frmQLMay_Load(object sender, EventArgs e)
        {
            mctrl.HienThi(dgv_DSMay);
        }
    }
}
