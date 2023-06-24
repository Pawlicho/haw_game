using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Creators;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Hamlet
{
    internal class InnBuilding : IBuilding
    {
        private string name;
        private PreAdventureGameState state;
        private ExpeditionCreator expeditionGenerator;
        private string welcomeMessage;

        public string WelcomeMessage
        {
            get 
            {
                welcomeMessage = "\nWelcome to " + name;
                welcomeMessage += "\nEnter a number to chose the place of next expedition: ";

                welcomeMessage += "\n0: Swamp";
                welcomeMessage += "\n1: Catacombs";
                welcomeMessage += "\n2: Graveyard";
                welcomeMessage += "\n2: Haunted Mansion";

                return welcomeMessage;
            }
        }
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
