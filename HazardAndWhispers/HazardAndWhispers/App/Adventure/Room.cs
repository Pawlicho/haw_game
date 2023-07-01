using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Adventure
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

        public string Enter(IAdventureState state)
        {
            string temp = "\nEntering the room...\n";
            bool hasEnemy = enemy != null;
            if (!(isCompleted))
            {
                if (hasEnemy)
                {
                    state.ExpeditionContext.State = new BattleAdventureState(state.ExpeditionContext);
                    temp += "Vicious " + Enum.GetName(typeof(LocationType), state.ExpeditionContext.Destination.Type) +
                            " monster has appeard.";
                    if (enemy.IsBoss)
                    {
                        temp += "\nIt is a boss fight!\n";
                    }
                }
                else
                {
                    if (HasReward())
                    {
                        temp += "Found an item chest inside.\n";
                        foreach (var item in Reward)
                        {
                            if (state.ExpeditionContext.Visitor.PickItem(item))
                            {
                                temp += item.ToString() + "\nAdded to your equipment";
                            }
                        }
                    }
                    temp += "\nLet's move on...";
                }
                isCompleted = true;
            }
            else
            {
                temp += "\nYou have already been here! Let's move on...";
            }

            return temp;
        }
    }
}
