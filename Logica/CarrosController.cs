using Datos;
using Datos.Entities;
using System.Collections.Generic;

namespace Logica
{
    public class CarrosController
    {
        private readonly BaseDatos basedatos;

        public CarrosController()
        {
            basedatos = new BaseDatos();
        }

        // Guardar un carro
        public string GuardarCarro(string placa, string marca, string modelo)
        {
            return basedatos.GuardarCarro(placa, marca, modelo);
        }

        // Ver lista de carros
        public List<CarrosEntity> VerCarros()
        {
            return basedatos.VerCarros();
        }
    }
}
