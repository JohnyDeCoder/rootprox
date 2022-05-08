using rootprox_2022.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngouriMath;

namespace rootprox_2022.Forms
{
    public partial class ROOTPROX_Bisección : Form
    {
        private TextBox currentTxtBox;
        public bool txtEmpty; // Variable utilizada para saber si hay algún TextBox vacio.
        public bool txtContains; // Variable utilizada para saber si hay algún TextBox únicamente con - o .
        private string currentForm;

        public ROOTPROX_Bisección(string currentTheme)
        {
            ColorsTheme.ChooseTheme(currentTheme);

            InitializeComponent();
        }

        private void ROOTPROX_Bisección_Load(object sender, EventArgs e)
        {
            dgvResultAprox.ColumnHeadersDefaultCellStyle.BackColor = ColorsTheme.PanelContainerLeft;
            dgvResultAprox.GridColor = ColorsTheme.PanelContainerLeft;

            dgvResults.ColumnHeadersDefaultCellStyle.BackColor = ColorsTheme.PanelContainerLeft;
            dgvResults.GridColor = ColorsTheme.PanelContainerLeft;
        }

        // Functions

        private double function(double x)
        {
            string expression = txtFX.Text;

            if (expression.Contains("ℯ"))
            {
                expression = expression.Replace("ℯ", "e");
            }

            if (expression.Contains("√"))
            {
                expression = expression.Replace("√", "sqrt");
            }

            if (expression.Contains("π"))
            {
                expression = expression.Replace("π", "pi");
            }

            if (expression.Contains("x"))
            {
                expression = expression.Replace("x", x.ToString());
            }

            var expr = MathS.FromString(expression);

            expr.Simplify(); // Simplificar expresiones complicadas

            double evalDouble = (double)expr.EvalNumerical();

            return evalDouble;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea reiniciar los valores?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Reset(gbValues);
            }
        }

        private void txtFX_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbersAndFunctions(sender, e);

            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFX_TextChanged(object sender, EventArgs e)
        {
            txtFX.CharacterCasing = CharacterCasing.Lower; // Solo aceptar minúsculas

            if (txtFX.Text != "")
            {
                if (txtFX.Text.Contains("e"))
                {
                    txtFX.Text = txtFX.Text.Replace("e", "ℯ^");
                    txtFX.Select(txtFX.Text.Length, 0);
                }
            }
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            txtFX.Text += "ℯ^";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtFX.Text += "^";
        }

        private void btnSigns_Click(object sender, EventArgs e)
        {
            Form ROOTPROX_Signos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ROOTPROX_Signos").SingleOrDefault<Form>();

            if (ROOTPROX_Signos != null)
            {
                ROOTPROX_Signos.BringToFront();
            }
            else
            {
                currentForm = GetType().Name; // Obtiene el nombre del formulario padre
                ROOTPROX_Signos formSigns = new ROOTPROX_Signos(currentForm);
                AddOwnedForm(formSigns);
                formSigns.Show();
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbersAndCharts(sender, e);
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbersAndCharts(sender, e);
        }

        private void txtNmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbersAndCharts(sender, e);
        }

        private void txtE_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbersAndCharts(sender, e);
        }

        private void cbSinEA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSinEA.Checked == true)
            {
                txtE.Enabled = false;
                txtE.Visible = false;
                lblPor100.Visible = false;
                lblError.Text = "Sin Factor de Paro (εa)";
            }
            else
            {
                lblError.Text = "Factor de Paro  (εa) =";
                txtE.Enabled = true;
                txtE.Visible = true;
                lblPor100.Visible = true;

            }
        }

        private void rbRedondear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRedondear.Checked == true)
            {
                numericRound.Enabled = true;
            }
            else
            {
                numericRound.Enabled = false;
            }
        }

        // Methods

        private void Reset(Control ROOTPROX_Bisección)
        {
            dgvResults.Rows.Clear();
            dgvResults.Refresh();

            dgvResultAprox.Rows.Clear();
            dgvResultAprox.Refresh();

            txtFX.Text = "x";
            txtA.Text = "0";
            txtB.Text = "1";
            txtNmax.Text = "100";
            txtE.Text = "0.01";
        }

        // Validation

        private void onlyNumbersAndCharts(object senderTxtBox, KeyPressEventArgs e)
        {
            currentTxtBox = (TextBox)senderTxtBox;

            // Solo aceptar dígitos, punto decimal y guión de resta.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Para que acepte un solo punto decimal.
            if ((e.KeyChar == '.') && (currentTxtBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Para que acepte un solo punto guión de resta.
            if ((e.KeyChar == '-') && (currentTxtBox.Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void onlyNumbersAndFunctions(object senderTxtBox, KeyPressEventArgs e)
        {
            currentTxtBox = (TextBox)senderTxtBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != '-')
                && (e.KeyChar != '+') && (e.KeyChar != '*')
                && (e.KeyChar != 'e') && (e.KeyChar != '(')
                && (e.KeyChar != ')') && (e.KeyChar != 'x')
                && (e.KeyChar != '^') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtBoxEmpty(Control ROOTPROX_Bisección)
        {
            // Busca cada TextBox dentro del formulario.
            foreach (Control oControls in ROOTPROX_Bisección.Controls)
            {
                // Si encuentra un TextBox vacío.
                if (oControls is TextBox & oControls.Enabled == true & oControls.Text == string.Empty)
                {
                    txtEmpty = true;
                }
            }
        }

        private void txtBoxContains(Control gbValues)
        {
            // Busca cada TextBox dentro del groupBox - Valores.
            foreach (Control oControls in gbValues.Controls)
            {
                // Si encuentra un TextBox con únicamente un - o punto o ambos juntos.
                if (oControls is TextBox & oControls.Enabled == true & oControls.Text == "-" || oControls.Text == "." ||
                    oControls.Text.Contains("-.") || oControls.Text.Contains(".-") ||
                    oControls.Text.EndsWith("-"))
                {
                    txtContains = true;
                }
            }
        }
    }
}
