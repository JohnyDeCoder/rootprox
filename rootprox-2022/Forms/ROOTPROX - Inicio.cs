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
using FontAwesome.Sharp;

namespace rootprox_2022
{
    public partial class ROOTPROX_Inicio : Form
    {
        // Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm;

        public ROOTPROX_Inicio()
        {
            InitializeComponent();

            customizeSubMenus();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
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
        }

        #region Controles
        // Controls

        private void panelLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnMethods_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMethods);

            activateBtn(sender);
        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.ROOTPROX_Bisección());

            hideSubMenu();
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.ROOTPROX_Secante());

            hideSubMenu();
        }

        private void btnReglaFalsa_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.ROOTPROX_Regla_Falsa());

            hideSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuHelp);

            activateBtn(sender);
        }

        private void btnGuia_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            hideSubMenu();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuTheme);

            activateBtn(sender);
        }

        private void btnBlueTheme_Click(object sender, EventArgs e)
        {
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

            hideSubMenu();
            Reset();
        }

        private void btnRedTheme_Click(object sender, EventArgs e)
        {
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

            hideSubMenu();
            Reset();
        }

        private void btnGreenTheme_Click(object sender, EventArgs e)
        {
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

            hideSubMenu();
            Reset();
        }

        private void btnPurpleTheme_Click(object sender, EventArgs e)
        {
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
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

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
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            disableBtn();
            leftBorderBtn.Visible = false;
        }
        #endregion
    }

}
