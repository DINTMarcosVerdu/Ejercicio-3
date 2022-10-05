using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = ayudaNombre;
            apellidosTextBox.Tag = ayudaApellido;
        }

        private void nombre_KeyDown(object sender, KeyEventArgs e)//Este es el objeto que cojemos al hacer el if con el e.key
        {
            TextBox tb = (TextBox)sender;


            if (e.Key == Key.F1)
            {
                if (((TextBlock)tb.Tag).Visibility == Visibility.Hidden)
                    ((TextBlock)tb.Tag).Visibility = Visibility.Visible;//Porque no me deja ponerle el visibility si el .Tag del textbox es igual al objeto textblock??
                else
                    ((TextBlock)tb.Tag).Visibility = Visibility.Hidden;

            }



        }

        private void edad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 && !int.TryParse(edad.Text, out _))
                ayudaEdad.Visibility = Visibility.Visible;
            else
                ayudaEdad.Visibility = Visibility.Hidden;
        }       
    }
}
