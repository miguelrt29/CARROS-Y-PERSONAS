using Logica;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Principal
{
    public partial class FmCarros : Form
    {
        private readonly CarrosController carrosController;

        public FmCarros()
        {
            InitializeComponent();
            carrosController = new CarrosController();
        }

        // ====== BOTÓN GUARDAR ======
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;

            if (string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(modelo) ||
                string.IsNullOrWhiteSpace(placa))
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }

            string resultado = carrosController.GuardarCarro(placa, marca, modelo);
            MessageBox.Show(resultado);

            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
        }

        // ====== BOTÓN VER ======
        private void btnVer_Click(object sender, EventArgs e)
        {
            List<CarrosEntity> listaCarros = carrosController.VerCarros();

            if (listaCarros.Count == 0)
            {
                MessageBox.Show("No hay carros registrados todavía.");
                return;
            }

            string mensaje = "=== Lista de Carros ===\n";
            foreach (var c in listaCarros)
            {
                mensaje += $"Placa: {c.Placa}, Marca: {c.Marca}, Modelo: {c.Modelo}\n";
            }

            MessageBox.Show(mensaje, "Carros Registrados");
        }

        // ====== BOTÓN VOLVER ======
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FmPersonas menu = new FmPersonas(); // tu menú de personas
            menu.Show();
            this.Close();
        }
    }
}
