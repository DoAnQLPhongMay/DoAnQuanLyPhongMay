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
    class LSCapNhatData
    {
        DataProvider cls = new DataProvider();

        public int GetID()
        {
            string select = "SELECT MaCapNhat ",
                from = "FROM dtb_LichSuCapNhat ",
                orderBy = "ORDER BY MaCapNhat DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        public DataSet LayDSCapNhat()
        {
            string select = "SELECT dtb_LichSuCapNhat.*, dtb_PhongMay.TenPhongMay, dtb_May.TenMay, dtb_ChiTietCapNhat.TenMay as TenMayCN, dtb_ChiTietCapNhat.MaCauHinh, dtb_CauHinh.TenCauHinh ",
                from = "FROM dtb_LichSuCapNhat, dtb_PhongMay, dtb_May, dtb_ChiTietCapNhat, dtb_CauHinh ",
                where = "WHERE dtb_LichSuCapNhat.MaPhongMay = dtb_PhongMay.MaPhongMay AND dtb_LichSuCapNhat.MaMay = dtb_May.MaMay AND dtb_LichSuCapNhat.MaCapNhat = dtb_ChiTietCapNhat.MaCapNhat AND dtb_ChiTietCapNhat.MaCauHinh = dtb_CauHinh.MaCauHinh ";
            SqlCommand sqlcmd = new SqlCommand(select + from + where);
            return cls.LayDuLieu(sqlcmd);
        }

        public int ThemLSCapNhat(LichSuCapNhat lsCapNhat)
        {
            SqlCommand cmd = new SqlCommand();
            string insert = "INSERT INTO dtb_LichSuCapNhat(MaCapNhat, MaPhongMay, MaMay, TenDangNhap, NgayCapNhat, GhiChu) ",
                values = "VALUES (@maCapNhat, @maPhong, @maMay, @tenDangNhap, @ngayCapNhat, @ghiChu)";

            cmd.CommandText = insert + values;
            cmd.Parameters.Add("maCapNhat", SqlDbType.Int).Value = lsCapNhat.MaCapNhat;
            cmd.Parameters.Add("maPhong", SqlDbType.Int).Value = lsCapNhat.MaPhongMay;
            cmd.Parameters.Add("maMay", SqlDbType.Int).Value = lsCapNhat.MaMay;
            cmd.Parameters.Add("tenDangNhap", SqlDbType.VarChar).Value = lsCapNhat.TenDangNhap;
            cmd.Parameters.Add("ngayCapNhat", SqlDbType.Date).Value = lsCapNhat.NgayCapNhat;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = lsCapNhat.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        public int ThemChiTietLSCapNhat(LichSuCapNhat lsCapNhat)
        {
            SqlCommand cmd = new SqlCommand();
            string insert = "INSERT INTO dtb_ChiTietCapNhat(MaCapNhat, TenMay, MaCauHinh, GhiChu) ",
                values = "VALUES (@maCapNhat, @tenMay, @maCauHinh, @ghiChu)";

            cmd.CommandText = insert + values;
            cmd.Parameters.Add("maCapNhat", SqlDbType.Int).Value = lsCapNhat.MaCapNhat;
            cmd.Parameters.Add("tenMay", SqlDbType.NVarChar).Value = lsCapNhat.TenMay;
            cmd.Parameters.Add("maCauHinh", SqlDbType.Int).Value = lsCapNhat.MaCauHinh;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = lsCapNhat.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        public DataSet LayDSTK(string key1, string key2, string loaiTK)
        {
            string select = "SELECT dtb_LichSuCapNhat.*, dtb_PhongMay.TenPhongMay, dtb_May.TenMay, dtb_ChiTietCapNhat.TenMay as TenMayCN, dtb_ChiTietCapNhat.MaCauHinh, dtb_CauHinh.TenCauHinh ",
                from = "FROM dtb_LichSuCapNhat, dtb_PhongMay, dtb_May, dtb_ChiTietCapNhat, dtb_CauHinh ",
                where = "WHERE dtb_LichSuCapNhat.MaPhongMay = dtb_PhongMay.MaPhongMay AND dtb_LichSuCapNhat.MaMay = dtb_May.MaMay AND dtb_LichSuCapNhat.MaCapNhat = dtb_ChiTietCapNhat.MaCapNhat AND dtb_ChiTietCapNhat.MaCauHinh = dtb_CauHinh.MaCauHinh AND ";

            switch (loaiTK)
            {
                case "may":
                    where += "(dtb_LichSuCapNhat.MaMay like '%" + key1 + "%' OR dtb_ChiTietCapNhat.TenMay like N'%" + key1 + "%' OR dtb_May.TenMay like N'%" + key1 + "%')";
                    break;
                case "phong":
                    where += "(dtb_LichSuCapNhat.MaPhongMay like '%" + key1 + "%' OR dtb_PhongMay.TenPhongMay like N'%" + key1 + "%')";
                    break;
                default:
                    where += "NgayCapNhat BETWEEN '" + key1 + "' AND '" + key2 + "'";
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
