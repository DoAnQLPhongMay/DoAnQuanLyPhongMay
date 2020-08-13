using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyPhongMay.BUS;

namespace QuanLyPhongMay.DataLayer
{
    class MayData
    {
        DataProvider cls = new DataProvider();

        public int GetID()
        {
            string select = "SELECT MaMay ",
                from = "FROM dtb_May ",
                orderBy = "ORDER BY MaMay DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        /*public DataSet LayDSMay()
        {
            string sql = "select MaMay, TenMay, dtb_PhongMay.TenPhongMay, TenThietBi, TSThietBi, TenTrangThai, dtb_May.GhiChu ",
                from =  "From dtb_May, dtb_PhongMay, dtb_ChiTietThietBi, dtb_TrangThai ",
                where = "where dtb_May.MaThietBi = dtb_ChiTietThietBi.MaThietBi and dtb_May.MaPhong = dtb_PhongMay.MaPhongMay and dtb_May.MaTrangThai = dtb_TrangThai.MaTrangThai";
            SqlCommand sqlcmd = new SqlCommand(sql + from + where);
            return cls.LayDuLieu(sqlcmd);
        }*/

        public DataSet LayDSMay()
        {
            string sql = "SELECT MaMay, TenMay, dtb_PhongMay.TenPhongMay, TenTrangThai, dtb_May.GhiChu, dtb_May.TrangThai, dtb_May.MaPhong ",
                from = "FROM dtb_May, dtb_PhongMay, dtb_TrangThai ",
                where = "WHERE  dtb_May.MaPhong = dtb_PhongMay.MaPhongMay and dtb_May.TrangThai = dtb_TrangThai.MaTrangThai";
            SqlCommand sqlcmd = new SqlCommand(sql + from + where);
            return cls.LayDuLieu(sqlcmd);
        }

        public DataSet LayDSMay(int maPhong)
        {
            string select = "SELECT MaMay, TenMay, dtb_PhongMay.TenPhongMay, TenTrangThai, dtb_May.GhiChu ",
                from = "FROM dtb_May, dtb_PhongMay, dtb_TrangThai ",
                where = "WHERE dtb_May.MaPhong = dtb_PhongMay.MaPhongMay AND dtb_May.TrangThai = dtb_TrangThai.MaTrangThai AND dtb_May.MaPhong = '" + maPhong + "'";
            SqlCommand sqlcmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(sqlcmd);
        }

        public DataSet LayDSTK(string tukhoa, string tieuchi)
        {
            string sql = "select MaMay, TenMay, dtb_PhongMay.TenPhongMay, TenThietBi, TSThietBi, TenTrangThai, dtb_May.GhiChu ",
               from = "From dtb_May, dtb_PhongMay, dtb_ChiTietThietBi, dtb_TrangThai ",
               where = "Where dtb_May.MaThietBi = dtb_ChiTietThietBi.MaThietBi and dtb_May.MaPhong = dtb_PhongMay.MaPhongMay and dtb_May.MaTrangThai = dtb_TrangThai.MaTrangThai";
            switch (tieuchi)
            {
                case "tenmay":
                    where += " And TenMay = '" + tukhoa + "'";
                    break;
            }
            SqlCommand sqlcmd = new SqlCommand(sql + from+ where);
            return cls.LayDuLieu(sqlcmd);
        }

        public int Them(May m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into dtb_May(MaMay,MaPhong,TenMay,MaTrangThai,GhiChu,MaThietBi) values (@mamay,@maphong,@tenmay,@matrangthai,@ghichu,@mathietbi)";
            cmd.Parameters.Add("mamay", SqlDbType.Int).Value = m.MaMay;
            cmd.Parameters.Add("maphong", SqlDbType.Int).Value = m.MaPhong;
            cmd.Parameters.Add("tenmay", SqlDbType.NVarChar).Value = m.TenMay;
            cmd.Parameters.Add("matrangthai", SqlDbType.Int).Value = m.TrangThai;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar).Value = m.GhiChu;
            cmd.Parameters.Add("mathietbi", SqlDbType.Int).Value = m.Mathietbi;
            return cls.CapNhatDL(cmd);
        }

        public int Xoa(int ma)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from dtb_May where MaMay=@mamay";
            cmd.Parameters.Add("mamay", SqlDbType.SmallInt).Value = ma;
            return cls.CapNhatDL(cmd);
        }

        public int Luu(May m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update dtb_May set TenMay=@tenmay,MaPhong=@maphong, MaTrangThai=@matrangthai, GhiChu=@ghichu where MaMay=@mamay";
            cmd.Parameters.Add("mamay", SqlDbType.Int).Value = m.MaMay;
            cmd.Parameters.Add("maphong", SqlDbType.Int).Value = m.MaPhong;
            cmd.Parameters.Add("matrangthai", SqlDbType.Int).Value = m.TrangThai;
            cmd.Parameters.Add("tenmay", SqlDbType.NVarChar).Value = m.TenMay;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar).Value = m.GhiChu;
            return cls.CapNhatDL(cmd);
        }

        public int ThemChiTiet(int maMay, int maLoai, int maThietBi)
        {
            SqlCommand cmd = new SqlCommand();
            string insert = "INSERT INTO dtb_ChiTietMay(MaMay, MaLoaiThietBi, MaThietBi) ",
                values = "VALUES (@maMay, @maLoaiThietBi, @maThietBi)";

            cmd.CommandText = insert + values;
            cmd.Parameters.Add("maMay", SqlDbType.Int).Value = maMay;
            cmd.Parameters.Add("maLoaiThietBi", SqlDbType.Int).Value = maLoai;
            cmd.Parameters.Add("maThietBi", SqlDbType.Int).Value = maThietBi;

            return cls.CapNhatDL(cmd);
        }

        public bool KiemTraTenMay(string tenmay)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from dtb_May where TenMay=@tenmay";
            cmd.Parameters.Add("tenmay", SqlDbType.VarChar).Value = tenmay;
            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }

        public int LuuLichSuCapNhat(May m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into dtb_LichSuCapNhat(MaCapNhat, MaPhong, MaMay,NgayCapNhat, GhiChu) values (@macapnhat,@maphong,@mamay,@ngcapnhat,@ghichu)";
            cmd.Parameters.Add("macapnhat", SqlDbType.Int).Value = m.MaCapNhat;
            cmd.Parameters.Add("maphong", SqlDbType.Int).Value = m.MaPhong;
            cmd.Parameters.Add("MaMay", SqlDbType.NVarChar).Value = m.MaMay;
            cmd.Parameters.Add("ngaycapnhat", SqlDbType.Date).Value = m.NgayCapNhat;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar).Value = m.GhiChu;

            return cls.CapNhatDL(cmd);
        }
    }
}
