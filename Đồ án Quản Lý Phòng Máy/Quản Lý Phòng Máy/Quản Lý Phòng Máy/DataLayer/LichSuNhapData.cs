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
    class LichSuNhapData
    {
        //Khởi tạo biến DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT MaNhap ",
                from = "FROM dtb_LichSuNhap ",
                orderBy = "ORDER BY MaNhap DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm xử lý lấy danh sách lịch sử nhập.
        public DataSet LayDSLichSuNhap()
        {
            string select = "SELECT dtb_LichSuNhap.*, dtb_TaiKhoan.HoVaTen, dtb_ChiTietThietBi.TenThietBi ",
                from = "FROM dtb_LichSuNhap, dtb_TaiKhoan, dtb_ChiTietThietBi ",
                where = "WHERE dtb_LichSuNhap.NguoiPhuTrach = dtb_TaiKhoan.TenDangNhap AND dtb_LichSuNhap.MaThietBi = dtb_ChiTietThietBi.MaThietBi";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý thêm mới lịch sử nhập.
        public int Them(LichSuNhap lsNhap)
        {
            SqlCommand cmd = new SqlCommand();

            string insert = "INSERT INTO dtb_LichSuNhap(MaNhap, NgayNhap, MaThietBi, NhaCungCap, NhaSanXuat, NamSanxuat, SoLuong, DonGia, NguoiPhuTrach, GhiChu) ",
                values = "VALUES(@maThanhLy, @ngayThanhLy, @maThietBi, @nhaCungCap, @nhaSanXuat, @namSanxuat, @soLuong, @donGia, @nguoiPhuTrach, @ghiChu)";

            cmd.CommandText = insert + values;
            cmd.Parameters.Add("maThanhLy", SqlDbType.Int).Value = lsNhap.MaNhap;
            cmd.Parameters.Add("ngayThanhLy", SqlDbType.Date).Value = lsNhap.NgayNhap;
            cmd.Parameters.Add("maThietBi", SqlDbType.Int).Value = lsNhap.MaThietBi;
            cmd.Parameters.Add("nhaCungCap", SqlDbType.NVarChar).Value = lsNhap.NhaCungCap;
            cmd.Parameters.Add("nhaSanXuat", SqlDbType.NVarChar).Value = lsNhap.NhaSanXuat;
            cmd.Parameters.Add("namSanxuat", SqlDbType.Int).Value = lsNhap.NamSanXuat;
            cmd.Parameters.Add("soLuong", SqlDbType.Int).Value = lsNhap.SoLuong;
            cmd.Parameters.Add("donGia", SqlDbType.Int).Value = lsNhap.DonGia;
            cmd.Parameters.Add("nguoiPhuTrach", SqlDbType.VarChar).Value = lsNhap.NguoiPhuTrach;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = lsNhap.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật lại số lượng của thiết bị sau khi nhập.
        public int CapNhatSL(LichSuNhap lsNhap)
        {
            SqlCommand cmd = new SqlCommand();

            string update = "UPDATE dtb_ChiTietThietBi ",
                set = "SET SoLuong = SoLuong + @soLuong, NamSanXuat = @namSanxuat, NhaSanXuat = @nhaSanXuat ",
                where = "WHERE MaThietBi = @maThietBi";

            cmd.CommandText = update + set + where;
            cmd.Parameters.Add("maThietBi", SqlDbType.Int).Value = lsNhap.MaThietBi;
            cmd.Parameters.Add("nhaSanXuat", SqlDbType.NVarChar).Value = lsNhap.NhaSanXuat;
            cmd.Parameters.Add("namSanxuat", SqlDbType.Int).Value = lsNhap.NamSanXuat;
            cmd.Parameters.Add("soLuong", SqlDbType.Int).Value = lsNhap.SoLuong;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm lịch sử nhập.
        public DataSet LayDSTK(string key, string loaiTK)
        {
            string select = "SELECT dtb_LichSuNhap.*, dtb_TaiKhoan.HoVaTen, dtb_ChiTietThietBi.TenThietBi ",
                from = "FROM dtb_LichSuNhap, dtb_TaiKhoan, dtb_ChiTietThietBi ",
                where = "WHERE dtb_LichSuNhap.NguoiPhuTrach = dtb_TaiKhoan.TenDangNhap AND dtb_LichSuNhap.MaThietBi = dtb_ChiTietThietBi.MaThietBi ";


            switch (loaiTK)
            {
                case "maNhap":
                    where += "AND dtb_LichSuNhap.MaNhap = " + key + "";
                    break;
                case "ngayNhap":
                    where += "AND dtb_LichSuNhap.NgayNhap = '" + key + "'";
                    break;
                case "nhaSanXuat":
                    where += "AND dtb_LichSuNhap.NhaSanXuat = '" + key + "'";
                    break;
                case "nhaCungCap":
                    where += "AND dtb_LichSuNhap.NhaCungCap = '" + key + "'";
                    break;
                case "maThietBi":
                    where += "AND dtb_LichSuNhap.MaThietBi = " + key + "";
                    break;
                default:
                    where += "AND (dtb_LichSuNhap.NguoiPhuTrach = '" + key + "' OR dtb_TaiKhoan.HoVaTen = '" + key + "')";
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
