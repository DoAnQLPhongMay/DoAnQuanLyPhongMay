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
            cmd.CommandText = "delete from dtb_TaiKhoan where MaGiangVien=@magv";
            cmd.Parameters.Add("magv", SqlDbType.SmallInt).Value = ma;
            return cls.CapNhatDL(cmd);
        }
        public int Them(TaiKhoan gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into dtb_TaiKhoan(TenDangNhap,MatKhau,MaTaiKhoan,HoVaTen,GioiTinh,SDT,Email,NgaySinh,DiaChi,LoaiTaiKhoan) values(@tendangnhap,@matkhau,@ten,@gioitinh,sdt,email,@ngsinh,@diachi,@loaitk)";
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = gv.TenDangNhap;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = gv.MatKhau;
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SoDienThoai;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = gv.Email;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("loaitk", SqlDbType.Bit).Value = gv.LoaiTaiKhoan;
            return cls.CapNhatDL(cmd);
        }
        public int Luu(TaiKhoan gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update dtb_TaiKhoan set TenDangNhap=@ten,GioiTinh=@gt,SoDienThoai=@sdt,Email=@email,NgaySinh=@ngsinh,DiaChi=@diachi,LoaiTaiKhoan=@loaitk where MaGiangVien=@magv";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SoDienThoai;
            cmd.Parameters.Add("email", SqlDbType.NChar).Value = gv.Email;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("loaitk", SqlDbType.Bit).Value = gv.LoaiTaiKhoan;
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = gv.MaGV;
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
            cmd.CommandText = "update dtb_TaiKhoan set TenGV=@ten,GioiTinh=@gt,NgaySinh=@ngsinh,DiaChi=@diachi,SoDienThoai=@sdt,MatKhau=@matkhau where MaGiangVien=@magv";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SoDienThoai;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = gv.MatKhau;
            cmd.Parameters.Add("magv", SqlDbType.VarChar).Value = gv.MaGV;
            return cls.CapNhatDL(cmd);
        }
    }
}
