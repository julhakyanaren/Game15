using Game2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
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

        private void BS_GF_ColorSetting_Click(object sender, EventArgs e)
        {
            ColorSettings csf = new ColorSettings();
            csf.Show();
        }
    }
}
