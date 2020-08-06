using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMay.Class
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-KUOPHKV\SQLEXPRESS"; //Thiện
            //string datasource = @"BV-PC"; //Khoi
            string database = "QL_PHONGMAY";
            string username = "sa";
            string password = "123456";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }

        //Hàm xử lý mở kết nối với CSDL.
        public static void openConnection(SqlConnection conn)
        {
            //Thực hiện kết nối CSDL.
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    //Xuất hộp thoại báo lỗi kết nối tới CSDL.
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        //Hàm xử lý đóng kết nối với CSDL.
        public static void closeConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //Hàm chạy câu lệnh có truy vấn
        public static DataTable dtTable(string querry, SqlConnection conn)
        {
            openConnection(conn);

            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }

            closeConnection(conn);

            return dt;
        }

        public static DataSet dsTable(string querry, SqlConnection conn)
        {
            openConnection(conn);

            DataSet ds = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception)
            {
                ds = null;
            }

            closeConnection(conn);

            return ds;
        }

        //Hàm chạy câu lệnh không truy vấn.
        public static Boolean exeReaderData(string querry, SqlConnection conn)
        {
            openConnection(conn);

            Boolean kiemTra = false;

            try
            {
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    kiemTra = true;
                }
            }
            catch (Exception)
            {
                kiemTra = false;
            }

            closeConnection(conn);

            return kiemTra;
        }

        public static Boolean exeNonQueryData(string querry, SqlConnection conn)
        {
            openConnection(conn);

            Boolean kiemTra;

            try
            {
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();
                kiemTra = true;
            }
            catch (Exception)
            {
                kiemTra = false;
            }

            closeConnection(conn);

            return kiemTra;
        }
    }
}
