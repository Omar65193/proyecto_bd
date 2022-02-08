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
            p.dificultad = cboDificultad.SelectedItem.ToString();
            p.bd = txtBD.Text.ToString();
            p.fecha = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            p.fuente = txtFuente.Text.ToString();
            p.gestor = cboGestor.SelectedItem.ToString();
            p.visibilidad = rbPrivado.Checked ? "Privado" : "Publico";
            p.puntaje = Convert.ToDouble(txtPuntaje.Text.ToString());
            if (validar())
            {
                //Insertar problema en la tabla
            }
            else
            {
                MessageBox.Show(this, "Los datos ingresados no son validos", "Datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public int getCategory()
        {
            C_consultas consulta = new C_consultas();
            int id = consulta.getCategory(txtCategoria.Text.ToString());
            return id;
        }
        public bool validar()
        {
            return false;
        }
    }
}
