using Datos;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PersonaController
    {
        BaseDatos basedatos;

        public PersonaController()
        {
            basedatos = new BaseDatos();
        }

        public string GuardarDatos(string nombre,string documento, string telefono)
        {
            string resultado = "";

            resultado = basedatos.GuardarDatos(nombre, documento, telefono);

            return resultado;
        }

        public List<PersonasEnitity> VerPersonas()
        {
            List<PersonasEnitity> listaPersonas = basedatos.VerPersonas();

            return listaPersonas;
        }
    }
}
