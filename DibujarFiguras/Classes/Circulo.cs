using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DibujarFiguras
{
    class Circulo : Figura
    {
        public Circulo(int r, int C1, int C2)
        {
            this.r = r; //redio del circulo
            this.C1 = C1; //centro del circulo X
            this.C2 = C2; //centro del circulo y
        }

        public override void Dibujar(int CentroX, int CentroY, ref Graphics formGraphics, int px)
        {
            miPincel = new Pen(Color.Red, 1);
            float x = this.C1 - this.r;
            while (x <= this.C1 + this.r)
            {
                float y = (float)Math.Sqrt((Math.Pow((this.r), 2) - Math.Pow(x - this.C1, 2)));
                float y1 = y + this.C2;
                float y2 = this.C2 - y;
                formGraphics.DrawEllipse(miPincel, x * px + CentroX, y1 * px + CentroY, 1, 1);
                formGraphics.DrawEllipse(miPincel, x * px + CentroX, y2 * px + CentroY, 1, 1);
                x = x + 1.00f;
            }
            miPincel.Dispose();
            formGraphics.Dispose();


        }

        public void DibujarC(int CentroX, int CentroY, int radio, ref Graphics formGraphics, int px)
        {
            
        }
    }
}
