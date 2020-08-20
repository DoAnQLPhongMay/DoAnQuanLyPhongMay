using System;
using System.Windows.Forms;
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmLichSuCapNhat : Form
    {
        LSCapNhatCtrl lsCtrl = new LSCapNhatCtrl();
        User user = new User();

        public frmLichSuCapNhat()
        {
            InitializeComponent();
        }

        public frmLichSuCapNhat(User user)
        {
            this.user = user;
            InitializeComponent();

            dtmDenNgay.Enabled = false;
            dtmTuNgay.Enabled = false;
            txtTimKiem.Enabled = true;
        }

        private void frmLichSuCapNhat_Load(object sender, EventArgs e)
        {
            lsCtrl.HienThi(dgvLSCapNhat);
        }

        private void LamMoi()
        {
            txtTimKiem.Clear();
            dtmDenNgay.Enabled = false;
            dtmTuNgay.Enabled = false;
            txtTimKiem.Enabled = true;

            radMay.Checked = false;
            radPhong.Checked = false;
            radNgay.Checked = false;
        }

        private void radNgayCapNhat_Click(object sender, EventArgs e)
        {
            if(radNgay.Checked == true)
            {
                dtmDenNgay.Enabled = true;
                dtmTuNgay.Enabled = true;
                txtTimKiem.Enabled = false;
            }
        }

        private void radMay_CheckedChanged(object sender, EventArgs e)
        {
            if (radNgay.Checked == false)
            {
                dtmDenNgay.Enabled = false;
                dtmTuNgay.Enabled = false;
                txtTimKiem.Enabled = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaiTK = "";
            string key1 = "", key2 = "";

            if (radNgay.Checked)
            {
                key1 = dtmTuNgay.Value.ToString();
                key2 = dtmDenNgay.Value.ToString();
                loaiTK = "ngay";
            }
            else if (radMay.Checked)
            {
                key1 = txtTimKiem.Text;
                loaiTK = "may";
            }
            else if (radPhong.Checked)
            {
                key1 = txtTimKiem.Text;
                loaiTK = "phong";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }

            if (txtTimKiem.Text.Length != 0 && loaiTK != "" )
            {
                lsCtrl.TimKiem(dgvLSCapNhat, key1, key2, loaiTK);
            }
            else if (radNgay.Checked && loaiTK != "")
            {
                lsCtrl.TimKiem(dgvLSCapNhat, key1, key2, loaiTK);
            }
        }
    }
}
