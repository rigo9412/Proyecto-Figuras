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
    class Hiperbola:Figura
    {
        bool Vertical;
        int inicio, fin;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">valor de "a" dentro de la formula</param>
        /// <param name="b">valor de "b" dentro de la formula</param>
        /// <param name="c">valor de "c" dentro de la formula</param>
        /// <param name="C1">Coordenada X del centro de la hiperbola</param>
        /// <param name="C2">Coordenada Y del centro de la hiperbola</param>
        /// <param name="X1">Especifica desde que numero real se comenzara a graficar</param>
        /// <param name="X2">Especifica en que numero real terminara de graficar</param>
        /// <param name="Vertical"></param>
        public Hiperbola(double a, double b, double c, int C1, int C2, int X1, int X2, bool Vertical = false)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.C1 = C1;
            this.C2 = C2;
            this.X1 = X1;
            this.X2 = X2;
            this.Vertical = Vertical;
        }

        public override void Dibujar(double centroX, double centroY, ref Canvas miCanvas, int px)
        {
            float coorX1 = this.C1 + (float)this.a;//Calcular los extremos de la hiperbola
            float coorX2 = this.C1 - (float)this.a;
            float y1, y2, y;
            float rangoI = coorX1 + X2;
            float rangoF = coorX2 + X1;

            if (Vertical)
            {
                //Son los rangos x1 = inicio x2 = fin
                while (coorX1 <= rangoI && coorX2 >= rangoF)
                {
                    y = (float)Math.Sqrt(((Math.Pow(this.b, 2) * (1 - (Math.Pow(coorX1 - C1, 2) / Math.Pow(this.a, 2)))) / -1));
                    y1 = y + this.C2;
                    y2 = this.C2 - y;

                    Rectangle miRect = new Rectangle();
                    miRect.Width = 2;
                    miRect.Height = 2;
                    miRect.Fill = Brushes.Red;
                    Canvas.SetLeft(miRect, coorX1 + centroX);
                    Canvas.SetTop(miRect, y1 + centroY);
                    //MessageBox.Show(x + ", " + y);
                    miCanvas.Children.Add(miRect);
                    //mitad de arriba
                    Rectangle miRect2 = new Rectangle();
                    miRect2.Width = 2;
                    miRect2.Height = 2;
                    miRect2.Fill = Brushes.Red;
                    Canvas.SetLeft(miRect2, coorX1 + centroX);
                    Canvas.SetTop(miRect2, y2 + centroY);
                    //MessageBox.Show(x + ", " + -y);
                    miCanvas.Children.Add(miRect2);




                    Rectangle miRect3 = new Rectangle();
                    miRect.Width = 2;
                    miRect.Height = 2;
                    miRect.Fill = Brushes.Red;
                    Canvas.SetLeft(miRect, coorX2 + centroX);
                    Canvas.SetTop(miRect, y1 + centroY);
                    //MessageBox.Show(x + ", " + y);
                    miCanvas.Children.Add(miRect);
                    //mitad de arriba
                    Rectangle miRect4= new Rectangle();
                    miRect2.Width = 2;
                    miRect2.Height = 2;
                    miRect2.Fill = Brushes.Red;
                    Canvas.SetLeft(miRect2, coorX2 + centroX);
                    Canvas.SetTop(miRect2, y2 + centroY);
                    //MessageBox.Show(x + ", " + -y);
                    miCanvas.Children.Add(miRect2);

                    coorX1 += 0.10f;
                    coorX2 -= 0.10f;
                }
            }
            else
            {
                //Son los rangos x1 = inicio x2 = fin
                while (coorX1 <= rangoI && coorX2 >= rangoF)
                {
                    y = (float)Math.Sqrt(((Math.Pow(this.b, 2) * (1 - (Math.Pow(coorX1 - C1, 2) / Math.Pow(this.a, 2)))) / -1));
                    y1 = y + this.C2;
                    y2 = this.C2 - y;

                    //Formula para vertical
                    //formGraphics.DrawEllipse(miPincel, y1 * px + CentroX, coorX1 * px + CentroY, 1, 1);
                    //formGraphics.DrawEllipse(miPincel, y2 * px + CentroX, coorX1 * px + CentroY, 1, 1);

                    //formGraphics.DrawEllipse(miPincel, y1 * px + CentroX, coorX2 * px + CentroY, 1, 1);
                    //formGraphics.DrawEllipse(miPincel, y2 * px + CentroX, coorX2 * px + CentroY, 1, 1);

                    coorX1 += 0.10f;
                    coorX2 -= 0.10f;
                }
            }
        }
    }
}
