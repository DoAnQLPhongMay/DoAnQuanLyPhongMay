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


        public DataSet LayDSMay()
        {
            string sql = "select MaMay, TenMay, dtb_PhongMay.TenPhongMay, TenThietBi, TSThietBi, TenTrangThai, dtb_May.GhiChu from dtb_May, dtb_PhongMay, dtb_ChiTietThietBi, dtb_TrangThai where dtb_May.MaThietBi = dtb_ChiTietThietBi.MaThietBi and dtb_May.MaPhong = dtb_PhongMay.MaPhongMay and dtb_May.MaTrangThai = dtb_TrangThai.MaTrangThai";
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
            cmd.CommandText = "update dtb_May set MaPhong=@maphong,TenMay=@tenmay,TrangThai=@trangthai,GhiChu=@ghichu, MaThietBi=@mathietbi where MaMay=@mamay";
            cmd.Parameters.Add("mamay", SqlDbType.Int).Value = m.MaMay;
            cmd.Parameters.Add("maphong", SqlDbType.Int).Value = m.MaPhong;
            cmd.Parameters.Add("soluong", SqlDbType.NVarChar).Value = m.TenMay;
            cmd.Parameters.Add("trangthai", SqlDbType.Int).Value = m.TrangThai;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar).Value = m.GhiChu;
            cmd.Parameters.Add("mahietbi", SqlDbType.Int).Value = m.Mathietbi;
            return cls.CapNhatDL(cmd);
        }

 

        public bool KiemTraTenMay(string tenmay)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from dtb_May where TenMay=@tenmay";
            cmd.Parameters.Add("tenmay", SqlDbType.VarChar).Value = tenmay;
            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);


        }
    }
}
