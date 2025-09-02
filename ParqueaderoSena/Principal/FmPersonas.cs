using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FmPersonas : Form
    {
        PersonaController controller;

        public FmPersonas()
        {
            controller = new PersonaController();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbName.Text;
            string telefono = tbTel.Text;
            string documento = tbDoc.Text;

            string resultado = controller.GuardarDatos(nombre, documento, telefono);

            MessageBox.Show(resultado);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            var listaPersonas = controller.VerPersonas();

            string resultado = "";

            foreach(var persona in listaPersonas)
            {
                resultado += "Nombre: " + persona.Nombre + " Documento: " + persona.Documento + " Telefono: " + persona.Telefono + Environment.NewLine;
            }

            MessageBox.Show(resultado);
        }
    }
}
