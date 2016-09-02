using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujarFiguras
{
    public abstract class Figura
    {
        public Pen miPincel = new Pen(Color.Red);
        public double a, b, c; //Variables dentro de las funciones
        public int r; //radio de las circunferencias
        public int C1, C2; //Rango de valores para X , Cordenadas de origen

        public abstract void Dibujar(int CentroX, int CentroY, ref Graphics formGraphics, int px);
    }
}
