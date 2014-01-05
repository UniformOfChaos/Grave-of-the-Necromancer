using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWindow
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GOTN_GameWindow_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            
        }

        private void bodyLabel_Click(object sender, EventArgs e)
        {

        }

        private void manaLabel_Click(object sender, EventArgs e)
        {

        }

        private void healthLabel_Click(object sender, EventArgs e)
        {

        }

        private void tsNewGame_Click(object sender, EventArgs e)
        {
            // Open the Choose Class form
            ChooseClass chooseClass = new ChooseClass();
            chooseClass.Show();
            chooseClass.Enabled = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
