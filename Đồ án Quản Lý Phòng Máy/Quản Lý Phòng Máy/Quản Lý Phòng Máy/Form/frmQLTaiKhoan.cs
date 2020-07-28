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

namespace QuanLyPhongMay
{
    public partial class frm_QLTaiKhoan : Form
    {
        SqlConnection conn = DBUtils.GetDBConnection();
        public User user;

        public frm_QLTaiKhoan(User user)
        {
            this.user = new User(user);
            InitializeComponent();
        }

        public frm_QLTaiKhoan()
        {
            // TODO: Complete member initialization
        }

        private void dgv_DSTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM dtb_TaiKhoan";
            DataSet ds = DBUtils.dsTable(querry, conn);

            dgv_DSTaiKhoan.DataSource = ds.Tables[0];
            dgv_DSTaiKhoan.Refresh();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan themtk = new frmThemTaiKhoan();
            this.Hide();
            themtk.Show();
        }
    }
}
