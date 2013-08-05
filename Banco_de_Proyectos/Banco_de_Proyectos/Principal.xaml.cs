using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ADEstandar;
using System.Data;


namespace Banco_de_Proyectos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
		
    {
        AccesoDatos gAcceso = new AccesoDatos("BancoDeProyectos|localhost|root|unipoli|3307");
      

        public MainWindow()
        {
            
            InitializeComponent();
        }
        private void MainWindow_Load(Object sender, EventArgs e)
        {
            LlenarGrid();         

        }
        private void LlenarGrid()
        {
            gAcceso.SQL =
                "SELECT u.folio, u.nomb_proyecto, u.autor, u.posible_asesor, u.resumen " +
                "FROM usuarios u";
               
            DataTable dtUsuarios = gAcceso.Llena_Tabla();
            gvUsuarios.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = dtUsuarios });
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Ralumno alumno = new Ralumno();
            //alumno.Show;
          
        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            Rproyecto proyecto = new Rproyecto();
            //proyecto.Show;

        }

        private void btnclose_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Agregar implementación de controlador de eventos aquí.
			Application.Current.Shutdown();
			
        }

        private void btnmini_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Agregar implementación de controlador de eventos aquí.
			this.WindowState=WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Logg loging = new Logg();
            //loging.show
        }
            


        



    }
}
