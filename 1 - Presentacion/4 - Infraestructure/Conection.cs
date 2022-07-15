using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Infraestructure
{
    public class Conection
    {
        public static void Conexion()
        {
            SqlConnection con = new SqlConnection(string.Format(@"
            integrated security = true;
            datasource = DESKTOP-SC15GE0;
            database = Taller
            "));
        }

        
    }
}
