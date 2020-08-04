using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.DataLayer
{
    class TrangThaiData
    {
        //Khởi tạo biến DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm xử lý lấy danh sách trạng thái phòng và máy.
        public DataSet LayDSTrangThai()
        {
            string select = "SELECT * ",
                from = "FROM dtb_TrangThai";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.LayDuLieu(cmd);
        }
    }
}
