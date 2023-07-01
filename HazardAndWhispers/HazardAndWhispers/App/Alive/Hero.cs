using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Item;
using HazardAndWhispers.App.TourMove;

namespace HazardAndWhispers.App.Alive
{
    internal class Hero : IAlive
    {
        private StatRegister statistics;
        private List<ITourMove> moveSet;
        private ClassType type;
        private Equipment heroEquipment;
        private Inventory heroInventory;
        private int gold;

        public Inventory Inventory
        {
            get { return heroInventory; }
        }
        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        public Equipment HeroEquipment
        {
            get { return heroEquipment; }
        }

        public StatRegister Statistics
        {
            get { return statistics; }
        }
        public List<ITourMove> MoveSet
        {
            get { return moveSet; }
        }
        public ClassType ClassType
        {
            get { return type; }
        }

        public Hero(StatRegister statistics_,
                    List<ITourMove> moveSet_,
                    ClassType type_,
                    Equipment heroEquipment_,
                    Inventory heroInventory_,
                    int gold_)
        {
            statistics = statistics_;
            moveSet = moveSet_;
            type = type_;
            heroEquipment = heroEquipment_;
            heroInventory = heroInventory_;
            gold = gold_;

            UpdateStatRegister();
        }

        public int RunMove(int moveId)
        {
            return MoveSet[moveId].MakeMove();
        }

        public bool PickItem(IItem item)
        {
            return heroInventory.AddItem(item);
        }

        public bool DropItem(int idx)
        {
            return heroInventory.DropItem(idx);
        }

        public bool EquipConsumableMove(int idx)
        {
            IItem usedItem = heroInventory.ItemSet[idx];
            if (usedItem == null)
                return false;

            if (usedItem.IsConsumable)
            {
                ConsumableItem? item = usedItem as ConsumableItem;
                if (item == null)
                    return false;

                moveSet.Add(new UseConsumableMove(item));
                DropItem(idx);

                return true;
            }

            return false;
        }
        public bool Equip(int idx)
        {
            IItem usedItem = heroInventory.ItemSet[idx];
            if (usedItem == null)
                return false;

            if (usedItem.IsEquipable)
            {
                EquipmentItem? item = usedItem as EquipmentItem;

                if (item == null)
                    return false;

                EquipmentItem temp = new();

                switch (item.EquipmentType)
                {
                    case EquipmentType.Head:
                    { 
                        statistics.Reverse(heroEquipment.Head.StatBonuses);
                        temp = heroEquipment.Head;
                        statistics.Update(heroEquipment.Head.StatBonuses); break;
                    }
                    case EquipmentType.Chest:
                    {
                        statistics.Reverse(heroEquipment.Chest.StatBonuses);
                        temp = heroEquipment.Chest;
                        statistics.Update(heroEquipment.Chest.StatBonuses); break;
                    }
                    case EquipmentType.Arms:
                    { 
                        statistics.Reverse(heroEquipment.Arms.StatBonuses);
                        temp = heroEquipment.Arms;
                        statistics.Update(heroEquipment.Arms.StatBonuses); break;
                    }
                    case EquipmentType.Hands:
                    {
                        statistics.Reverse(heroEquipment.Hands.StatBonuses);
                        temp = heroEquipment.Hands;
                        statistics.Update(heroEquipment.Hands.StatBonuses); break;
                    }
                    case EquipmentType.Legs:
                    {
                        statistics.Reverse(heroEquipment.Legs.StatBonuses);
                        temp = heroEquipment.Legs;
                        statistics.Update(heroEquipment.Legs.StatBonuses); break;
                    }
                    case EquipmentType.Feet:
                    {
                        statistics.Reverse(heroEquipment.Feet.StatBonuses);
                        temp = heroEquipment.Feet;
                        statistics.Update(heroEquipment.Feet.StatBonuses); break;
                    }
                    case EquipmentType.Weapon:
                    {
                        temp = heroEquipment.Weapon;
                        heroEquipment.Weapon = item;
                        statistics.Update(heroEquipment.Weapon.StatBonuses);break;
                    }
                }

                if (temp != null)
                {
                    heroInventory.AddItem(temp, idx);
                }

                return true;
            }

            return false;
        }

        public bool IsAlive()
        {
            if (statistics.HealthPoints > 0)
                return true;
            else 
                return false;
        }

        public void SetEnemy(IAlive enemy)
        {
            foreach (var move in moveSet)
            {
                move.Executor = this;
                move.Receiver = enemy;
            }
        }
        public void UpdateStatRegister()
        {
            heroEquipment.UpdateStatRegister(statistics);
        }

        public override string ToString()
        {
            string temp = "";
            int tempInt = 0;
            temp += "\nClass: "; temp += Enum.GetName(typeof(ClassType), type);
            temp += statistics.ToString();
            temp += "\n\nMove set: ";
            foreach(var move in moveSet)
            {
                temp += "\n" + tempInt + ": " + move.ToString();
                tempInt++;
            }
            return temp;
        }
    }
}
