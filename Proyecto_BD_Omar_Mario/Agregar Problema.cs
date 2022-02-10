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
    public partial class Agregar_Problema : Form
    {
        bool editado1 = false;
        bool editado2 = false;
        public Agregar_Problema()
        {
            InitializeComponent();            
            C_consultas c_Consultas = new C_consultas();
            cmb_categoria.DataSource = c_Consultas.llenar_categorias();
            cmb_categoria.DisplayMember = "NOMBRE";
            cmb_categoria.ValueMember = "ID_CATEGORIA";

            String[] dificultades = { "BASICO", "NORMAL", "DIFICIL" };
            String[] gestores = { "MYSQL", "POSTGRES", "MARIADB" };

            cboDificultad.DataSource = dificultades;
            cboGestor.DataSource = gestores;

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
            p.puntaje = Convert.ToDouble(nm_puntaje.Value);
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
            //int id = consulta.getCategory(txtCategoria.Text.ToString());
            //return id;
            return 0;
        }
        public bool validar()
        {
            return false;
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            OpenFileDialog explorador = new OpenFileDialog();            
            explorador.Filter = "Text files (*.txt)|*.txt";
            explorador.Title = "Abrir archivo";

            if(explorador.ShowDialog()== DialogResult.OK){
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

        private void txt_desc_TextChanged(object sender, EventArgs e)
        {
            if (editado1 == false)
            {
                lb_archivo.Text = "ninguno";
            }
            
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

        private void txt_sol_TextChanged(object sender, EventArgs e)
        {
            if (editado2 == false)
            {
                lb_sol.Text = "ninguno";
            }

        }

        private void Agregar_Problema_Load(object sender, EventArgs e)
        {

        }
    }
}
