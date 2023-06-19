using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class Hero : IAlive
    {
        private StatRegister statistics;
        private List<ITourMove> moveSet;
        private bool isBoss;
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
                    bool isBoss_,
                    ClassType type_,
                    Equipment heroEquipment_,
                    Inventory heroInventory_,
                    uint gold_)
        {
            statistics = statistics_;
            moveSet = moveSet_;
            isBoss = isBoss_;
            type = type_;
            heroEquipment = heroEquipment_;
            heroInventory = heroInventory_;
            gold = gold_;
        }

        public int RunMove(int moveId)
        {
            return MoveSet[moveId].MakeMove();
        }
    }
}
