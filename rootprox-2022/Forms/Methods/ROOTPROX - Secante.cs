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
    public partial class ROOTPROX_Secante : Form
    {
        public ROOTPROX_Secante()
        {
            InitializeComponent();
        }

        private void ROOTPROX_Secante_Load(object sender, EventArgs e)
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
            double xi, xd, ea, em, xa;

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

            if (function(xi) * function(xd) > 0)
            {
                MessageBox.Show("No existe raíz en esos intérvalos.");
            }
            else
            {
                do
                {

                    xa = xd - (function(xd) * (xi - xd) / (function(xi) - function(xd)));

                    ea = Math.Abs((xa - xd) / xa) * 100;

                    int n1 = dgvResults.Rows.Add();

                    dgvResults.Rows[n1].Cells[0].Value = iter;
                    dgvResults.Rows[n1].Cells[1].Value = xa;
                    dgvResults.Rows[n1].Cells[2].Value = ea + " %";

                    //if (Math.Abs(function(xa)) <= em)
                    //{
                    //    break;
                    //}

                    xi = xd;
                    xd = xa;

                    iter++;

                } while (ea > em && iter <= imax);

                int n2 = dgvResultAprox.Rows.Add();

                dgvResultAprox.Rows[n2].Cells[0].Value = iter - 1;
                dgvResultAprox.Rows[n2].Cells[1].Value = xa;
                dgvResultAprox.Rows[n2].Cells[2].Value = ea + " %";
            }
        }

        // Methods


    }
}
