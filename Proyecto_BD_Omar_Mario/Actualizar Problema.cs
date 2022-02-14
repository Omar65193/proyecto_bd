using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD_Omar_Mario
{
    public partial class Actualizar_Problema : Form
    {
        public bool editado1;
        public bool editado2;
        Principal PG;
        public Actualizar_Problema(Problema p, Principal principal)
        {
            InitializeComponent();
            C_consultas c_Consultas = new C_consultas();
            cmb_categoria.DataSource = c_Consultas.llenar_categorias();
            cmb_categoria.DisplayMember = "NOMBRE";
            cmb_categoria.ValueMember = "ID_CATEGORIA";

            String[] dificultades = { "BASICO", "NORMAL", "DIFICIL", "MUY DIFICIL" };
            String[] gestores = { "MYSQL", "POSTGRESQL", "MARIADB" };
            PG = principal;
            cboDificultad.DataSource = dificultades;
            cboGestor.DataSource = gestores;
            txtBD.Text = p.bd;
            txtID.Text = p.id.ToString();
            txtFuente.Text = p.fuente;
            txtNombre.Text = p.nombre;
            txt_desc.Text = p.descripcion;
            txt_sol.Text = p.solucion;
            cboDificultad.SelectedItem = p.dificultad;
            cboGestor.SelectedItem = p.gestor;
            nm_puntaje.Value = p.puntaje;
            rbPublico.Checked = true;
            if (p.visibilidad.Equals("privado")) rbPrivado.Checked = true;
            else rbPublico.Checked = true;
        }
        public Actualizar_Problema()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Problema p = new Problema();
            p.id = Convert.ToInt32(txtID.Text.ToString());
            p.nombre = txtNombre.Text.ToString();
            p.descripcion = txt_desc.Text.ToString();
            p.solucion = txt_sol.Text.ToString();
            p.puntaje = Convert.ToDecimal(nm_puntaje.Value);
            p.idcat = getCategory();
            p.dificultad = cboDificultad.SelectedItem.ToString();
            p.gestor = cboGestor.SelectedItem.ToString();
            p.bd = txtBD.Text.ToString();
            p.visibilidad = rbPrivado.Checked ? "PRIVADO" : "PUBLICO";
            p.fecha = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            p.fuente = txtFuente.Text.ToString();

            if (validar(p.nombre, p.descripcion, p.puntaje, p.dificultad, p.gestor, p.bd, p.visibilidad, p.fecha))
            {
                C_consultas c_consultas = new C_consultas();
                if (c_consultas.modificar(p))
                {
                    MessageBox.Show(this, "Se hizo la modificación al problema", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PG.dgvProblemas.DataSource = c_consultas.obtenerProblemas();
                    this.Close();
                }

                //MessageBox.Show(this, "Si funciona pero todavía no está terminado el metodo", "Datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "Los datos ingresados no son validos", "Datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            OpenFileDialog explorador = new OpenFileDialog();
            explorador.Filter = "Text files (*.txt)|*.txt";
            explorador.Title = "Abrir archivo";

            if (explorador.ShowDialog() == DialogResult.OK)
            {
                editado1 = true;
                lb_archivo.Text = explorador.FileName;
                txt_desc.Text = "";
                using (StreamReader lector = new StreamReader(explorador.FileName))
                {
                    while (!lector.EndOfStream)
                    {
                        txt_desc.Text += lector.ReadLine();
                    }
                }
            }
            editado1 = false;
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            OpenFileDialog explorador = new OpenFileDialog();
            explorador.Filter = "Text files (*.txt)|*.txt";
            explorador.Title = "Abrir archivo";

            if (explorador.ShowDialog() == DialogResult.OK)
            {
                editado2 = true;
                lb_sol.Text = explorador.FileName;
                txt_sol.Text = "";
                using (StreamReader lector = new StreamReader(explorador.FileName))
                {
                    while (!lector.EndOfStream)
                    {
                        txt_sol.Text += lector.ReadLine();
                    }
                }
            }
            editado2 = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_desc_TextChanged(object sender, EventArgs e)
        {
            if (editado1 == false)
            {
                lb_archivo.Text = "ninguno";
            }
        }

        private void txt_sol_TextChanged(object sender, EventArgs e)
        {
            if (editado2 == false)
            {
                lb_sol.Text = "ninguno";
            }
        }
        public int getCategory()
        {
            C_consultas consulta = new C_consultas();
            int id = consulta.getCategory(cmb_categoria.Text.ToString());
            return id;

        }
        public bool validar(String nombre, String desc, decimal puntaje, String dificultad, String gestor, String bd, String visi, String fecha)
        {
            if (String.IsNullOrEmpty(nombre))
            {
                return false;
            }
            if (String.IsNullOrEmpty(desc))
            {
                return false;
            }
            if (puntaje == 0)
            {
                return false;
            }
            if (String.IsNullOrEmpty(dificultad))
            {
                return false;
            }
            if (String.IsNullOrEmpty(gestor))
            {
                return false;
            }
            if (String.IsNullOrEmpty(bd))
            {
                return false;
            }
            if (String.IsNullOrEmpty(visi))
            {
                return false;
            }
            if (String.IsNullOrEmpty(fecha))
            {
                return false;
            }
            return true;
        }

        private void Actualizar_Problema_Enter(object sender, EventArgs e)
        {

        }
    }
}
