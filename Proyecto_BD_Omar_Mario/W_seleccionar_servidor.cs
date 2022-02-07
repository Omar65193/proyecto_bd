using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_BD_Omar_Mario
{
    public partial class W_seleccionar_servidor : Form
    {
        public W_seleccionar_servidor()
        {
            InitializeComponent();
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            Conexion.servidor = txt_server.Text;
            Conexion.puerto = txt_puerto.Text;

            try
            {
                Conexion con1 = new Conexion();
                con1.conexion.Open();
                W_login w_Login = new W_login();

                w_Login.Show();
                this.Hide();


                con1.conexion.Close();
                con1.conexion.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show("Dato incorrectos");
            }

        }
    }
}
