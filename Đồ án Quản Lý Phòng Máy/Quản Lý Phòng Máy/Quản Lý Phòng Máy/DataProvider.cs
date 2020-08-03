using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyPhongMay.Class;
namespace QuanLyPhongMay
{
    class DataProvider
    {
        SqlConnection conn = DBUtils.GetDBConnection(); //Khoi
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MTBP4JI\SQLEXPRESS1;Initial Catalog=QL_PHONGMAY;Integrated Security=True");
        
        public DataProvider()
        {
            KetNoi();
        }
        
        void KetNoi()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
       
        public DataSet LayDuLieu(SqlCommand sqlcmd)
        {
            DataSet ds = new DataSet();
            sqlcmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

            da.Fill(ds);

            return ds;
        }
        
        public int CapNhatDL(SqlCommand sqlcmd)
        {
            SqlCommand cmd = sqlcmd;

            cmd.Connection = conn;

            return cmd.ExecuteNonQuery();
        }
       
    }
}
