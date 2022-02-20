using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace Proyecto2
{
    class Conexion
    {
        public String conexionstring { set; get; }
        public SqlConnection conexion { get; }

        public static SqlConnection conexionPro;
        public Conexion()
        {
            conexionstring = @"Server=187.140.103.190;Initial Catalog=TAREA2_2;Persist Security Info=False;User ID=mario;Password=password;";
            conexion = new SqlConnection(conexionstring);
        }
        public static bool conectar()
        {
            string parametrosConexion = @"Server=187.140.103.190;Initial Catalog=TAREA2_2;Persist Security Info=False;User ID=mario;Password=password;";
            try
            {
                conexionPro = new SqlConnection(parametrosConexion);
                conexionPro.Open();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error");
                return false;
            }

        }
        public static void desconectar()
        {
            if (conexionPro != null && conexionPro.State == ConnectionState.Open)
                conexionPro.Close();
        }
        public static DataTable ejecutarConsulta(SqlCommand query)
        {
            if (conectar())
            {
                try
                {
                    query.Connection = conexionPro;
                    SqlDataAdapter adaptador = new SqlDataAdapter(query);
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    return resultado;
                }
                catch (SqlException ex)
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
        public static int ejecutarSentencia(SqlCommand sentencia)
        {
            if (conectar())
            {
                try
                {
                    sentencia.Connection = conexionPro;
                    return sentencia.ExecuteNonQuery();
                }
                catch (SqlException ex)
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