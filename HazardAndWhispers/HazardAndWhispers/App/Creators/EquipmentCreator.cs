using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Creators
{
    internal class EquipmentCreator
    {
        private int damageModifierA, damageModifierB;
        private int protectionModifierA, protectionModifierB;
        private int chanceModifierA, chanceModifierB;

        private int valueModifier;

        private string mageNamePrefix, warriorNamePrefix, assasinNamePrefix, paladinNamePrefix;

        public EquipmentCreator() { }

        public Equipment CreateEquipment(EquipmentLevel level, ClassType type)
        {
            /* Stat register parameters are scaled linear */
            /* y = Ax + B */
            /* e.g. damage = damageModifierA * damage + damageModifierB */

            switch (level)
            {
                case EquipmentLevel.Basic:
                    {
                        damageModifierA = 1;
                        damageModifierB = 0;
                        protectionModifierA = 1;
                        protectionModifierB = 0;
                        chanceModifierA = 1;
                        chanceModifierB = 0;
                        valueModifier = 0;
                        mageNamePrefix = "Acolyte";
                        warriorNamePrefix = "Recruit";
                        assasinNamePrefix = "Neophyte";
                        paladinNamePrefix = "Aspirant";
                        break;
                    }
                case EquipmentLevel.Intermediate:
                    {
                        damageModifierA = 1;
                        damageModifierB = 7;
                        protectionModifierA = 1;
                        protectionModifierB = 7;
                        chanceModifierA = 1;
                        chanceModifierB = 5;
                        valueModifier = 500;
                        mageNamePrefix = "Adept";
                        warriorNamePrefix = "Vanguard";
                        assasinNamePrefix = "Nightblade";
                        paladinNamePrefix = "Crusader";
                        break;
                    }
                case EquipmentLevel.Advanced:
                    {
                        damageModifierA = 2;
                        damageModifierB = 10;
                        protectionModifierA = 2;
                        protectionModifierB = 10;
                        chanceModifierA = 2;
                        chanceModifierB = 10;
                        valueModifier = 750;
                        mageNamePrefix = "Archmage";
                        warriorNamePrefix = "Warlord";
                        assasinNamePrefix = "Shadow Master";
                        paladinNamePrefix = "Holy Champion";
                        break;
                    }
            }

           switch (type) 
           {
                case ClassType.Mage:
                    {
                        /* Chest */
                        StatRegister chestStats = new()
                        {
                            DefensePoints = 5 * protectionModifierA + protectionModifierB,
                            MagicResistancePoints = 15 * protectionModifierA + protectionModifierB
                        };
                        EquipmentItem chest = new(mageNamePrefix + " Robe", valueModifier, chestStats, EquipmentType.Chest);
                        /* Head */
                        StatRegister headStats = new()
                        {
                            DefensePoints = 3 * protectionModifierA + protectionModifierB,
                            MagicResistancePoints = 3 * protectionModifierA + protectionModifierB
                        };
                        EquipmentItem head = new(mageNamePrefix + " Hat", valueModifier, headStats, EquipmentType.Head);
                        /* Legs */
                        StatRegister legsStats = new()
                        {
                            DodgeChance = 3 * chanceModifierA + chanceModifierB,
                            SpeedPoints = 2
                        };
                        EquipmentItem legs = new(mageNamePrefix + " Trousers", valueModifier, legsStats, EquipmentType.Legs);
                        /* Feet */
                        StatRegister feetStats = new()
                        {
                            SpeedPoints = 1,
                            DodgeChance = 1 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem feet = new(mageNamePrefix + " Boots", valueModifier, feetStats, EquipmentType.Feet);
                        /* Arms */
                        StatRegister armsStats = new()
                        {
                            AbilityPoints = 4 * damageModifierA + damageModifierB,
                            AttackDamage = 1 * damageModifierA + damageModifierB
                        };
                        EquipmentItem arms = new(mageNamePrefix + " Sleeves", valueModifier, armsStats, EquipmentType.Arms);
                        /* Hands */
                        StatRegister handsStats = new StatRegister
                        {
                            AttackDamage = 0 * damageModifierA + damageModifierB,
                            AbilityPoints = 3 * damageModifierA + damageModifierB,
                            CriticalStrikeChance = 3 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem hands = new(mageNamePrefix + " Gloves", valueModifier, handsStats, EquipmentType.Hands);
                        /* Weapon */
                        StatRegister weaponStats = new()
                        {
                            AttackDamage = 4 * damageModifierA + damageModifierB,
                            AbilityPoints = 8 * damageModifierA + damageModifierB,
                            CriticalStrikeChance = 2 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem weapon = new(mageNamePrefix + " Wand", valueModifier, weaponStats, EquipmentType.Weapon);

                        return new(head, chest, legs, arms, hands, feet, weapon);
                    }
                case ClassType.Warrior:
                    {
                        /* Chest */
                        StatRegister chestStats = new()
                        {
                            DefensePoints = 15 * protectionModifierA + protectionModifierB,
                            MagicResistancePoints = 10 * protectionModifierA + protectionModifierB
                        };
                        EquipmentItem chest = new(warriorNamePrefix + " Chestplate", valueModifier, chestStats, EquipmentType.Chest);
                        /* Head */
                        StatRegister headStats = new()
                        {
                            DefensePoints = 7 * protectionModifierA + protectionModifierB,
                            MagicResistancePoints = 7 * protectionModifierA + protectionModifierB
                        };
                        EquipmentItem head = new(warriorNamePrefix + " Helmet", valueModifier, headStats, EquipmentType.Head);
                        /* Legs */
                        StatRegister legsStats = new()
                        {
                            DodgeChance = 3 * chanceModifierA + chanceModifierB,
                            SpeedPoints = 1
                        };
                        EquipmentItem legs = new(warriorNamePrefix + " Trousers", valueModifier, legsStats, EquipmentType.Legs);
                        /* Feet */
                        StatRegister feetStats = new()
                        {
                            SpeedPoints = 0,
                            DodgeChance = 2 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem feet = new EquipmentItem(warriorNamePrefix + " Boots", valueModifier, feetStats, EquipmentType.Feet);
                        /* Arms */
                        StatRegister armsStats = new()
                        {
                            AbilityPoints = 1 * damageModifierA + damageModifierB,
                            AttackDamage = 3 * damageModifierA + damageModifierB
                        };
                        EquipmentItem arms = new(warriorNamePrefix + " Armplates", valueModifier, armsStats, EquipmentType.Arms);
                        /* Hands */
                        StatRegister handsStats = new()
                        {
                            AttackDamage = 3 * damageModifierA + damageModifierB,
                            AbilityPoints = 0 * damageModifierA + damageModifierB,
                            CriticalStrikeChance = 2 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem hands = new(warriorNamePrefix + " Gloves", valueModifier, handsStats, EquipmentType.Hands);
                        /* Weapon */
                        StatRegister weaponStats = new()
                        {
                            AttackDamage = 9 * damageModifierA + damageModifierB,
                            AbilityPoints = 4 * damageModifierA + damageModifierB,
                            CriticalStrikeChance = 1 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem weapon = new(warriorNamePrefix + " Sword", valueModifier, weaponStats, EquipmentType.Weapon);

                        return new(head, chest, legs, arms, hands, feet, weapon);
                    }
                case ClassType.Assasin:
                    {
                        StatRegister chestStats = new()
                        {
                            DefensePoints = 5 * protectionModifierA + protectionModifierB,
                            MagicResistancePoints = 5 * protectionModifierA + protectionModifierB
                        };
                        EquipmentItem chest = new(assasinNamePrefix + " Vest", valueModifier, chestStats, EquipmentType.Chest);
                        /* Head */
                        StatRegister headStats = new()
                        {
                            DefensePoints = 2 * protectionModifierA + protectionModifierB,
                            MagicResistancePoints = 2 * protectionModifierA + protectionModifierB
                        };
                        EquipmentItem head = new(assasinNamePrefix + " Mask", valueModifier, headStats, EquipmentType.Head);
                        /* Legs */
                        StatRegister legsStats = new()
                        {
                            DodgeChance = 8 * chanceModifierA + chanceModifierB,
                            SpeedPoints = 4
                        };
                        EquipmentItem legs = new(assasinNamePrefix + " Trousers", valueModifier, legsStats, EquipmentType.Legs);
                        /* Feet */
                        StatRegister feetStats = new()
                        {
                            SpeedPoints = 3,
                            DodgeChance = 3 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem feet = new(assasinNamePrefix + " Boots", valueModifier, feetStats, EquipmentType.Feet);
                        /* Arms */
                        StatRegister armsStats = new()
                        {
                            AbilityPoints = 2 * damageModifierA + damageModifierB,
                            AttackDamage = 3 * damageModifierA + damageModifierB
                        };
                        EquipmentItem arms = new(assasinNamePrefix + " Sleeves", valueModifier, armsStats, EquipmentType.Arms);
                        /* Hands */
                        StatRegister handsStats = new()
                        {
                            AttackDamage = 1 * damageModifierA + damageModifierB,
                            AbilityPoints = 1 * damageModifierA + damageModifierB,
                            CriticalStrikeChance = 6 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem hands = new(assasinNamePrefix + " Gloves", valueModifier, handsStats, EquipmentType.Hands);
                        /* Weapon */
                        StatRegister weaponStats = new()
                        {
                            AttackDamage = 6 * damageModifierA + damageModifierB,
                            AbilityPoints = 2 * damageModifierA + damageModifierB,
                            CriticalStrikeChance = 6 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem weapon = new(assasinNamePrefix + " Dagger", valueModifier, weaponStats, EquipmentType.Weapon);

                        return new(head, chest, legs, arms, hands, feet, weapon);
                    }
                case ClassType.Paladin:
                    {
                        StatRegister chestStats = new()
                        {
                            DefensePoints = 10 * protectionModifierA + protectionModifierB,
                            MagicResistancePoints = 10 * protectionModifierA + protectionModifierB
                        };
                        EquipmentItem chest = new(paladinNamePrefix + " Chestplate", valueModifier, chestStats, EquipmentType.Chest);
                        /* Head */
                        StatRegister headStats = new()
                        {
                            DefensePoints = 5 * protectionModifierA + protectionModifierB,
                            MagicResistancePoints = 5 * protectionModifierA + protectionModifierB
                        };
                        EquipmentItem head = new(paladinNamePrefix + " Helmet", valueModifier, headStats, EquipmentType.Head);
                        /* Legs */
                        StatRegister legsStats = new()
                        {
                            DodgeChance = 3 * chanceModifierA + chanceModifierB,
                            SpeedPoints = 2
                        };
                        EquipmentItem legs = new(paladinNamePrefix + " Trousers", valueModifier, legsStats, EquipmentType.Legs);
                        /* Feet */
                        StatRegister feetStats = new()
                        {
                            SpeedPoints = 1,
                            DodgeChance = 1 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem feet = new(paladinNamePrefix + " Boots", valueModifier, feetStats, EquipmentType.Feet);
                        /* Arms */
                        StatRegister armsStats = new()
                        {
                            AbilityPoints = 3 * damageModifierA + damageModifierB,
                            AttackDamage = 2 * damageModifierA + damageModifierB
                        };
                        EquipmentItem arms = new(paladinNamePrefix + " Armplates", valueModifier, armsStats, EquipmentType.Arms);
                        /* Hands */
                        StatRegister handsStats = new()
                        {
                            AttackDamage = 2 * damageModifierA + damageModifierB,
                            AbilityPoints = 2 * damageModifierA + damageModifierB,
                            CriticalStrikeChance = 1 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem hands = new(paladinNamePrefix + " Gloves", valueModifier, handsStats, EquipmentType.Hands);
                        /* Weapon */
                        StatRegister weaponStats = new()
                        {
                            AttackDamage = 7 * damageModifierA + damageModifierB,
                            AbilityPoints = 7 * damageModifierA + damageModifierB,
                            CriticalStrikeChance = 0 * chanceModifierA + chanceModifierB
                        };
                        EquipmentItem weapon = new(paladinNamePrefix + " Hammer", valueModifier, weaponStats, EquipmentType.Weapon);

                        return new(head, chest, legs, arms, hands, feet, weapon);
                    }
           }
           return null;
        }
    }
}
