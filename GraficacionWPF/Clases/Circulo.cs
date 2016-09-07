using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.IO;

namespace GraficacionWPF
{
    class Circulo : Figura
    {
       
        public Circulo(int r, int C1, int C2)
        {
            this.r = r; //redio del circulo
            this.C1 = C1; //centro del circulo X
            this.C2 = C2; //centro del circulo y
        }

        public override void Dibujar(double centroX, double centroY, ref Canvas miCanvas, int px=1)
        {

            float x = this.C1 - this.r;

            while (x <= this.C1 + this.r)
            {
                float y = (float)Math.Sqrt((Math.Pow((this.r), 2) - Math.Pow(x - this.C1, 2)));
                float y1 = y + this.C2;
                float y2 = this.C2 - y;

                //mitad de abajo
                Rectangle miRect = new Rectangle();
                miRect.Width = 2;
                miRect.Height = 2;
                miRect.Fill = Brushes.Red;
                Canvas.SetLeft(miRect, x + centroX);
                Canvas.SetTop(miRect, y1 + centroY);
                //MessageBox.Show(x + ", " + y);
                miCanvas.Children.Add(miRect);

                //mitad de arriba
                Rectangle miRect2 = new Rectangle();
                miRect2.Width = 2;
                miRect2.Height = 2;
                miRect2.Fill = Brushes.Red;
                Canvas.SetLeft(miRect2, x + centroX);
                Canvas.SetTop(miRect2, y2 + centroY);
                //MessageBox.Show(x + ", " + -y);
                miCanvas.Children.Add(miRect2);

                x = x + 1.00f;
            }
        }
    }
}
