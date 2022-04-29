using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootprox_2022.Forms
{
    public partial class ROOTPROX_Bisección : Form
    {
        public ROOTPROX_Bisección()
        {
            InitializeComponent();
        }

        private void ROOTPROX_Bisección_Load(object sender, EventArgs e)
        {

        }

        // Functions

        private double function(double x)
        {
            MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
            sc.Language = "VBScript";

            string expression = "", eulerReplace = "";

            if ((txtFX.Text.Contains("e")) && (txtFX.Text.Contains("x")))
            {
                eulerReplace = txtFX.Text.Replace("e", "2.7182818284");
                expression = eulerReplace.Replace("x", x.ToString());
            }
            else
            {
                expression = txtFX.Text.Replace("x", x.ToString());
            }

            double result = sc.Eval(expression);

            return result;
        }

        // Controls

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int imax, iter;
            double xi, xd, ea, em, xa, xaold;

            /* xi = a
             * xd = b
             * imax = iteraciones maximas
             * em = error minimo
             * 
             * iter = numero de iteraciones
             * imax = iteraciones maximas
             */

            xi = double.Parse(txtA.Text);
            xd = double.Parse(txtB.Text);
            em = double.Parse(txtE.Text);
            imax = int.Parse(txtNmax.Text);

            dgvResults.Rows.Clear();
            dgvResultAprox.Rows.Clear();

            iter = 0;
            xa = 0;

            if (function(xi) * function(xd) > 0)
            {
                MessageBox.Show("No existe raíz en esos intérvalos.");
            }
            else
            {
                do
                {
                    iter++;

                    xaold = xa;
                    xa = (xi + xd) / 2;

                    ea = Math.Abs((xa - xaold) / xa) * 100;

                    if (function(xi) * function(xa) < 0)
                    {
                        xd = xa;
                    }
                    else if (function(xi) * function(xa) > 0)
                    {
                        xi = xa;
                    }
                    else
                    {
                        ea = 0;
                    }

                    int n1 = dgvResults.Rows.Add();

                    dgvResults.Rows[n1].Cells[0].Value = iter;
                    dgvResults.Rows[n1].Cells[1].Value = xa;
                    dgvResults.Rows[n1].Cells[2].Value = ea + " %";

                } while (ea > em && iter <= imax);

                int n2 = dgvResultAprox.Rows.Add();

                dgvResultAprox.Rows[n2].Cells[0].Value = iter;
                dgvResultAprox.Rows[n2].Cells[1].Value = xa;
                dgvResultAprox.Rows[n2].Cells[2].Value = ea + " %";
            }
        }

        // Methods


    }
}
