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
    public partial class ChooseClass : Form
    {

        public bool isWarrior;
        public bool isRogue;
        public bool isWizard;

        public ChooseClass()
        {
            InitializeComponent();
        }

        private void btnSelectWarrior_Click(object sender, EventArgs e)
        {
            isWarrior = true;
            isRogue = false;
            isWizard = false;
        }

        private void btnSelectRogue_Click(object sender, EventArgs e)
        {
            isWarrior = false;
            isRogue = true;
            isWizard = false;
        }

        private void btnSelectWizard_Click(object sender, EventArgs e)
        {
            isWarrior = false;
            isRogue = false;
            isWizard = true;
        }

        private void ChooseClass_Load(object sender, EventArgs e)
        {
               
        }
     }
}
