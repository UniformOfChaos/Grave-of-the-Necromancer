using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    // Create player class, with all their stats and attributes
    class Player
    {
        //Stats
        private static int playerHealth;      // Health Stat
        private static int playerMana;        // Mana Stat

        //Skills
        private static int playerBody;        // Body Skill
        private static int playerMind;        // Mind Skill

        //Misc
        private static int playerAC;          // Player's Armour Class, AC
        private static int equippedArmour; // Currently Equipped Armour
        private static int equippedMain;   // What is currently equipped in player's main hand
        private static int equippedOff;    // What is currently equipped in player's off hand (weapon or shield)
        private static bool canUseShield;     // Whether the player can use a shield, depends on equipment, class etc.
        private static int healthPotions;     // Number of health potions in inventory.
        private static int manaPotions;       // Number of mana potions in inventory

        // Player's class-defined variables (not code class, in-game class. Don't get confused...)
        private static int playerClass;     // The class of the player in game (1: Warrior, 2: Rogue, 3: Wizard)
        private static int maxWeaponType;      // Maximum weapon type the class can use
        private static int maxArmourType;      // Maximum armour type the class can use
        private static int maxMagicType;// Maximum magic type the class can use

        public const int INV_SLOTS = 16; // number of inventory slots the player has

        public static string[] playerAttributes = new string[9]; // Creates an array to store the player's attributes


        //Player Creation
        public static void CreatePlayer(int chosenClass)
        {
            // Create instance of player
            Player playerChar = new Player();

            // Selects the player's class
            switch (chosenClass)
            {
                case 1:
                    {
                        //Initial Warrior Attributes
                        playerClass = 1;
                        playerHealth = 200;
                        playerMana = 100;
                        playerBody = 20;
                        playerMind = 10;
                        maxWeaponType = 5;
                        maxArmourType = 5;
                        maxMagicType = 1;
                        canUseShield = true;

                        // Starting Equipment
                        
                        break;
                    }
                case 2:
                    {
                        //Initial Rogue Attributes
                        playerClass = 1;
                        playerHealth = 150;
                        playerMana = 150;
                        playerBody = 15;
                        playerMind = 15;
                        maxWeaponType = 3;
                        maxArmourType = 3;
                        maxMagicType = 3;
                        canUseShield = true;

                        // Starting Equipment

                        break;
                    }
                case 3:
                    {
                        //Initial Wizard Attributes
                        playerClass = 3;
                        playerHealth = 100;
                        playerMana = 200;
                        playerBody = 10;
                        playerMind = 20;
                        playerClass = 3;
                        canUseShield = false;

                        // Starting Equipment

                        break;
                    }
            }

            //put the Attributes into an array
            playerAttributes[0] = playerClass.ToString();
            playerAttributes[1] = playerHealth.ToString();
            playerAttributes[2] = playerMana.ToString();
            playerAttributes[3] = playerBody.ToString();
            playerAttributes[4] = playerMind.ToString();
            playerAttributes[5] = maxWeaponType.ToString();
            playerAttributes[6] = maxArmourType.ToString();
            playerAttributes[7] = maxMagicType.ToString();
            playerAttributes[8] = canUseShield.ToString();
        }

    }
}

        
        