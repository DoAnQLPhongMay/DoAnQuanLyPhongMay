using System.Data;
using System.Data.SqlClient;
using QuanLyPhongMay.BUS;

namespace QuanLyPhongMay.DataLayer
{
    class KhoaData
    {
        //Khởi tạo biến kết nối DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm lấy ra ID có giá trị cao nhất.
        public int GetID()
        {
            string select = "SELECT MaKhoa ",
                from = "FROM dtb_Khoa ",
                orderBy = "ORDER BY MaKhoa DESC";

            SqlCommand cmd = new SqlCommand(select + from + orderBy);

            return cls.GetID(cmd);
        }

        //Hàm xử lý lấy danh sách.
        public DataSet LayDSKhoa()
        {
            string select = "SELECT * ",
                from = "FROM dtb_Khoa ";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.LayDuLieu(cmd);
        }

        //Hàm kiểm tra tên đã tồn tại chưa.
        public bool KiemTraTenKhoa(string tenKhoa)
        {
            SqlCommand cmd = new SqlCommand();
            string select = "SELECT * ",
                from = "FROM dtb_Khoa ",
                where = "WHERE TenKhoa=@tenKhoa";
            cmd.CommandText = select + from + where;

            cmd.Parameters.Add("tenKhoa", SqlDbType.VarChar).Value = tenKhoa;

            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }

        //Hàm xử lý thêm mới.
        public int Them(Khoa khoa)
        {
            SqlCommand cmd = new SqlCommand();
            string insert = "INSERT INTO dtb_Khoa(MaKhoa, TenKhoa) ",
                values = "VALUES (@maKhoa, @tenKhoa)";
            cmd.CommandText = insert + values;

            cmd.Parameters.Add("maKhoa", SqlDbType.Int).Value = khoa.MaKhoa;
            cmd.Parameters.Add("tenKhoa", SqlDbType.NVarChar).Value = khoa.TenKhoa;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý xóa.
        public int Xoa(int maKhoa)
        {
            SqlCommand cmd = new SqlCommand();
            string delete = "DELETE FROM dtb_Khoa ",
                where = "WHERE MaKhoa = @maKhoa";
            cmd.CommandText = delete + where;

            cmd.Parameters.Add("maKhoa", SqlDbType.Int).Value = maKhoa;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý cập nhật.
        public int CapNhat(Khoa khoa)
        {
            SqlCommand cmd = new SqlCommand();
            string update = "UPDATE dtb_Khoa ",
                set = "SET TenKhoa = @tenKhoa ",
                where = "WHERE MaKhoa = @maKhoa";
            cmd.CommandText = update + set + where;

            cmd.Parameters.Add("maKhoa", SqlDbType.Int).Value = khoa.MaKhoa;
            cmd.Parameters.Add("tenKhoa", SqlDbType.NVarChar).Value = khoa.TenKhoa;

            return cls.CapNhatDL(cmd);
        }

        //Hàm xử lý tìm kiếm.
        public DataSet LayDSTK(string key, string loaiTK)
        {
            string select = "SELECT * ",
                from = "FROM dtb_Khoa ",
                where = "WHERE ";

            switch (loaiTK)
            {
                default:
                    where += "TenKhoa = N'" + key + "'";
                    break;
            }

            SqlCommand cmd = new SqlCommand(select + from + where);

            return cls.LayDuLieu(cmd);
        }
    }
}
