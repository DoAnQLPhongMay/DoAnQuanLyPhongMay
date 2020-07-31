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
using QuanLyPhongMay.BUS;
using QuanLyPhongMay.Class;
using QuanLyPhongMay.Controller;

namespace QuanLyPhongMay
{
    public partial class frmQLThanhLy : Form
    {
        /*SqlConnection conn = DBUtils.GetDBConnection();
        public User user;*/

        LichSuThanhLyCtrl thanhLyCtrl = new LichSuThanhLyCtrl();
        LichSuThanhLy thanhLy = new LichSuThanhLy();

        public frmQLThanhLy()
        {
            InitializeComponent();
        }

        private void frm_QLThanhLy_Load(object sender, EventArgs e)
        {
            /*//Thực hiện kết nối CSDL.
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                //Xuất hộp thoại báo lỗi kết nối tới CSDL.
                MessageBox.Show("Error: " + ex);
            }

            String querry = "SELECT * FROM SELECT * FROM dtb_LichSuThanhLy";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            da.Fill(ds);
            dgv_DSThanhLy.DataSource = ds.Tables[0];
            dgv_DSThanhLy.Refresh();*/

            thanhLyCtrl.HienThiDgv(dgvDSThanhLy);
        }
    }
}
