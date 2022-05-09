using rootprox_2022.Classes;
using rootprox_2022.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Diagnostics;

namespace rootprox_2022
{
    public partial class ROOTPROX_Inicio : Form
    {
        // Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm;
        private string currentTheme;

        public ROOTPROX_Inicio()
        {
            InitializeComponent();

            customizeSubMenus();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 45);
            panelContainerLeft.Controls.Add(leftBorderBtn);
        }

        private void ROOTPROX_Inicio_Load(object sender, EventArgs e)
        {
            ColorsTheme.ChooseTheme("Default");
            // Left Panel
            panelContainerLeft.BackColor = ColorsTheme.PanelContainerLeft;

            // Child Form
            panelForm.BackColor = ColorsTheme.PanelChildForm;

            //SubMenus
            panelSubMenuMethods.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuHelp.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuTheme.BackColor = ColorsTheme.PanelSubMenu;

            // Buttons Font
            btnMethods.ForeColor = ColorsTheme.PrimaryFont; // Methods Button
            btnBiseccion.ForeColor = ColorsTheme.PrimaryFont;
            btnSecante.ForeColor = ColorsTheme.PrimaryFont;
            btnReglaFalsa.ForeColor = ColorsTheme.PrimaryFont;
            btnAyuda.ForeColor = ColorsTheme.PrimaryFont; // Help Button
            btnGuia.ForeColor = ColorsTheme.PrimaryFont;
            btnAbout.ForeColor = ColorsTheme.PrimaryFont;
            btnTheme.ForeColor = ColorsTheme.PrimaryFont; // Theme Button
            btnBlueTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnRedTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnGreenTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnPurpleTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnTags.ForeColor = ColorsTheme.PrimaryFont; // Tags Button
            btnExit.ForeColor = ColorsTheme.PrimaryFont; // Exit Button

            // Labels
            lblVersion.ForeColor = ColorsTheme.PanelSubMenu;
            lblHora.ForeColor = ColorsTheme.PanelSubMenu;
            lblFecha.ForeColor = ColorsTheme.PanelContainerLeft;
        }

        #region Controles
        // Controls

