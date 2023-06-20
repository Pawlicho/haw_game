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
        private uint gold;

        public Inventory Inventory
        {
            get { return heroInventory; }
        }
        public uint Gold
        {
            get { return gold; }
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
                    uint gold_)
        {
            statistics = statistics_;
            moveSet = moveSet_;
            type = type_;
            heroEquipment = heroEquipment_;
            heroInventory = heroInventory_;
            gold = gold_;
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

                switch (item.EquipmentType)
                {
                    case EquipmentType.Head:
                        heroEquipment.Head = item; break;
                    case EquipmentType.Chest:
                        heroEquipment.Chest = item; break;
                    case EquipmentType.Arms:
                        heroEquipment.Arms = item; break;
                    case EquipmentType.Hands:
                        heroEquipment.Hands = item; break;
                    case EquipmentType.Legs:
                        heroEquipment.Legs = item; break;
                    case EquipmentType.Feet:
                        heroEquipment.Feet = item; break;
                    case EquipmentType.Weapon:
                        heroEquipment.Weapon = item; break;
                }

                UpdateStatRegister();
                return true;
            }

            return false;
        }

        public void UpdateStatRegister()
        {
            heroEquipment.UpdateStatRegister(statistics);
        }

    }
}
