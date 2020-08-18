using System.Data;
using System.Data.SqlClient;
using QuanLyPhongMay.BUS;

namespace QuanLyPhongMay.DataLayer
{
    class ThietBiData
    {
        //Khởi tạo biến kết nối DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT MaThietBi ",
                from = "FROM dtb_ChiTietThietBi ",
                orderBy = "ORDER BY MaThietBi DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm kiểm tra thiết bị có đang sử dụng không.
        public bool KTThietBi(int maThietBi)
        {
            string select = "SELECT * ",
                from = "FROM dtb_ChiTietMay ",
                where = "WHERE MaThietBi = '" + maThietBi + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.KiemTra(cmd);
        }

        //Hàm xử lý lấy danh sách thiết bị.
        public DataSet LayDSThietBi()
        {
            string select = "SELECT * ",
                from = "FROM dtb_ChiTietThietBi, dtb_LoaiThietBi ", 
                where = "WHERE dtb_ChiTietThietBi.MaLoai = dtb_LoaiThietBi.MaLoai";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý lấy danh sách thiết bị theo mã loại.
        public DataSet LayDSThietBi(int maLoai)
        {
            string select = "SELECT * ",
                from = "FROM dtb_ChiTietThietBi, dtb_LoaiThietBi ",
                where = "WHERE dtb_ChiTietThietBi.MaLoai = dtb_LoaiThietBi.MaLoai AND dtb_ChiTietThietBi.MaLoai = '" + maLoai + "'";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý lấy thông tin thiết bị.
        public DataSet LayThongTin()
        {
            string select = "SELECT * ",
                from = "FROM dtb_ChiTietThietBi ";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý lấy thông tin thiết bị của máy.
        public DataSet LayThongTinMay()
        {
            string select = "SELECT dtb_May.*, dtb_ChiTietThietBi.TenThietBi, dtb_ChiTietMay.MaThietBi, dtb_ChiTietThietBi.MaLoai ",
                from = "FROM dtb_May, dtb_ChiTietMay, dtb_ChiTietThietBi, dtb_LoaiThietBi ",
                where = "WHERE dtb_May.MaMay =  dtb_ChiTietMay.MaMay AND dtb_ChiTietMay.MaThietBi = dtb_ChiTietThietBi.MaThietBi AND dtb_ChiTietThietBi.MaLoai = dtb_LoaiThietBi.MaLoai";

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }

        //Hàm xử lý thêm mới thiết bị.
        public int Them(ThietBi thietBi)
        {
            SqlCommand cmd = new SqlCommand();
            string insert = "INSERT INTO dtb_ChiTietThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu) ",
                values = "VALUES(@maThietBi, @tenThietBi, @tsThietBi, @soLuong, @maLoai, @namSanXuat, @nhaSanXuat, @hanThanhLy, @ghiChu)";
            cmd.CommandText = insert + values;

            cmd.Parameters.Add("maThietBi", SqlDbType.Int).Value = thietBi.MaThietBi;
            cmd.Parameters.Add("tenThietBi", SqlDbType.NVarChar).Value = thietBi.TenThietBi;
            cmd.Parameters.Add("tsThietBi", SqlDbType.NVarChar).Value = thietBi.ThongSoThietBi;
            cmd.Parameters.Add("soLuong", SqlDbType.Int).Value = thietBi.SoLuong;
            cmd.Parameters.Add("maLoai", SqlDbType.Int).Value = thietBi.MaLoai;
            cmd.Parameters.Add("namSanXuat", SqlDbType.Int).Value = thietBi.NamSanXuat;
            cmd.Parameters.Add("nhaSanXuat", SqlDbType.NVarChar).Value = thietBi.NhaSanXuat;
            cmd.Parameters.Add("hanThanhLy", SqlDbType.Int).Value = thietBi.HanThanhLy;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = thietBi.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý xóa thiết bị.
        public int Xoa(int maThietBi)
        {
            SqlCommand cmd = new SqlCommand();
            string delete = "DELETE FROM dtb_ChiTietThietBi ",
                where = "WHERE MaThietBi = @maThietBi";
            cmd.CommandText = delete + where;

            cmd.Parameters.Add("maThietBi", SqlDbType.Int).Value = maThietBi;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật thiết bị.
        public int CapNhat(ThietBi thietBi)
        {
            SqlCommand cmd = new SqlCommand();
            string update = "UPDATE dtb_ChiTietThietBi ",
                set = "SET TenThietBi = @tenThietBi, TSThietBi = @tsThietBi, SoLuong = @soLuong, MaLoai = @maLoai, NamSanXuat = @namSanXuat, NhaSanXuat = @nhaSanXuat, HanThanhLy = @hanThanhLy, GhiChu = @ghiChu ",
                where = "WHERE MaThietBi = @maThietBi";
            cmd.CommandText = update + set + where;

            cmd.Parameters.Add("maThietBi", SqlDbType.Int).Value = thietBi.MaThietBi;
            cmd.Parameters.Add("tenThietBi", SqlDbType.NVarChar).Value = thietBi.TenThietBi;
            cmd.Parameters.Add("tsThietBi", SqlDbType.NVarChar).Value = thietBi.ThongSoThietBi;
            cmd.Parameters.Add("soLuong", SqlDbType.Int).Value = thietBi.SoLuong;
            cmd.Parameters.Add("maLoai", SqlDbType.Int).Value = thietBi.MaLoai;
            cmd.Parameters.Add("namSanXuat", SqlDbType.Int).Value = thietBi.NamSanXuat;
            cmd.Parameters.Add("nhaSanXuat", SqlDbType.NVarChar).Value = thietBi.NhaSanXuat;
            cmd.Parameters.Add("hanThanhLy", SqlDbType.Int).Value = thietBi.HanThanhLy;
            cmd.Parameters.Add("ghiChu", SqlDbType.NVarChar).Value = thietBi.GhiChu;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm thiết bị.
        public DataSet LayDSTK(string key, string loaiTK)
        {
            string select = "SELECT * ",
                from = "FROM dtb_ChiTietThietBi, dtb_LoaiThietBi ",
                where = "WHERE dtb_ChiTietThietBi.MaLoai = dtb_LoaiThietBi.MaLoai AND ";

            switch (loaiTK)
            {
                case "maThietBi":
                    where += "dtb_ChiTietThietBi.MaThietBi = '" + key + "'";
                    break;
                case "tenThietBi":
                    where += "dtb_ChiTietThietBi.TenThietBi = N'" + key + "'";
                    break;
                case "nhaSanXuat":
                    where += "dtb_ChiTietThietBi.NhaSanXuat = N'" + key + "'";
                    break;
                default:
                    where += "dtb_ChiTietThietBi.MaLoai = '" + key + "'";
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
