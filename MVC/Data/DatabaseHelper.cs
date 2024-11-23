using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MVC.Data
{
    class DatabaseHelper
    {
        private const string ConnectionString = "Server=127.0.01;Database=pos;Uid=user;Pwd=kopi;";

        public static IDbConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
