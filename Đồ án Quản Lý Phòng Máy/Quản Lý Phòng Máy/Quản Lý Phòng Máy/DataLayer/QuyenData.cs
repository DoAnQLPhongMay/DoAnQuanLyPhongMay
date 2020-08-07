using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QuanLyPhongMay.DataLayer
{
    class QuyenData
    {
        //Khởi tạo biến DataProvider.
        DataProvider cls = new DataProvider();

        //Hàm xử lý lấy danh sách trạng thái phòng và máy.
        public DataSet LayDSTrangThai()
        {
            string select = "SELECT * ",
                from = "FROM dtb_Quyen";

            SqlCommand cmd = new SqlCommand(select + from);

            return cls.LayDuLieu(cmd);
        }
    }
}
