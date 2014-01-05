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
using Items;
//using Level;

namespace Inventory
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        
    }

    class PlayerInventory
    {
        const int INV_SIZE = 15; // playerInv size limit = Inventory slots -1

        public Array[,] playerInv = new Array[INV_SIZE, INV_SIZE]; // Array for items in a player's inventory
        // Array values will be [itemAmount,itemName]

        // Set local variables
        public HealthPotion healthPotion = new HealthPotion();
        public ManaPotion manaPotion = new ManaPotion();
        public int itemAmount = 0; 

    }
}
