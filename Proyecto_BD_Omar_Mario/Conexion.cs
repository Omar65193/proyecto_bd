using System;
using System.Collections.Generic;
using System.Data;
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
        public static MySqlConnection conexionPro;
       public Conexion()
        {           
             conexionstring = "server=" + servidor + "; port="+puerto+"; database=SERVERBD; Uid=omar; pwd=password;";
             conexion = new MySqlConnection(conexionstring);            
        }
        public static bool conectar()
        {
            string parametrosConexion = "server=" + servidor + "; port=" + puerto + "; database=SERVERBD; Uid=omar; pwd=password;";
            try
            {
                conexionPro = new MySqlConnection(parametrosConexion);
                conexionPro.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }

        }
        public static void desconectar()
        {
            if (conexionPro != null && conexionPro.State == ConnectionState.Open)
                conexionPro.Close();
        }
        public static DataTable ejecutarConsulta(MySqlCommand query)
        {
            if (conectar())
            {
                try
                {
                    query.Connection = conexionPro;
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query);
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    return resultado;
                }
                catch (MySqlException ex)
                {
                    return null;
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                return null;
            }
        }
        public static int ejecutarSentencia(MySqlCommand sentencia)
        {
            if (conectar())
            {
                try
                {
                    sentencia.Connection = conexionPro;
                    return sentencia.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return 0;
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                return 0;
            }
        }


    }
}
