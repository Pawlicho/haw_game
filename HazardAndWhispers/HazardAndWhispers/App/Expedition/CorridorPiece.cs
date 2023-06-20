using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Expedition
{
    internal class CorridorPiece : IHallwayPiece
    {
        private bool isTrap;
        private List<IItem> reward;

        public List<IItem> Reward
        {
            get { return reward; }
        }

        public bool IsTrap
        {
            get { return isTrap; }
        }

        public bool HasReward()
        {
            return reward.Any();
        }
        public CorridorPiece(List<IItem> reward_, bool isTrap_)
        {
            isTrap = isTrap_;

            if (reward_ == null)
            {
                reward = new List<IItem>();
            }
            else
            {
                reward = reward_;
            }

        }

        public void Enter(IAdventureState state)
        {
            /* Do not change state */
        }
    }
}
