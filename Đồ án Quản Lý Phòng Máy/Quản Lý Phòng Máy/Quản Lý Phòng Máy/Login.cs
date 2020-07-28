using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QuanLyPhongMay
{
    class Login
    {

         DataProvider cls = new DataProvider();
        private static string _ten;

        public static string Ten
        {
            get { return Login._ten; }
            set { Login._ten = value; }
        }
        private static string _tendangnhap;

        public static string TenDangNhap
        {
            get { return Login._tendangnhap; }
            set { Login._tendangnhap = value; }
        }
        private static string _matkhau;

        public static string Matkhau
        {
          get { return Login._matkhau; }
          set { Login._matkhau = value; }
        }


        public bool XacThuc(string user, string password)
        {
            SqlCommand cmd = new SqlCommand("select * from dtb_TaiKhoan where TenDangNhap=@username and MatKhau=@password");
            cmd.Parameters.Add("username", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("password", SqlDbType.VarChar).Value = password;
            DataSet ds = cls.LayDuLieu(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ten = ds.Tables[0].Rows[0]["HoVaTen"].ToString();
                TenDangNhap = ds.Tables[0].Rows[0]["TenDangNhap"].ToString();
                Matkhau = ds.Tables[0].Rows[0]["MatKhau"].ToString();
                return true;
            }
            return false;
        }
        public bool Logout()
        {
            TenDangNhap = "";
            Matkhau = "";
            return true;
        }
    }
}
