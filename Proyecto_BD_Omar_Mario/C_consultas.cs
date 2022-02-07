using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 
namespace Proyecto_BD_Omar_Mario
{
    class C_consultas
    {
        public void iniciar_sesion(String server,string puerto,C_usuarios user)
        {
            Conexion con1 = new Conexion(server,puerto);
            
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con1.conexion;
            Console.WriteLine(con1.conexion.ConnectionString);
            con1.conexion.Open();

            string consulta= @"SELECT COUNT(*) FROM USUARIOS
                               WHERE USUARIO=@USUARIO AND SHA2(CONTRASENIA,256)=SHA2(@CONTRASENIA,256)";

            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("USUARIO", user.usuario);
            comando.Parameters.AddWithValue("CONTRASENIA", user.contrasenia);

            int confirmacion = Convert.ToInt32(comando.ExecuteScalar());
            if (confirmacion==0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                MessageBox.Show("SIMON YA ENTRASTE");
            }
        }
        public int getCategory(String nombre)
        {
            Conexion con1 = new Conexion(server, puerto);
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con1.conexion;
            con1.conexion.Open();
            string query = "SELECT ID_CATEGORIA FROM CATEGORIA WHERE NOMBRE LIKE '@nombre'";
          
            // SqlDataAdapter da = new SqlDataAdapter(cadena, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(query, con1.conexion);
            DataSet ds = new DataSet();
            da.Fill(ds, "categoria");


    

            // REGRESA LA LISTA
            return lstProductos;
        }
    }
}
