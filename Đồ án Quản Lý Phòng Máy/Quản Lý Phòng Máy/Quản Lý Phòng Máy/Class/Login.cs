using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QuanLyPhongMay.Class
{
    class Login
    {
        //Khởi tạo các biến lưu trữ và kết nối.
        DataProvider cls = new DataProvider();

        //Hàm xử lý đăng nhập và lưu giá trị
        public bool DangNhap(string username, string password, User user)
        {
            SqlCommand cmd = new SqlCommand("select * from dtb_TaiKhoan where TenDangNhap=@username and MatKhau=@password");

            cmd.Parameters.Add("username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("password", SqlDbType.VarChar).Value = password;

            DataSet ds = cls.LayDuLieu(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                user.TenUser = ds.Tables[0].Rows[0]["HoVaTen"].ToString();
                user.TenTK = ds.Tables[0].Rows[0]["TenDangNhap"].ToString();
                user.PhanQuyen = Convert.ToBoolean(ds.Tables[0].Rows[0]["LoaiTK"].ToString());
                return true;
            }

            return false;
        }

        public int DoiMatKhau(string matKhau, string taiKhoan)
        {
            SqlCommand cmd = new SqlCommand();
            string update = "UPDATE dtb_TaiKhoan SET MatKhau = @maKhau ",
                where = "WHERE TenDangNhap = @taiKhoan";

            cmd.CommandText = update + where;

            cmd.Parameters.Add("maKhau", SqlDbType.VarChar).Value = matKhau;
            cmd.Parameters.Add("taiKhoan", SqlDbType.VarChar).Value = taiKhoan;

            return cls.CapNhatDL(cmd);
        }

        public bool XacThuc(int sdt, string email, string tenDangNhap)
        {
            SqlCommand cmd = new SqlCommand();
             
            string select = "SELECT * ",
                from = "FROM dtb_TaiKhoan ",
                where = "WHERE TenDangNhap = @tenDangNhap AND SDT = @sdt AND Email = @email";

            cmd.CommandText = select + from + where;

            cmd.Parameters.Add("sdt", SqlDbType.Int).Value = sdt;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("tenDangNhap", SqlDbType.VarChar).Value = tenDangNhap;

            return cls.KiemTra(cmd);
        }
    }
}
