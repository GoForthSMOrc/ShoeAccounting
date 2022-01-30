using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ShoeAccounting
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string username = "root";
            string password = "root";
            string database = "ShoeAccounting";

            return DBMySQLUtils.GetDBConnection(host,port,database,username,password);
        }
    }
}
