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
        DataProvider cls = new DataProvider();

        //Hàm xử lý lấy danh sách lịch sử thanh lý.
        public DataSet LayDSLichSuThanhLy()
        {
            string select = "SELECT dtb_LichSuThanhLy.*, dtb_TaiKhoan.HoVaTen, dtb_ChiTietThietBi.TenThietBi ",
                from = "FROM dtb_LichSuThanhLy, dtb_TaiKhoan, dtb_ChiTietThietBi ",
                where = "WHERE dtb_LichSuThanhLy.NguoiPhuTrach = dtb_TaiKhoan.TenDangNhap AND dtb_LichSuThanhLy.MaThietBi = dtb_ChiTietThietBi.MaThietBi";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý thêm mới lịch sử thanh lý.
        public int Them(LichSuThanhLy lsThanhLy)
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

        public DataSet LayDSTK(string key, string loaiTK)
        {
            string select = "SELECT dtb_LichSuThanhLy.*, dtb_TaiKhoan.HoVaTen, dtb_ChiTietThietBi.TenThietBi ",
                from = "FROM dtb_LichSuThanhLy, dtb_TaiKhoan, dtb_ChiTietThietBi ",
                where = "WHERE dtb_LichSuThanhLy.NguoiPhuTrach = dtb_TaiKhoan.TenDangNhap AND dtb_LichSuThanhLy.MaThietBi = dtb_ChiTietThietBi.MaThietBi ";

            switch (loaiTK)
            {
                case "maThanhLy":
                    where += "AND dtb_LichSuThanhLy.MaThanhLy = " + key + "";
                    break;
                case "ngayThanhLy":
                    where += "AND dtb_LichSuThanhLy.NgayThanhLy like \"%" + key + "%\"";
                    break;
                case "nhaSanXuat":
                    where += "AND dtb_LichSuThanhLy.NhaSanXuat = '" + key + "'";
                    break;
                case "maThietBi":
                    where += "AND dtb_LichSuThanhLy.MaThietBi = " + key + "";
                    break;
                default:
                    where += "AND (dtb_LichSuThanhLy.NguoiPhuTrach = '" + key + "' OR dtb_TaiKhoan.HoVaTen = '" + key + "')";
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
