using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.TourMove;

namespace HazardAndWhispers.App.Alive
{
    internal class Monster : IAlive
    {
        private StatRegister statistics;
        private List<ITourMove> moveSet;
        private bool isBoss;

        public StatRegister Statistics
        {
            get { return statistics; }
        }
        public List<ITourMove> MoveSet
        {
            get { return moveSet; }
        }
        public bool IsBoss
        {
            get { return isBoss; }
        }

        public Monster(StatRegister statistics_, List<ITourMove> moveSet_, bool isBoss_)
        {
            statistics = statistics_;
            moveSet = moveSet_;
            isBoss = isBoss_;
        }

        public int RunMove(int moveId)
        {
            return MoveSet[moveId].MakeMove();
        }
    }
}
