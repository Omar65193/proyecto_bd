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
            Agregar_Problema agregar_Problema = new Agregar_Problema(this); 
            agregar_Problema.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvProblemas.SelectedRows[0];
            if(dgvProblemas.SelectedRows.Count == 1)
            {
                DialogResult res = MessageBox.Show(this, "¿Seguro que desea eliminar el problema?", "Eliminar Problema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    cc.eliminar(Convert.ToInt32(row.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado el problema");
                    dgvProblemas.DataSource = cc.obtenerProblemas();
                }
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
                problem.id = Convert.ToInt32(dato.Rows[0][0].ToString());
                problem.nombre = dato.Rows[0][1].ToString();
                problem.descripcion = dato.Rows[0][2].ToString();
                problem.solucion = dato.Rows[0][3].ToString();
                problem.idcat = Convert.ToInt32(dato.Rows[0][4].ToString());
                problem.puntaje = Convert.ToDecimal(dato.Rows[0][5].ToString());
                problem.dificultad = dato.Rows[0][6].ToString();
                problem.gestor = dato.Rows[0][7].ToString();
                problem.bd = dato.Rows[0][8].ToString();
                problem.visibilidad = dato.Rows[0][9].ToString();
                problem.fecha = dato.Rows[0][10].ToString();
                problem.fuente = dato.Rows[0][11].ToString();
                Actualizar_Problema upd = new Actualizar_Problema(problem, this);
                upd.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un problema para modificar");
            }
        }

        private void Principal_Enter(object sender, EventArgs e)
        {
            dgvProblemas.DataSource = cc.obtenerProblemas();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
