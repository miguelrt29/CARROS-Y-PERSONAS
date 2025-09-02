using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BaseDatos
    {
        List<PersonasEnitity> listaPersonas;

        public BaseDatos()
        {
            listaPersonas = new List<PersonasEnitity>();
        }

        public string GuardarDatos(string nombre, string documento, string telefono)
        {
            string resultado = "";

            PersonasEnitity personaActual = new PersonasEnitity();

            personaActual.Nombre = nombre;
            personaActual.Telefono = telefono;
            personaActual.Documento = documento;


            listaPersonas.Add(personaActual);

            resultado = "Guardado";

            return resultado;
        }

        public List<PersonasEnitity> VerPersonas()
        {
            return listaPersonas;
        }
    }
}
