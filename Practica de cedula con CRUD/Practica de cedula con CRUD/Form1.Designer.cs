namespace Practica_de_cedula_con_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picbAñadir = new System.Windows.Forms.PictureBox();
            this.pcbModificar = new System.Windows.Forms.PictureBox();
            this.pcbEliminar = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNocedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechadenacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaOcupacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaLugar_de_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picbAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbAñadir
            // 
            this.picbAñadir.BackColor = System.Drawing.Color.White;
            this.picbAñadir.Image = ((System.Drawing.Image)(resources.GetObject("picbAñadir.Image")));
            this.picbAñadir.Location = new System.Drawing.Point(796, 59);
            this.picbAñadir.Name = "picbAñadir";
            this.picbAñadir.Size = new System.Drawing.Size(70, 70);
            this.picbAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbAñadir.TabIndex = 0;
            this.picbAñadir.TabStop = false;
            this.picbAñadir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbModificar
            // 
            this.pcbModificar.BackColor = System.Drawing.Color.White;
            this.pcbModificar.Image = ((System.Drawing.Image)(resources.GetObject("pcbModificar.Image")));
            this.pcbModificar.Location = new System.Drawing.Point(796, 167);
            this.pcbModificar.Name = "pcbModificar";
            this.pcbModificar.Size = new System.Drawing.Size(70, 70);
            this.pcbModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbModificar.TabIndex = 1;
            this.pcbModificar.TabStop = false;
            this.pcbModificar.Click += new System.EventHandler(this.pcbModificar_Click);
            // 
            // pcbEliminar
            // 
            this.pcbEliminar.BackColor = System.Drawing.Color.White;
            this.pcbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pcbEliminar.Image")));
            this.pcbEliminar.Location = new System.Drawing.Point(796, 269);
            this.pcbEliminar.Name = "pcbEliminar";
            this.pcbEliminar.Size = new System.Drawing.Size(70, 70);
            this.pcbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEliminar.TabIndex = 2;
            this.pcbEliminar.TabStop = false;
            this.pcbEliminar.Click += new System.EventHandler(this.pcbEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNocedula,
            this.ColumnNombre,
            this.ColumnaApellido,
            this.ColumnaEstado_civil,
            this.ColumnaFechadenacimiento,
            this.ColumnaOcupacio,
            this.ColumnaLugar_de_nacimiento});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 296);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnNocedula
            // 
            this.ColumnNocedula.HeaderText = "No. cedula";
            this.ColumnNocedula.Name = "ColumnNocedula";
            this.ColumnNocedula.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnaApellido
            // 
            this.ColumnaApellido.HeaderText = "Apellidos";
            this.ColumnaApellido.Name = "ColumnaApellido";
            this.ColumnaApellido.ReadOnly = true;
            // 
            // ColumnaEstado_civil
            // 
            this.ColumnaEstado_civil.HeaderText = "Estado civil";
            this.ColumnaEstado_civil.Name = "ColumnaEstado_civil";
            this.ColumnaEstado_civil.ReadOnly = true;
            // 
            // ColumnaFechadenacimiento
            // 
            this.ColumnaFechadenacimiento.HeaderText = "Fecha de nacimiento";
            this.ColumnaFechadenacimiento.Name = "ColumnaFechadenacimiento";
            this.ColumnaFechadenacimiento.ReadOnly = true;
            // 
            // ColumnaOcupacio
            // 
            this.ColumnaOcupacio.HeaderText = "Ocupacion";
            this.ColumnaOcupacio.Name = "ColumnaOcupacio";
            this.ColumnaOcupacio.ReadOnly = true;
            // 
            // ColumnaLugar_de_nacimiento
            // 
            this.ColumnaLugar_de_nacimiento.HeaderText = "Lugar de nacimiento";
            this.ColumnaLugar_de_nacimiento.Name = "ColumnaLugar_de_nacimiento";
            this.ColumnaLugar_de_nacimiento.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pcbEliminar);
            this.Controls.Add(this.pcbModificar);
            this.Controls.Add(this.picbAñadir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picbAñadir;
        private PictureBox pcbModificar;
        private PictureBox pcbEliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnNocedula;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaEstado_civil;
        private DataGridViewTextBoxColumn ColumnaFechadenacimiento;
        private DataGridViewTextBoxColumn ColumnaOcupacio;
        private DataGridViewTextBoxColumn ColumnaLugar_de_nacimiento;
    }
}