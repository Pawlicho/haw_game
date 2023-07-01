using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Adventure
{
    internal class CorridorPiece : IHallwayPiece
    {
        private bool isTrap;
        private List<IItem> reward;
        private bool isCompleted;
        private const int trapDamage = 5;
        public bool IsCompleted
        {
            get { return isCompleted; }
        }


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
            isCompleted = false;

            if (reward_ == null)
            {
                reward = new List<IItem>();
            }
            else
            {
                reward = reward_;
            }

        }

        public string Enter(IAdventureState state)
        {
            /* Do not change state */
            if (!(IsCompleted)) 
            {
                if (isTrap)
                {
                    state.ExpeditionContext.Visitor.Statistics.HealthPoints -= 5;
                    isCompleted = true;
                    return "\nIt is an ambush! Hero lost. " + trapDamage + "HP.\n";
                }
            }
            return "\nJust another dark corridor. Let's continue...\n";
        }
    }
}
