using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Hamlet
{
    internal class BlackSmithBuilding : IBuilding
    {
        private string name;
        private PreAdventureGameState state;
        private List<EquipmentItem> inventory;
        private string welcomeMessage;

        public string WelcomeMessage
        {
            get 
            {
                int tempInt = 0;
                welcomeMessage = "\nWelcome to " + name + "What Can I get for you?";
                welcomeMessage += "\nEnter a number to buy an item: ";
                foreach (var item in inventory)
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
        public List<EquipmentItem> Inventory
        {
            get { return inventory; }
        }

        public BlackSmithBuilding(string name_, PreAdventureGameState state_, List<EquipmentItem> inventory_)
        {
            name = name_;
            state = state_;
            inventory = inventory_;
        }

        public string Action(ConsoleKey key)
        {
            /* TODO: IMPLEMENT */
            return String.Empty;
        }
    }
}
