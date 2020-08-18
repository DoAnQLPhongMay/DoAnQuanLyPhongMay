using System.Data;
using System.Data.SqlClient;
using QuanLyPhongMay.BUS;

namespace QuanLyPhongMay.DataLayer
{
    class CauHinhData
    {
        //Khởi tạo biến kết nối DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT MaCauHinh ",
                from = "FROM dtb_CauHinh ",
                orderBy = "ORDER BY MaCauHinh DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm xử lý lấy danh sách.
        public DataSet LayDSCauHinh()
        {
            string select = "SELECT * ",
                from = "FROM dtb_CauHinh ";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.LayDuLieu(cmd);
        }

        //Hàm kiểm tra tên đã tồn tại chưa.
        public bool KTCauHinh(string tenCauHinh)
        {
            SqlCommand cmd = new SqlCommand();
            string select = "SELECT * ",
                from = "FROM dtb_CauHinh ",
                where = "WHERE TenCauHinh=@tenCauHinh";
            cmd.CommandText = select + from + where;

            cmd.Parameters.Add("tenCauHinh", SqlDbType.VarChar).Value = tenCauHinh;

            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }

        //Hàm kiểm tra có đang sử dụng.
        public bool KTSuDung(int maCauHinh)
        {
            string select = "SELECT * ",
                from = "FROM dtb_May ",
                where = "WHERE MaCauHinh = '" + maCauHinh + "'";
            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.KiemTra(cmd);
        }

        //Hàm xử lý thêm mới.
        public int Them(CauHinh cauHinh)
        {
            SqlCommand cmd = new SqlCommand();
            string insert = "INSERT INTO dtb_CauHinh(MaCauHinh, TenCauHinh, ManHinh, Chuot, BanPhim, Thung, CPU, MainBoard, RAM, OCung, VGA, PSU, HeDieuHanh) ",
                values = "VALUES (@maCauHinh, @tenCauHinh, @manHinh, @chuot, @banPhim, @thung, @CPU, @mainBoard, @RAM, @oCung, @VGA, @PSU, @heDieuHanh)";
            cmd.CommandText = insert + values;

            cmd.Parameters.Add("maCauHinh", SqlDbType.Int).Value = cauHinh.MaCauHinh;
            cmd.Parameters.Add("tenCauHinh", SqlDbType.NVarChar).Value = cauHinh.TenCauHinh;
            cmd.Parameters.Add("manHinh", SqlDbType.Int).Value = cauHinh.ManHinh;
            cmd.Parameters.Add("banPhim", SqlDbType.Int).Value = cauHinh.BanPhim;
            cmd.Parameters.Add("chuot", SqlDbType.Int).Value = cauHinh.Chuot;
            cmd.Parameters.Add("thung", SqlDbType.Int).Value = cauHinh.Case;
            cmd.Parameters.Add("CPU", SqlDbType.Int).Value = cauHinh.CPU;
            cmd.Parameters.Add("mainBoard", SqlDbType.Int).Value = cauHinh.MainBoard;
            cmd.Parameters.Add("RAM", SqlDbType.Int).Value = cauHinh.RAM;
            cmd.Parameters.Add("oCung", SqlDbType.Int).Value = cauHinh.OCung;
            cmd.Parameters.Add("VGA", SqlDbType.Int).Value = cauHinh.VGA;
            cmd.Parameters.Add("PSU", SqlDbType.Int).Value = cauHinh.PSU;
            cmd.Parameters.Add("heDieuHanh", SqlDbType.Int).Value = cauHinh.HDH;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý xóa.
        public int Xoa(int maCauHinh)
        {
            SqlCommand cmd = new SqlCommand();
            string delete = "DELETE FROM dtb_CauHinh ",
                where = "WHERE MaCauHinh = @maCauHinh";
            cmd.CommandText = delete + where;

            cmd.Parameters.Add("maCauHinh", SqlDbType.Int).Value = maCauHinh;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật.
        public int CapNhat(CauHinh cauHinh)
        {
            SqlCommand cmd = new SqlCommand();
            string update = "UPDATE dtb_CauHinh ",
                set = "SET TenCauHinh = @tenCauHinh ",
                where = "WHERE MaCauHinh = @maCauHinh";
            cmd.CommandText = update + set + where;

            cmd.Parameters.Add("maCauHinh", SqlDbType.Int).Value = cauHinh.MaCauHinh;
            cmd.Parameters.Add("tenCauHinh", SqlDbType.NVarChar).Value = cauHinh.TenCauHinh;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm.
        public DataSet LayDSTK(string key, string loaiTK)
        {
            string select = "SELECT * ",
                from = "FROM dtb_CauHinh ",
                where = "WHERE ";

            switch (loaiTK)
            {
                case "tenCauHinh":
                    where += "TenCauHinh = N'" + key + "'";
                    break;
                default:
                    where += "ManHinh = N'" + key + "' OR Chuot = N'" + key + "' OR BanPhim = N'" + key + "' OR Thung = N'" + key + "' OR CPU = N'" + key + "' OR MainBoard = N'" + key + "' OR RAM = N'" + key + "' OR OCung = N'" + key + "' OR VGA = N'" + key + "' OR PSU = N'" + key + "' OR HeDieuHanh = N'" + key + "'";
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
