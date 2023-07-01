using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Adventure
{
    internal class BlankPiece : IHallwayPiece
    {
        private List<IItem> reward;

        private bool isCompleted;

        public bool IsCompleted
        {
            get
            {
                return false;
            }
        }

        public List<IItem> Reward
        {
            get { return reward; }
        }

        public bool HasReward()
        {
            return false;
        }
        public BlankPiece()
        {

        }

        public string Enter(IAdventureState state)
        {
            /* Do not change state */
            return "";
        }
    }
}
