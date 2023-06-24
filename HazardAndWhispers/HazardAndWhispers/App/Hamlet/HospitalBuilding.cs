using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Hamlet
{
    internal class HospitalBuilding : IBuilding
    {
        private string name;
        private PreAdventureGameState state;
        private List<Treatment> treatmentSet;
        private string welcomeMessage;

        public string WelcomeMessage
        {
            get 
            {
                int tempInt = 0;
                welcomeMessage = "\nWelcome to " + name + "What Can I get for you?";
                welcomeMessage += "\nEnter a number to buy a Treatment: ";
                foreach (var item in treatmentSet)
                {
                    welcomeMessage += "\n\n" + tempInt + ": " + item.ToString();
                    tempInt++;
                }
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
        public List<Treatment> TreatmentSet
        {
            get { return treatmentSet; }
        }

        public HospitalBuilding(string name_, PreAdventureGameState state_, List<Treatment> treatmentSet_)
        {
            name = name_;
            state = state_;
            treatmentSet = treatmentSet_;
        }

        public string Action(ConsoleKey key)
        {
            
            return String.Empty;
        }
    }
}
