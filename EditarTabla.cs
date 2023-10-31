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
    public partial class EditarTabla : Form
    {
        // Conexion
        private ConexionSQL conexion = new ConexionSQL();
        private MySqlConnection conexionBD;
        public EditarTabla()
        {
            InitializeComponent();
            welcomeLabel.Text = "Bienvenid@ usuario";

            //Abrir conexion
            conexionBD = conexion.conectar();
            conexion.abrirConexion(conexionBD);

            // Llenar el DataGridView con los datos de la tabla productos
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT nombreProducto,cantidad FROM productos", conexionBD))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    productosDataGridView.DataSource = table;
                    productosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void confirmarButton_Click_1(object sender, EventArgs e)
        {
            // Escribir los cambios de la tabla en la base de datos
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM productos", conexionBD))
                {
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                    adapter.Update((DataTable)productosDataGridView.DataSource);
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
