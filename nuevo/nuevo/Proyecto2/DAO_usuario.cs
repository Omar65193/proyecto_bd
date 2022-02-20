using System;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Proyecto2
{
    public class DAO_usuario
    {
        public bool iniciarSesion(Usuario user)
        {
            Conexion con1 = new Conexion();
            try
            {
                SqlCommand comando = new SqlCommand();
                SqlCommand comando1 = new SqlCommand();
                comando.Connection = con1.conexion;
                comando1.Connection = con1.conexion;
                con1.conexion.Open();

                string consulta = @"SELECT COUNT(*) FROM USUARIOS WHERE NOMBRE=@NOMBRE AND CONTRASENIA=@CONTRASENIA";

                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@NOMBRE", user.Nombre.ToString());
                comando.Parameters.AddWithValue("@CONTRASENIA", user.Contrasenia.ToString());

                int confirmacion = Convert.ToInt32(comando.ExecuteScalar());
                if (confirmacion == 0)
                {
                    return false;
                }
                else
                {
                    string consulta1 = @"SELECT ROL FROM USUARIOS WHERE NOMBRE=@NOMBRE AND CONTRASENIA=@CONTRASENIA";
                    comando1.CommandText = consulta1;
                    comando1.Parameters.AddWithValue("@NOMBRE", user.Nombre.ToString());
                    comando1.Parameters.AddWithValue("@CONTRASENIA", user.Contrasenia.ToString());                    

                    SqlDataReader dataReader = comando1.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Login.usuario.Rol = dataReader.GetString(0);
                    }
                    
                    return true;
                }


            }
            catch (Exception)
            {
                
                return false;
            }
            finally
            {
                con1.conexion.Close();
                con1.conexion.Dispose();
            }
        }

        public bool registrarse(Usuario user)
        {
            Conexion con1 = new Conexion();
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = con1.conexion;
                con1.conexion.Open();

                string consulta = @"INSERT INTO USUARIOS VALUES (@NOMBRE,@CONTRASENIA,'BASICO')";

                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@NOMBRE", user.Nombre.ToString());
                comando.Parameters.AddWithValue("@CONTRASENIA", user.Contrasenia.ToString());

                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con1.conexion.Close();
                con1.conexion.Dispose();
            }
        }


    }
}