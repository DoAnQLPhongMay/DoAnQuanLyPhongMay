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
    public partial class frm_QLMay : Form
    {
        /*SqlConnection conn = DBUtils.GetDBConnection();
        public User user;*/

        public frm_QLMay()
        {
            InitializeComponent();
        }

        private void frm_QLMay_Load(object sender, EventArgs e)
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

            String querry = "SELECT * FROM SELECT * FROM dtb_May";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            da.Fill(ds);
            dgv_DSMay.DataSource = ds.Tables[0];
            dgv_DSMay.Refresh();*/
        }
    }
}
