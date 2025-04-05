using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoGitFlow.CapaDeEntidades;

namespace ProyectoGitFlow
{
    internal class CapaDeDatos
    {
        private readonly string cadenaConexion = "Server=DESKTOP-SNPAUOO;Database=Autobuses;User Id=sa;Password=12345;TrustServerCertificate=True";

        public void RegistrarAutobus(CapaDeEntidades.Autobus autobus)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Autobuses (Id, Marca, Modelo, Placa, Color, año) VALUES (@Id, @Marca, @Modelo, @Placa, @Color, @año)";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", autobus.Id);
                    comando.Parameters.AddWithValue("@Marca", autobus.Marca);
                    comando.Parameters.AddWithValue("@Modelo", autobus.Modelo);
                    comando.Parameters.AddWithValue("@Placa", autobus.Placa);
                    comando.Parameters.AddWithValue("@Color", autobus.Color);
                    comando.Parameters.AddWithValue("@año", autobus.Año);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar el autobús: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

    }
}
