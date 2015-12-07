using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Piagg.AutoQuery.Helpers
{
    public static class ConfigHelper
    {

        /*
         * Retorna os dados da string de conexão separado por propriedade
         */
        public static MySqlConnectionStringBuilder getConStringMysql()
        {
            var conSettings = ConfigurationManager.ConnectionStrings["BancoDados"].ConnectionString;


            MySqlConnectionStringBuilder mySqlConn = new MySqlConnectionStringBuilder(conSettings);

            return mySqlConn;
        }

        public static String GetStringConnection()
        {
            String stringConnnection = System.Configuration.ConfigurationManager.ConnectionStrings["BancoDados"].ConnectionString;
            return stringConnnection;
        }

    }
}
