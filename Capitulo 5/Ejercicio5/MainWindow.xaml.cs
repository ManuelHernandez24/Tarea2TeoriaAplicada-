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
            Letras();
        }

        void Letras(){
            string letras = "";
            if (int.Parse(TextBoxNumero.Text) >= 1 &&  int.Parse(TextBoxNumero.Text) <= 10){
                int numero = int.Parse(TextBoxNumero.Text);
                
                switch(numero){
                    case 1:
                        letras = "Uno";
                        break;
                    case 2:
                        letras = "Dos";
                        break;
                    case 3:
                        letras = "Tres";
                        break;
                    case 4:
                        letras = "Cuatro";
                        break;
                    case 5:
                        letras = "Cinco";
                        break;
                    case 6:
                        letras = "Seis";
                        break;
                    case 7:
                        letras = "Siete";    
                        break;
                    case 8:
                        letras = "Ocho";     
                        break;             
                    case 9:
                        letras = "Nueve";  
                        break;
                    case 10:
                        letras = "Diez";
                        break;
                }
                TextBoxResultado.Text = (letras);
            } else{
                MessageBox.Show("No es un numero del 1 al 10.");
            }
            
        }
    }
}
