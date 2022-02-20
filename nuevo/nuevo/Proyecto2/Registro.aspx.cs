using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            DAO_usuario dAO_Usuario = new DAO_usuario();

            usuario.Nombre = txtUser.Text;
            if(txtPass.Text == txtPass2.Text)
            {
                usuario.Contrasenia = txtPass.Text;
                if (dAO_Usuario.registrarse(usuario))
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    string script = "alert('Ha ocurrido un error intentalo otra vez');";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            else {
                string script = "alert('Las contraseñas no son iguales');";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
            
            

        }
    }
}