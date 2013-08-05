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
	/// Lógica de interacción para Ralumno.xaml
	/// </summary>
	public partial class Ralumno : Window
	{
        AccesoDatos gAcceso = new AccesoDatos("BancoDeProyectos|localhost|root|unipoli|3307");

		public Ralumno()
		{
			this.InitializeComponent();
			
			// A partir de este punto se requiere la inserción de código para la creación del objeto.
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void LimpiarRegistro()
        {
            txtmatricula.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtggrupo.Text = string.Empty;
            cmbfolio.SelectedIndex = 0;
            txttelefono.Text = string.Empty;
            txtcorreo.Text = string.Empty;
            txtdireccion.Text = string.Empty;     
        }
        void GuardarUsuario()
        { 
           /* gAcceso.SQL = string.Format(
                 "INSERT INTO usuarios " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}' ) ",
                
                
                
                
                ); */
        
        
        }

        private void txtmatricula_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
	}
}