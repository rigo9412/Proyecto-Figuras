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
    public class Linea : Figura
    {
        public Linea(double a, double b, int C1, int C2)
        {
            this.a = a;
            this.b = b;
            this.C1 = C1;
            this.C2 = C2;
        }
        public override void Dibujar(double centroX, double centroY, ref Canvas miCanvas, int px)
        {
            for (int x = this.C1 * px; x <= this.C2 * px; x++)
            {
                float coorx = (float)centroX + x;
                float coory = (float)centroY + float.Parse((this.a * x + this.b * px).ToString()) * -1;
                //MessageBox.Show(coorx.ToString() + ", " + coory.ToString());
                Rectangle miRect = new Rectangle();
                miRect.Width = 2;
                miRect.Height = 2;
                miRect.Fill = Brushes.Blue;
                Canvas.SetLeft(miRect, coorx);
                Canvas.SetTop(miRect, coory);
                //MessageBox.Show(x + ", " + y);
                miCanvas.Children.Add(miRect);
            }
        }
    }
}
