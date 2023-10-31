using MySqlConnector;
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
    public partial class Edicion : Form
    {
        // Variables de conexion
        private ConexionSQL conexionProductos = new ConexionSQL();
        private MySqlConnection conexionBD;

        public Edicion()
        {
            InitializeComponent();
            tituloLabel.Text = "Edicion de productos";

            // Inicializar el combobox de proveedores
            try
            {
                conexionBD = conexionProductos.conectar();
                conexionProductos.abrirConexion(conexionBD);

                string query = "SELECT nombreProducto,cantidad FROM productos";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    productodDataGridView.DataSource = table;
                    productodDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            // Escribir los cambios de la tabla en la base de datos
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT nombreProducto,cantidad FROM productos", conexionBD))
                {
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                    adapter.Update((DataTable)productodDataGridView.DataSource);
                    MessageBox.Show("Cambios guardados");

                    // Abrir el InventarioMaster form
                    this.Hide();
                    InventarioMaster inventarioMaster = new InventarioMaster("usuario");
                    inventarioMaster.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
