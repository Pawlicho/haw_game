using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Hamlet
{
    internal class GuildBuilding
    {
        private string name;
        private PreAdventureGameState state;
        private List<Upgrade> upgradeSet;

        public string Name
        {
            get { return name; }
        }
        public PreAdventureGameState State
        {
            get { return state; }
            set { state = value; }
        }
        public List<Upgrade> UpgradeSet
        {
            get { return upgradeSet; }
        }

        public GuildBuilding(string name_, PreAdventureGameState state_, List<Upgrade> upgradeSet_)
        {
            name = name_;
            state = state_;
            upgradeSet = upgradeSet_;
        }

        public string Action(ConsoleKey key)
        {
            /* TODO: IMPLEMENT */

            return String.Empty;
        }
    }
}
