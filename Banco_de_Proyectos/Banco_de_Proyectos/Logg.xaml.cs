using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ADEstandar;

namespace Banco_de_Proyectos
{
	/// <summary>
	/// Lógica de interacción para Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
        AccesoDatos gAcceso = new AccesoDatos("BancoDeProyectos|localhost|root|unipoli|3307");
		public Window1()
		{
            
			this.InitializeComponent();
			
			// A partir de este punto se requiere la inserción de código para la creación del objeto.
		}


        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals("Usuario"))
            {
                txtuser.Text = string.Empty;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals(string.Empty))
            {
                txtuser.Text = "Usuario";
            }

        }
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text.Equals("Contraseña"))
            {
                txtpass.Text = string.Empty;
                //txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text.Equals(string.Empty))
            {
                txtpass.Text = "Contraseña";
                //txtpass.UseSystemPasswordChar = false;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!gAcceso.Crear_Conexion())
            {
                MessageBox.Show("Ha Ocurrido Un Error Al Iniciar El Programa. \n Intente De Nuevo Más ");

            }
            else {

                MainWindow.Show();


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!ChecarUsuario())
            {
                MessageBox.Show("El Usuario no existe.\n Verifique He Intente De Nuevo");
                return;          
            }

            if (ChecarPass(txtuser.Text, txtpass.Text))
            {
                string rol = string.Empty;
                rol = ObtenerRol(txtuser.Text);
                
                MainWindow frmPrincipal = new MainWindow();
                frmPrincipal.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("La Contreseña No Es Correcta.\n Verifique De Nuevo");
                return;           
            }
        }
        string ObtenerRol(string ipUsuario)
        {
            gAcceso.SQL = String.Format(
                "SELECT rol " +
                "FROM usuarios " +
                "Where matricula = '{0}'",
                ipUsuario
                );
            gAcceso.Buscar_Primero();
            return gAcceso.Renglon["ROL"].ToString();       
        }

        private bool ChecarUsuario()
        {

                gAcceso.SQL = string.Format(
                "SELECT matricula " +
                "FROM tabla_alumno  " +
                "WHERE matricula '{0}' ",
                txtuser.Text
                );

                gAcceso.Buscar_Primero();
                if (gAcceso.Renglon == null)
                {
                    return false;
                }
                else
                {
                    return true;                
                }       
        }
        private bool ChecarPass(string ipUsuario, string ipPassword)
        {
            gAcceso.SQL = string.Format(
           "SELECT matricula " +
           "FROM usuarios " +
           "AND pass = MD5('{1}')",
           ipUsuario,
           ipPassword
           );

            gAcceso.Buscar_Primero();
            if (gAcceso.Renglon == null)
                return false;
            else
                return true;          
        }


	}
}