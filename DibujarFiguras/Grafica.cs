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
    public partial class Grafica : Form
    {
        int px = 30; //Pixeles por unidad (para la Cuadricula)
        int CentroX, CentroY; //centro del plano carteciano
        Pen miPincel;
        Graphics formGraphics;

        Figura miFigura;
        public Grafica(Figura f, int px)
        {
            miFigura = f;
            this.px = px;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cacular tama;o de la forma
            CentroX = this.Size.Width / 2;
            CentroY = this.Size.Height / 2;

            GraficarEjes();
            

            miFigura.Dibujar(CentroX, CentroY, ref formGraphics, px);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GraficarEjes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GraficarEjes()
        {
            miPincel = new Pen(Color.Black, 2);
            formGraphics = this.CreateGraphics();
            //Graficar eje X
            formGraphics.DrawLine(miPincel, 0, CentroY, this.Size.Width, CentroY);
            //Graficar eje Y
            formGraphics.DrawLine(miPincel, CentroX, 0, CentroX, this.Size.Height);
            //Dibujar unidades
            miPincel.Color = Color.Blue;
            for (int i = 0; i <= CentroX / px; i++)
            {
                formGraphics.DrawLine(miPincel, CentroX + (i * -px), (CentroY - 3), CentroX + (i * -px), (CentroY + 3));
                formGraphics.DrawLine(miPincel, CentroX + (i * px), (CentroY - 3), CentroX + (i * px), (CentroY + 3));
            }
            for (int i = 0; i <= CentroY / px; i++)
            {
                formGraphics.DrawLine(miPincel, (CentroX - 3), CentroY + (i * -px), (CentroX + 3), CentroY + (i * -px));
                formGraphics.DrawLine(miPincel, (CentroX - 3), CentroY + (i * px), (CentroX + 3), CentroY + (i * px));
            }
        }
    }
}
