using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujarFiguras
{
    class Linea : Figura
    {
        public Linea(double a, double b, int C1, int C2)
        {
            this.a = a;
            this.b = b;
            this.C1 = C1;
            this.C2 = C2;
        }

        public override void Dibujar(int CentroX, int CentroY, ref Graphics formGraphics, int px)
        {
            miPincel = new Pen(Color.Red, 1);

            for (int x = this.C1 * px; x <= this.C2 * px; x++)
            {
                float coorx = CentroX + x;
                float coory = CentroY + float.Parse((this.a * x + this.b * px).ToString()) * -1;
                //MessageBox.Show(coorx.ToString() + ", " + coory.ToString());
                formGraphics.DrawEllipse(miPincel, coorx, coory, 1, 1);
            }
            miPincel.Dispose();
            formGraphics.Dispose();
        }
    }
}
