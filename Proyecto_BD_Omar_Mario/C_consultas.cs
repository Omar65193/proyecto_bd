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
        public bool iniciar_sesion(C_usuarios user)
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
                    return false;
                }
                else
                {
                    return true;
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

            return false;
          
        }
        public int getCategory(String nombre)
        {
            MySqlCommand query = new MySqlCommand("SELECT ID_CATEGORIA FROM " +
                "CATEGORIA WHERE NOMBRE LIKE @nombre");
            query.Parameters.AddWithValue("@nombre", nombre);
            DataTable dato = Conexion.ejecutarConsulta(query);
            if(dato.Rows.Count == 0) { return -1; }
            return Convert.ToInt32(dato.Rows[0][0].ToString());
            
        }
        public DataTable llenar_categorias()
        {
            string consulta = "SELECT ID_CATEGORIA, NOMBRE FROM CATEGORIA";
            MySqlCommand cmd = new MySqlCommand(consulta);
            
            var tabla = Conexion.ejecutarConsulta(cmd);
            return tabla;
        }

        public int getID()
        {
            Conexion con1 = new Conexion();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con1.conexion;
                con1.conexion.Open();
                string consulta = "SELECT MAX(ID_PROBLEMA) FROM PROBLEMAS";
                comando.CommandText = consulta;
                int confirmacion = Convert.ToInt32(comando.ExecuteScalar());
                return confirmacion + 1;
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
            return 0;
        }

        public bool insertar(Problema problem)
        {
            Conexion con1 = new Conexion();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con1.conexion;
                con1.conexion.Open();

                string consulta = @"INSERT INTO PROBLEMAS (ID_PROBLEMA, NOMBRE, DESCRIPCION, SOLUCION, ID_CATEGORIA, PUNTAJE, DIFICULTAD, GESTOR, BD, VISIBILIDAD, FECHA_CREACION, FUENTE) 
                VALUES(@id, @nombre, @descripcion, @solucion, @idcat, @puntaje, @dificultad, @gestor, @bd, @visi, @fecha, @fuente)";


                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@id", problem.id);
                comando.Parameters.AddWithValue("@nombre", problem.nombre);
                comando.Parameters.AddWithValue("@descripcion", problem.descripcion);
                comando.Parameters.AddWithValue("@solucion", problem.solucion);
                comando.Parameters.AddWithValue("@idcat", problem.idcat);
                comando.Parameters.AddWithValue("@puntaje", problem.puntaje);
                comando.Parameters.AddWithValue("@dificultad", problem.dificultad);
                comando.Parameters.AddWithValue("@gestor", problem.gestor);
                comando.Parameters.AddWithValue("@bd", problem.bd);
                comando.Parameters.AddWithValue("@visi", problem.visibilidad);
                comando.Parameters.AddWithValue("@fecha", problem.fecha);
                comando.Parameters.AddWithValue("@fuente", problem.fuente);
                

                comando.ExecuteNonQuery();
                return true;
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

            return false;

        }
    }
}
