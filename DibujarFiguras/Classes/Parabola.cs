using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DibujarFiguras
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

        public override void Dibujar(int CentroX, int CentroY, ref Graphics formGraphics, int px)
        {
            miPincel = new Pen(Color.Red, 1);

            //Y = aX^2 + bX + c
            //X = aY^2 + bY + c
            StreamWriter sw = new StreamWriter("debug Parabola.txt", false);
            sw.WriteLine("Graficar despejando Y");
            float coorx = this.C1;
            while (coorx <= this.C2)
            {
                float coory = (float)(this.a * Math.Pow(coorx, 2) + this.b * coorx + this.c) * -1;
                if (!Vertical)
                    formGraphics.DrawEllipse(miPincel, coorx * px + CentroX, coory * px + CentroY, 1, 1);
                else
                    formGraphics.DrawEllipse(miPincel, coory * px + CentroX, coorx * px + CentroY, 1, 1);

                sw.WriteLine(string.Format("X:{0}\tY:{1}\t\tXg:{2}\tYg:{3}", coorx, coory, coorx * px, coory * px));
                coorx += 0.01f;
            }

            /*for (int xy = C1; xy <= C2; xy++)
            {
                //xy: x
                float coorx = xy;
                float coory = (float)(this.a * Math.Pow(xy, 2) + this.b * xy + this.c) * -1;
                //MessageBox.Show(coorx.ToString() + ", " + coory.ToString());
                formGraphics.DrawEllipse(miPincel, coorx * px + CentroX, coory * px + CentroY, 1, 1);
                sw.WriteLine(string.Format("X:{0}\tY:{1}\t\tXg:{2}\tYg:{3}", coorx, coory, coorx * px, coory * px));

            }/**/
            sw.Close();
            Process.Start("debug Parabola.txt");
            miPincel.Dispose();
            formGraphics.Dispose();
        }
    }
}
