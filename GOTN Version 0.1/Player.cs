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
        private string playerClass;     // The class of the player
        private string className;       // Name of the class
        private int maxWeaponType;      // Maximum weapon type the class can use
        private int maxArmourType;      // Maximum armour type the class can use
        private int maxMagicType;       // Maximum magic type the class can use

        /* Methods: fight, move, start, quit, die, pickupItem, equipItem, useHealthPotion, 
        * useManaPotion, pickClass, openDoor, useMagic, useInventory
        * 
        * METHODS GO HERE
        */
    }
}
