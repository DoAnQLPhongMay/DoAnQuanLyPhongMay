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
    public partial class frmQLPhongMay : Form
    {
        /*SqlConnection conn = DBUtils.GetDBConnection();
        public User user;*/

        public frmQLPhongMay()
        {
            InitializeComponent();
        }

        private void grp_QLPhongMay_Enter(object sender, EventArgs e)
        {

        }

        private void frm_QLPhongMay_Load(object sender, EventArgs e)
        {
            /*string querry = "SELECT * FROM dtb_PhongMay";
            DataSet ds = DBUtils.dsTable(querry,conn);

            dgvDSPhongMay.DataSource = ds.Tables[0];
            dgvDSPhongMay.Refresh();*/
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            /*string maPhong = txtMaPhong.Text;
            string tenPhong = txtTenPhong.Text;
            int soLuong = Convert.ToInt32(txtSoLuongMay.Text);

            string querry = "INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay) VALUES('" + maPhong + "', '" + tenPhong + "', '" + soLuong + "')";
            
            if(DBUtils.exeData(querry,conn))
            {
                MessageBox.Show("Thêm mới phòng thành công!");
                dgvDSPhongMay.Refresh();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại");
            }*/
        }
    }
}
