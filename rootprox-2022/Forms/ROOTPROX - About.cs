using rootprox_2022.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rootprox_2022.Forms
{
    public partial class ROOTPROX_About : Form
    {
        public ROOTPROX_About(string currentTheme)
        {
            ColorsTheme.ChooseTheme(currentTheme);

            InitializeComponent();

            switch (currentTheme)
            {
                case "Default":
                    
                    break;
                case "Red":
                    
                    break;
                case "Green":
                    
                    break;
                case "Purple":
                    
                    break;
            }
        }

        private void ROOTPROX_About_Load(object sender, EventArgs e)
        {
            panelP1.BackColor = ColorsTheme.PanelContainerLeft;
            panelP2.BackColor = ColorsTheme.PanelContainerLeft;

            linkJohnyDeCoder.LinkColor = ColorsTheme.LinkColor;
            linkJohnyDeCoder.ActiveLinkColor = ColorsTheme.ActiveLinkColor;
            linkJohnyDeCoder.VisitedLinkColor = ColorsTheme.VisitedLinkColor;

            linkBrandonMoran11.LinkColor = ColorsTheme.LinkColor;
            linkBrandonMoran11.ActiveLinkColor = ColorsTheme.ActiveLinkColor;
            linkBrandonMoran11.VisitedLinkColor = ColorsTheme.VisitedLinkColor;
        }

        private void linkJohnyDeCoder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkJohnyDeCoder.LinkVisited = true;

            using (Process compiler = new Process())
            {
                compiler.StartInfo.FileName = "https://github.com/JohnyDeCoder";
                compiler.StartInfo.UseShellExecute = true;
                compiler.Start();
            }
        }

        private void linkBrandonMoran11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkBrandonMoran11.LinkVisited = true;

            using (Process compiler = new Process())
            {
                compiler.StartInfo.FileName = "https://github.com/BrandonMoran11";
                compiler.StartInfo.UseShellExecute = true;
                compiler.Start();
            }
        }
    }
}
