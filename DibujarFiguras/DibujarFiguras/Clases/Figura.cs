using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarFiguras.Clases
{
    public abstract class Figura
    {
        
        //rango de dibujo
       //public int ranF;
       //public int ranI;
       public double x ;
       public double y ;
       public double a ;
       public double b ;
       public double c ;
       public double r;
        public abstract void Dibujar(int ranI, int ranF);
        
    }
}
