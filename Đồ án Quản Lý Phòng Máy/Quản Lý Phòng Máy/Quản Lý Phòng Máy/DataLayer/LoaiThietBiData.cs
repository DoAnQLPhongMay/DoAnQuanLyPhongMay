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
    class LoaiThietBiData
    {
        DataProvider cls = new DataProvider();

        public DataSet LayDSMaLoai()
        {
            string query = "SELECT * FROM dtb_LoaiThietBi";

            SqlCommand cmd = new SqlCommand(query);

            return cls.LayDuLieu(cmd);
        }
    }
}
