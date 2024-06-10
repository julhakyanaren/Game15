using Game15.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Game15
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        void SetItemColors(ToolStripItem item)
        {
            if (item is ToolStripMenuItem menuItem)
            {
                menuItem.BackColor = ColorMethods.BackColor;
                menuItem.ForeColor = ColorMethods.ForeColor;
                foreach (ToolStripItem subItem in menuItem.DropDownItems)
                {
                    SetItemColors(subItem);
                }
            }
        }
        void SetMenuColors(ToolStrip menuStrip)
        {
            foreach (ToolStripItem item in menuStrip.Items)
            {
                SetItemColors(item);
            }
            TLP_GF_Main.BackColor = ColorMethods.BackColor;
            TLP_GF_Main.ForeColor = ColorMethods.ForeColor;
        }

        void SetComponentsColors()
        {
            Color back = ColorMethods.BackColor;
            Color text = ColorMethods.ForeColor;
            List<Control> controlsList = new List<Control>();

            foreach (Control control in TLP_GF_Board.Controls)
            {
                controlsList.Add(control);
            }
            foreach (Control control in TLP_GF_Main.Controls)            
            {
                controlsList.Add(control);
            }
            foreach (Control control in PNL_GF_Control.Controls)
            {
                controlsList.Add(control);
            }
            controlsList.Add(MS_GF_Main);
            for (int l = 0; l < controlsList.Count; l++)
            {
                if (controlsList[l] is Panel)
                {
                    controlsList[l].BackColor = text;
                }
                else if (controlsList[l] is Label)
                {
                    controlsList[l].ForeColor = back;
                }
                else if (controlsList[l] is TextBox)
                {
                    controlsList[l].ForeColor = back;
                    controlsList[l].BackColor = text;
                }
                else
                {
                    controlsList[l].BackColor = back;
                    controlsList[l].ForeColor = text;
                }
            }
            SetMenuColors(MS_GF_Main);
            BackColor = back;
            ForeColor = text;
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            foreach (Button b in TLP_GF_Board.Controls)
            {
                if (b is  Button && b.Tag.ToString() == "0")
                {
                    b.Visible = false;
                }
            }
        }

        private void TSMI_ColorSettings_Back_Click(object sender, EventArgs e)
        {
            using (ColorDialog CD_Back = new ColorDialog())
            {
                if (CD_Back.ShowDialog() == DialogResult.OK)
                {
                    ColorMethods.BackColor = CD_Back.Color;
                }
            }
            SetComponentsColors();
        }

        private void TSMI_ColorSettings_Text_Click(object sender, EventArgs e)
        {
            using (ColorDialog CD_Text = new ColorDialog())
            {
                if (CD_Text.ShowDialog() == DialogResult.OK)
                {
                    ColorMethods.ForeColor = CD_Text.Color;
                }
            }
            SetComponentsColors();
        }

        private void TSMI_ColorSettings_Reverse_Click(object sender, EventArgs e)
        {
            Color tempBack = ColorMethods.BackColor;
            Color tempText = ColorMethods.ForeColor;
            ColorMethods.BackColor = tempText;
            ColorMethods.ForeColor = tempBack;
            SetComponentsColors();
        }

        private void TSMI_Main_AllwaysOnTop_Click(object sender, EventArgs e)
        {
            TopMost = TSMI_Main_AllwaysOnTop.Checked;
        }

        private void BS_GF_ApplyUsername_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to use \"{TB_GF_Username.Text}\" as a username?", "Game15", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.Username = TB_GF_Username.Text;
                TB_GF_Username.ReadOnly = true;
                BS_GF_ApplyUsername.Visible = false;
                BS_GF_PauseResume.Visible = true;
                TSMI_Main_Game.Enabled = true;
            }
        }
    }
}
