using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongMay.Controller;
using QuanLyPhongMay.BUS;
namespace QuanLyPhongMay
{
    public partial class frmThemMay : Form
    {
        MayCtrl mctrl = new MayCtrl();
        TrangThaiCtrl ttctrl = new TrangThaiCtrl();
        ThietBiCtrl tbctrl = new ThietBiCtrl();
        PhongMayCtrl phongctrl = new PhongMayCtrl();
        public frmThemMay()
        {
            InitializeComponent();
        }

        private void btnThemMay_Click(object sender, EventArgs e)
        {
            May m = new May();
            m.MaMay = mctrl.GetID() + 1;
            m.TenMay = txtTenMay.Text;
            m.MaPhong = int.Parse(cbMaPhong.SelectedValue.ToString());
            m.TrangThai = int.Parse(cbTrangThai.SelectedValue.ToString());
            m.Mathietbi = int.Parse(cbMaThietBi.SelectedValue.ToString());
            m.GhiChu = txtGhiChu.Text;
             if (txtTenMay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên Máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else if (txtGhiChu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Ghi Chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*else
            {
                switch (mctrl.Them(m))
                {
                    case 0:
                        MessageBox.Show("Tên Máy đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 1:
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }*/
        }

        private void frmThemMay_Load(object sender, EventArgs e)
        {
            ttctrl.HienThiCbo(cbTrangThai);
            tbctrl.HienThiCbo(cbMaThietBi);
            phongctrl.HienThiCbo(cbMaPhong);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQLMay frm = new frmQLMay();
            frm.Show();
            this.Hide();
        }
    }
}
