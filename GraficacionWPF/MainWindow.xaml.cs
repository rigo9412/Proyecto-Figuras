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
            double centrox = canvasCoor.Width / 2;
            double centroy = canvasCoor.Height / 2;
            //eje X
            Rectangle miRect = new Rectangle();
            miRect.Width = canvasCoor.Width;
            miRect.Height = 1;
            miRect.Fill = Brushes.Red;
            Canvas.SetLeft(miRect, 0);
            Canvas.SetTop(miRect, centroy);
            canvasCoor.Children.Add(miRect);
            //eje Y
            Rectangle miRect2 = new Rectangle();
            miRect2.Width = 1;
            miRect2.Height = canvasCoor.Height;
            miRect2.Fill = Brushes.Red;
            Canvas.SetLeft(miRect2, centrox);
            Canvas.SetTop(miRect2, 0);
            canvasCoor.Children.Add(miRect2);
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
