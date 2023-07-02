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
        private EquipmentCreator equipmentCreator;

        public ClassType HeroClass
        {
            get { return heroClass; }
            set { heroClass = value; }
        }

        public HeroCreator()
        {
            heroClass = ClassType.Mage;
            equipmentCreator = new EquipmentCreator();
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
            StatRegister minorHealPotionRegister = new StatRegister()
            {
                HealthPoints = 80
            };
            inventory.AddItem(new ConsumableItem("Minor Healing Potion", 50, minorHealPotionRegister));
            inventory.AddItem(new ValuableItem("Scarlet Rubin", 1000));

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

                    Equipment equipment = equipmentCreator.CreateEquipment(EquipmentLevel.Basic, type);

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

                    Equipment equipment = equipmentCreator.CreateEquipment(EquipmentLevel.Basic, type);

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

                    Equipment equipment = equipmentCreator.CreateEquipment(EquipmentLevel.Basic, type);

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
                    
                    Equipment equipment = equipmentCreator.CreateEquipment(EquipmentLevel.Basic, type);
                    
                    Hero hero = new(reg, moveSet, type, equipment, inventory, initialGoldValue);

                    return hero;
                }
            }

            /* Should not enter this return, but just for compiler sake */
            return null;
        }
    }
}
