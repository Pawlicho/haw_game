using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Hamlet
{
    internal class CourtyardBuilding
    {
        private string name;
        private PreAdventureGameState state;

        public string Name
        {
            get { return name; }
        }
        public PreAdventureGameState State
        {
            get { return state; }
            set { state = value; }
        }

        public CourtyardBuilding(string name_, PreAdventureGameState state_)
        {
            name = name_;
            state = state_;
        }

        public string Action(ConsoleKey key)
        {
            /* TODO: IMPLEMENT */

            return String.Empty;
        }
    }    
}
