using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujarFiguras
{
    class Hiperbola : Figura
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CentroX">Especifica el centro horizontal de la forma</param>
        /// <param name="CentroY">Especifica el centro vertical de la forma</param>
        /// <param name="formGraphics"></param>
        /// <param name="px">pixeles por unidad</param>
        public override void Dibujar(int CentroX, int CentroY, ref Graphics formGraphics, int px)
        {
            miPincel = new Pen(Color.Red, 1);

            float coorx = this.X1;
            while (coorx <= this.X2)
            {
                float coory = (float)(this.b / this.a) * (coorx - this.C1);
                if (!Vertical)
                {
                    //MessageBox.Show(coorx + "\t" + coory);
                    formGraphics.DrawEllipse(miPincel, coorx * px + CentroX, coory * px * -1 + CentroY, 1, 1);
                    formGraphics.DrawEllipse(miPincel, coorx * px + CentroX, coory * px + CentroY, 1, 1);
                }
                else
                {
                    formGraphics.DrawEllipse(miPincel, coory * px + CentroX, coorx * px + CentroY, 1, 1);
                }

                coorx += 0.01f;
            }
            miPincel.Dispose();
            formGraphics.Dispose();
        }
    }
}
