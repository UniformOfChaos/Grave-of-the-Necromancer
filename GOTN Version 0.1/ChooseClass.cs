using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Player;

namespace GameWindow
{
    public partial class ChooseClass : Form
    {

        public ChooseClass()
        {
            InitializeComponent();
        }

        private void btnSelectWarrior_Click(object sender, EventArgs e)
        {
            Player.Player.CreatePlayer(1);
            DisplayPlayerAttributes();

        }

        private void btnSelectRogue_Click(object sender, EventArgs e)
        {
            Player.Player.CreatePlayer(2);
            DisplayPlayerAttributes();
        }

        private void btnSelectWizard_Click(object sender, EventArgs e)
        {
            Player.Player.CreatePlayer(3);
            DisplayPlayerAttributes();
        }

        private void ChooseClass_Load(object sender, EventArgs e)
        {
               
        }

        void DisplayPlayerAttributes()
        {
            for (int i = 0; i < 9; i++)
            {
                MessageBox.Show(Player.Player.playerAttributes[i]);
            }
        }
     }
}
