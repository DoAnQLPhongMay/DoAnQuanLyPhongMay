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
    class LichSuThanhLyData
    {
        //Khởi tạo biến DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT MaThanhLy ",
                from = "FROM dtb_LichSuThanhLy ",
                orderBy = "ORDER BY MaThanhLy DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm xử lý lấy danh sách lịch sử thanh lý.
        public DataSet LayDSLichSuThanhLyTB()
        {
            string select = "SELECT dtb_LichSuThanhLy.*, dtb_TaiKhoan.HoVaTen, dtb_ThietBi.TenThietBi ",
                from = "FROM dtb_LichSuThanhLy, dtb_TaiKhoan, dtb_ThietBi ",
                where = "WHERE dtb_LichSuThanhLy.NguoiPhuTrach = dtb_TaiKhoan.TenDangNhap AND dtb_LichSuThanhLy.MaThietBi = dtb_ThietBi.MaThietBi";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        public DataSet LayDSLichSuThanhLyCH()
        {
            string select = "SELECT dtb_LichSuThanhLy.*, dtb_TaiKhoan.HoVaTen, dtb_CauHinh.TenCauHinh ",
                from = "FROM dtb_LichSuThanhLy, dtb_TaiKhoan, dtb_CauHinh ",
                where = "WHERE dtb_LichSuThanhLy.NguoiPhuTrach = dtb_TaiKhoan.TenDangNhap AND dtb_LichSuThanhLy.MaCauHinh = dtb_CauHinh.MaCauHinh";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý thêm mới lịch sử thanh lý.
        public int ThemThietBi(LichSuThanhLy lsThanhLy)
        {
            SqlCommand cmd = new SqlCommand();

            string insert = "INSERT INTO dtb_LichSuThanhLy(MaThanhLy, NgayThanhLy, MaThietBi, NhaSanXuat, NamSanxuat, SoLuong, DonGia, NguoiPhuTrach, GhiChu) ",
                values = "VALUES(@maThanhLy, @ngayThanhLy, @maThietBi, @nhaSanXuat, @namSanxuat, @soLuong, @donGia, @nguoiPhuTrach, @ghiChu)";

            cmd.CommandText = insert + values;
            cmd.Parameters.Add("maThanhLy", SqlDbType.Int).Value = lsThanhLy.MaThanhLy;
            cmd.Parameters.Add("ngayThanhLy", SqlDbType.Date).Value = lsThanhLy.NgayThanhLy;
            cmd.Parameters.Add("maThietBi", SqlDbType.Int).Value = lsThanhLy.MaThietBi;
            cmd.Parameters.Add("nhaSanXuat", SqlDbType.NVarChar).Value = lsThanhLy.NhaSanXuat;
            cmd.Parameters.Add("namSanxuat", SqlDbType.Int).Value = lsThanhLy.NamSanXuat;
            cmd.Parameters.Add("soLuong", SqlDbType.Int).Value = lsThanhLy.SoLuong;
            cmd.Parameters.Add("donGia", SqlDbType.Int).Value = lsThanhLy.DonGia;
            cmd.Parameters.Add("nguoiPhuTrach", SqlDbType.VarChar).Value = lsThanhLy.NguoiPhuTrach;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = lsThanhLy.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        public int ThemCauHinh(LichSuThanhLy lsThanhLy)
        {
            SqlCommand cmd = new SqlCommand();

            string insert = "INSERT INTO dtb_LichSuThanhLy(MaThanhLy, NgayThanhLy, MaCauHinh, NhaSanXuat, NamSanxuat, SoLuong, DonGia, NguoiPhuTrach, GhiChu) ",
                values = "VALUES(@maThanhLy, @ngayThanhLy, @maCauHinh, @nhaSanXuat, @namSanxuat, @soLuong, @donGia, @nguoiPhuTrach, @ghiChu)";

            cmd.CommandText = insert + values;
            cmd.Parameters.Add("maThanhLy", SqlDbType.Int).Value = lsThanhLy.MaThanhLy;
            cmd.Parameters.Add("ngayThanhLy", SqlDbType.Date).Value = lsThanhLy.NgayThanhLy;
            cmd.Parameters.Add("maCauHinh", SqlDbType.Int).Value = lsThanhLy.MaCauHinh;
            cmd.Parameters.Add("nhaSanXuat", SqlDbType.NVarChar).Value = lsThanhLy.NhaSanXuat;
            cmd.Parameters.Add("namSanxuat", SqlDbType.Int).Value = lsThanhLy.NamSanXuat;
            cmd.Parameters.Add("soLuong", SqlDbType.Int).Value = lsThanhLy.SoLuong;
            cmd.Parameters.Add("donGia", SqlDbType.Int).Value = lsThanhLy.DonGia;
            cmd.Parameters.Add("nguoiPhuTrach", SqlDbType.VarChar).Value = lsThanhLy.NguoiPhuTrach;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = lsThanhLy.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật lại số lượng của thiết bị sau khi thanh lý.
        public int CapNhatSL(LichSuThanhLy lsThanhLy)
        {
            SqlCommand cmd = new SqlCommand();

            string update = "UPDATE dtb_ThietBi ",
                set = "SET SoLuong = SoLuong - @soLuong ",
                where = "WHERE MaThietBi = @maThietBi";

            cmd.CommandText = update + set + where;
            cmd.Parameters.Add("maThietBi", SqlDbType.Int).Value = lsThanhLy.MaThietBi;
            cmd.Parameters.Add("soLuong", SqlDbType.Int).Value = lsThanhLy.SoLuong;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm lịch sử thanh lý.
        public DataSet LayDSTKTB(string key1, string key2, string loaiTK)
        {
            string select = "SELECT dtb_LichSuThanhLy.*, dtb_TaiKhoan.HoVaTen, dtb_ThietBi.TenThietBi ",
                from = "FROM dtb_LichSuThanhLy, dtb_TaiKhoan, dtb_ThietBi ",
                where = "WHERE dtb_LichSuThanhLy.NguoiPhuTrach = dtb_TaiKhoan.TenDangNhap AND dtb_LichSuThanhLy.MaThietBi = dtb_ThietBi.MaThietBi ";

            switch (loaiTK)
            {
                case "ngayThanhLY":
                    where += "AND dtb_LichSuThanhLy.NgayThanhLy BETWEEN '" + key1 + "' AND '" + key2 + "'";
                    break;
                case "nhaSanXuat":
                    where += "AND dtb_LichSuThanhLy.NhaSanXuat like N'%" + key1 + "%'";
                    break;
                case "thietBi":
                    where += "AND (dtb_LichSuThanhLy.MaThietBi like '%" + key1 + "%' OR dtb_ThietBi.TenThietBi like N'%" + key1 + "%')";
                    break;
                default:
                    where += "AND (dtb_LichSuThanhLy.NguoiPhuTrach like N'%" + key1 + "%' OR dtb_TaiKhoan.HoVaTen like N'%" + key1 + "%')";
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        public DataSet LayDSTKCH(string key1, string key2, string loaiTK)
        {
            string select = "SELECT dtb_LichSuThanhLy.*, dtb_TaiKhoan.HoVaTen, dtb_CauHinh.TenCauHinh ",
                from = "FROM dtb_LichSuThanhLy, dtb_TaiKhoan, dtb_CauHinh ",
                where = "WHERE dtb_LichSuThanhLy.NguoiPhuTrach = dtb_TaiKhoan.TenDangNhap AND dtb_LichSuThanhLy.MaCauHinh = dtb_CauHinh.MaCauHinh ";

            switch (loaiTK)
            {
                case "ngayThanhLY":
                    where += "AND dtb_LichSuThanhLy.NgayThanhLy BETWEEN '" + key1 + "' AND '" + key2 + "'";
                    break;
                case "nhaSanXuat":
                    where += "AND dtb_LichSuThanhLy.NhaSanXuat like N'%" + key1 + "%'";
                    break;
                case "cauHinh":
                    where += "AND (dtb_LichSuThanhLy.MaCauHinh like '%" + key1 + "%' OR dtb_LichSuThanhLy.TenCauHinh like N'%" + key1 + "%')";
                    break;
                default:
                    where += "AND (dtb_LichSuThanhLy.NguoiPhuTrach like N'%" + key1 + "%' OR dtb_TaiKhoan.HoVaTen like N'%" + key1 + "%')";
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
