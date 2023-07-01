using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Hamlet
{
    internal class GuildBuilding : IBuilding
    {
        private string name;
        private PreAdventureGameState state;
        private List<Upgrade> upgradeSet;
        private string welcomeMessage;

        public string WelcomeMessage
        {
            get 
            {
                int tempInt = 0;
                welcomeMessage = "\nWelcome to " + name + "What Can I get for you?";
                welcomeMessage += "\nEnter a number to buy an upgrade: ";
                foreach (var item in upgradeSet)
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

        public string Action(ConsoleKeyInfo keyInfo)
        {
            ConsoleKey key = keyInfo.Key;
            Upgrade chosenUpgrade;
            switch (key)
            {
                case ConsoleKey.D0:
                {
                    if (upgradeSet.Count < 1)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[0];
                    break;
                }
                case ConsoleKey.D1:
                {
                    if (upgradeSet.Count < 2)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[1];
                    break;
                }
                case ConsoleKey.D2:
                {
                    if (upgradeSet.Count < 3)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[2];
                    break;
                }
                case ConsoleKey.D3:
                {
                    if (upgradeSet.Count < 4)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[3];
                    break;
                }
                case ConsoleKey.D4:
                {
                    if (upgradeSet.Count < 5)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[4];
                    break;
                }
                case ConsoleKey.D5:
                {
                    if (upgradeSet.Count < 6)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[5];
                    break;
                }
                case ConsoleKey.D6:
                {
                    if (upgradeSet.Count < 7)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[6];
                    break;
                }
                case ConsoleKey.D7:
                {
                    if (upgradeSet.Count < 8)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[7];
                    break;
                }
                case ConsoleKey.D8:
                {
                    if (upgradeSet.Count < 9)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[8];
                    break;
                }
                case ConsoleKey.D9:
                {
                    if (upgradeSet.Count < 10)
                        return "No such upgrade.";
                    chosenUpgrade = upgradeSet[9];
                    break;
                }
                default:
                {
                    return "Wrong key! Chose on of the mentioned. ";
                }
            }
            if (chosenUpgrade == null)
            {
                return "No such upgrade.";
            }

            if (chosenUpgrade.Price > state.GameHero.Gold)
            {
                return "You cannot afford such upgrade.";
            }

            state.GameHero.Gold -= chosenUpgrade.Price;
            bool success = chosenUpgrade.UpgradeHero(state.GameHero);

            if (success)
                return "\nSuccess! Hero has been upgraded with " + chosenUpgrade.Name +
                       ".\nHero's balance is: " + state.GameHero.Gold;
            else
                return "Unfortunately, Hero has not been upgraded successfully.\nCurrent Health state: " +
                       state.GameHero.Statistics.HealthPoints + ".";

        }
    }
}
