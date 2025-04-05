using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoGitFlow.CapaDeDatos;
using static ProyectoGitFlow.CapaDeEntidades;
using static ProyectoGitFlow.Form1;



namespace ProyectoGitFlow
{
    internal class CapaDeNegocios
    {
        private readonly CapaDeDatos capaDeDatos = new CapaDeDatos();

        public void RegistrarAutobus(CapaDeEntidades.Autobus autobus)
        {
            if (string.IsNullOrWhiteSpace(autobus.Marca) || string.IsNullOrWhiteSpace(autobus.Placa))
            {
                MessageBox.Show("La marca y la placa son obligatorias.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            capaDeDatos.RegistrarAutobus(autobus);
        }



















    }
}
