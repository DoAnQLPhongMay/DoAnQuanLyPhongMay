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
            string query = "SELECT * FROM dtb_LichSuThanhLy";

            SqlCommand cmd = new SqlCommand(query);

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
            string query = "SELECT * FROM dtb_LichSuThanhLy ";
            switch (loaiTK)
            {
                case "maThanhLy":
                    query += "WHERE MaThanhLy = " + key + "";
                    break;
                case "ngayThanhLy":
                    query += "WHERE NgayThanhLy like \"%" + key + "%\"";
                    break;
                case "nhaSanXuat":
                    query += "WHERE NhaSanXuat = '" + key + "'";
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
