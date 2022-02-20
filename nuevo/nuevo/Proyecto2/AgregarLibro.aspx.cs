using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2
{
    public partial class AddLibro : Page
    {
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.sinopsis = txtSinopsis.Text;
            libro.carrera = txtCarrera.Text;   
            libro.anio = Convert.ToInt32(txtAnio.Text.ToString());
            libro.autores = txtAutores.Text;
            libro.pais = txtPais.Text;
            libro.isbn = Convert.ToInt64(txtISBM.Text.ToString());
            libro.materia = txtMateria.Text;
            libro.edicion = Convert.ToInt32(txtEdicion.Text.ToString());
            DAOLibros dAOLibros = new DAOLibros();
            if (dAOLibros.insertar(libro))
            {
                Response.Redirect("MostrarLibros.aspx");
                
            }
            else
            {
                string script = "alert('Fallo la insecion del libro');";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }
    }
}
