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
            MessageBox.Show("Se guardo el Vehiculo exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarTextBoxes(this);

            capaDeNegocios.RegistrarAutobus(autobus);

        }


        private void BuscarVehiculo_Click_1(object sender, EventArgs e)
        {
            string idText = txtAutobuses_ID.Text.Trim();
            // Verificar si el campo txtAutobuses_ID está vacío
            if (string.IsNullOrWhiteSpace(txtAutobuses_ID.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si el ID está vacío
            }
            // Intentar convertir el texto del ID a un número entero
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero válido.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si la conversión falla
            }

            DataTable autobus = capaDeNegocios.BuscarAutobus(id);

            if (autobus.Rows.Count > 0)
            {
                txtAutobuses_Marca.Text = autobus.Rows[0]["Marca"].ToString();
                txtAutobuses_Modelo.Text = autobus.Rows[0]["Modelo"].ToString();
                txtAutobuses_Placa.Text = autobus.Rows[0]["Placa"].ToString();
                txtAutobuses_Color.Text = autobus.Rows[0]["Color"].ToString();
                txtAutobuses_año.Text = autobus.Rows[0]["año"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el autobús.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditarVehiculo_Click(object sender, EventArgs e)
        {
            var autobus = new CapaDeEntidades.Autobus
            {
                Id = int.Parse(txtAutobuses_ID.Text),
                Marca = txtAutobuses_Marca.Text,
                Modelo = txtAutobuses_Modelo.Text,
                Placa = txtAutobuses_Placa.Text,
                Color = txtAutobuses_Color.Text,
                Año = int.Parse(txtAutobuses_año.Text)
            };
            MessageBox.Show("Se Edito el Vehiculo exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarTextBoxes(this);

            capaDeNegocios.EditarAutobus(autobus);

        }
    }
}
