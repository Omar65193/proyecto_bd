namespace Proyecto_BD_Omar_Mario
{
    partial class Actualizar_Problema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Problema));
            this.lb_sol = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_archivo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_sol = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.nm_puntaje = new System.Windows.Forms.NumericUpDown();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPrivado = new System.Windows.Forms.RadioButton();
            this.rbPublico = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboGestor = new System.Windows.Forms.ComboBox();
            this.cboDificultad = new System.Windows.Forms.ComboBox();
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nm_puntaje)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sol
            // 
            this.lb_sol.Location = new System.Drawing.Point(784, 769);
            this.lb_sol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sol.Name = "lb_sol";
            this.lb_sol.Size = new System.Drawing.Size(244, 117);
            this.lb_sol.TabIndex = 72;
            this.lb_sol.Text = "ninguno";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(655, 769);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 16);
            this.label16.TabIndex = 70;
            this.label16.Text = "Archivo cargado: ";
            // 
            // lb_archivo
            // 
            this.lb_archivo.Location = new System.Drawing.Point(176, 781);
            this.lb_archivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_archivo.Name = "lb_archivo";
            this.lb_archivo.Size = new System.Drawing.Size(244, 117);
            this.lb_archivo.TabIndex = 69;
            this.lb_archivo.Text = "ninguno";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 781);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 16);
            this.label14.TabIndex = 68;
            this.label14.Text = "Archivo cargado: ";
            // 
            // txt_sol
            // 
            this.txt_sol.Location = new System.Drawing.Point(648, 587);
            this.txt_sol.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sol.Multiline = true;
            this.txt_sol.Name = "txt_sol";
            this.txt_sol.Size = new System.Drawing.Size(527, 158);
            this.txt_sol.TabIndex = 67;
            this.txt_sol.TextChanged += new System.EventHandler(this.txt_sol_TextChanged);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(40, 587);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(527, 158);
            this.txt_desc.TabIndex = 66;
            this.txt_desc.TextChanged += new System.EventHandler(this.txt_desc_TextChanged);
            // 
            // nm_puntaje
            // 
            this.nm_puntaje.DecimalPlaces = 2;
            this.nm_puntaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nm_puntaje.Location = new System.Drawing.Point(1101, 470);
            this.nm_puntaje.Margin = new System.Windows.Forms.Padding(4);
            this.nm_puntaje.Name = "nm_puntaje";
            this.nm_puntaje.Size = new System.Drawing.Size(99, 22);
            this.nm_puntaje.TabIndex = 65;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(525, 347);
            this.cmb_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(285, 24);
            this.cmb_categoria.TabIndex = 64;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAceptar.Location = new System.Drawing.Point(996, 903);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(167, 59);
            this.btnAceptar.TabIndex = 63;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(771, 903);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 59);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(1035, 769);
            this.btnSol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(141, 30);
            this.btnSol.TabIndex = 61;
            this.btnSol.Text = "Seleccionar archivo";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(427, 769);
            this.btnDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(141, 30);
            this.btnDesc.TabIndex = 60;
            this.btnDesc.Text = "Seleccionar archivo";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(643, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 59;
            this.label12.Text = "Solución:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(44, 559);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 25);
            this.label11.TabIndex = 58;
            this.label11.Text = "Descripción:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPrivado);
            this.groupBox1.Controls.Add(this.rbPublico);
            this.groupBox1.Location = new System.Drawing.Point(501, 929);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(197, 38);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // rbPrivado
            // 
            this.rbPrivado.AutoSize = true;
            this.rbPrivado.Location = new System.Drawing.Point(79, 11);
            this.rbPrivado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPrivado.Name = "rbPrivado";
            this.rbPrivado.Size = new System.Drawing.Size(75, 20);
            this.rbPrivado.TabIndex = 1;
            this.rbPrivado.TabStop = true;
            this.rbPrivado.Text = "Privado";
            this.rbPrivado.UseVisualStyleBackColor = true;
            // 
            // rbPublico
            // 
            this.rbPublico.AutoSize = true;
            this.rbPublico.Location = new System.Drawing.Point(0, 11);
            this.rbPublico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPublico.Name = "rbPublico";
            this.rbPublico.Size = new System.Drawing.Size(73, 20);
            this.rbPublico.TabIndex = 0;
            this.rbPublico.TabStop = true;
            this.rbPublico.Text = "Público";
            this.rbPublico.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(519, 474);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 22);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // cboGestor
            // 
            this.cboGestor.FormattingEnabled = true;
            this.cboGestor.Location = new System.Drawing.Point(49, 469);
            this.cboGestor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGestor.Name = "cboGestor";
            this.cboGestor.Size = new System.Drawing.Size(179, 24);
            this.cboGestor.TabIndex = 55;
            // 
            // cboDificultad
            // 
            this.cboDificultad.FormattingEnabled = true;
            this.cboDificultad.Location = new System.Drawing.Point(860, 346);
            this.cboDificultad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDificultad.Name = "cboDificultad";
            this.cboDificultad.Size = new System.Drawing.Size(205, 24);
            this.cboDificultad.TabIndex = 54;
            // 
            // txtFuente
            // 
            this.txtFuente.Location = new System.Drawing.Point(860, 469);
            this.txtFuente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(208, 22);
            this.txtFuente.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(855, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 52;
            this.label10.Text = "Fuente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(513, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(501, 903);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Visibilidad:";
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(249, 472);
            this.txtBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(244, 22);
            this.txtBD.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(247, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "BD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(43, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Gestor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(855, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Dificultad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(1095, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Puntaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(520, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Categoria:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(249, 347);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 22);
            this.txtNombre.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(244, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(49, 347);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(179, 22);
            this.txtID.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(45, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-29, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1247, 231);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // Actualizar_Problema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1231, 990);
            this.Controls.Add(this.lb_sol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lb_archivo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_sol);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.nm_puntaje);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboGestor);
            this.Controls.Add(this.cboDificultad);
            this.Controls.Add(this.txtFuente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Actualizar_Problema";
            this.Text = "Modificar Problema";
            this.Enter += new System.EventHandler(this.Actualizar_Problema_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.nm_puntaje)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_sol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_archivo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_sol;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.NumericUpDown nm_puntaje;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPrivado;
        private System.Windows.Forms.RadioButton rbPublico;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboGestor;
        private System.Windows.Forms.ComboBox cboDificultad;
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}