using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GraficacionWPF
{
    public abstract class Figura
    {
        // public Pen miPincel = new Pen(Color.Red);
        public double a, b, c; //Variables dentro de las funciones
        public int r; //radio de las circunferencias
        public int C1, C2, X1, X2; //Rango de valores para X , Cordenadas de origen

        public abstract void Dibujar(double centroX, double centroY, ref Canvas miCanvas, int px);
    }
}
