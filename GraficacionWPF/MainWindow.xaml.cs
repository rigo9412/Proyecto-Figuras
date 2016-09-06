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

namespace GraficacionWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, RoutedEventArgs e)
        {
            Circulo miCirculo = new Circulo(int.Parse(txtRadio.Text), int.Parse(txtXo.Text), int.Parse(txtYo.Text));
            miCirculo.centrox = canvas1.Width / 2;
            miCirculo.centroy = canvas1.Height / 2;
            miCirculo.Dibujar(ref canvas1);
        }
    }
}
