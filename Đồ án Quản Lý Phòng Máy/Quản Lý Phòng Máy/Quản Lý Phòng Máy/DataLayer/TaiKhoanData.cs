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
            SqlCommand sqlcmd = new SqlCommand("select TenDangNhap, MaTaiKhoan, HoVaTen, GioiTinh , SDT, Email, NgaySinh, DiaChi, LoaiTK from dtb_TaiKhoan ");
            return cls.LayDuLieu(sqlcmd);
        }

        public DataSet LayDSTK()
        {
            SqlCommand sqlcmd = new SqlCommand("select * from dtb_TaiKhoan");
            return cls.LayDuLieu(sqlcmd);
        }

        public DataSet LayDSTK(string tukhoa, string tieuchi)
        {
            string sql = "select * from dtb_TaiKhoan where ";

            switch (tieuchi)
            {
                case "hoTen":
                    sql += "HoVaTen like N'%" + tukhoa + "%'";
                    break;
                default:
                    sql += "SDT like '%" + tukhoa + "%'";
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
            cmd.CommandText = "insert into dtb_TaiKhoan (TenDangNhap,MatKhau,MaTaiKhoan,HoVaTen,GioiTinh,SDT,Email,NgaySinh,DiaChi, LoaiTK) values(@tendn,@mk,@matk,@ten,@gioitinh,@sdt,@mail,@ngsinh,@dchi, @loaitk)";
            
            cmd.Parameters.Add("tendn", SqlDbType.VarChar).Value = gv.TenDangNhap;
            cmd.Parameters.Add("mk", SqlDbType.VarChar).Value = gv.MatKhau;
            cmd.Parameters.Add("matk", SqlDbType.NVarChar).Value = gv.MaGV;
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Bit).Value = gv.Gioitinh;
            cmd.Parameters.Add("sdt", SqlDbType.VarChar).Value = gv.SDT;
            cmd.Parameters.Add("mail", SqlDbType.VarChar).Value = gv.Email;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("dchi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("loaitk", SqlDbType.Bit).Value = gv.Loaitaikhoan;

            return cls.CapNhatDL(cmd);
        }
       
        public int Luu(TaiKhoan gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update dtb_TaiKhoan set HoVaTen=@ten,GioiTinh=@gioitinh, SDT=@sdt, NgaySinh=@ngsinh,DiaChi=@diachi, Email=@email, LoaiTK=@loaitk where TenDangNhap=@tendangnhap";
            
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SDT;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;  
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = gv.TenDangNhap;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = gv.Email;
            cmd.Parameters.Add("loaitk", SqlDbType.Bit).Value = gv.Loaitaikhoan;

            return cls.CapNhatDL(cmd);
        }

        public bool KiemTra(string tk)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from dtb_TaiKhoan where TenDangNhap=@tendangnhap";
            
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = tk;
            
            return  (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }

        public bool KTLSThanhLy(string tk)
        {
            SqlCommand cmd = new SqlCommand();
            string select = "SELECT * ",
                from = "FROM dtb_TaiKhoan, dbo.dtb_LichSuThanhLy ",
                where = "WHERE dtb_TaiKhoan.TenDangNhap = dbo.dtb_LichSuThanhLy.NguoiPhuTrach AND dtb_TaiKhoan.TenDangNhap = @tenDangNhap";
            cmd.CommandText = select + from + where;

            cmd.Parameters.Add("tenDangNhap", SqlDbType.VarChar).Value = tk;

            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }

        public bool KTLSNhap(string tk)
        {
            SqlCommand cmd = new SqlCommand();
            string select = "SELECT * ",
                from = "FROM dtb_TaiKhoan, dtb_LichSuNhap ",
                where = "WHERE dtb_TaiKhoan.TenDangNhap = dtb_LichSuNhap.NguoiPhuTrach AND dtb_TaiKhoan.TenDangNhap = @tenDangNhap";
            cmd.CommandText = select + from + where;

            cmd.Parameters.Add("tenDangNhap", SqlDbType.VarChar).Value = tk;

            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }

        public bool KTLSCapNhat(string tk)
        {
            SqlCommand cmd = new SqlCommand();
            string select = "SELECT * ",
                from = "FROM dtb_TaiKhoan, dtb_LichSuCapNhat ",
                where = "WHERE dtb_TaiKhoan.TenDangNhap = dtb_LichSuCapNhat.TenDangNhap AND dtb_TaiKhoan.TenDangNhap = @tenDangNhap";
            cmd.CommandText = select + from + where;

            cmd.Parameters.Add("tenDangNhap", SqlDbType.VarChar).Value = tk;

            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }

        public bool KiemTraMaTaiKhoan(string matk)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from dtb_TaiKhoan where MaTaiKhoan=@matk";
            
            cmd.Parameters.Add("matk", SqlDbType.VarChar).Value = matk;
            
            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);


        }

        public bool KiemTraQuyen(int maquyen)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from dtb_TaiKhoan where MaQuyen=@maquyen";
            cmd.Parameters.Add("maquyen", SqlDbType.VarChar).Value = maquyen;
            
            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }
    }
}
