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

            Figura miFigura = null;
            switch (cboxTipo.Text)
            {
                case "Linea":
                    miFigura = new Linea(double.Parse(txtA.Text), double.Parse(txtB.Text), int.Parse(txtXi.Text), int.Parse(txtXf.Text));
                    break;
                case "Circulo":
                     miFigura = new Circulo(int.Parse(txtRadio.Text), int.Parse(txtXo.Text), -1* int.Parse(txtYo.Text));
                    break;
                case "Parabola":
                    miFigura = new Parabola(double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtC.Text), int.Parse(txtXi.Text), int.Parse(txtXf.Text), chboxInvertir.IsChecked.Value);
                    break;
                case "Hiperbola":
                    miFigura = new Hiperbola(double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtC.Text), int.Parse(txtXo.Text), -1*int.Parse(txtXo.Text), int.Parse(txtXi.Text), int.Parse(txtXf.Text), chboxInvertir.IsChecked.Value);
                    break;
                case "Elipse":
                    miFigura = new Elipse(int.Parse(txtXo.Text), -1*int.Parse(txtXo.Text), int.Parse(txtA.Text), int.Parse(txtB.Text));
                    break;
            }


            miFigura.Dibujar((canvasCoor.Width / 2), (canvasCoor.Height / 2), ref canvasCoor, 10);




        }
    }
}
