using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoGitFlow.CapaDeDatos;
using static ProyectoGitFlow.CapaDeEntidades;
using static ProyectoGitFlow.CapaDeNegocios;

namespace ProyectoGitFlow
{
    public partial class Form1: Form
    {
        private readonly CapaDeNegocios capaDeNegocios = new CapaDeNegocios();

        private void LimpiarTextBoxes(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control.HasChildren)
                {
                    LimpiarTextBoxes(control);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarVehiculo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAutobuses_ID.Text, out int id))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el Id.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAutobuses_año.Text, out int año))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el Año.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var autobus = new CapaDeEntidades.Autobus

            {
                Id = int.Parse(txtAutobuses_ID.Text),
                Marca = txtAutobuses_Marca.Text,
                Modelo = txtAutobuses_Modelo.Text,
                Placa = txtAutobuses_Placa.Text,
                Color = txtAutobuses_Color.Text,
                Año = int.Parse(txtAutobuses_año.Text)
            };
            LimpiarTextBoxes(this);

            capaDeNegocios.RegistrarAutobus(autobus);

        }
    }
}
