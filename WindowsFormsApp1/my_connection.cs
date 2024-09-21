using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    internal class my_connection
    {
        MySqlConnection conn = new MySqlConnection("datasource = localhost; username = root; password =; database = kelvin_ms_csharp");
        public MySqlConnection open()
        {
            conn.Open();
            return conn;
        }

        public MySqlConnection close()
        {
            conn.Close();
            return conn;
        }
    }
}
