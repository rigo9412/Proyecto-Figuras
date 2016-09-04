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
    public partial class FabricaDeFiguras : Form
    {
        public FabricaDeFiguras()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            try
            {
                Figura miFigura = null;
                switch (cboTipo.Text)
                {
                    case "Linea":
                        miFigura = new Linea((double)numA.Value, (double)numB.Value, (int)numXi.Value, (int)numXf.Value);
                        break;
                    case "Circulo":
                        miFigura = new Circulo((int)numR.Value, (int)numOx.Value, -1*(int)numOy.Value);
                        break;
                    case "Parabola":
                        miFigura = new Parabola((double)numA.Value, (double)numB.Value, (double)numC.Value, (int)numXi.Value, (int)numXf.Value, chkInvertir.Checked);
                        break;
                    case "Hiperbola":
                        miFigura = new Hiperbola((double)numA.Value, (double)numB.Value, (double)numC.Value, (int)numOx.Value, (int)numOy.Value, (int)numXi.Value, (int)numXf.Value, chkInvertir.Checked);
                        break;
                    case "Elipse":
                        miFigura = new Elipse((int)numOx.Value, -1 * (int)numOy.Value, (int)numA.Value, (int)numB.Value);
                        break;
                }
                Grafica miGrafica = new Grafica(miFigura, (int)numPx.Value);
                miGrafica.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipo.Text)
            {
                case "Linea":
                    numA.Enabled = true;
                    numB.Enabled = true;
                    numC.Enabled = false;
                    numR.Enabled = false;
                    numOx.Enabled = false;
                    numOy.Enabled = false;
                    numXi.Enabled = true;
                    numXf.Enabled = true;
                    chkInvertir.Visible = false;
                    break;
                case "Circulo":
                    numA.Enabled = false;
                    numB.Enabled = false;
                    numC.Enabled = false;
                    numR.Enabled = true;
                    numOx.Enabled = true;
                    numOy.Enabled = true;
                    numXi.Enabled = false;
                    numXf.Enabled = false;
                    chkInvertir.Visible = false;
                    break;
                case "Parabola":
                    numA.Enabled = true;
                    numB.Enabled = true;
                    numC.Enabled = true;
                    numR.Enabled = false;
                    numOx.Enabled = true;
                    numOy.Enabled = true;
                    numXi.Enabled = true;
                    numXf.Enabled = true;
                    chkInvertir.Visible = true;
                    break;
                case "Hiperbola":
                    numA.Enabled = true;
                    numB.Enabled = true;
                    numC.Enabled = false;
                    numR.Enabled = false;
                    numOx.Enabled = true;
                    numOy.Enabled = true;
                    numXi.Enabled = true;
                    numXf.Enabled = true;
                    chkInvertir.Visible = true;
                    break;
                case "Elipse":
                 
                    numA.Enabled = true;
                    numB.Enabled = true;
                    numC.Enabled = false;
                    numR.Enabled = false;
                    numOx.Enabled = true;
                    numOy.Enabled = true;
                    numXi.Enabled = false;
                    numXf.Enabled = false;
                    chkInvertir.Visible = false;
                    break;
            }
        }
    }
}
