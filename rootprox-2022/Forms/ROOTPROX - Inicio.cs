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

namespace rootprox_2022
{
    public partial class ROOTPROX_Inicio : Form
    {
        public ROOTPROX_Inicio()
        {
            InitializeComponent();

            customizeSubMenus();
        }

        private void ROOTPROX_Inicio_Load(object sender, EventArgs e)
        {
            ColorsTheme.ChooseTheme("Default");
            panelContainerLeft.BackColor = ColorsTheme.PanelContainerLeft;
            panelForm.BackColor = ColorsTheme.PanelChildForm;
            panelSubMenuHelp.BackColor = ColorsTheme.PanelSubMenu;
            btnBiseccion.ForeColor = ColorsTheme.PrimaryFont;
            btnAyuda.ForeColor = ColorsTheme.PrimaryFont;
            btnBiseccion.ForeColor = ColorsTheme.PrimaryFont;
            btnAbout.ForeColor = ColorsTheme.PrimaryFont;
            btnTags.ForeColor = ColorsTheme.PrimaryFont;
            btnExit.ForeColor = ColorsTheme.PrimaryFont;
        }

        // Controls

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {


            hideSubMenu();
        }

        private void btnMethods_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMethods);
        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.ROOTPROX_Bisección());

            hideSubMenu();
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnSustitucion_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuHelp);
        }

        private void btnGuia_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        // Methods

        private void customizeSubMenus()
        {
            panelSubMenuMethods.Visible = false;
            panelSubMenuHelp.Visible = false;
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

        private Form activeForm = null;
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
    }
}
