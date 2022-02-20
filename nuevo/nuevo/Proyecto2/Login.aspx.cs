using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2


{
    public partial class Login : System.Web.UI.Page
    {
        public static Usuario usuario { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {

            usuario = new Usuario();
            
            usuario.Nombre = txtUser.Text;
            usuario.Contrasenia = txtPass.Text;
            usuario.Rol ="";

            DAO_usuario dAO_Usuario = new DAO_usuario();

            if ((dAO_Usuario.iniciarSesion(usuario))){
                Response.Redirect("MostrarLibros.aspx");
            }
            else
            {
                string script = "alert('Datos incorrectos');";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
            
        }
    }
}