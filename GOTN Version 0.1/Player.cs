using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOTN_Version_0._1
{
    // Create player class, with all their stats and attributes
    class Player
    {
        //Stats
        private int playerHealth;      // Health Stat
        private int playerMana;        // Mana Stat

        //Skills
        private int playerBody;        // Body Skill
        private int playerMind;        // Mind Skill

        //Misc
        private int playerAC;          // Player's Armour Class, AC
        private string equippedArmour; // Currently Equipped Armour
        private string equippedMain;   // What is currently equipped in player's main hand
        private string equippedOff;    // What is currently equipped in player's off hand (weapon or shield)
        private bool canUseShield;     // Whether the player can use a shield, depends on equipment, class etc.
        private int healthPotions;     // Number of health potions in inventory.
        private int manaPotions;       // Number of mana potions in inventory

        // Player's class-defined variables (not code class, in-game class. Don't get confused...)
        private string playerClass;     // The class of the player in game
        private int maxWeaponType;      // Maximum weapon type the class can use
        private int maxArmourType;      // Maximum armour type the class can use
        private int maxMagicType;       // Maximum magic type the class can use

        //constructor
        public Player(int pHealth, int pMana, int pBody, int pMind, int pAC, string pEquippedArmour, string pEquippedMain, string pEquippedOff, bool pCanUseShield, int pHealthPotions, int pManaPotions, string pClass, int pMaxWeaponType, int pMaxArmourType, int pMaxMagicType)
        {
            // Creates an object 'Player' and assigns what will be the public variables to it. I think.
            // Class will determine starting values for most of these
            this.playerHealth = pHealth;
            this.playerMana = pMana;
            this.playerBody = pBody;
            this.playerMind = pMind;
            this.playerAC = pAC;
            this.equippedArmour = pEquippedArmour;
            this.equippedMain = pEquippedMain;
            this.equippedOff = pEquippedOff;
            this.canUseShield = pCanUseShield;
            this.healthPotions = pHealthPotions;
            this.manaPotions = pManaPotions;
            this.playerClass = pClass;
            this.maxWeaponType = pMaxWeaponType;
            this.maxArmourType = pMaxArmourType;
            this.maxMagicType = pMaxMagicType;
        }

        /*This detects which class button has been pressed on ChooseClass
        
        pickClass(return bool isWarrior OR return bool isRogue OR return bool isWizard);
        {
            if(isWarrior = true)
            {
                //Player will be a warrior, so gets the warrior starting attributes
                //Health 200
                //Mana 100
                //Body 20
                //Mind 10
                //Max Weapon Type 5
                //Max Armour Type 5
                //Max Magic Type 1

                // Properties - needed to access the private attributes
                public int pHealth
                {
                    get { return pHealth; }
                    set { pHealth = 200; }
                }

                public int pMana 
                {
                    get { return pMana; }
                    set { pMana = 100; }
                }

                public int pBody
                {
                    get { return pBody; }
                    set { pBody = 20; }
                }

                public int pMind
                {
                    get { return pMind; }
                    set { pMind = 10; }
                }
            
                public int pMaxWeaponType
                {
                    get { return pMaxWeaponType; }
                    set { pMaxWeaponType = 5; }
                }

                public int pMaxArmourType
                {
                    get { return pMaxArmourType; }
                    set { pMaxArmourType = 5; }
                }

                public int pMaxMagicType
                {
                    get { return pMaxMagicType; }
                    set { pMaxMagicType = 1; }
                }
            }
        }
    */
    }
}
