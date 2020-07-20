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
using Quản_Lý_Phòng_Máy.Class;

namespace Quản_Lý_Phòng_Máy
{
    public partial class frm_QLNhapMay : Form
    {
        SqlConnection conn = DBUtils.GetDBConnection();
        public User user;

        public frm_QLNhapMay(User user)
        {
            this.user = new User(user);
            InitializeComponent();
        }

        private void frm_QLNhapMay_Load(object sender, EventArgs e)
        {
            //Thực hiện kết nối CSDL.
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                //Xuất hộp thoại báo lỗi kết nối tới CSDL.
                MessageBox.Show("Error: " + ex);
            }

            String querry = "SELECT * FROM SELECT * FROM dtb_LichSuNhap";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            da.Fill(ds);
            dgv_DSNhap.DataSource = ds.Tables[0];
            dgv_DSNhap.Refresh();
        }
    }
}
