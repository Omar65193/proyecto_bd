using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_BD_Omar_Mario
{
   class Conexion
    {
        public String conexionstring { set; get; }
        public MySqlConnection conexion { get; }
        public static String servidor { get; set; }
        public static String puerto { get; set; }

       public Conexion()
        {           
             conexionstring = "server=" + servidor + "; port="+puerto+"; database=SERVERBD; Uid=omar; pwd=password;";
             conexion = new MySqlConnection(conexionstring);            
        }




    }
}
