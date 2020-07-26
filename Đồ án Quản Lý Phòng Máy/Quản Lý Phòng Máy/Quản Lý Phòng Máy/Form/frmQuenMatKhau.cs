using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyPhongMay.Class;
using System.Windows.Forms;

namespace QuanLyPhongMay
{
    public partial class frmQuenMatKhau : Form
    {
        SqlConnection conn = DBUtils.GetDBConnection();

        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        //Hàm xử lý khi ấn nút thoát.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        //Hàm không sử dụng.
        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            this.Hide();
            frm.Show();
        }
    }
}
