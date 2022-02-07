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
         String conexionstring;        
       public MySqlConnection conexion { get; }
       
       public Conexion(String servidor,string puerto)
        {           
             conexionstring = "server=" + servidor + "; port="+puerto+"; database=SERVERBD; Uid=omar; pwd=password;";
             conexion = new MySqlConnection(conexionstring);            
        }




    }
}
