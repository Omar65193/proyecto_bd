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
        public void iniciar_sesion(C_usuarios user)
        {
            Conexion con1 = new Conexion();
            try
            {                

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con1.conexion;
                con1.conexion.Open();

                string consulta = @"SELECT COUNT(*) FROM USUARIOS
                               WHERE USUARIO=@USUARIO AND SHA2(CONTRASENIA,256)=SHA2(@CONTRASENIA,256)";

                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("USUARIO", user.usuario);
                comando.Parameters.AddWithValue("CONTRASENIA", user.contrasenia);

                int confirmacion = Convert.ToInt32(comando.ExecuteScalar());
                if (confirmacion == 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    MessageBox.Show("YA ENTRASTE PERO ESTE LOGIN AUN NO ABRE NADA. PON ALGO AQUI");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
                
            }
            finally
            {
                con1.conexion.Close();
                con1.conexion.Dispose();
            }
          
        }
        public int getCategory(String nombre)
        {
            MySqlCommand query = new MySqlCommand("SELECT ID_CATEGORIA FROM " +
                "CATEGORIA WHERE NOMBRE LIKE '@nombre'");
            query.Parameters.AddWithValue("@nombre", nombre);
            DataTable dato = Conexion.ejecutarConsulta(query);
            if(dato.Rows.Count == 0) { return -1; }
            return Convert.ToInt32(dato.Rows[0][0].ToString());
            
        }
    }
}
