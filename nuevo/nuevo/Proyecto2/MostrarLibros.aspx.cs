using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            DAOLibros dAOLibros = new DAOLibros();            
            gvLibros.DataSource = dAOLibros.select();
            gvLibros.DataBind();
        }
      
        protected void gvLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void add_libro_Click(object sender, EventArgs e)
        {
            if (Login.usuario.Rol == "ADMINISTRADOR")
            {
                Response.Redirect("AgregarLibro.aspx");
            }
            else
            {
                string script = "alert('No tienes permisos para hacer esto');";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
            
        }
    }
}
