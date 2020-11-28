using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql_Form_2
{
    class Constanta
    {
        public static string server = "localhost";
        public static string database = "praktisidb";
        public static string user = "root";
        public static string pass = "";

        public static string conString = "server=" + server +
            ";database=" + database +
            ";uid=" + user +
            ";pwd=" + pass;
    }
}
