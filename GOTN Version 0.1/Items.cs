using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    // Create item class, which all other items derive from
    class Item
    {
        private int itemCode;
        private string itemName;
        private string itemType;

        // Methods: generateInLevel, pickedUp, dropped
        // METHODS GO HERE
    }

    class Weapon : Item
    {
        public static int weaponDamage = 0; // For shields this is zero
        public string weaponType = ""; // Staff, Dagger, Sword, Shield, Greatsword, possibly axes and maces too, later on.
        public static int SAC; // Shield Armour Class, shields are the only instances where this is not zero.
        // Might have to do shields as a separate array...
        public const int NUM_OF_WEAPONS = 22;

        public string wD = weaponDamage.ToString();
        public string[, ,] weaponArray = new string[NUM_OF_WEAPONS, NUM_OF_WEAPONS, NUM_OF_WEAPONS];

        //weaponArray[0,0,0] = this bit isn't behaving... 
        // Methods: equippedWeapon
        // METHODS GO HERE
    }

    class Armour : Item
    {
        private int AC;
        private string armourType; // Cloth, Leather, Metal

        // Methods: equippedArmour
        // METHODS GO HERE
    }

    class Potion : Item
    {
        private int amountRestored; // Amount restored by potion.

        // Methods: usedPotion()
        // METHODS GO HERE
    }

    class HealthPotion:Potion
    {
        // Health potions go here
        // restorePlayerHealth(): calls system class method to restore player's health
    }

    class ManaPotion:Potion
    {
        // Mana potions go here
        //restorePlayerMana(); // calls system class method to restore player's mana
    }
    
}
