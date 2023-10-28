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
    public partial class SignUp : Form
    {
        private ConexionSQL conexion = new ConexionSQL();
        private Login loginForm;

        public SignUp(Login loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm; // Asignar una referencia al LoginForm
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear la conexion con la base de datos
                MySqlConnection conexionBD = conexion.conectar();
                conexion.abrirConexion(conexionBD);

                // Tomar lo que el usuario escribio en los campos de texto
                string usuario = userTextBox.Text;
                string password = passwordTextBox.Text;

                // Crear la consulta SQL
                string query = "INSERT INTO usuarios (usuario, password) VALUES ('" + usuario + "', '" + password + "')";
                
                // Ejecutar la consulta con el metodo insertar
                conexion.insertar(conexionBD, query);

                // Mostar un message box de que el usuario se creo correctamente y ademas mostrando el usuario y la contraseña mediante un query
                string confirmationQuery = "SELECT * FROM usuarios WHERE usuario = '" + usuario + "' AND password = '" + password + "'";
                MySqlDataReader reader = conexion.consultar(conexionBD, confirmationQuery);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Usuario creado correctamente\nUsuario: " + reader.GetString(1) + "\nPassword: " + reader.GetString(2));
                    }
                }
                else
                {
                    MessageBox.Show("Error al crear el usuario");
                }
                // Cerrar la conexion con la base de datos
                conexion.cerrarConexion(conexionBD);
                conexionBD.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de conexion");
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();  // Mostrar el LoginForm cuando el SignUpForm se cierre
        }

    }

}
