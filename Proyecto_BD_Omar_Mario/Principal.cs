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
    public partial class Principal : Form
    {
        C_consultas cc;
        public Principal()
        {
            InitializeComponent();
            cc = new C_consultas();
            dgvProblemas.DataSource = cc.obtenerProblemas();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agregar_Problema agregar_Problema = new Agregar_Problema(); 
            agregar_Problema.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvProblemas.SelectedRows[0];
            if(dgvProblemas.SelectedRows.Count == 1)
            {
                cc.eliminar(Convert.ToInt32(row.Cells[0].Value));
            }
            else
            {
                MessageBox.Show("Seleccione un problema para eliminar");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvProblemas.SelectedRows[0];
            if (dgvProblemas.SelectedRows.Count == 1)
            {
                DataTable dato = cc.obtenerProblema(Convert.ToInt32(row.Cells[0].Value));
                Problema problem = new Problema();
                problem.id = Convert.ToInt32(dato.Rows[0][0]);
                problem.nombre = dato.Rows[0][1].ToString();
                problem.visibilidad = dato.Rows[0][2].ToString();
                problem.gestor = dato.Rows[0][3].ToString();
                problem.puntaje = Convert.ToInt32(dato.Rows[0][3].ToString());
                problem.fuente = dato.Rows[0][3].ToString();
                problem.dificultad = dato.Rows[0][3].ToString();
                problem.solucion = dato.Rows[0][3].ToString();
                problem.descripcion = dato.Rows[0][3].ToString();
                problem.fecha = dato.Rows[0][3].ToString();
                Actualizar_Problema upd = new Actualizar_Problema();
                upd.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un problema para modificar");
            }
        }
    }
}
