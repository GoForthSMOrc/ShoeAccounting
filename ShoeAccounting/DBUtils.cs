using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SshNet;
using Renci.SshNet.Common;

namespace ShoeAccounting
{
    internal class DBUtils
    {
       
        public static MySqlConnection GetDBConnection()
        {

            /*PasswordConnectionInfo connectionInfo = new PasswordConnectionInfo(IP_ssh_server, port_ssh_server, ssh_user, ssh_password);
            connectionInfo.Timeout = TimeSpan.FromSeconds(30);*/
            string host = "194.58.121.94";
            int port = 3306;
            string username = "app_user";
            string password = "password";
            string database = "shoeaccounting";

            return DBMySQLUtils.GetDBConnection(host,port,database,username,password);
        }
    }
}
