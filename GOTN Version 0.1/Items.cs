using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOTN_Version_0._1
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
        private int weaponDamage; // For shields this is zero
        public string weaponType; // Staff, Dagger, Sword, Shield, Greatsword, possibly axes and maces too, later on.
        private int SAC; // Shield Armour Class, shields are the only instances where this is not zero.

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
        private int amount; // Amount restored by potion.

        // Methods: usedPotion
        // METHODS GO HERE
    }

    class HealthPotion
    {
        // Health potions go here
        // restorePlayerHealth: calls system class method to restore player's health
    }

    class HealthPotion
    {
        // Mana potions go here
        //restorePlayerMana(); // calls system class method to restore player's mana
    }
    
}
