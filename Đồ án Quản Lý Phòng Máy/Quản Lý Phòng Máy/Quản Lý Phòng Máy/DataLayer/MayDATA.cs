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
        public DataSet LayDSMay()
        {
            string sql = "select dtb_May.MaMay, TenMay,TenPhongMay, TenThietBi,TSThietBi, dtb_May.TrangThai, dtb_May.GhiChu from dtb_ChiTietMay, dtb_May, dtb_ChiTietThietBi, dtb_PhongMaywhere dtb_May.MaMay = dtb_ChiTietMay.MaMay and dtb_ChiTietMay.MaThietBi = dtb_ChiTietThietBi.MaThietBi and dtb_May.MaPhong = dtb_PhongMay.MaPhongMay";
            SqlCommand sqlcmd = new SqlCommand(sql);
            return cls.LayDuLieu(sqlcmd);
        }
        public DataSet LayDSTK(string tukhoa, string tieuchi)
        {
            string sql = "select * from dtb_May";
            switch (tieuchi)
            {
                case "mamay":
                    sql += " where MaMay like \"%" + tukhoa + "%\"";
                    break;
                case "tenmay":
                    sql += " where TenMay like \"%" + tukhoa + "%\"";
                    break;
                default:
                    sql += " where TrangThai like \"%" + tukhoa + "%\"";
                    break;
            }
            SqlCommand sqlcmd = new SqlCommand(sql);
            return cls.LayDuLieu(sqlcmd);
        }
        public int Them(May m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into dtb_May(MaMay,MaPhong,TenMay,TrangThai,GhiChu) values(@mamay,@maphong,@tenmay,@trangthai,@ghichu)";
            cmd.Parameters.Add("mamay", SqlDbType.Int).Value = m.MaMay;
            cmd.Parameters.Add("maphong", SqlDbType.Int).Value = m.MaPhong;
            cmd.Parameters.Add("soluong", SqlDbType.NVarChar).Value = m.TenMay;
            cmd.Parameters.Add("trangthai", SqlDbType.SmallInt).Value = m.TrangThai;
            cmd.Parameters.Add("ghichu", SqlDbType.SmallInt).Value = m.GhiChu;
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
            cmd.CommandText = "update dtb_May set MaMay=@mamay,MaPhong=@maphong,TenMay=@tenmay,TrangThai=@trangthai,GhiChu=@ghichu where MaMay=@mamay";
            cmd.Parameters.Add("mamay", SqlDbType.Int).Value = m.MaMay;
            cmd.Parameters.Add("maphong", SqlDbType.Int).Value = m.MaPhong;
            cmd.Parameters.Add("soluong", SqlDbType.NVarChar).Value = m.TenMay;
            cmd.Parameters.Add("trangthai", SqlDbType.SmallInt).Value = m.TrangThai;
            cmd.Parameters.Add("ghichu", SqlDbType.SmallInt).Value = m.GhiChu;
            return cls.CapNhatDL(cmd);
        }

    }
}
