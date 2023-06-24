using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Item;
using HazardAndWhispers.App.TourMove;

namespace HazardAndWhispers.App.Creators
{
    internal class HeroCreator
    {
        private ClassType heroClass;

        public ClassType HeroClass
        {
            get { return heroClass; }
            set { heroClass = value; }
        }

        public HeroCreator()
        {
            heroClass = ClassType.Mage;
        }

        public Hero CreateHero(ClassType type)
        {
            /* Common */
            int healthPoints;
            int maxHealthPoints;
            int abilityPoints;
            int speedPoints;
            int defensePoints;
            int magicResistancePoints;
            int dodgeChance;
            int missChance;
            int attackDamage;
            int criticalStrikeChance;
            bool waterResistance;
            bool earthResistance;
            bool fireResistance;
            bool windResistance;
            bool lightResistance;
            bool shadowResistance;

            /* Inventory */
            const int maxInventorySize = 10;
            Inventory inventory = new(maxInventorySize);

            /* Initial gold value */
            const int initialGoldValue = 500;

            switch (type)
            {
                case ClassType.Mage:
                {
                    /* Stat Register */
                    healthPoints = 80;
                    maxHealthPoints = 80;
                    abilityPoints = 30;
                    speedPoints = 3;
                    defensePoints = 10;
                    magicResistancePoints = 30;
                    dodgeChance = 10;
                    missChance = 20;
                    attackDamage = 10;
                    criticalStrikeChance = 10;
                    waterResistance = false;
                    earthResistance = false;
                    fireResistance = false;
                    windResistance = false;
                    lightResistance = false;
                    shadowResistance = false;
                    StatRegister reg = new(healthPoints,
                                           maxHealthPoints,
                                           abilityPoints,
                                           speedPoints,
                                           defensePoints,
                                           magicResistancePoints,
                                           dodgeChance,
                                           missChance,
                                           attackDamage,
                                           criticalStrikeChance,
                                           waterResistance,
                                           earthResistance,
                                           fireResistance,
                                           windResistance,
                                           lightResistance,
                                           shadowResistance);

                    /* MoveSet */
                    List<ITourMove> moveSet = new()
                    {
                        new BasicAttackMove(5),
                        new SkipTourMove(),
                        new CastSpellMove(10, Element.Fire),
                        new CastSpellMove(8, Element.Light),
                        new CastSpellMove(9, Element.Wind)
                    };

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new()
                    {
                        DefensePoints = 5,
                        MagicResistancePoints = 15
                    };
                    EquipmentItem chest = new("Acolyte Robe", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new()
                    {
                        DefensePoints = 3,
                        MagicResistancePoints = 3
                    };
                    EquipmentItem head = new("Acolyte Hat", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new()
                    {
                        DodgeChance = 3,
                        SpeedPoints = 2
                    };
                    EquipmentItem legs = new("Acolyte Trousers", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new()
                    {
                        SpeedPoints = 1,
                        DodgeChance = 1
                    };
                    EquipmentItem feet = new("Acolate Boots", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new()
                    {
                        AbilityPoints = 4,
                        AttackDamage = 1
                    };
                    EquipmentItem arms = new("Acolate Sleeves", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new StatRegister
                    {
                        AttackDamage = 0,
                        AbilityPoints = 3,
                        CriticalStrikeChance = 3
                    };
                    EquipmentItem hands = new("Acolate Gloves", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new()
                    {
                        AttackDamage = 4,
                        AbilityPoints = 8,
                        CriticalStrikeChance = 2
                    };
                    EquipmentItem weapon = new("Acolyte Wand", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new(reg, moveSet, type, equipment, inventory, initialGoldValue);

                    return hero;
                }
                case ClassType.Warrior:
                {
                    /* Stat Register */
                    healthPoints = 120;
                    maxHealthPoints = 120;
                    abilityPoints = 10;
                    speedPoints = 1;
                    defensePoints = 30;
                    magicResistancePoints = 40;
                    dodgeChance = 10;
                    missChance = 20;
                    attackDamage = 20;
                    criticalStrikeChance = 10;
                    waterResistance = false;
                    earthResistance = false;
                    fireResistance = false;
                    windResistance = false;
                    lightResistance = false;
                    shadowResistance = false;
                    StatRegister reg = new(healthPoints,
                                           maxHealthPoints,
                                           abilityPoints,
                                           speedPoints,
                                           defensePoints,
                                           magicResistancePoints,
                                           dodgeChance,
                                           missChance,
                                           attackDamage,
                                           criticalStrikeChance,
                                           waterResistance,
                                           earthResistance,
                                           fireResistance,
                                           windResistance,
                                           lightResistance,
                                           shadowResistance);

                    /* MoveSet */
                    List<ITourMove> moveSet = new()
                    {
                        new BasicAttackMove(15),
                        new SkipTourMove(),
                        new CastSpellMove(5, Element.Shadow),
                        new CastSpellMove(7, Element.Earth),
                        new CastSpellMove(5, Element.Water)
                    };

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new()
                    {
                        DefensePoints = 15,
                        MagicResistancePoints = 10
                    };
                    EquipmentItem chest = new("Recruit Chestplate", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new()
                    {
                        DefensePoints = 7,
                        MagicResistancePoints = 7
                    };
                    EquipmentItem head = new("Recruit Helmet", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new()
                    {
                        DodgeChance = 3,
                        SpeedPoints = 1
                    };
                    EquipmentItem legs = new("Recruit Trousers", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new()
                    {
                        SpeedPoints = 0,
                        DodgeChance = 2
                    };
                    EquipmentItem feet = new EquipmentItem("Recruit Boots", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new()
                    {
                        AbilityPoints = 1,
                        AttackDamage = 3
                    };
                    EquipmentItem arms = new("Recruit Armplates", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new()
                    {
                        AttackDamage = 3,
                        AbilityPoints = 0,
                        CriticalStrikeChance = 2
                    };
                    EquipmentItem hands = new("Recruit Gloves", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new()
                    {
                        AttackDamage = 9,
                        AbilityPoints = 4,
                        CriticalStrikeChance = 1
                    };
                    EquipmentItem weapon = new("Recruit Sword", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new(reg, moveSet, type, equipment, inventory, initialGoldValue);

                    return hero;
                }
                case ClassType.Assasin:
                {
                    /* Stat Register */
                    healthPoints = 60;
                    maxHealthPoints = 60;
                    abilityPoints = 20;
                    speedPoints = 5;
                    defensePoints = 10;
                    magicResistancePoints = 20;
                    dodgeChance = 35;
                    missChance = 5;
                    attackDamage = 30;
                    criticalStrikeChance = 35;
                    waterResistance = false;
                    earthResistance = false;
                    fireResistance = false;
                    windResistance = false;
                    lightResistance = false;
                    shadowResistance = false;
                    StatRegister reg = new(healthPoints,
                                           maxHealthPoints,
                                           abilityPoints,
                                           speedPoints,
                                           defensePoints,
                                           magicResistancePoints,
                                           dodgeChance,
                                           missChance,
                                           attackDamage,
                                           criticalStrikeChance,
                                           waterResistance,
                                           earthResistance,
                                           fireResistance,
                                           windResistance,
                                           lightResistance,
                                           shadowResistance);

                    /* MoveSet */
                    List<ITourMove> moveSet = new()
                    {
                        new BasicAttackMove(15),
                        new SkipTourMove(),
                        new CastSpellMove(10, Element.Wind),
                        new CastSpellMove(9, Element.Shadow),
                        new CastSpellMove(7, Element.Fire)
                    };

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new()
                    {
                        DefensePoints = 5,
                        MagicResistancePoints = 5
                    };
                    EquipmentItem chest = new("Neophyte Vest", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new()
                    {
                        DefensePoints = 2,
                        MagicResistancePoints = 2
                    };
                    EquipmentItem head = new("Neophyte Mask", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new()
                    {
                        DodgeChance = 8,
                        SpeedPoints = 4
                    };
                    EquipmentItem legs = new("Neophyte Trousers", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new()
                    {
                        SpeedPoints = 3,
                        DodgeChance = 3
                    };
                    EquipmentItem feet = new("Neophyte Boots", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new()
                    {
                        AbilityPoints = 2,
                        AttackDamage = 3
                    };
                    EquipmentItem arms = new("Neophyte Sleeves", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new()
                    {
                        AttackDamage = 1,
                        AbilityPoints = 1,
                        CriticalStrikeChance = 6
                    };
                    EquipmentItem hands = new("Neophyte Gloves", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new()
                    {
                        AttackDamage = 6,
                        AbilityPoints = 2,
                        CriticalStrikeChance = 6
                    };
                    EquipmentItem weapon = new("Neophyte Dagger", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new(reg, moveSet, type, equipment, inventory, initialGoldValue);

                    return hero;
                }
                case ClassType.Paladin:
                {
                    /* Stat Register */
                    healthPoints = 110;
                    maxHealthPoints = 110;
                    abilityPoints = 25;
                    speedPoints = 1;
                    defensePoints = 20;
                    magicResistancePoints = 30;
                    dodgeChance = 15;
                    missChance = 25;
                    attackDamage = 10;
                    criticalStrikeChance = 15;
                    waterResistance = false;
                    earthResistance = false;
                    fireResistance = false;
                    windResistance = false;
                    lightResistance = false;
                    shadowResistance = false;
                    StatRegister reg = new(healthPoints,
                                           maxHealthPoints,
                                           abilityPoints,
                                           speedPoints,
                                           defensePoints,
                                           magicResistancePoints,
                                           dodgeChance,
                                           missChance,
                                           attackDamage,
                                           criticalStrikeChance,
                                           waterResistance,
                                           earthResistance,
                                           fireResistance,
                                           windResistance,
                                           lightResistance,
                                           shadowResistance);

                    /* MoveSet */
                    List<ITourMove> moveSet = new()
                    {
                        new BasicAttackMove(10),
                        new SkipTourMove(),
                        new CastSpellMove(9, Element.Earth),
                        new CastSpellMove(9, Element.Fire),
                        new CastSpellMove(11, Element.Shadow)
                    };

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new()
                    {
                        DefensePoints = 10,
                        MagicResistancePoints = 10
                    };
                    EquipmentItem chest = new("Aspirant Chestplate", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new()
                    {
                        DefensePoints = 5,
                        MagicResistancePoints = 5
                    };
                    EquipmentItem head = new("Aspirant Helmet", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new()
                    {
                        DodgeChance = 3,
                        SpeedPoints = 2
                    };
                    EquipmentItem legs = new("Aspirant Trousers", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new()
                    {
                        SpeedPoints = 1,
                        DodgeChance = 1
                    };
                    EquipmentItem feet = new("Aspirant Boots", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new()
                    {
                        AbilityPoints = 3,
                        AttackDamage = 2
                    };
                    EquipmentItem arms = new("Aspirant Armplates", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new()
                    {
                        AttackDamage = 2,
                        AbilityPoints = 2,
                        CriticalStrikeChance = 1
                    };
                    EquipmentItem hands = new("Aspirant Gloves", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new()
                    {
                        AttackDamage = 7,
                        AbilityPoints = 7,
                        CriticalStrikeChance = 0
                    };
                    EquipmentItem weapon = new("Aspirant Hammer", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new(reg, moveSet, type, equipment, inventory, initialGoldValue);

                    return hero;
                }
            }

            /* Should not enter this return, but just for compiler sake */
            return null;
        }
    }
}
