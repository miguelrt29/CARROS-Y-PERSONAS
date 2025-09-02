using Datos.Entities;
using System.Collections.Generic;

namespace Datos
{
    public class BaseDatos
    {
        // Listas en memoria
        private readonly List<PersonasEnitity> listaPersonas;
        private readonly List<CarrosEntity> listaCarros;

        // Contadores para ID
        private int personaId = 1;
        private int carroId = 1;

        public BaseDatos()
        {
            listaPersonas = new List<PersonasEnitity>();
            listaCarros = new List<CarrosEntity>();
        }

        // ===================== PERSONAS =====================
        public string GuardarDatos(string nombre, string documento, string telefono)
        {
            var persona = new PersonasEnitity
            {
                ID = personaId++,
                Nombre = nombre,
                Documento = documento,
                Telefono = telefono
            };
            listaPersonas.Add(persona);
            return "Persona guardada";
        }

        public List<PersonasEnitity> VerPersonas()
        {
            return listaPersonas;
        }

        // ===================== CARROS =====================
        public string GuardarCarro(string placa, string marca, string modelo)
        {
            var carro = new CarrosEntity
            {
                ID = carroId++,
                Placa = placa,
                Marca = marca,
                Modelo = modelo
            };
            listaCarros.Add(carro);
            return "Carro guardado";
        }

        public List<CarrosEntity> VerCarros()
        {
            return listaCarros;
        }
    }
}
