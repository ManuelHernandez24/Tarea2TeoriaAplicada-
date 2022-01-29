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

        public int cantidad = 0;
        public int menor = 0;
        public int mayor = 0;
        public double promedio = 0;

        public List<int> edades = new List<int>();

        private void CalcularButton_Click (object sender, RoutedEventArgs e){
            int edadActual = int.Parse(TextBoxNumero.Text);
            edades.Add(edadActual);
            Calculos();
            Imprimir();

        }
        void Calculos(){
            promedio = (double) edades.Sum() / (edades.Count);
            menor = edades.Min();
            mayor = edades.Max();
        }

        void Imprimir(){
            TextBlockPromedio.Text = $"Promedio: {promedio}";
            TextBlockMenor.Text = $"Mejor: {menor}";
            TextBlockMayor.Text = $"Mejor: {mayor}";

            foreach (int a in edades){
                TextBloxEdades.Text = ($", {a}");
            } 
        }
    }
}
