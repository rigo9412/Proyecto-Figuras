using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarFiguras
{
    class Hiperbola : Figura
    {
        bool Vertical;
        int inicio, fin;
        public Hiperbola(double a, double b, double c, int C1, int C2, bool Vertical = false)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.C1 = C1; //X1
            this.C2 = C2; //X2
            this.Vertical = Vertical;
        }

        public override void Dibujar(int CentroX, int CentroY, ref Graphics formGraphics, int px)
        {
            
        }
    }
}
