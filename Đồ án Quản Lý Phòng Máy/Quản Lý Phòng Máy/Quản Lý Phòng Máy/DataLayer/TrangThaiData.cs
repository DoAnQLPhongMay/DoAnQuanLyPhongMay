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
        DataProvider cls = new DataProvider();

        public DataSet LayDSTrangThai()
        {
            string query = "SELECT * FROM dtb_TrangThai";

            SqlCommand cmd = new SqlCommand(query);

            return cls.LayDuLieu(cmd);
        }
    }
}
