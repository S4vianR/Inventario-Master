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
        private MySqlTransaction transaccion;

        public Edicion()
        {
            InitializeComponent();
            tituloLabel.Text = "Edicion de productos";
            agregarGroupBox.Enabled = false;
            actualizarGroupBox.Enabled = false;
            eliminarGroupBox.Enabled = false;

            productodDataGridView.ReadOnly = true;

            // Cargar la tabla de datos
            try
            {
                conexionBD = conexionProductos.conectar();
                conexionProductos.abrirConexion(conexionBD);

                string query = "SELECT p.idProducto,p.nombreProducto,p.precio,p.cantidad,c.nombreCategoria,prov.primerNombre,a.nombreAlmacen " +
                    "FROM productos AS p INNER JOIN categorias AS c ON p.idCategoria=c.idCategoria " +
                    "INNER JOIN proveedores AS prov ON p.idProveedor=prov.idProveedor " +
                    "INNER JOIN almacen AS a ON p.idAlmacen=a.idAlmacen ORDER BY p.idProducto ASC";

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

            // Cerrar la conexion
            conexionProductos.cerrarConexion(conexionBD);
        }

        private void Edicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Esconder el form actual y abrir el form principal
            this.Hide();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            // Esconder los otros group boxes
            actualizarGroupBox.Enabled = false;
            eliminarGroupBox.Enabled = false;

            // Limpiar los campos de texto
            // Eliminar
            eliminarTextBox.Text = "";

            // Actualizar
            actualizarNombreTextBox.Text = "";
            actualizarDescripcionTextBox.Text = "";
            actualizarCategoriaComboBox.DataSource = null;
            actualizarProveedorComboBox.DataSource = null;
            actualizarAlmacenComboBox.DataSource = null;
            actualizarPrecioNumericUpDown.Value = 0;
            actualizarCantidadNumericUpDown.Value = 0;

            // Mostrar el group box de agregar
            agregarGroupBox.Enabled = true;

            // Cargar los datos a los comboBox de agregar
            cargarDatosAgregar();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            // Esconder los otros group boxes
            agregarGroupBox.Enabled = false;
            actualizarGroupBox.Enabled = false;

            // Limpiar los campos de texto
            // Agregar
            agregarNombreTextBox.Text = "";
            agregarDescripcionTextBox.Text = "";
            agregarCategoriaComboBox.DataSource = null;
            agregarProveedorComboBox.DataSource = null;
            agregarAlmacenComboBox.DataSource = null;
            agregarPrecioNumericUpDown.Value = 0;
            agregarCantidadNumericUpDown.Value = 0;

            // Actualizar
            actualizarNombreTextBox.Text = "";
            actualizarDescripcionTextBox.Text = "";
            actualizarCategoriaComboBox.DataSource = null;
            actualizarProveedorComboBox.DataSource = null;
            actualizarAlmacenComboBox.DataSource = null;
            actualizarPrecioNumericUpDown.Value = 0;
            actualizarCantidadNumericUpDown.Value = 0;

            // Mostrar el group box de eliminar
            eliminarGroupBox.Enabled = true;
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            // Esconder los otros group boxes
            agregarGroupBox.Enabled = false;
            eliminarGroupBox.Enabled = false;

            // Limpiar los campos de texto
            // Agregar
            agregarNombreTextBox.Text = "";
            agregarDescripcionTextBox.Text = "";
            agregarCategoriaComboBox.DataSource = null;
            agregarProveedorComboBox.DataSource = null;
            agregarAlmacenComboBox.DataSource = null;
            agregarPrecioNumericUpDown.Value = 0;
            agregarCantidadNumericUpDown.Value = 0;

            // Eliminar
            eliminarTextBox.Text = "";

            // Mostrar el group box de actualizar
            actualizarGroupBox.Enabled = true;

            // Cargar los datos a los comboBox de actualizar
            cargarDatosActualizar();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Esconder los group boxes
            agregarGroupBox.Enabled = false;
            eliminarGroupBox.Enabled = false;
            actualizarGroupBox.Enabled = false;

            // Limpiar los campos de texto
            // Agregar
            agregarNombreTextBox.Text = "";
            agregarDescripcionTextBox.Text = "";
            agregarCategoriaComboBox.DataSource = null;
            agregarProveedorComboBox.DataSource = null;
            agregarAlmacenComboBox.DataSource = null;
            agregarPrecioNumericUpDown.Value = 0;
            agregarCantidadNumericUpDown.Value = 0;

            // Eliminar
            eliminarTextBox.Text = "";

            // Actualizar
            actualizarNombreTextBox.Text = "";
            actualizarDescripcionTextBox.Text = "";
            actualizarCategoriaComboBox.DataSource = null;
            actualizarProveedorComboBox.DataSource = null;
            actualizarAlmacenComboBox.DataSource = null;
            actualizarPrecioNumericUpDown.Value = 0;
            actualizarCantidadNumericUpDown.Value = 0;
        }

        private void agregarConfirmarButton_Click(object sender, EventArgs e)
        {
            // Variables
            string nombreProducto = agregarNombreTextBox.Text;
            string descripcion = agregarDescripcionTextBox.Text;
            int idCategoria = (int)agregarCategoriaComboBox.SelectedValue;
            int idProveedor = (int)agregarProveedorComboBox.SelectedValue;
            int idAlmacen = (int)agregarAlmacenComboBox.SelectedValue;
            double precio = (double)agregarPrecioNumericUpDown.Value;
            int cantidad = (int)agregarCantidadNumericUpDown.Value;
            string query;

            // Agregar el producto a la base de datos con una transaccion
            // Conectar a la base de datos
            using (conexionProductos.conectar())
            {
                // Abrir la conexion
                conexionProductos.abrirConexion(conexionBD);

                // Crear la consulta SQL
                query = "INSERT INTO productos(nombreProducto,descripcion,idCategoria,idProveedor,idAlmacen,precio,cantidad) " +
                    "VALUES('" + nombreProducto + "','" + descripcion + "'," + idCategoria + "," + idProveedor + "," + idAlmacen + "," + precio + "," + cantidad + ")";

                // Inicializar la transaccion
                transaccion = conexionBD.BeginTransaction();

                // Ejecutar la consulta
                using (MySqlCommand comando = new MySqlCommand(query, conexionBD, transaccion))
                {
                    try
                    {
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Producto agregado exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        transaccion.Rollback();
                    }
                }

                // Actualizar la tabla
                query = "SELECT p.idProducto,p.nombreProducto,p.precio,p.cantidad,c.nombreCategoria,prov.primerNombre,a.nombreAlmacen " +
                    "FROM productos AS p INNER JOIN categorias AS c ON p.idCategoria=c.idCategoria " +
                    "INNER JOIN proveedores AS prov ON p.idProveedor=prov.idProveedor " +
                    "INNER JOIN almacen AS a ON p.idAlmacen=a.idAlmacen ORDER BY p.idProducto ASC";

                // Ejecutar la consulta
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    productodDataGridView.DataSource = table;
                    productodDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // Cerrar la conexion
                conexionProductos.cerrarConexion(conexionBD);
            }
        }

        private void actualizarConfirmarButton_Click(object sender, EventArgs e)
        {
            // Variables
            string nombreProducto = actualizarNombreTextBox.Text;
            string descripcion = actualizarDescripcionTextBox.Text;
            int idCategoria = (int)actualizarCategoriaComboBox.SelectedValue;
            int idProveedor = (int)actualizarProveedorComboBox.SelectedValue;
            int idAlmacen = (int)actualizarAlmacenComboBox.SelectedValue;
            double precio = (double)actualizarPrecioNumericUpDown.Value;
            int cantidad = (int)actualizarCantidadNumericUpDown.Value;
            string query;

            // Actualizar el producto en la base de datos con una transaccion
            // Conectar a la base de datos
            using (conexionProductos.conectar())
            {
                // Abrir la conexion
                conexionProductos.abrirConexion(conexionBD);

                // Crear la consulta SQL para actualizar
                query = "UPDATE productos SET nombreProducto='" + nombreProducto + "',descripcion='" + descripcion 
                    + "',idCategoria=" + idCategoria + ",idProveedor=" + idProveedor + ",idAlmacen=" + idAlmacen 
                    + ",precio=" + precio + ",cantidad=" + cantidad + " WHERE idProducto=" + actualizarIdTextBox.Text + ";";

                // Inicializar la transaccion
                transaccion = conexionBD.BeginTransaction();

                // Ejecutar la consulta
                using (MySqlCommand comando = new MySqlCommand(query, conexionBD, transaccion))
                {
                    try
                    {
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Producto actualizado exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        transaccion.Rollback();
                    }
                }

                // Actualizar la tabla
                query = "SELECT p.idProducto,p.nombreProducto,p.precio,p.cantidad,c.nombreCategoria,prov.primerNombre,a.nombreAlmacen " +
                    "FROM productos AS p INNER JOIN categorias AS c ON p.idCategoria=c.idCategoria " +
                    "INNER JOIN proveedores AS prov ON p.idProveedor=prov.idProveedor " +
                    "INNER JOIN almacen AS a ON p.idAlmacen=a.idAlmacen ORDER BY p.idProducto ASC";

                // Ejecutar la consulta
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    productodDataGridView.DataSource = table;
                    productodDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // Cerrar la conexion
                conexionProductos.cerrarConexion(conexionBD);
            }
        }

        private void eliminarConfirmarButton_Click(object sender, EventArgs e)
        {
            // Variables
            int idProducto = int.Parse(eliminarTextBox.Text);
            string query;

            // Eliminar el producto de la base de datos con una transaccion
            // Conectar a la base de datos
            using (conexionProductos.conectar())
            {
                // Abrir la conexion
                conexionProductos.abrirConexion(conexionBD);

                // Crear la consulta SQL
                query = "DELETE FROM productos WHERE idProducto=" + idProducto + ";";

                // Inicializar la transaccion
                transaccion = conexionBD.BeginTransaction();

                using (MySqlCommand comando = new MySqlCommand(query, conexionBD, transaccion))
                {
                    try
                    {
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Producto eliminado exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        transaccion.Rollback();
                    }
                }

                // Actualizar la tabla
                query = "SELECT p.idProducto,p.nombreProducto,p.precio,p.cantidad,c.nombreCategoria,prov.primerNombre,a.nombreAlmacen " +
                    "FROM productos AS p INNER JOIN categorias AS c ON p.idCategoria=c.idCategoria " +
                    "INNER JOIN proveedores AS prov ON p.idProveedor=prov.idProveedor " +
                    "INNER JOIN almacen AS a ON p.idAlmacen=a.idAlmacen ORDER BY p.idProducto ASC";

                // Ejecutar la consulta
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    productodDataGridView.DataSource = table;
                    productodDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // Cerrar la conexion
                conexionProductos.cerrarConexion(conexionBD);
            }
        }

        private void cargarDatosAgregar()
        {
            // Variables
            string query;
            // Cargar los datos a los comboBox del group box de agregar
            try
            {
                // Conectar a la base de datos
                using (conexionProductos.conectar())
                {
                    // Abrir la conexion
                    conexionProductos.abrirConexion(conexionBD);
                    // Cargar los datos de los proveedores
                    query = "SELECT * FROM proveedores";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        agregarProveedorComboBox.DataSource = table;
                        agregarProveedorComboBox.DisplayMember = "primerNombre";
                        agregarProveedorComboBox.ValueMember = "idProveedor";
                    }

                    // Cargar los datos de los almacenes
                    query = "SELECT * FROM almacen";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        agregarAlmacenComboBox.DataSource = table;
                        agregarAlmacenComboBox.DisplayMember = "nombreAlmacen";
                        agregarAlmacenComboBox.ValueMember = "idAlmacen";
                    }

                    // Cargar los datos de las categorias
                    query = "SELECT * FROM categorias";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        agregarCategoriaComboBox.DataSource = table;
                        agregarCategoriaComboBox.DisplayMember = "nombreCategoria";
                        agregarCategoriaComboBox.ValueMember = "idCategoria";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Cerrar la conexion
            conexionProductos.cerrarConexion(conexionBD);
        }

        private void cargarDatosActualizar()
        {
            // Variables
            string query;
            // Cargar los datos a los comboBox del group box de agregar
            try
            {
                // Conectar a la base de datos
                using (conexionProductos.conectar())
                {
                    // Abrir la conexion
                    conexionProductos.abrirConexion(conexionBD);
                    // Cargar los datos de los proveedores
                    query = "SELECT * FROM proveedores";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        actualizarProveedorComboBox.DataSource = table;
                        actualizarProveedorComboBox.DisplayMember = "primerNombre";
                        actualizarProveedorComboBox.ValueMember = "idProveedor";
                    }

                    // Cargar los datos de los almacenes
                    query = "SELECT * FROM almacen";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        actualizarAlmacenComboBox.DataSource = table;
                        actualizarAlmacenComboBox.DisplayMember = "nombreAlmacen";
                        actualizarAlmacenComboBox.ValueMember = "idAlmacen";
                    }

                    // Cargar los datos de las categorias
                    query = "SELECT * FROM categorias";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        actualizarCategoriaComboBox.DataSource = table;
                        actualizarCategoriaComboBox.DisplayMember = "nombreCategoria";
                        actualizarCategoriaComboBox.ValueMember = "idCategoria";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Cerrar la conexion
            conexionProductos.cerrarConexion(conexionBD);
        }


    }
}
