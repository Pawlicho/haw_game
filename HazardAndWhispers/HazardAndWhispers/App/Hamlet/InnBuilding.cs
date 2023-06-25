using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Adventure;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Creators;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Hamlet
{
    internal class InnBuilding : IBuilding
    {
        private string name;
        private PreAdventureGameState state;
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

        public InnBuilding(string name_, PreAdventureGameState state_)
        {
            name = name_;
            state = state_;
        }

        public string Action(ConsoleKey key)
        {
            LocationType destination = LocationType.Swamp;

            switch (key)
            {
                case ConsoleKey.D0:
                {
                    destination = LocationType.Swamp;
                    break;
                }
                case ConsoleKey.D1:
                {
                    destination = LocationType.Catacombs;
                    break;
                }
                case ConsoleKey.D2:
                {
                    destination = LocationType.Graveyard;
                    break;
                }
                case ConsoleKey.D3:
                {
                    destination = LocationType.HauntedMansion;
                    break;
                }
                default:
                {
                    return "Wrong key!";
                }
            }

            state.Ready = true;
            state.ExpeditionGenerator.ChosenLocation = destination;
            return "Chosen destination! Next Expedition will take place in: " +
                    Enum.GetName(typeof(LocationType), destination);
        }
    }
}
