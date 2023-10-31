using MySqlConnector;
using PracticaU2_Componentes;
using System;
using System.Data;
using System.Windows.Forms;

namespace InventarioMaster
{
    public partial class InventarioMaster : Form
    {
        private ConexionSQL conexionProductos = new ConexionSQL();
        private MySqlConnection conexionBD;

        public InventarioMaster(string usuario)
        {
            InitializeComponent();
            welcomeLabel.Text = "Bienvenid@ " + usuario;
            tablaDeDatos.ReadOnly = true;
        }

        private void InventarioMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conexionBD != null)
            {
                conexionProductos.cerrarConexion(conexionBD);
                conexionBD.Dispose();
            }
            Application.Exit();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void verPerecederosButton_Click(object sender, EventArgs e)
        {
            try
            {
                conexionBD = conexionProductos.conectar();
                conexionProductos.abrirConexion(conexionBD);

                string query = "SELECT p.nombreProducto,p.precio,p.cantidad,prov.primerNombre " +
                    "FROM productos AS p INNER JOIN proveedores AS prov ON p.idProveedor=prov.idProveedor WHERE p.idAlmacen=1";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    tablaDeDatos.DataSource = table;
                    tablaDeDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Cerrar la conexion
            conexionProductos.cerrarConexion(conexionBD);
            conexionBD.Dispose();
        }

        private void verElectronicosButton_Click(object sender, EventArgs e)
        {
            try
            {
                conexionBD = conexionProductos.conectar();
                conexionProductos.abrirConexion(conexionBD);

                string query = "SELECT p.nombreProducto,p.precio,p.cantidad,prov.primerNombre " +
                    "FROM productos AS p INNER JOIN proveedores AS prov ON p.idProveedor=prov.idProveedor WHERE p.idAlmacen=2";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    tablaDeDatos.DataSource = table;
                    tablaDeDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            // Cerrar la conexion
            conexionProductos.cerrarConexion(conexionBD);
            conexionBD.Dispose();
        }

        private void editarCantidad_Click(object sender, EventArgs e)
        {
            // Cerrar la conexion de la base de datos
            conexionProductos.cerrarConexion(conexionBD);
            conexionBD.Dispose();

            // Abrir el EditarTabla form
            this.Hide();
            EditarTabla editar = new EditarTabla();
            editar.Show();
        }
    }
}
