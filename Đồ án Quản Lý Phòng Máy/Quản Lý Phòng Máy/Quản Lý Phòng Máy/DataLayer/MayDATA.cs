﻿using System;
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
            string select = "SELECT dtb_May.*, TenPhongMay, TenTrangThai, TenCauHinh ",
                from = "FROM dtb_May, dtb_PhongMay, dtb_TrangThai, dtb_CauHinh ",
                where = "WHERE dtb_May.MaPhong = dtb_PhongMay.MaPhongMay AND dtb_May.TrangThai = dtb_TrangThai.MaTrangThai AND dtb_May.MaCauHinh = dtb_CauHinh.MaCauHinh";
            SqlCommand sqlcmd = new SqlCommand(select + from + where);
            return cls.LayDuLieu(sqlcmd);
        }

        public DataSet LayDSMay(int maPhong)
        {
            string select = "SELECT dtb_May.*, TenPhongMay, TenTrangThai, TenCauHinh ",
                from = "FROM dtb_May, dtb_PhongMay, dtb_TrangThai, dtb_CauHinh ",
                where = "WHERE dtb_May.MaPhong = dtb_PhongMay.MaPhongMay AND dtb_May.TrangThai = dtb_TrangThai.MaTrangThai AND dtb_May.MaCauHinh = dtb_CauHinh.MaCauHinh AND dtb_May.MaPhong = '" + maPhong + "'";
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

        public int ThemMoi(May may)
        {
            SqlCommand cmd = new SqlCommand();
            string insert = "INSERT INTO dtb_May(MaMay, MaPhong, TenMay, MaCauHinh, TrangThai, GhiChu) ",
                values = "VALUES (@maMay, @maPhong, @tenMay, @cauHinh, @trangThai, @ghiChu)";

            cmd.CommandText = insert + values;
            cmd.Parameters.Add("maMay", SqlDbType.Int).Value = may.MaMay;
            cmd.Parameters.Add("maPhong", SqlDbType.Int).Value = may.MaPhong;
            cmd.Parameters.Add("tenMay", SqlDbType.NVarChar).Value = may.TenMay;
            cmd.Parameters.Add("cauHinh", SqlDbType.Int).Value = may.MaCauHinh;
            cmd.Parameters.Add("trangThai", SqlDbType.Int).Value = may.TrangThai;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = may.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        public int Xoa(int maMay)
        {
            SqlCommand cmd = new SqlCommand();
            string delete = "DELETE FROM dtb_May ",
                where = "WHERE MaMay = @maMay";
            cmd.CommandText = delete + where;

            cmd.Parameters.Add("maMay", SqlDbType.SmallInt).Value = maMay;

            return cls.CapNhatDL(cmd);
        }

        public int CapNhatMay(May may)
        {
            SqlCommand cmd = new SqlCommand();
            string update = "UPDATE dtb_May ",
                set = "SET TenMay = @tenMay, MaPhong = @maPhong, MaCauHinh = @maCauHinh, TrangThai = @trangThai, GhiChu = @ghiChu ",
                where = "WHERE MaMay=@maMay";

            cmd.CommandText = update + set + where;
            cmd.Parameters.Add("maMay", SqlDbType.Int).Value = may.MaMay;
            cmd.Parameters.Add("maPhong", SqlDbType.Int).Value = may.MaPhong;
            cmd.Parameters.Add("maCauHinh", SqlDbType.Int).Value = may.MaCauHinh;
            cmd.Parameters.Add("trangThai", SqlDbType.Int).Value = may.TrangThai;
            cmd.Parameters.Add("tenMay", SqlDbType.NVarChar).Value = may.TenMay;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = may.GhiChu;

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
