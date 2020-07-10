using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Phòng_Máy.Class
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"BV-PC"; //Khoi
            string database = "QLPHONGMAY";
            string username = "sa";
            string password = "123456";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
