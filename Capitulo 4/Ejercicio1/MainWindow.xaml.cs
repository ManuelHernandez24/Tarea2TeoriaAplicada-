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

namespace Ejercicio1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalcularButton_Click (object sender, RoutedEventArgs e){
            TextBoxTabla.Text = "";
            for (int i = 1; i<=10; i++){
                TextBoxTabla.Text =  TextBoxTabla.Text + $"{i}x{TextBoxNumero.Text}="+ (Convert.ToString(i * int.Parse(TextBoxNumero.Text)) + "\n");
            }
        }

    }
}
