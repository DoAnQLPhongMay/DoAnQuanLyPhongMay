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
        //Khởi tạo biến DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT MaPhongMay ",
                from = "FROM dtb_PhongMay ",
                orderBy = "ORDER BY MaPhongMay DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm lấy ra số lượng máy của 1 phòng.
        public int GetSLMay(int maPhong)
        {
            string select = "SELECT SoLuongMay ",
                from = "FROM dtb_PhongMay ",
                where = "WHERE MaPhongMay = '" + maPhong + "'";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.GetID(cmd);
        }

        //Hàm lấy ra số lượng máy của 1 phòng.
        public int GetCountMay(int maPhong)
        {
            string select = "SELECT COUNT(*) ",
                from = "FROM dtb_PhongMay, dtb_May ",
                where = "WHERE dtb_PhongMay.MaPhongMay = dtb_May.MaPhong AND MaPhongMay = '" + maPhong + "'";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.GetID(cmd);
        }

        //Hàm kiểm tra tên phòng đã tồn tại chưa.
        public bool KTTenPhong(string tenPhong)
        {
            SqlCommand cmd = new SqlCommand();
            string select = "SELECT * ",
                from = "FROM dtb_PhongMay ",
                where = "WHERE TenPhongMay = N'" + tenPhong + "'";
            cmd.CommandText = select + from + where;

            return cls.KiemTra(cmd);
        }

        //Hàm kiểm tra có đang sử dụng.
        public bool KTSuDung(int maPhong)
        {
            string select = "SELECT * ",
                from = "FROM dtb_May ",
                where = "WHERE MaPhong = N'" + maPhong + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.KiemTra(cmd);
        }

        //Hàm xử lý lấy danh sách phòng máy.
        public DataSet LayDSPhong()
        {
            string select = "SELECT dtb_PhongMay.*, dtb_TrangThai.TenTrangThai, dtb_Khoa.TenKhoa ",
                from = "FROM dtb_PhongMay, dtb_TrangThai, dtb_Khoa ",
                where = "WHERE dtb_PhongMay.TrangThai = dtb_TrangThai.MaTrangThai AND dtb_PhongMay.Khoa = dtb_Khoa.MaKhoa";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        public DataSet LayPhong(int maPhong)
        {
            string select = "SELECT TenPhongMay, SoLuongMay ",
                from = "FROM dtb_PhongMay ",
                where = "WHERE MaPhongMay = '" + maPhong + "'";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý thêm mới phòng máy.
        public int Them(PhongMay phong)
        {
            SqlCommand cmd = new SqlCommand();

            string insert = "INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, Khoa, TrangThai, GhiChu) ",
                values = "VALUES(@maPhong, @tenPhong, @soLuongMay, @khoa, @trangThai, @ghiChu)";

            cmd.CommandText = insert + values;
            cmd.Parameters.Add("maPhong", SqlDbType.Int).Value = phong.MaPhong;
            cmd.Parameters.Add("tenPhong", SqlDbType.NVarChar).Value = phong.TenPhong;
            cmd.Parameters.Add("soLuongMay", SqlDbType.Int).Value = phong.SoLuongMay;
            cmd.Parameters.Add("khoa", SqlDbType.Int).Value = phong.Khoa;
            cmd.Parameters.Add("trangThai", SqlDbType.Int).Value = phong.TrangThai;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = phong.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý xóa.
        public int Xoa(int maPhong)
        {
            SqlCommand cmd = new SqlCommand();

            string delete = "DELETE FROM dtb_PhongMay ",
                where = "WHERE MaPhongMay = @maPhong";

            cmd.CommandText = delete + where;
            cmd.Parameters.Add("maPhong", SqlDbType.Int).Value = maPhong;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật.
        public int CapNhat(PhongMay phong)
        {
            SqlCommand cmd = new SqlCommand();

            string update = "UPDATE dtb_PhongMay ",
                set = "SET TenPhongMay = @tenPhong, SoLuongMay = @soLuongMay, Khoa = @khoa, TrangThai = @trangThai, GhiChu = @ghiChu ",
                where = "WHERE MaPhongMay = @maPhong";

            cmd.CommandText = update + set + where;
            cmd.Parameters.Add("maPhong", SqlDbType.Int).Value = phong.MaPhong;
            cmd.Parameters.Add("tenPhong", SqlDbType.NVarChar).Value = phong.TenPhong;
            cmd.Parameters.Add("soLuongMay", SqlDbType.Int).Value = phong.SoLuongMay;
            cmd.Parameters.Add("khoa", SqlDbType.Int).Value = phong.Khoa;
            cmd.Parameters.Add("trangThai", SqlDbType.Int).Value = phong.TrangThai;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = phong.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm.
        public DataSet LayDSTK(string key, string loaiTK)
        {
            string select = "SELECT dtb_PhongMay.*, dtb_TrangThai.TenTrangThai ",
                from = "FROM dtb_PhongMay, dtb_TrangThai ",
                where = "WHERE dtb_PhongMay.TrangThai = dtb_TrangThai.MaTrangThai ";

            switch (loaiTK)
            {
                case "maPhong":
                    where += "AND dtb_PhongMay.MaPhongMay = " + key + "";
                    break;
                case "tenPhong":
                    where += "AND dtb_PhongMay.TenPhongMay = '" + key + "'";
                    break;
                default:
                    where += "AND dtb_PhongMay.TrangThai = " + key + "";
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
