using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootprox_2022.Classes
{
    class ColorsTheme
    {

        public static Color PanelContainerLeft; // Color del panel general principal
        public static Color PanelChildForm; // Color del background de los formularios
        public static Color PanelSubMenu; // Color del submenu principal
        public static Color PrimaryFont; // Color del texto
        public static Color PrimaryFontSelected; // Color del texto seleccionado
        public static Color leftBorderButton; // Color del borde izquierdo del botón seleccionado
        public static Color btnActivated; // Color del botón seleccionado

        // Default Colors
        private static readonly Color PanelContainerLeftD = Color.FromArgb(76, 137, 199); // E
        private static readonly Color PanelChildFormD = Color.FromArgb(171, 211, 251); // B
        private static readonly Color PanelSubMenuD = Color.FromArgb(47, 84, 122); // A
        private static readonly Color PrimaryFontD = Color.White;
        private static readonly Color PrimaryFontSelectedD = Color.White;
        private static readonly Color leftBorderButtonD = Color.FromArgb(83, 103, 122); // D
        private static readonly Color btnActivatedD = Color.FromArgb(94, 172, 250); // C

        // Red Theme
        private static readonly Color PanelContainerLeftR = Color.FromArgb(179, 52, 37); // E
        private static readonly Color PanelChildFormR = Color.FromArgb(234, 131, 119); // B
        private static readonly Color PanelSubMenuR = Color.FromArgb(122, 35, 26); // A
        private static readonly Color PrimaryFontR = Color.White;
        private static readonly Color PrimaryFontSelectedR = Color.White;
        private static readonly Color leftBorderButtonR = Color.FromArgb(102, 57, 52); // D
        private static readonly Color btnActivatedR = Color.FromArgb(230, 66, 48); // C

        // Green Theme
        private static readonly Color PanelContainerLeftG = Color.FromArgb(82, 194, 70); // E
        private static readonly Color PanelChildFormG = Color.FromArgb(171, 247, 163); // B
        private static readonly Color PanelSubMenuG = Color.FromArgb(50, 177, 42); // A
        private static readonly Color PrimaryFontG = Color.White;
        private static readonly Color PrimaryFontSelectedG = Color.Black;
        private static readonly Color leftBorderButtonG = Color.FromArgb(81, 117, 77); // D
        private static readonly Color btnActivatedG = Color.FromArgb(105, 245, 89); // C

        // Purple Theme
        private static readonly Color PanelContainerLeftP = Color.FromArgb(158, 88, 199); // E
        private static readonly Color PanelChildFormP = Color.FromArgb(227, 186, 251); // B
        private static readonly Color PanelSubMenuP = Color.FromArgb(97, 54, 122); // A
        private static readonly Color PrimaryFontP = Color.White;
        private static readonly Color PrimaryFontSelectedP = Color.White;
        private static readonly Color leftBorderButtonP = Color.FromArgb(111, 91, 122); // D
        private static readonly Color btnActivatedP = Color.FromArgb(198, 109, 250); // C

        #region Methods
        public static void ChooseTheme(string Theme)
        {
            switch (Theme)
            {
                case "Default":
                    PanelContainerLeft = PanelContainerLeftD;
                    PanelChildForm = PanelChildFormD;
                    PanelSubMenu = PanelSubMenuD;
                    PrimaryFont = PrimaryFontD;
                    PrimaryFontSelected = PrimaryFontSelectedD;
                    leftBorderButton = leftBorderButtonD;
                    btnActivated = btnActivatedD;
                    break;
                case "Red":
                    PanelContainerLeft = PanelContainerLeftR;
                    PanelChildForm = PanelChildFormR;
                    PanelSubMenu = PanelSubMenuR;
                    PrimaryFont = PrimaryFontR;
                    PrimaryFontSelected = PrimaryFontSelectedR;
                    leftBorderButton = leftBorderButtonR;
                    btnActivated = btnActivatedR;
                    break;
                case "Green":
                    PanelContainerLeft = PanelContainerLeftG;
                    PanelChildForm = PanelChildFormG;
                    PanelSubMenu = PanelSubMenuG;
                    PrimaryFont = PrimaryFontG;
                    PrimaryFontSelected = PrimaryFontSelectedG;
                    leftBorderButton = leftBorderButtonG;
                    btnActivated = btnActivatedG;
                    break;
                case "Purple":
                    PanelContainerLeft = PanelContainerLeftP;
                    PanelChildForm = PanelChildFormP;
                    PanelSubMenu = PanelSubMenuP;
                    PrimaryFont = PrimaryFontP;
                    PrimaryFontSelected = PrimaryFontSelectedP;
                    leftBorderButton = leftBorderButtonP;
                    btnActivated = btnActivatedP;
                    break;
            }
        }
        #endregion
    }
}
