using DibujarFiguras.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujarFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Figura x = new Linea(1, 1);
            x.Dibujar(0,4);
        }
       
    }
}
