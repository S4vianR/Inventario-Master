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
    public partial class Login : Form
    {
        // Variables
        private SignUp signUpForm;
        private ConexionSQL conexion = new ConexionSQL();
        private Usuario user;

        public Login()
        {
            InitializeComponent();
            signUpForm = new SignUp(this); // Crear una instancia del SignUpForm
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signUpForm.Show();  // Mostrar el SignUpForm
            this.Hide();        // Ocultar el LoginForm
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Tomar lo que el usuario escribio en los campos de texto
                string usuario = userTextBox.Text;
                string password = passwordTextBox.Text;

                // Crear la consulta SQL
                string query = "SELECT * FROM usuarios WHERE usuario = '" + usuario + "' AND password = '" + password + "'";

                // Ejecutar la consulta con el metodo consultar
                using (MySqlConnection conexionBD = conexion.conectar())
                {
                    using (MySqlDataReader reader = conexion.consultar(conexionBD, query))
                    {
                        
                        // If the user exists, open the main form
                        if (reader.HasRows)
                        {

                            this.Hide();

                            // Obtener el tipo de acceso del usuario y el nombre
                            while (reader.Read())
                            {
                                string tipoAcceso = reader.GetString(3);
                                string nombre = reader.GetString(1);
                                user = new Usuario(nombre, tipoAcceso);
                            }
                            InventarioMaster inventarioMaster = new InventarioMaster(user);
                            inventarioMaster.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesion: " + ex.Message, "Error de inicio de sesion");
            }
        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Al cerrar el formulario, cerrar la aplicacion
            Application.Exit();
        }
    }

}
