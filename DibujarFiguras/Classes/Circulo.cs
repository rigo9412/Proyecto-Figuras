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
            if (this.C1 == 0 && this.C2 == 0)
            {
                //r^2 = x^2 + y^2
                //y^2 = r^2 - x^2
                StreamWriter sw = new StreamWriter("debug Circulo.txt", false);
                sw.WriteLine("Graficar despejando Y");
                for (int x = -1 * (this.r * px); x <= (this.r * px); x++)
                {
                    //MessageBox.Show((this.r * px).ToString());
                    //MessageBox.Show(x.ToString());

                    float y1 = (float)Math.Sqrt((Math.Pow((this.r * px),2) - Math.Pow(Math.Abs(x),2)));
                    float y2 = y1 * -1;
                    formGraphics.DrawEllipse(miPincel, x + CentroX, y1 + CentroY, 1, 1);
                    formGraphics.DrawEllipse(miPincel, x + CentroX, y2 + CentroY, 1, 1);
                    sw.WriteLine(string.Format("X:{0}\ty1:{1}\ty2:{2}", x + CentroX, y1 + CentroY, y2 + CentroY));
                }
                //Recalcar
                sw.WriteLine("Graficar despejando X");
                for (int y = -1 * (this.r * px); y <= (this.r * px); y++)
                {
                    //MessageBox.Show((this.r * px).ToString());
                    //MessageBox.Show(x.ToString());    

                    float x1 = (float)Math.Sqrt((Math.Pow((this.r * px), 2) - Math.Pow(Math.Abs(y), 2)));
                    float x2 = x1 * -1;
                    formGraphics.DrawEllipse(miPincel, x1 + CentroX, y + CentroY, 1, 1);
                    formGraphics.DrawEllipse(miPincel, x2 + CentroX, y + CentroY, 1, 1);
                    sw.WriteLine(string.Format("Y:{0}\tx1:{1}\tx2:{2}", y + CentroY, x1 + CentroX, x2 + CentroX));
                }
                sw.Close();
                miPincel.Dispose();
                formGraphics.Dispose();
            }
            else
            {
                //r^2 = x^2 + y^2
                //y^2 = r^2 - x^2
            }
        }
    }
}
