using MySqlConnector;
using PracticaU2_Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioMaster
{
    public partial class InventarioMaster : Form
    {
        // Conexion
        private ConexionSQL conexionProductos = new ConexionSQL();
        private ConexionSQL conexionEmpleados = new ConexionSQL();
        private MySqlConnection productosBD;
        private MySqlConnection empleadosBD;


        public InventarioMaster(string usuario)
        {
            InitializeComponent();
            // Mostrar el usuario en el label
            welcomeLabel.Text = "Bienvenido " + usuario;
        }

        private void InventarioMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (productosBD != null)
            {
                // Cerrar la conexion
                conexionProductos.cerrarConexion(productosBD);
                productosBD.Dispose();
            }

            if (empleadosBD != null)
            {
                // Cerrar la conexion
                conexionEmpleados.cerrarConexion(empleadosBD);
                empleadosBD.Dispose();
            }

            // Al cerrar el formulario, cerrar la aplicacion
            Application.Exit();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual y abrir el de login
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void verProductosButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Always use a new connection for this operation
                using (MySqlConnection productosBD = conexionProductos.conectar())
                {
                    // Create and open the connection
                    conexionProductos.abrirConexion(productosBD);

                    // Create the query
                    string query = "SELECT * FROM productos";

                    // Execute the query
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, productosBD))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        tablaDeDatos.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void verEmpleadosButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Always use a new connection for this operation
                using (MySqlConnection empleadosBD = conexionEmpleados.conectar())
                {
                    // Create and open the connection
                    conexionEmpleados.abrirConexion(empleadosBD);

                    // Create the query
                    string query = "SELECT * FROM empleados";

                    // Execute the query
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, empleadosBD))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        tablaDeDatos.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