        private void ROOTPROX_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnMethods_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMethods);

            activateBtn(sender);
        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            if (Text != "ROOTPROX - Bisección")
            {
                openChildForm(new ROOTPROX_Bisección(currentTheme));
            }

            hideSubMenu();
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {
            if (Text != "ROOTPROX - Secante")
            {
                openChildForm(new ROOTPROX_Secante(currentTheme));
            }

            hideSubMenu();
        }

        private void btnReglaFalsa_Click(object sender, EventArgs e)
        {
            if (Text != "ROOTPROX - Regla Falsa")
            {
                openChildForm(new ROOTPROX_Regla_Falsa(currentTheme));
            }

            hideSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuHelp);

            activateBtn(sender);
        }

        private void btnGuia_Click(object sender, EventArgs e)
        {
            using (Process compiler = new Process())
            {
                compiler.StartInfo.FileName = "https://github.com/JohnyDeCoder/rootprox#guía-de-uso";
                compiler.StartInfo.UseShellExecute = true;
                compiler.Start();
            }

            hideSubMenu();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            hideSubMenu();

            Form ROOTPROX_About = new ROOTPROX_About(currentTheme);
            ROOTPROX_About.ShowDialog();

            Reset();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            using (Process compiler = new Process())
            {
                compiler.StartInfo.FileName = "https://github.com/JohnyDeCoder/rootprox/tags";
                compiler.StartInfo.UseShellExecute = true;
                compiler.Start();
            }

            hideSubMenu();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuTheme);

            activateBtn(sender);
        }

        private void btnBlueTheme_Click(object sender, EventArgs e)
        {
            currentTheme = "Default";
            ColorsTheme.ChooseTheme("Default");

            // Left Panel
            panelContainerLeft.BackColor = ColorsTheme.PanelContainerLeft;

            btnMethods.BackColor = ColorsTheme.PanelContainerLeft;
            btnAyuda.BackColor = ColorsTheme.PanelContainerLeft;
            btnTheme.BackColor = ColorsTheme.PanelContainerLeft;
            btnTags.BackColor = ColorsTheme.PanelContainerLeft;
            btnExit.BackColor = ColorsTheme.PanelContainerLeft;

            // Child Form
            panelForm.BackColor = ColorsTheme.PanelChildForm;

            //SubMenus
            panelSubMenuMethods.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuHelp.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuTheme.BackColor = ColorsTheme.PanelSubMenu;

            // Buttons Font
            btnMethods.ForeColor = ColorsTheme.PrimaryFont; // Methods Button
            btnBiseccion.ForeColor = ColorsTheme.PrimaryFont;
            btnSecante.ForeColor = ColorsTheme.PrimaryFont;
            btnReglaFalsa.ForeColor = ColorsTheme.PrimaryFont;
            btnAyuda.ForeColor = ColorsTheme.PrimaryFont; // Help Button
            btnGuia.ForeColor = ColorsTheme.PrimaryFont;
            btnAbout.ForeColor = ColorsTheme.PrimaryFont;
            btnTheme.ForeColor = ColorsTheme.PrimaryFont; // Theme Button
            btnBlueTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnRedTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnGreenTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnPurpleTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnTags.ForeColor = ColorsTheme.PrimaryFont; // Tags Button
            btnExit.ForeColor = ColorsTheme.PrimaryFont; // Exit Button

            // Labels
            lblVersion.ForeColor = ColorsTheme.PanelSubMenu;
            lblHora.ForeColor = ColorsTheme.PanelSubMenu;
            lblFecha.ForeColor = ColorsTheme.PanelContainerLeft;

            hideSubMenu();
            Reset();
        }

        private void btnRedTheme_Click(object sender, EventArgs e)
        {
            currentTheme = "Red";
            ColorsTheme.ChooseTheme("Red");

            // Left Panel
            panelContainerLeft.BackColor = ColorsTheme.PanelContainerLeft;

            btnMethods.BackColor = ColorsTheme.PanelContainerLeft;
            btnAyuda.BackColor = ColorsTheme.PanelContainerLeft;
            btnTheme.BackColor = ColorsTheme.PanelContainerLeft;
            btnTags.BackColor = ColorsTheme.PanelContainerLeft;
            btnExit.BackColor = ColorsTheme.PanelContainerLeft;

            // Child Form
            panelForm.BackColor = ColorsTheme.PanelChildForm;

            //SubMenus
            panelSubMenuMethods.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuHelp.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuTheme.BackColor = ColorsTheme.PanelSubMenu;

            // Buttons Font
            btnMethods.ForeColor = ColorsTheme.PrimaryFont; // Methods Button
            btnBiseccion.ForeColor = ColorsTheme.PrimaryFont;
            btnSecante.ForeColor = ColorsTheme.PrimaryFont;
            btnReglaFalsa.ForeColor = ColorsTheme.PrimaryFont;
            btnAyuda.ForeColor = ColorsTheme.PrimaryFont; // Help Button
            btnGuia.ForeColor = ColorsTheme.PrimaryFont;
            btnAbout.ForeColor = ColorsTheme.PrimaryFont;
            btnTheme.ForeColor = ColorsTheme.PrimaryFont; // Theme Button
            btnBlueTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnRedTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnGreenTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnPurpleTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnTags.ForeColor = ColorsTheme.PrimaryFont; // Tags Button
            btnExit.ForeColor = ColorsTheme.PrimaryFont; // Exit Button

            // Labels
            lblVersion.ForeColor = ColorsTheme.PanelSubMenu;
            lblHora.ForeColor = ColorsTheme.PanelSubMenu;
            lblFecha.ForeColor = ColorsTheme.PanelContainerLeft;

            hideSubMenu();
            Reset();
        }

        private void btnGreenTheme_Click(object sender, EventArgs e)
        {
            currentTheme = "Green";
            ColorsTheme.ChooseTheme("Green");

            // Left Panel
            panelContainerLeft.BackColor = ColorsTheme.PanelContainerLeft;

            btnMethods.BackColor = ColorsTheme.PanelContainerLeft;
            btnAyuda.BackColor = ColorsTheme.PanelContainerLeft;
            btnTheme.BackColor = ColorsTheme.PanelContainerLeft;
            btnTags.BackColor = ColorsTheme.PanelContainerLeft;
            btnExit.BackColor = ColorsTheme.PanelContainerLeft;

            // Child Form
            panelForm.BackColor = ColorsTheme.PanelChildForm;

            //SubMenus
            panelSubMenuMethods.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuHelp.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuTheme.BackColor = ColorsTheme.PanelSubMenu;

            // Buttons Font
            btnMethods.ForeColor = ColorsTheme.PrimaryFont; // Methods Button
            btnBiseccion.ForeColor = ColorsTheme.PrimaryFont;
            btnSecante.ForeColor = ColorsTheme.PrimaryFont;
            btnReglaFalsa.ForeColor = ColorsTheme.PrimaryFont;
            btnAyuda.ForeColor = ColorsTheme.PrimaryFont; // Help Button
            btnGuia.ForeColor = ColorsTheme.PrimaryFont;
            btnAbout.ForeColor = ColorsTheme.PrimaryFont;
            btnTheme.ForeColor = ColorsTheme.PrimaryFont; // Theme Button
            btnBlueTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnRedTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnGreenTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnPurpleTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnTags.ForeColor = ColorsTheme.PrimaryFont; // Tags Button
            btnExit.ForeColor = ColorsTheme.PrimaryFont; // Exit Button

            // Labels
            lblVersion.ForeColor = ColorsTheme.PanelSubMenu;
            lblHora.ForeColor = ColorsTheme.PanelSubMenu;
            lblFecha.ForeColor = ColorsTheme.PanelContainerLeft;

            hideSubMenu();
            Reset();
        }

        private void btnPurpleTheme_Click(object sender, EventArgs e)
        {
            currentTheme = "Purple";
            ColorsTheme.ChooseTheme("Purple");

            // Left Panel
            panelContainerLeft.BackColor = ColorsTheme.PanelContainerLeft;

            btnMethods.BackColor = ColorsTheme.PanelContainerLeft;
            btnAyuda.BackColor = ColorsTheme.PanelContainerLeft;
            btnTheme.BackColor = ColorsTheme.PanelContainerLeft;
            btnTags.BackColor = ColorsTheme.PanelContainerLeft;
            btnExit.BackColor = ColorsTheme.PanelContainerLeft;

            // Child Form
            panelForm.BackColor = ColorsTheme.PanelChildForm;

            //SubMenus
            panelSubMenuMethods.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuHelp.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuTheme.BackColor = ColorsTheme.PanelSubMenu;

            // Buttons Font
            btnMethods.ForeColor = ColorsTheme.PrimaryFont; // Methods Button
            btnBiseccion.ForeColor = ColorsTheme.PrimaryFont;
            btnSecante.ForeColor = ColorsTheme.PrimaryFont;
            btnReglaFalsa.ForeColor = ColorsTheme.PrimaryFont;
            btnAyuda.ForeColor = ColorsTheme.PrimaryFont; // Help Button
            btnGuia.ForeColor = ColorsTheme.PrimaryFont;
            btnAbout.ForeColor = ColorsTheme.PrimaryFont;
            btnTheme.ForeColor = ColorsTheme.PrimaryFont; // Theme Button
            btnBlueTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnRedTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnGreenTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnPurpleTheme.ForeColor = ColorsTheme.PrimaryFont;
            btnTags.ForeColor = ColorsTheme.PrimaryFont; // Tags Button
            btnExit.ForeColor = ColorsTheme.PrimaryFont; // Exit Button

            // Labels
            lblVersion.ForeColor = ColorsTheme.PanelSubMenu;
            lblHora.ForeColor = ColorsTheme.PanelSubMenu;
            lblFecha.ForeColor = ColorsTheme.PanelContainerLeft;

            hideSubMenu();
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Métodos
        // Methods

        private void customizeSubMenus()
        {
            panelSubMenuMethods.Visible = false;
            panelSubMenuHelp.Visible = false;
            panelSubMenuTheme.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuHelp.Visible == true)
            {
                panelSubMenuHelp.Visible = false;
            }
            if (panelSubMenuMethods.Visible == true)
            {
                panelSubMenuMethods.Visible = false;
            }
            if (panelSubMenuTheme.Visible == true)
            {
                panelSubMenuTheme.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            Text = childForm.Text;
            childForm.Show();
        }

        private void activateBtn(object senderBtn)
        {
            if (senderBtn != null)
            {
                disableBtn();

                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = ColorsTheme.btnActivated;
                currentBtn.ForeColor = ColorsTheme.PrimaryFontSelected;
                currentBtn.IconColor = ColorsTheme.PrimaryFontSelected;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                // Left border button
                leftBorderBtn.BackColor = ColorsTheme.leftBorderButton;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void disableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = ColorsTheme.PanelContainerLeft;
                currentBtn.ForeColor = ColorsTheme.PrimaryFont;
                currentBtn.IconColor = ColorsTheme.PrimaryFont;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Text = "ROOTPROX - Inicio";
            }
            disableBtn();
            leftBorderBtn.Visible = false;
        }
        #endregion
    }
}
