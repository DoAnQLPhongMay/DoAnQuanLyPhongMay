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
        DataProvider cls = new DataProvider();

        //Hàm xử lý lấy danh sách lịch sử nhập.
        public DataSet LayDSLichSuNhap()
        {
            string query = "SELECT * FROM dtb_LichSuNhap";

            SqlCommand cmd = new SqlCommand(query);

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

        //Hàm xử lý tìm kiếm lịch sử nhập.
        public DataSet LayDSTK(string key, string loaiTK)
        {
            string query = "SELECT * FROM dtb_LichSuNhap ";
            switch (loaiTK)
            {
                case "maNhap":
                    query += "WHERE MaNhap = " + key + "";
                    break;
                case "ngayNhap":
                    query += "WHERE NgayNhap like \"%" + key + "%\"";
                    break;
                case "nhaSanXuat":
                    query += "WHERE NhaSanXuat = '" + key + "'";
                    break;
                case "nhaCungCap":
                    query += "WHERE NhaCungCap = '" + key + "'";
                    break;
                case "maThietBi":
                    query += "WHERE MaThietBi = " + key + "";
                    break;
                default:
                    query += "WHERE NguoiPhuTrach = '" + key + "'";
                    break;
            }

            SqlCommand cmd = new SqlCommand(query);

            return cls.LayDuLieu(cmd);
        }
    }
}
