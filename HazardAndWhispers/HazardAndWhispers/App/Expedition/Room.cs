using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Expedition
{
    internal class Room : IHallwayPiece
    {
        private List<IItem> reward;
        private bool isCompleted;
        private Monster enemy;

        public Monster Enemy
        {
            get { return enemy; }
        }
        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }
        public List<IItem> Reward
        {
            get { return reward; }
        }

        public bool HasReward()
        {
            return reward.Any();
        }
        public Room(List<IItem> reward_, Monster enemy_)
        {
            reward = reward_;
            enemy = enemy_;
            isCompleted = false;
        }

        public void Enter(IAdventureState state)
        {
            if (IsCompleted)
            {
                state.ExpeditionContext.State = new ExploreAdventureState(state.ExpeditionContext);
            }
            else
            {
                state.ExpeditionContext.State = new BattleAdventureState(state.ExpeditionContext);
            }
        }
    }
}
