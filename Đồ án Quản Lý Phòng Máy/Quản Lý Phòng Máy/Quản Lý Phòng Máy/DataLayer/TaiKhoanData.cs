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
            SqlCommand sqlcmd = new SqlCommand("select TenDangNhap, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, TenQuyen from dtb_Quyen, dtb_TaiKhoan where dtb_Quyen.MaQuyen = dtb_TaiKhoan.MaQuyen");
            return cls.LayDuLieu(sqlcmd);
        }
        public DataSet LayDSTK(string tukhoa, string tieuchi)
        {
            string sql = "select TenDangNhap, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, TenQuyen from dtb_Quyen, dtb_TaiKhoan where dtb_Quyen.MaQuyen = dtb_TaiKhoan.MaQuyen ";

            switch (tieuchi)
            {
                case "hovaten":
                    sql += " And HoVaTen = '" + tukhoa + "'";
                    break;
                default:
                    sql += " And SDT = '" + tukhoa + "'";
                    break;
            }
            SqlCommand sqlcmd = new SqlCommand(sql);
            return cls.LayDuLieu(sqlcmd);
        }
        public int Xoa(string tendn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from dtb_TaiKhoan where TenDangNhap=@tendangnhap";
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = tendn;
            return cls.CapNhatDL(cmd);
        }
        public int Them(TaiKhoan gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into dtb_TaiKhoan (TenDangNhap,MatKhau,MaTaiKhoan,HoVaTen,GioiTinh,SDT,Email,NgaySinh,DiaChi,MaQuyen) values(@tendn,@mk,@matk,@ten,@gioitinh,@sdt,@mail,@ngsinh,@dchi,@maquyen)";
            cmd.Parameters.Add("tendn", SqlDbType.VarChar).Value = gv.TenDangNhap;
            cmd.Parameters.Add("mk", SqlDbType.VarChar).Value = gv.MatKhau;
            cmd.Parameters.Add("matk", SqlDbType.NVarChar).Value = gv.MaGV;
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("sdt", SqlDbType.VarChar).Value = gv.SDT;
            cmd.Parameters.Add("mail", SqlDbType.VarChar).Value = gv.Email;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("dchi", SqlDbType.NVarChar).Value = gv.Diachi;
           cmd.Parameters.Add("maquyen", SqlDbType.Int).Value = gv.LoaiTaiKhoan;
            return cls.CapNhatDL(cmd);
        }
        public int Luu(TaiKhoan gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update dtb_TaiKhoan set HoVaTen=@ten,SDT=@sdt,Email=@email,NgaySinh=@ngsinh,DiaChi=@diachi where TenDangNhap=@tendangnhap";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SDT;
            cmd.Parameters.Add("email", SqlDbType.NChar).Value = gv.Email;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
           cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = gv.TenDangNhap;
            return cls.CapNhatDL(cmd);
        }
        public bool KiemTra(string tk)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from dtb_TaiKhoan where TenDangNhap=@tendangnhap";
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = tk;
            return  (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);

            
        }
        public bool KiemTraMaTaiKhoan(string matk)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from dtb_TaiKhoan where MaTaiKhoan=@matk";
            cmd.Parameters.Add("matk", SqlDbType.VarChar).Value = matk;
            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);


        }
        public int DoiThongTin(TaiKhoan gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update dtb_TaiKhoan set HoVaTen=@ten,GioiTinh=@gt,NgaySinh=@ngsinh,DiaChi=@diachi,SDT=@sdt,MatKhau=@matkhau where TenDangNhap=@tendangnhap";
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
