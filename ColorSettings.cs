using Game2024.Classes;
using Game2048;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2024
{
    public partial class ColorSettings : Form
    {
        public ColorSettings()
        {
            InitializeComponent();
        }
        void SetControlsColors()
        {
            L_Info_SelectColor.ForeColor = ColorMethods.BackColor;
            BackColor = ColorMethods.ForeColor;

            BS_CS_Select_BackColor.BackColor = ColorMethods.BackColor;
            BS_CS_Select_BackColor.FlatAppearance.BorderColor = ColorMethods.ForeColor;
            BS_CS_Select_BackColor.ForeColor = ColorMethods.ForeColor;

            BS_CS_Select_TextColor.BackColor = ColorMethods.BackColor;
            BS_CS_Select_TextColor.ForeColor = ColorMethods.ForeColor;
            BS_CS_Select_TextColor.FlatAppearance.BorderColor = ColorMethods.ForeColor;
        }
        private void ColorSettings_Load(object sender, EventArgs e)
        {
            L_Info_SelectColor.Location = new Point((Width - L_Info_SelectColor.Width) / 2, L_Info_SelectColor.Location.Y);
            SetControlsColors();
        }

        private void BS_CS_Select_BackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog CD_Back = new ColorDialog())
            {
                if (CD_Back.ShowDialog() == DialogResult.OK)
                {
                    ColorMethods.BackColor = CD_Back.Color;
                }
            }
            SetControlsColors();
        }

        private void BS_CS_Select_TextColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog CD_Fore = new ColorDialog())
            {
                if (CD_Fore.ShowDialog() == DialogResult.OK)
                {
                    ColorMethods.ForeColor = CD_Fore.Color;
                }
            }
            SetControlsColors();
        }
    }
}
