using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QuanLyPhongMay.BUS;
using System.Data.SqlClient;

namespace QuanLyPhongMay.DataLayer
{
    class GiangVienDATA
    {
        DataProvider cls = new DataProvider();
        public DataSet LayDLMotDong(string ten)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TenDangNhap=@tendangnhap");
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = ten;
            return cls.LayDuLieu(cmd);
        }
        public DataSet LayDSGiangVien()
        {
            SqlCommand sqlcmd = new SqlCommand("select * from TaiKhoan");
            return cls.LayDuLieu(sqlcmd);
        }
        public DataSet LayDSTK(string tukhoa, string tieuchi)
        {
            string sql = "select * from TaiKhoan";

            switch (tieuchi)
            {
                case "tennv":
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
            cmd.CommandText = "delete from TaiKhoan where MaGiangVien=@magv";
            cmd.Parameters.Add("magv", SqlDbType.SmallInt).Value = ma;
            return cls.CapNhatDL(cmd);
        }
        public int Them(GiangVien gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into TaiKhoan(TenDangNhap,MatKhau,HoVaTen,GioiTinh,NgaySinh,DiaChi,SoDienThoai) values(@tendangnhap,@matkhau,@ten,@gioitinh,@ngsinh,@diachi,@sdt)";
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = gv.TenDangNhap;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = DataProvider.MD5(gv.MatKhau);
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SoDienThoai;
            
            return cls.CapNhatDL(cmd);
        }
        public int Luu(GiangVien gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update TaiKhoan set TenGV=@ten,GioiTinh=@gt,NgaySinh=@ngsinh,DiaChi=@diachi,SoDienThoai=@sdt where MaGiangVien=@magv";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SoDienThoai;
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = gv.MaGV;
            return cls.CapNhatDL(cmd);
        }
        public bool KiemTra(string tk)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from TaiKhoan where TenDangNhap=@tendangnhap";
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = tk;
            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }
        public int DoiThongTin(GiangVien gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update TaiKhoan set TenGV=@ten,GioiTinh=@gt,NgaySinh=@ngsinh,DiaChi=@diachi,SoDienThoai=@sdt,MatKhau=@matkhau where MaGiangVien=@magv";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SoDienThoai;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = DataProvider.MD5(gv.MatKhau);
            cmd.Parameters.Add("magv", SqlDbType.VarChar).Value = gv.MaGV;
            return cls.CapNhatDL(cmd);
        }
    }
}
