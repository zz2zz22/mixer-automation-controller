using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htv5_mixer_control
{
    class DatabaseUtils
    {
        public static SqlConnection GetSoftDBConnection()
        {
            string datasource = "172.16.0.12";
            string database = "VUSOFT_SUPPORT";
            string username = "ERPUSER";
            string password = "12345";

            //string connectionString = @"Data Source=DESKTOP-R9UCIUR/SQLEXPRESS;Initial Catalog=TLVN2; Integrated Security = True"; //Test on local server clone from mes_interface on MES database.
            return DatabaseSQLServerUtils.GetSoftDBConnection(datasource, database, username, password);
        }

        public static SqlConnection GetHTV5ControlDBConnection()
        {
            string datasource = "172.16.0.12";
            string database = "HTV5_CONTROL";
            string username = "ERPUSER";
            string password = "12345";

            //string connectionString = @"Data Source=DESKTOP-R9UCIUR/SQLEXPRESS;Initial Catalog=TLVN2; Integrated Security = True"; //Test on local server clone from mes_interface on MES database.
            return DatabaseSQLServerUtils.GetSoftDBConnection(datasource, database, username, password);
        }
    }
}
