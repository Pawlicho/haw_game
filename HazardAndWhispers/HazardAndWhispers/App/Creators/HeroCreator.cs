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
            uint healthPoints;
            uint maxHealthPoints;
            int abilityPoints;
            uint speedPoints;
            uint defensePoints;
            uint magicResistancePoints;
            uint dodgeChance;
            uint missChance;
            int attackDamage;
            uint criticalStrikeChance;
            bool waterResistance;
            bool earthResistance;
            bool fireResistance;
            bool windResistance;
            bool lightResistance;
            bool shadowResistance;

            /* Inventory */
            const uint maxInventorySize = 10;
            Inventory inventory = new Inventory(maxInventorySize);

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
                    StatRegister reg = new StatRegister(healthPoints,
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
                    List<ITourMove> moveSet = new List<ITourMove>()
                    {
                        new BasicAttackMove(5),
                        new SkipTourMove(),
                        new CastSpellMove(10, Element.Fire),
                        new CastSpellMove(8, Element.Light),
                        new CastSpellMove(9, Element.Wind)
                    };

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new StatRegister();
                    chestStats.DefensePoints = 5;
                    chestStats.MagicResistancePoints = 15;
                    EquipmentItem chest = new EquipmentItem("Acolyte Robe", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new StatRegister();
                    headStats.DefensePoints = 3;
                    headStats.MagicResistancePoints = 3;
                    EquipmentItem head = new EquipmentItem("Acolyte Hat", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new StatRegister();
                    legsStats.DodgeChance = 3;
                    legsStats.SpeedPoints = 2;
                    EquipmentItem legs = new EquipmentItem("Acolyte Trousers", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new StatRegister();
                    feetStats.SpeedPoints = 1;
                    feetStats.DodgeChance = 1;
                    EquipmentItem feet = new EquipmentItem("Acolate Boots", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new StatRegister();
                    armsStats.AbilityPoints = 4;
                    armsStats.AttackDamage = 1;
                    EquipmentItem arms = new EquipmentItem("Acolate Sleeves", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new StatRegister();
                    handsStats.AttackDamage = 0;
                    handsStats.AbilityPoints = 3;
                    handsStats.CriticalStrikeChance = 3;
                    EquipmentItem hands = new EquipmentItem("Acolate Gloves", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new StatRegister();
                    handsStats.AttackDamage = 4;
                    handsStats.AbilityPoints = 8;
                    handsStats.CriticalStrikeChance = 2;
                    EquipmentItem weapon = new EquipmentItem("Acolyte Wand", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new Equipment(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new Hero(reg, moveSet, type, equipment, inventory, initialGoldValue);

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
                    StatRegister reg = new StatRegister(healthPoints,
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
                    List<ITourMove> moveSet = new List<ITourMove>()
                    {
                        new BasicAttackMove(15),
                        new SkipTourMove(),
                        new CastSpellMove(5, Element.Shadow),
                        new CastSpellMove(7, Element.Earth),
                        new CastSpellMove(5, Element.Water)
                    };

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new StatRegister();
                    chestStats.DefensePoints = 15;
                    chestStats.MagicResistancePoints = 10;
                    EquipmentItem chest = new EquipmentItem("Recruit Chestplate", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new StatRegister();
                    headStats.DefensePoints = 7;
                    headStats.MagicResistancePoints = 7;
                    EquipmentItem head = new EquipmentItem("Recruit Helmet", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new StatRegister();
                    legsStats.DodgeChance = 3;
                    legsStats.SpeedPoints = 1;
                    EquipmentItem legs = new EquipmentItem("Recruit Trousers", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new StatRegister();
                    feetStats.SpeedPoints = 0;
                    feetStats.DodgeChance = 2;
                    EquipmentItem feet = new EquipmentItem("Recruit Boots", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new StatRegister();
                    armsStats.AbilityPoints = 1;
                    armsStats.AttackDamage = 3;
                    EquipmentItem arms = new EquipmentItem("Recruit Armplates", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new StatRegister();
                    handsStats.AttackDamage = 3;
                    handsStats.AbilityPoints = 0;
                    handsStats.CriticalStrikeChance = 2;
                    EquipmentItem hands = new EquipmentItem("Recruit Gloves", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new StatRegister();
                    handsStats.AttackDamage = 9;
                    handsStats.AbilityPoints = 4;
                    handsStats.CriticalStrikeChance = 1;
                    EquipmentItem weapon = new EquipmentItem("Recruit Sword", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new Equipment(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new Hero(reg, moveSet, type, equipment, inventory, initialGoldValue);

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
                    StatRegister reg = new StatRegister(healthPoints,
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
                    List<ITourMove> moveSet = new List<ITourMove>()
                    {
                        new BasicAttackMove(15),
                        new SkipTourMove(),
                        new CastSpellMove(10, Element.Wind),
                        new CastSpellMove(9, Element.Shadow),
                        new CastSpellMove(7, Element.Fire)
                    };

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new StatRegister();
                    chestStats.DefensePoints = 5;
                    chestStats.MagicResistancePoints = 5;
                    EquipmentItem chest = new EquipmentItem("Neophyte Vest", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new StatRegister();
                    headStats.DefensePoints = 2;
                    headStats.MagicResistancePoints = 2;
                    EquipmentItem head = new EquipmentItem("Neophyte Mask", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new StatRegister();
                    legsStats.DodgeChance = 8;
                    legsStats.SpeedPoints = 4;
                    EquipmentItem legs = new EquipmentItem("Neophyte Trousers", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new StatRegister();
                    feetStats.SpeedPoints = 3;
                    feetStats.DodgeChance = 3;
                    EquipmentItem feet = new EquipmentItem("Neophyte Boots", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new StatRegister();
                    armsStats.AbilityPoints = 2;
                    armsStats.AttackDamage = 3;
                    EquipmentItem arms = new EquipmentItem("Neophyte Sleeves", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new StatRegister();
                    handsStats.AttackDamage = 1;
                    handsStats.AbilityPoints = 1;
                    handsStats.CriticalStrikeChance = 6;
                    EquipmentItem hands = new EquipmentItem("Neophyte Gloves", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new StatRegister();
                    handsStats.AttackDamage = 6;
                    handsStats.AbilityPoints = 2;
                    handsStats.CriticalStrikeChance = 6;
                    EquipmentItem weapon = new EquipmentItem("Neophyte Dagger", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new Equipment(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new Hero(reg, moveSet, type, equipment, inventory, initialGoldValue);

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
                    StatRegister reg = new StatRegister(healthPoints,
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
                    List<ITourMove> moveSet = new List<ITourMove>()
                    {
                        new BasicAttackMove(10),
                        new SkipTourMove(),
                        new CastSpellMove(9, Element.Earth),
                        new CastSpellMove(9, Element.Fire),
                        new CastSpellMove(11, Element.Shadow)
                    };

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new StatRegister();
                    chestStats.DefensePoints = 10;
                    chestStats.MagicResistancePoints = 10;
                    EquipmentItem chest = new EquipmentItem("Aspirant Chestplate", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new StatRegister();
                    headStats.DefensePoints = 5;
                    headStats.MagicResistancePoints = 5;
                    EquipmentItem head = new EquipmentItem("Aspirant Helmet", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new StatRegister();
                    legsStats.DodgeChance = 3;
                    legsStats.SpeedPoints = 2;
                    EquipmentItem legs = new EquipmentItem("Aspirant Trousers", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new StatRegister();
                    feetStats.SpeedPoints = 1;
                    feetStats.DodgeChance = 1;
                    EquipmentItem feet = new EquipmentItem("Aspirant Boots", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new StatRegister();
                    armsStats.AbilityPoints = 3;
                    armsStats.AttackDamage = 2;
                    EquipmentItem arms = new EquipmentItem("Aspirant Armplates", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new StatRegister();
                    handsStats.AttackDamage = 2;
                    handsStats.AbilityPoints = 2;
                    handsStats.CriticalStrikeChance = 1;
                    EquipmentItem hands = new EquipmentItem("Aspirant Gloves", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new StatRegister();
                    handsStats.AttackDamage = 7;
                    handsStats.AbilityPoints = 7;
                    handsStats.CriticalStrikeChance = 0;
                    EquipmentItem weapon = new EquipmentItem("Aspirant Hammer", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new Equipment(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new Hero(reg, moveSet, type, equipment, inventory, initialGoldValue);

                    return hero;
                }
            }

            /* Should not enter this return, but just for compiler sake */
            return null;
        }
    }
}
