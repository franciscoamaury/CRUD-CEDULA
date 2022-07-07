using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_cedula_con_CRUD.Datos
{
    public class PersonaRepositorio
    {
        private const string RUTA_FICHERO_PERSONAS = @"c:\temp\Personas.json";
        public static List<Persona> Personas { get; private set; }

        public static void InicializarRepositorio()
        {
            Personas = new List<Persona>();
        }

        public static void AñadirPersona(Persona persona)
        {
            Personas.Add(persona);
            string json = JsonConvert.SerializeObject(Personas, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_PERSONAS,json);
        }
        public static void EliminarPersona(string nO_Cedula)
        {
            Personas.RemoveAll(e => e.NO_Cedula.Equals(nO_Cedula));
            string json = JsonConvert.SerializeObject(Personas, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_PERSONAS, json);
        }

        public static void ActualizarPersona(string nocedulaPersonaOrigen, Persona personaModificado)
        {
            int indicePersonaOriginal = Personas.FindIndex(e => e.NO_Cedula == nocedulaPersonaOrigen);
            if(indicePersonaOriginal != -1)
            {
                Personas[indicePersonaOriginal] = personaModificado;
            }
            string json = JsonConvert.SerializeObject(Personas, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_PERSONAS, json);
        }
    }
}
