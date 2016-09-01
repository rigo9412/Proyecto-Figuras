using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujarFiguras.Clases
{
    public class Linea : Figura
    {
        public Linea(double a ,double b)
        {
            this.a = a;
            this.b = b;
            
        }   
        public override void Dibujar(int ranI,int ranF)
        {
            for (int x = ranI; x <= ranF; x++)
            {
                this.y = a * x + b;
                MessageBox.Show(this.y.ToString());
            }
        }
    }
}
