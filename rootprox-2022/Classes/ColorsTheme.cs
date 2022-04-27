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

        public static Color PanelContainerLeft;
        public static Color PanelChildForm;
        public static Color PanelSubMenu;
        public static Color PrimaryFont;

        // Default Colors
        private static readonly Color PanelContainerLeftD = Color.FromArgb(76, 137, 199); // E
        private static readonly Color PanelChildFormD = Color.FromArgb(171, 211, 251); // B
        private static readonly Color PanelSubMenuD = Color.FromArgb(47, 84, 122); // A
        private static readonly Color PrimaryFontD = Color.White;

        #region -> Methods
        public static void ChooseTheme(string Theme)
        {
            switch (Theme)
            {
                case "Default":
                    PanelContainerLeft = PanelContainerLeftD;
                    PanelChildForm = PanelChildFormD;
                    PanelSubMenu = PanelSubMenuD;
                    PrimaryFont = PrimaryFontD;
                    break;
            }
        }
        #endregion
    }
}
