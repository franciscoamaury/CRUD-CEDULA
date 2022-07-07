using Practica_de_cedula_con_CRUD.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_de_cedula_con_CRUD.Formularios
{
    public partial class RegistroForm : Form
    {
        public Persona Persona { get;private set; }
        public RegistroForm()
        {
            InitializeComponent();
        }

        public RegistroForm(Persona persona)
        {
            InitializeComponent();
            tbxNocedula.Text = persona.NO_Cedula;
            tbxNombre.Text = persona.Nombres;
            tbxApellidos.Text = persona.Apellidos;
            tbxEstadoCivil.Text = persona.Estado_civil;
            tbxFecha.Text = persona.Fecha_de_nacimiento;
            tbxOcupacion.Text = persona.Ocupacion;
            tbxLugar.Text = persona.Lugar_de_nacimiento;
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar(object sender, EventArgs e)
        {
            bool personavalidado = ValidarRegistro(out string errorMsg);
            if (personavalidado)
            {
                Persona = new Persona(tbxNocedula.Text,tbxNombre.Text, tbxApellidos.Text, tbxEstadoCivil.Text, tbxFecha.Text,tbxOcupacion.Text, tbxLugar.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }
        private bool ValidarRegistro(out string errorMsg)
        {
            errorMsg = string.Empty;
            if (string.IsNullOrEmpty(tbxNocedula.Text))
            {
                errorMsg += "El Numero de la cedula no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxNombre.Text))
            {
                errorMsg += "El nombre de la persona no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxApellidos.Text))
            {
                errorMsg += "El Apellido de la persona no puede estar vacio" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxEstadoCivil.Text))
            {
                errorMsg += "Debe de llenar este campo" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxFecha.Text))
            {
                errorMsg += "La fecha no es valida" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxOcupacion.Text))
            {
                errorMsg += "Debe de llenar este campo" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxLugar.Text))
            {
                errorMsg += "Debe de llenar este campo" + Environment.NewLine;
            }
            return errorMsg == String.Empty;
        }
    }
}
