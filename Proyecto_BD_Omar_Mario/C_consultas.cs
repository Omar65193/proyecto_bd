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
                int confirmacion;
                try
                {
                    confirmacion = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    confirmacion = 0;
                }
                //hola
                confirmacion++;
                return confirmacion;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error xd");

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
                string sentencia = "ALTER TABLE PROBLEMAS AUTO_INCREMENT = 1";
                MySqlCommand comando2 = new MySqlCommand(sentencia);
                Conexion.ejecutarSentencia(comando2);
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
        public DataTable obtenerProblemas()
        {
            string consulta = "SELECT * FROM PROBLEMAS";
            MySqlCommand cmd = new MySqlCommand(consulta);

            var tabla = Conexion.ejecutarConsulta(cmd);
            return tabla;
        }
        public void eliminar(int id)
        {
            string sentencia = "DELETE FROM PROBLEMAS WHERE ID_PROBLEMA = @id";
            MySqlCommand cmd = new MySqlCommand(sentencia);
            cmd.Parameters.AddWithValue("@id", id);
            Conexion.ejecutarSentencia(cmd);
        }
        public DataTable obtenerProblema(int id)
        {
            string consulta = "SELECT * FROM PROBLEMAS WHERE ID_PROBLEMA = @id";
            MySqlCommand cmd = new MySqlCommand(consulta);
            cmd.Parameters.AddWithValue("@id", id);
            return Conexion.ejecutarConsulta(cmd);
        }
        public bool modificar(Problema problem)
        {
            try
            {
                string sentencia = "UPDATE PROBLEMAS SET NOMBRE = @nombre WHERE ID_PROBLEMA = @id";
                MySqlCommand cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@nombre", problem.nombre);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET DESCRIPCION = @descripcion WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@descripcion", problem.descripcion);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET SOLUCION = @solucion WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@solucion", problem.solucion);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET IDCAT = @idcat WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@idcat", problem.idcat);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET PUNTAJE = @puntaje WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@puntaje", problem.puntaje);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET DIFICULTAD = @dificultad WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@dificultad", problem.dificultad);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET gestor = @gestor WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@gestor", problem.gestor);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET BD = @bd WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@bd", problem.bd);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET VISIBILIDAD = @visibilidad WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@visi", problem.visibilidad);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET FECHA = @fecha WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@fecha", problem.fecha);
                Conexion.ejecutarSentencia(cmd);
                sentencia = "UPDATE PROBLEMAS SET FUENTE = @fuente WHERE ID_PROBLEMA = @id";
                cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@id", problem.id);
                cmd.Parameters.AddWithValue("@fuente", problem.fuente);
                Conexion.ejecutarSentencia(cmd);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
