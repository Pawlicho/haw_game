using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Creators;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Hamlet
{
    internal class InnBuilding : IBuilding
    {
        private string name;
        private PreAdventureGameState state;
        private ExpeditionCreator expeditionGenerator;

        public string Name
        {
            get { return name; }
        }
        public PreAdventureGameState State
        {
            get { return state; }
            set { state = value; }
        }

        public InnBuilding(string name_, PreAdventureGameState state_, ExpeditionCreator expeditionGenerator_)
        {
            name = name_;
            state = state_;
            expeditionGenerator = expeditionGenerator_;
        }

        public string Action(ConsoleKey key)
        {
            /* TODO: IMPLEMENT */

            return String.Empty;
        }
    }
}
