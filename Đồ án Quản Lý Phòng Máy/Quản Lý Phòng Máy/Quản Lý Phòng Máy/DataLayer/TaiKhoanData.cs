using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QuanLyPhongMay.BUS;
using System.Data.SqlClient;

namespace QuanLyPhongMay.DataLayer
{
    class TaiKhoanData
    {
        DataProvider cls = new DataProvider();
        public DataSet LayDLMotDong(string ten)
        {
            SqlCommand cmd = new SqlCommand("select * from dtb_TaiKhoan where TenDangNhap=@tendangnhap");
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = ten;
            return cls.LayDuLieu(cmd);
        }
        public DataSet LayDSGiangVien()
        {
            SqlCommand sqlcmd = new SqlCommand("select * from dtb_TaiKhoan");
            return cls.LayDuLieu(sqlcmd);
        }
        public DataSet LayDSTK(string tukhoa, string tieuchi)
        {
            string sql = "select * from dtb_TaiKhoan";

            switch (tieuchi)
            {
                case "tentaikhoan":
                    sql += " where HoVaTen like \"%" + tukhoa + "%\"";
                    break;
                case "sodienthoai":
                    sql += " where SoDienThoai like \"%" + tukhoa + "%\"";
                    break;
            }
            SqlCommand sqlcmd = new SqlCommand(sql);
            return cls.LayDuLieu(sqlcmd);
        }
        public int Xoa(int ma)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from dtb_TaiKhoan where TenDangNhap=@tendangnhap";
            cmd.Parameters.Add("tendangnhap", SqlDbType.SmallInt).Value = ma;
            return cls.CapNhatDL(cmd);
        }
        public int Them(TaiKhoan gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into dtb_TaiKhoan(TenDangNhap,MatKhau,MaTaiKhoan,HoVaTen,GioiTinh,SDT,Email,NgaySinh,DiaChi) values(@tendangnhap,@matkhau,@ten,@gioitinh,sdt,email,@ngsinh,@diachi)";
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = gv.TenDangNhap;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = gv.MatKhau;
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("sdt", SqlDbType.VarChar).Value = gv.SDT;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = gv.Email;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
           // cmd.Parameters.Add("loaitk", SqlDbType.Bit).Value = gv.LoaiTaiKhoan;
            return cls.CapNhatDL(cmd);
        }
        public int Luu(TaiKhoan gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update dtb_TaiKhoan set HoVaTen=@ten,GioiTinh=@gt,SoDienThoai=@sdt,Email=@email,NgaySinh=@ngsinh,DiaChi=@diachi where TenDangNhap=@tendangnhap";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SDT;
            cmd.Parameters.Add("email", SqlDbType.NChar).Value = gv.Email;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
         
            return cls.CapNhatDL(cmd);
        }
        public bool KiemTra(string tk)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from dtb_TaiKhoan where TenDangNhap=@tendangnhap";
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = tk;
            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }
        public int DoiThongTin(TaiKhoan gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update dtb_TaiKhoan set HoVaTen=@ten,GioiTinh=@gt,NgaySinh=@ngsinh,DiaChi=@diachi,SoDienThoai=@sdt,MatKhau=@matkhau where TenDangNhap=@tendangnhap";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SDT;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = gv.MatKhau;
           
            return cls.CapNhatDL(cmd);
        }
    }
}
