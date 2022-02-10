using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD_Omar_Mario
{
    public partial class W_login : Form
    {
        public W_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C_usuarios user = new C_usuarios();
            user.usuario = txt_user.Text.Trim();
            user.contrasenia = txt_password.Text.ToString().Trim();
            C_consultas c_Consultas = new C_consultas();

            if (c_Consultas.iniciar_sesion(user))
            {
                Agregar_Problema w_problemas = new Agregar_Problema();
                w_problemas.Show();
                this.Hide();
            }

        }
    }
}
