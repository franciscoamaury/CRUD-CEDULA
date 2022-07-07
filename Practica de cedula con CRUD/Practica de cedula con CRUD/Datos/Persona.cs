using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_cedula_con_CRUD.Datos
{
    public class Persona
    {
        public string NO_Cedula { get; private set; }
        public string Nombres { get; private set; }
        public string Apellidos { get; private set; }
        public string Estado_civil { get; private set; }
        public string Fecha_de_nacimiento { get; private set; }
        public string Ocupacion { get; private set; }
        public string Lugar_de_nacimiento { get; private set; }

        public Persona(string nO_Cedula, string nombres, string apellidos, string estado_civil, string fecha_de_nacimiento, string ocupacion, string lugar_de_nacimiento)
        {
            this.NO_Cedula = nO_Cedula;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Estado_civil = estado_civil;
            this.Fecha_de_nacimiento = fecha_de_nacimiento;
            this.Ocupacion = ocupacion;
            this.Lugar_de_nacimiento = lugar_de_nacimiento;
        }
    }
}
