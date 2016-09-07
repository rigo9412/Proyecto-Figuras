using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GraficacionWPF
{
    class Parabola : Figura
    {
        bool Vertical;
        int inicio, fin;
        public Parabola(double a, double b, double c, int C1, int C2, bool Vertical = false)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.C1 = C1; //X1
            this.C2 = C2; //X2
            this.Vertical = Vertical;
        }

        public override void Dibujar(double centroX, double centroY, ref Canvas miCanvas, int px)
        {
            float coorx = this.C1;
            while (coorx <= this.C2)
            {
                float coory = (float)(this.a * Math.Pow(coorx, 2) + this.b * coorx + this.c) * -1;
                if (!Vertical)
                {
                    Rectangle miRect = new Rectangle();
                    miRect.Width = 2;
                    miRect.Height = 2;
                    miRect.Fill = Brushes.Red;
                    Canvas.SetLeft(miRect, coorx + centroX);
                    Canvas.SetTop(miRect, coory + centroY);
                    //MessageBox.Show(x + ", " + y);
                    miCanvas.Children.Add(miRect);
                }
              
                else
                {
                    Rectangle miRect = new Rectangle();
                    miRect.Width = 2;
                    miRect.Height = 2;
                    miRect.Fill = Brushes.Red;
                    Canvas.SetLeft(miRect, coory + centroX);
                    Canvas.SetTop(miRect, coorx + centroY);
                    //MessageBox.Show(x + ", " + y);
                    miCanvas.Children.Add(miRect);
                }

                    coorx += 0.01f;
            }
        }
    }
}
