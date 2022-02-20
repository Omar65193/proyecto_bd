using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace Proyecto2
{
    public class DAOLibros
    {
        public bool insertar(Libro libro)
        {
            Conexion con1 = new Conexion();
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = con1.conexion;
                con1.conexion.Open();
                string consulta = @"insert into LIBRO(ID, ISBN, NO_EDICION, ANIO_PUBLICACION, NOMBRE_AUTORES, PAIS, SINOPSIS, CARRERA, MATERIA) " +
                    "VALUES(@id, @isbn, @edicion, @anio, @autores, @pais, @sinopsis, @carrera, @materia); ";

                comando.CommandText = consulta;
                comando.Parameters.AddWithValue("@id", libro.id);
                comando.Parameters.AddWithValue("@isbn", libro.isbn);
                comando.Parameters.AddWithValue("@edicion", libro.edicion);
                comando.Parameters.AddWithValue("@anio", libro.anio);
                comando.Parameters.AddWithValue("@autores", libro.autores);
                comando.Parameters.AddWithValue("@pais", libro.pais);
                comando.Parameters.AddWithValue("@sinopsis", libro.sinopsis);
                comando.Parameters.AddWithValue("@carrera", libro.carrera);
                comando.Parameters.AddWithValue("@materia", libro.materia);

                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {


            }
            finally
            {
                con1.conexion.Close();
                con1.conexion.Dispose();
            }

            return false;

        }
        public DataTable select()
        {
            Conexion con1 = new Conexion();
            string consulta = "SELECT * FROM LIBRO;";
            SqlCommand cmd = new SqlCommand(consulta);
            return Conexion.ejecutarConsulta(cmd);
        }
    }
}