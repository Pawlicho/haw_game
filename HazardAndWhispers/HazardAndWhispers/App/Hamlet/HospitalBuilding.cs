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

        public string Action(ConsoleKeyInfo keyInfo)
        {
            ConsoleKey key = keyInfo.Key;
            Treatment chosenTreatment;
            switch (key)
            {
                case ConsoleKey.D0:
                {
                    if (treatmentSet.Count < 1)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[0];
                    break;
                }
                case ConsoleKey.D1:
                {
                    if (treatmentSet.Count < 2)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[1];
                    break;
                }
                case ConsoleKey.D2:
                {
                    if (treatmentSet.Count < 3)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[2];
                    break;
                }
                case ConsoleKey.D3:
                {
                    if (treatmentSet.Count < 4)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[3];
                    break;
                }
                case ConsoleKey.D4:
                {
                    if (treatmentSet.Count < 5)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[4];
                    break;
                }
                case ConsoleKey.D5:
                {
                    if (treatmentSet.Count < 6)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[5];
                    break;
                }
                case ConsoleKey.D6:
                {
                    if (treatmentSet.Count < 7)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[6];
                    break;
                }
                case ConsoleKey.D7:
                {
                    if (treatmentSet.Count < 8)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[7];
                    break;
                }
                case ConsoleKey.D8:
                {
                    if (treatmentSet.Count < 9)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[8];
                    break;
                }
                case ConsoleKey.D9:
                {
                    if (treatmentSet.Count < 10)
                        return "No such treatment";
                    chosenTreatment = treatmentSet[9];
                    break;
                }
                default:
                {
                    return "Wrong key! Chose on of the mentioned. ";
                }
            }
            if (chosenTreatment.Price > state.GameHero.Gold)
            {
                return "You cannot afford such treatment";
            }

            state.GameHero.Gold -= chosenTreatment.Price;
            bool success = chosenTreatment.TreatHero(state.GameHero);

            if (success)
                return "\nSuccess! Hero has been treated with " + chosenTreatment.Name +
                       ".\nCurrent Health state: " + state.GameHero.Statistics.HealthPoints + 
                       ".\nHero's balance is: " + state.GameHero.Gold;
            else
                return "Unfortunately, Hero has not been treated successfully.\nCurrent Health state: " +
                       state.GameHero.Statistics.HealthPoints + ".";

        }
    }
}
