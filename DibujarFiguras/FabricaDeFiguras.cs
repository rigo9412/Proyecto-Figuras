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
                        miFigura = new Hiperbola((double)numA.Value, (double)numB.Value, (double)numC.Value, (int)numOx.Value, -1 * (int)numOy.Value, (int)numXi.Value, (int)numXf.Value, chkInvertir.Checked);
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
            ActualizarFormula();
        }

        private void ActualizarFormula()
        {
            switch (cboTipo.Text)
            {
                case "Linea":
                    lblFormula.Text = "Formula: Y = aX + b";
                    lblSust.Text = string.Format("Sustitución: Y = {0}X + {1}", numA.Value, numB.Value);
                    break;
                case "Circulo":
                    lblFormula.Text = "Formula: Y = ±(r^2 - (X - Xo)^2)";
                    lblSust.Text = string.Format("Sustitución: Y1 = ({0}^2 - (X - {1})^2)\n                    Y2 = -({0}^2 - (X - {1})^2)", numR.Value, numOx.Value);
                    break;
                case "Parabola":
                    lblFormula.Text = "Formula: Y = aX^2 + bX + c";
                    lblSust.Text = string.Format("Sustitución: Y = {0}X^2 + {1}X + {2}", numA.Value, numB.Value, numC.Value);
                    break;
                case "Hiperbola":
                    lblFormula.Text = "Formula: Y = ±√(b^2 * 1 - (Xi - Xo) + a^2) / -1";
                    lblSust.Text = string.Format("Sustitución: Y = ±√({0}^2 * 1 - ({1} - {2}) + {3}^2) / -1", numB.Value, numXi.Value, numOx.Value, numA.Value);
                    break;
                case "Elipse":
                    lblFormula.Text = "Formula: Y = ±√(b^2 * 1 - (Xi - Xo) + a^2)";
                    lblSust.Text = string.Format("Sustitución: Y = ±√({0}^2 * 1 - ({1} - {2}) + {3}^2)", numB.Value, numXi.Value, numOx.Value, numA.Value);
                    break;
            }
        }

        private void numA_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }

        private void numB_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }

        private void numC_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }

        private void numR_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }

        private void numXi_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }

        private void numXf_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }

        private void numOx_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }

        private void numOy_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }

        private void numPx_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }

        private void chkInvertir_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarFormula();
        }
    }
}
