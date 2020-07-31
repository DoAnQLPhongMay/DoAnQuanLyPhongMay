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
    public partial class frm_QLMay : Form
    {
        MayCtrl mctrl = new MayCtrl();

        public frm_QLMay()
        {
            InitializeComponent();
        }
        private void frm_QLMay_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            May may = new May();

            may.MaMay = int.Parse(txt_MaMay.Text);
            may.MaPhong = int.Parse(txtMaPhong.Text);
            may.TenMay = txt_TenMay.Text;
            may.GhiChu = txt_GhiChu.Text;
            may.TrangThai = int.Parse(txtTrangThai.Text);

            if (mctrl.Them(may) > 0) 
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
