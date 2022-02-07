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
    public partial class Agregar_Problema : Form
    {
        public Agregar_Problema()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Problema p = new Problema();
            p.id = Convert.ToInt32(txtID.Text.ToString());
            p.nombre = txtNombre.Text.ToString();
            p.idcat = getCategory();
            p.dificultad = cboDificultad.Text.ToString();
            p.bd = txtBD.Text.ToString();
        }
        public int getCategory()
        {
            C_consultas consulta = new C_consultas();
            return consulta.
            return -1;
        }
    }
}
