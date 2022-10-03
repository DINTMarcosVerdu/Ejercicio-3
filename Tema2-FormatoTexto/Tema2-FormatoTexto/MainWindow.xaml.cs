using System.Windows;
using System.Windows.Media;

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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azul.IsChecked = true;
        }

        private void Negrita_Checked(object sender, RoutedEventArgs e)
        {
            salida.FontWeight = FontWeights.Bold;
        }

        private void Cursiva_Checked(object sender, RoutedEventArgs e)
        {
            
            salida.FontStyle = FontStyles.Italic;
        }

        private void Negrita_Unchecked(object sender, RoutedEventArgs e)
        {
            salida.FontWeight = FontWeights.Normal;
        }

        private void Cursiva_Unchecked(object sender, RoutedEventArgs e)
        {
            salida.FontStyle = FontStyles.Normal;
        }

        private void azul_Checked(object sender, RoutedEventArgs e)
        {
            salida.Foreground = Brushes.Blue;
        }

        private void rojo_Checked(object sender, RoutedEventArgs e)
        {
            salida.Foreground = Brushes.Red;
        }

        private void verde_Checked(object sender, RoutedEventArgs e)
        {
            salida.Foreground = Brushes.Green;
        }

        private void entrada_TextChanged(object sender, TextChangedEventArgs e)
        {
            salida.Text = entrada.Text;
        }
    }
}
