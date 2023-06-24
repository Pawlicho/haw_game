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
            /* Common fields */

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
                    StatRegister reg = new StatRegister();

                    /* MoveSet */
                    List<ITourMove> moveSet = new List<ITourMove>();

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new StatRegister();
                    EquipmentItem chest = new EquipmentItem("NONE", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new StatRegister();
                    EquipmentItem head = new EquipmentItem("NONE", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new StatRegister();
                    EquipmentItem legs = new EquipmentItem("NONE", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new StatRegister();
                    EquipmentItem feet = new EquipmentItem("NONE", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new StatRegister();
                    EquipmentItem arms = new EquipmentItem("NONE", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new StatRegister();
                    EquipmentItem hands = new EquipmentItem("NONE", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new StatRegister();
                    EquipmentItem weapon = new EquipmentItem("NONE", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new Equipment(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new Hero(reg, moveSet, type, equipment, inventory, initialGoldValue);

                    return hero;
                }
                case ClassType.Warrior:
                {
                    /* Stat Register */
                    StatRegister reg = new StatRegister();

                    /* MoveSet */
                    List<ITourMove> moveSet = new List<ITourMove>();

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new StatRegister();
                    EquipmentItem chest = new EquipmentItem("NONE", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new StatRegister();
                    EquipmentItem head = new EquipmentItem("NONE", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new StatRegister();
                    EquipmentItem legs = new EquipmentItem("NONE", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new StatRegister();
                    EquipmentItem feet = new EquipmentItem("NONE", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new StatRegister();
                    EquipmentItem arms = new EquipmentItem("NONE", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new StatRegister();
                    EquipmentItem hands = new EquipmentItem("NONE", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new StatRegister();
                    EquipmentItem weapon = new EquipmentItem("NONE", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new Equipment(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new Hero(reg, moveSet, type, equipment, inventory, initialGoldValue);

                    return hero;
                }
                case ClassType.Assasin:
                {
                    /* Stat Register */
                    StatRegister reg = new StatRegister();

                    /* MoveSet */
                    List<ITourMove> moveSet = new List<ITourMove>();

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new StatRegister();
                    EquipmentItem chest = new EquipmentItem("NONE", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new StatRegister();
                    EquipmentItem head = new EquipmentItem("NONE", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new StatRegister();
                    EquipmentItem legs = new EquipmentItem("NONE", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new StatRegister();
                    EquipmentItem feet = new EquipmentItem("NONE", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new StatRegister();
                    EquipmentItem arms = new EquipmentItem("NONE", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new StatRegister();
                    EquipmentItem hands = new EquipmentItem("NONE", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new StatRegister();
                    EquipmentItem weapon = new EquipmentItem("NONE", 0, weaponStats, EquipmentType.Weapon);

                    Equipment equipment = new Equipment(head, chest, legs, arms, hands, feet, weapon);

                    Hero hero = new Hero(reg, moveSet, type, equipment, inventory, initialGoldValue);

                    return hero;
                }
                case ClassType.Paladin:
                {
                    /* Stat Register */
                    StatRegister reg = new StatRegister();

                    /* MoveSet */
                    List<ITourMove> moveSet = new List<ITourMove>();

                    /* Equipment */

                    /* Chest */
                    StatRegister chestStats = new StatRegister();
                    EquipmentItem chest = new EquipmentItem("NONE", 0, chestStats, EquipmentType.Chest);
                    /* Head */
                    StatRegister headStats = new StatRegister();
                    EquipmentItem head = new EquipmentItem("NONE", 0, headStats, EquipmentType.Head);
                    /* Legs */
                    StatRegister legsStats = new StatRegister();
                    EquipmentItem legs = new EquipmentItem("NONE", 0, legsStats, EquipmentType.Legs);
                    /* Feet */
                    StatRegister feetStats = new StatRegister();
                    EquipmentItem feet = new EquipmentItem("NONE", 0, feetStats, EquipmentType.Feet);
                    /* Arms */
                    StatRegister armsStats = new StatRegister();
                    EquipmentItem arms = new EquipmentItem("NONE", 0, armsStats, EquipmentType.Arms);
                    /* Hands */
                    StatRegister handsStats = new StatRegister();
                    EquipmentItem hands = new EquipmentItem("NONE", 0, handsStats, EquipmentType.Hands);
                    /* Weapon */
                    StatRegister weaponStats = new StatRegister();
                    EquipmentItem weapon = new EquipmentItem("NONE", 0, weaponStats, EquipmentType.Weapon);

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
