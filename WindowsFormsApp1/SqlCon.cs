using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public static class SqlCon
    {
        readonly static string connectionstring = ("DATA SOURCE = YUSUF; INITIAL CATALOG = kutuphanedb; Integrated Security = True ");

        public static SqlConnection Connect()
        {
            return new SqlConnection(connectionstring);

        }
    }
}
