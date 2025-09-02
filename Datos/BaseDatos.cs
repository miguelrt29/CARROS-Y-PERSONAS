using Datos.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class BaseDatos
    {
        // Cadena de conexión sin usuario ni contraseña
        private readonly string connectionString = "server=localhost;database=MiBase;user=root;";

        // ===================== PERSONAS =====================
        public string GuardarDatos(string nombre, string documento, string telefono)
        {
            string query = "INSERT INTO Personas (Nombre, Documento, Telefono) VALUES (@nombre, @documento, @telefono)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.ExecuteNonQuery();
                }
            }

            return "Persona guardada en MySQL";
        }

        public List<PersonasEnitity> VerPersonas()
        {
            var listaPersonas = new List<PersonasEnitity>();
            string query = "SELECT * FROM Personas";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPersonas.Add(new PersonasEnitity
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Nombre = reader["Nombre"].ToString(),
                            Documento = reader["Documento"].ToString(),
                            Telefono = reader["Telefono"].ToString()
                        });
                    }
                }
            }

            return listaPersonas;
        }

        // ===================== CARROS =====================
        public string GuardarCarro(string placa, string marca, string modelo)
        {
            string query = "INSERT INTO Carros (Placa, Marca, Modelo) VALUES (@placa, @marca, @modelo)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.ExecuteNonQuery();
                }
            }

            return "Carro guardado en MySQL";
        }

        public List<CarrosEntity> VerCarros()
        {
            var listaCarros = new List<CarrosEntity>();
            string query = "SELECT * FROM Carros";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaCarros.Add(new CarrosEntity
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Placa = reader["Placa"].ToString(),
                            Marca = reader["Marca"].ToString(),
                            Modelo = reader["Modelo"].ToString()
                        });
                    }
                }
            }

            return listaCarros;
        }
    }
}
