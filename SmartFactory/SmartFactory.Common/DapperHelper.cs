using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Common
{
    using System.Configuration;
    using Dapper;
    using MySql.Data.MySqlClient;
    using MySql.Data;

    public class DapperHelper
    {
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        /// <summary>
        /// 获取连接数据库的字符串
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection GetConnString()
        {
            return new MySqlConnection(connString);
        }
    }
}
