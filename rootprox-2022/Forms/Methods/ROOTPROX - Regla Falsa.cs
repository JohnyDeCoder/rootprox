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
    public partial class ROOTPROX_Regla_Falsa : Form
    {
        // Campos
        private TextBox currentTxtBox;
        public bool txtEmpty; // Variable utilizada para saber si hay algún TextBox vacio.
        public bool txtContains; // Variable utilizada para saber si hay algún TextBox únicamente con - o .
        private string currentForm; // Variable utilizada para guardar el Name del formulario padre
        public bool error; // Variable utilizada para detectar un error

        public ROOTPROX_Regla_Falsa(string currentTheme)
        {
            ColorsTheme.ChooseTheme(currentTheme);

            InitializeComponent();
        }

        private void ROOTPROX_Regla_Falsa_Load(object sender, EventArgs e)
        {
            dgvResultAprox.ColumnHeadersDefaultCellStyle.BackColor = ColorsTheme.PanelContainerLeft; // Cabezera
            dgvResultAprox.GridColor = ColorsTheme.PanelSubMenu; // Lineas

            dgvResults.ColumnHeadersDefaultCellStyle.BackColor = ColorsTheme.PanelContainerLeft; // Cabezera
            dgvResults.GridColor = ColorsTheme.PanelSubMenu; // Lineas
        }

        // Functions

        private double function(double x)
        {
            string expression = txtFX.Text;
            double evalDouble = 0;

            error = false;

            try
            {
                // Puede ser lento a la hora de ejecutar .Replace
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

                if (expression.Contains("sin⁻¹"))
                {
                    expression = expression.Replace("sin⁻¹", "arcsin");
                }

                if (expression.Contains("cos⁻¹"))
                {
                    expression = expression.Replace("cos⁻¹", "arccos");
                }

                if (expression.Contains("tan⁻¹"))
                {
                    expression = expression.Replace("tan⁻¹", "arctan");
                }

                if (expression.Contains("x"))
                {
                    expression = expression.Replace("x", x.ToString());
                }

                var expr = MathS.FromString(expression);

                expr.Simplify(); // Simplificar expresiones complicadas

                evalDouble = (double)expr.EvalNumerical();
            }
            catch (Exception err)
            {
                error = true;

                if (err.Message.Contains("no viable alternative at input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR100",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://google.com"
                    );
                }

                if (err.Message.Contains("mismatched input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor no escriba signos o símbolos repetidos.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR101",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://google.com"
                    );
                }

                if (err.Message.Contains("extraneous input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR102",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://google.com"
                    );
                }

                if (err.Message.Contains("Cannot cast from AngouriMath.Entity+Number+Complex to System.Double"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, la función es muy compleja para su solución.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR103",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://google.com"
                    );
                }

                if (err.Message.Contains("Result cannot be represented as a simple number!"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR104",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://google.com"
                    );
                }

                if (err.Message.Contains("token recognition error at"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR105",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://google.com"
                    );
                }
            }
            return evalDouble;
        }

        // Controls

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int imax, iter, round;
            double xi, xd, ea, em, xa, xaold;

            /* xi = a
             * xd = b
             * imax = iteraciones maximas
             * em = error minimo
             * 
             * iter = numero de iteraciones
             * imax = iteraciones maximas
             */

            txtBoxEmpty(gbValues); // Determina si hay TextBox vacíos.
            txtBoxContains(gbValues); // Determina si algunos de los TextBox tengan solamente - o punto.

            if (txtEmpty == true || txtContains == true) // Si hay algún TextBox vacío o únicamente con - o punto.
            {
                MessageBox.Show(
                    "No se admiten campos con valores inválidos, por favor rellene correctamente los campos para continuar.\n\n" +
                    "Da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: A100",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    0, "https://google.com"
                    );

                txtEmpty = false; // Se reinicia la variable si ya se había encontrado un TextBox vacío.
                txtContains = false; // Se reinicia la variable si ya se había encontrado un TextBox con - o punto.
            }
            else
            {
                xi = double.Parse(txtA.Text);
                xd = double.Parse(txtB.Text);
                em = double.Parse(txtE.Text);
                imax = int.Parse(txtNmax.Text);

                dgvResults.Rows.Clear();
                dgvResultAprox.Rows.Clear();

                iter = 0;
                xa = 0;

                function(xi); // Detectar error al inicio solo 1 vez

                if (error == false)
                {
                    if (function(xi) * function(xd) < 0)
                    {
                        if (cbSinEA.Checked == true)
                        {
                            if (rbRedondear.Checked == true)
                            {
                                round = Convert.ToInt32(Math.Round(numericRound.Value, 0));

                                do
                                {
                                    iter++;

                                    xa = xd - (function(xd) * (xi - xd) / (function(xi) - function(xd)));

                                    int n1 = dgvResults.Rows.Add();

                                    dgvResults.Rows[n1].Cells[1].Value = Math.Round(xi, round);
                                    dgvResults.Rows[n1].Cells[2].Value = Math.Round(xd, round);

                                    if (function(xi) * function(xa) < 0)
                                    {
                                        xd = xa;
                                    }
                                    else
                                    {
                                        xi = xa;
                                    }

                                    dgvResults.Rows[n1].Cells[0].Value = iter;
                                    dgvResults.Rows[n1].Cells[3].Value = Math.Round(xa, round);

                                } while (iter <= imax);

                                int n2 = dgvResultAprox.Rows.Add();

                                dgvResultAprox.Rows[n2].Cells[0].Value = iter;
                                dgvResultAprox.Rows[n2].Cells[1].Value = Math.Round(xa, round);
                            }
                            else
                            {
                                do
                                {
                                    iter++;

                                    xa = xd - (function(xd) * (xi - xd) / (function(xi) - function(xd)));

                                    int n1 = dgvResults.Rows.Add();

                                    dgvResults.Rows[n1].Cells[1].Value = xi;
                                    dgvResults.Rows[n1].Cells[2].Value = xd;

                                    if (function(xi) * function(xa) < 0)
                                    {
                                        xd = xa;
                                    }
                                    else
                                    {
                                        xi = xa;
                                    }

                                    dgvResults.Rows[n1].Cells[0].Value = iter;
                                    dgvResults.Rows[n1].Cells[3].Value = xa;

                                } while (iter <= imax);

                                int n2 = dgvResultAprox.Rows.Add();

                                dgvResultAprox.Rows[n2].Cells[0].Value = iter;
                                dgvResultAprox.Rows[n2].Cells[1].Value = xa;
                            }
                        }
                        else
                        {
                            if (rbRedondear.Checked == true)
                            {
                                round = Convert.ToInt32(Math.Round(numericRound.Value, 0));

                                do
                                {
                                    iter++;
                                    xaold = xa;

                                    xa = xd - (function(xd) * (xi - xd) / (function(xi) - function(xd)));

                                    ea = Math.Abs((xa - xaold) / xa) * 100;

                                    int n1 = dgvResults.Rows.Add();

                                    dgvResults.Rows[n1].Cells[1].Value = Math.Round(xi, round);
                                    dgvResults.Rows[n1].Cells[2].Value = Math.Round(xd, round);

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

                                    dgvResults.Rows[n1].Cells[0].Value = iter;
                                    dgvResults.Rows[n1].Cells[3].Value = Math.Round(xa, round);
                                    dgvResults.Rows[n1].Cells[4].Value = Math.Round(ea, round) + " %";

                                } while (ea > em && iter <= imax);

                                int n2 = dgvResultAprox.Rows.Add();

                                dgvResultAprox.Rows[n2].Cells[0].Value = iter;
                                dgvResultAprox.Rows[n2].Cells[1].Value = Math.Round(xa, round);
                                dgvResultAprox.Rows[n2].Cells[2].Value = Math.Round(ea, round) + " %";
                            }
                            else
                            {
                                do
                                {
                                    iter++;
                                    xaold = xa;

                                    xa = xd - (function(xd) * (xi - xd) / (function(xi) - function(xd)));

                                    ea = Math.Abs((xa - xaold) / xa) * 100;

                                    int n1 = dgvResults.Rows.Add();

                                    dgvResults.Rows[n1].Cells[1].Value = xi;
                                    dgvResults.Rows[n1].Cells[2].Value = xd;

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

                                    dgvResults.Rows[n1].Cells[0].Value = iter;
                                    dgvResults.Rows[n1].Cells[3].Value = xa;
                                    dgvResults.Rows[n1].Cells[4].Value = ea + " %";

                                } while (ea > em && iter <= imax);

                                int n2 = dgvResultAprox.Rows.Add();

                                dgvResultAprox.Rows[n2].Cells[0].Value = iter;
                                dgvResultAprox.Rows[n2].Cells[1].Value = xa;
                                dgvResultAprox.Rows[n2].Cells[2].Value = ea + " %";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "No se existe una raíz entre esos intérvalos [X₀, X₁], por favor cambie de intérvalos y/o cambie la función para calcular\n\n" +
                        "Da click en el botón AYUDA para obtener más información.\n\n" +
                        "Código: A101",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        0, "https://google.com"
                        );
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea reiniciar los valores?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Reset();
            }
        }

        private void numericRound_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFX_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbersAndFunctions(sender, e);

            if (char.IsSeparator(e.KeyChar)) // No imprime un espacio en blanco
            {
                e.Handled = true;
            }

            // Envía un TAB al precionar enter
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{TAB}");
            //}
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

                if (txtFX.Text.Contains("sin") || txtFX.Text.Contains("cos") ||
                    txtFX.Text.Contains("tan") || txtFX.Text.Contains("sin⁻¹") ||
                    txtFX.Text.Contains("cos⁻¹") || txtFX.Text.Contains("tan⁻¹"))
                {
                    lblMODE.Visible = true;
                }
                else
                {
                    lblMODE.Visible = false;
                }
            }
            else
            {
                lblMODE.Visible = false;
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
                dgvResultAprox.Columns.RemoveAt(2);
                dgvResults.Columns.RemoveAt(4);
                lblError.Text = "Sin Factor de Paro (εa)";
            }
            else
            {
                lblError.Text = "Factor de Paro  (εa) =";
                dgvResultAprox.Columns.Add("ea", "Error Relativo Aproximado");
                dgvResults.Columns.Add("ea", "Error Relativo Aproximado");
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

        private void Reset()
        {
            dgvResults.Rows.Clear();
            dgvResults.Refresh();

            dgvResultAprox.Rows.Clear();
            dgvResultAprox.Refresh();

            txtFX.Text = "x";
            txtA.Text = "0";
            txtB.Text = "1";
            txtNmax.Text = "20";
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
