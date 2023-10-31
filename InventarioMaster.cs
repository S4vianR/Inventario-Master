using MySqlConnector;
using PracticaU2_Componentes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace InventarioMaster
{
    public partial class InventarioMaster : Form
    {
        private ConexionSQL conexionProductos = new ConexionSQL();
        private MySqlConnection conexionBD;
        private Usuario usuario;

        public InventarioMaster(Usuario user)
        {
            InitializeComponent();
            this.usuario = user;

            welcomeLabel.Text = "Bienvenid@ " + usuario.getUsuario();
            tablaDeDatos.ReadOnly = true;

            // Esconder o mostrar botones dependiendo del tipo de acceso
            if (usuario.getTipoAcceso().Equals("Admin"))
            {
                editarCantidad.Enabled = true;
            }
            else
            {
                editarCantidad.Enabled = false;
            }
        }

        private void InventarioMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conexionBD != null)
            {
                conexionProductos.cerrarConexion(conexionBD);
                conexionBD.Dispose();
            }
            // Cerrar el programa
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
        }

        private void editarCantidad_Click(object sender, EventArgs e)
        {
            // Abrir el EditarTabla form
            Edicion edicionForm = new Edicion();
            edicionForm.Show();
            edicionForm.Focus();
        }
    }
}
