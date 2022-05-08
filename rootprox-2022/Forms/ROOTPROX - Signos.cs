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

namespace rootprox_2022.Forms
{
    public partial class ROOTPROX_Signos : Form
    {
        // Campos
        public string currentFormReceived;

        public ROOTPROX_Signos(string currentForm)
        {
            currentFormReceived = currentForm; // Recibe el nombre del formulario padre

            InitializeComponent();
        }
        private void ROOTPROX_Signos_Load(object sender, EventArgs e)
        {
            
        }

        // Controls
        private void printSign(string sign)
        {
            switch (currentFormReceived)
            {
                case "ROOTPROX_Bisección":
                    // Crea la instancia como un rol
                    ROOTPROX_Bisección formMethodBi = Owner as ROOTPROX_Bisección;
                    formMethodBi.txtFX.Text += sign;
                    break;
                case "ROOTPROX_Secante":
                    // Crea la instancia como un rol
                    ROOTPROX_Secante formMethodSe = Owner as ROOTPROX_Secante;
                    formMethodSe.txtFX.Text += sign;
                    break;
                case "ROOTPROX_Regla_Falsa":
                    // Crea la instancia como un rol
                    ROOTPROX_Bisección formMethodReFa = Owner as ROOTPROX_Bisección;
                    formMethodReFa.txtFX.Text += sign;
                    break;
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            printSign("+");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            printSign("-");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            printSign("*");
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            printSign("/");
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            printSign("√(x)");
        }

        private void btnParen1_Click(object sender, EventArgs e)
        {
            printSign("(");
        }

        private void btnParen2_Click(object sender, EventArgs e)
        {
            printSign(")");
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            printSign("^");
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            printSign("sin(x)");
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            printSign("cos(x)");
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            printSign("tan(x)");
        }

        private void btnArcSin_Click(object sender, EventArgs e)
        {
            printSign("sin⁻¹(x)");
        }

        private void btnArcCos_Click(object sender, EventArgs e)
        {
            printSign("cos⁻¹(x)");
        }

        private void btnArcTan_Click(object sender, EventArgs e)
        {
            printSign("tan⁻¹(x)");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            printSign("log(x)");
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            printSign("ln(x)");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            printSign("ℯ");
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            printSign("π");
        }
    }
}
