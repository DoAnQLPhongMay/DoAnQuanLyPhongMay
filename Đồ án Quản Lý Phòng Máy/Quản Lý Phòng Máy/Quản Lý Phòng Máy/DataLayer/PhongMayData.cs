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
    class PhongMayData
    {
        DataProvider cls = new DataProvider();

        //Hàm xử lý lấy danh sách phòng máy.
        public DataSet LayDSPhong()
        {
            string query = "SELECT * FROM dtb_PhongMay";

            SqlCommand cmd = new SqlCommand(query);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý tìm kiếm phòng máy.
        public DataSet LayDSTK(string key, string loaiTK)
        {
            string query = "SELECT * FROM dtb_PhongMay ";
            switch (loaiTK)
            {
                case "maPhong":
                    query += "WHERE MaPhongMay = " + key + "";
                    break;
                case "tenPhong":
                    query += " WHERE TenPhongMay = " + key + "";
                    break;
                default:
                    query += " WHERE TrangThai = " + key + "";
                    break;
            }

            SqlCommand cmd = new SqlCommand(query);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý thêm mới phòng máy.
        public int Them(PhongMay phong)
        {
            SqlCommand cmd = new SqlCommand();

            string insert = "INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu) ",
                values = "VALUES(@maPhong, @tenPhong, @soLuongMay, @trangThai, @ghiChu)";

            cmd.CommandText = insert + values;
            cmd.Parameters.Add("maPhong", SqlDbType.Int).Value = phong.MaPhong;
            cmd.Parameters.Add("tenPhong", SqlDbType.NVarChar).Value = phong.TenPhong;
            cmd.Parameters.Add("soLuongMay", SqlDbType.Int).Value = phong.SoLuongMay;
            cmd.Parameters.Add("trangThai", SqlDbType.Int).Value = phong.TrangThai;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = phong.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý xóa phòng máy.
        public int Xoa(int maPhong)
        {
            SqlCommand cmd = new SqlCommand();

            string delete = "DELETE FROM dtb_PhongMay ",
                where = "WHERE MaPhongMay = @maPhong";

            cmd.CommandText = delete + where;
            cmd.Parameters.Add("maPhong", SqlDbType.Int).Value = maPhong;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật phòng máy
        public int CapNhat(PhongMay phong)
        {
            SqlCommand cmd = new SqlCommand();

            string update = "UPDATE dtb_PhongMay ",
                set = "SET TenPhongMay = @tenPhong, SoLuongMay = @soLuongMay, TrangThai = @trangThai, GhiChu = @ghiChu ",
                where = "WHERE MaPhongMay = @maPhong";

            cmd.CommandText = update + set + where;
            cmd.Parameters.Add("maPhong", SqlDbType.Int).Value = phong.MaPhong;
            cmd.Parameters.Add("tenPhong", SqlDbType.NVarChar).Value = phong.TenPhong;
            cmd.Parameters.Add("soLuongMay", SqlDbType.Int).Value = phong.SoLuongMay;
            cmd.Parameters.Add("trangThai", SqlDbType.Int).Value = phong.TrangThai;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = phong.GhiChu;

            return cls.CapNhatDL(cmd);
        }
    }
}
