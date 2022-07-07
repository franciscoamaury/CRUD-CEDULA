using Practica_de_cedula_con_CRUD.Datos;
using Practica_de_cedula_con_CRUD.Formularios;

namespace Practica_de_cedula_con_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PersonaRepositorio.InicializarRepositorio();
            VisualizarPersonas();
        }

        private void VisualizarPersonas()
        {
            dataGridView1.Rows.Clear();
            foreach (Persona persona in PersonaRepositorio.Personas)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = persona.NO_Cedula.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = persona.Nombres.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = persona.Apellidos.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = persona.Estado_civil.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = persona.Fecha_de_nacimiento.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = persona.Ocupacion.ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = persona.Lugar_de_nacimiento.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            DialogResult dialogResult = registroForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                PersonaRepositorio.AñadirPersona(registroForm.Persona);
                VisualizarPersonas();
            }
        }

        private void pcbEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nocedulaEliminar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                PersonaRepositorio.EliminarPersona(nocedulaEliminar);
                VisualizarPersonas();
            }
            else
            {
                MessageBox.Show("No has seleccionado ninguna persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nocedulaModificar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombrePersonaModificar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string apellidoPersonaModificar = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string estadocivilPersonaModificar = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string fechadenacimientoPersonaModificar = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string ocupacionPersonaModificar = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string lugardenacimientoPersonaModificar = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                Persona personaModificar = new Persona(nocedulaModificar, nombrePersonaModificar, apellidoPersonaModificar, estadocivilPersonaModificar, fechadenacimientoPersonaModificar, ocupacionPersonaModificar, lugardenacimientoPersonaModificar);
                RegistroForm registroForm = new RegistroForm(personaModificar);
               DialogResult dialogResult = registroForm.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    PersonaRepositorio.ActualizarPersona(nocedulaModificar, registroForm.Persona);
                    VisualizarPersonas();
                }
            }
            else
            {
                MessageBox.Show("NOn has seleccionado ningun empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}