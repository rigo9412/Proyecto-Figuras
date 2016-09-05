using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarFiguras
{
    public class Elipse : Figura
    {
        public Elipse( int C1, int C2,int a ,int b)
        {
            this.a = a;
            this.b = b;
           
            this.C1 = C1; //centro del circulo X
            this.C2 = C2; //centro del circulo y
        }

        public override void Dibujar(int CentroX, int CentroY, ref Graphics formGraphics, int px)
        {
            float x = this.C1 - (float)this.a;
            while (x <= this.C1 + this.a)
            {
                float y = (float)Math.Sqrt(Math.Pow(this.b,2)*(1-(Math.Pow((x-this.C1),2)/ Math.Pow(this.a, 2))));
                float y1 = y + this.C2;
                float y2 = this.C2 - y;
                formGraphics.DrawEllipse(miPincel, x * px + CentroX, y1 * px + CentroY, 1, 1);
                formGraphics.DrawEllipse(miPincel, x * px + CentroX, y2 * px + CentroY, 1, 1);
                 x =x + 0.10f;
            }
            miPincel.Dispose();
            formGraphics.Dispose();
        }
    }
}
