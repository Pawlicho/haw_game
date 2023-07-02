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

        public string Action(ConsoleKeyInfo keyInfo)
        {
            ConsoleKey key = keyInfo.Key;
            EquipmentItem chosenItem;

            int idx = (int)key - (int)ConsoleKey.D0;
            switch (key)
            {
                case ConsoleKey.D0:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                case ConsoleKey.D1:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                case ConsoleKey.D2:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                case ConsoleKey.D3:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                case ConsoleKey.D4:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                case ConsoleKey.D5:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                case ConsoleKey.D6:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                case ConsoleKey.D7:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                case ConsoleKey.D8:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                case ConsoleKey.D9:
                {
                    if (inventory.Count < idx + 1)
                        return "No such item";
                    chosenItem = inventory[idx];
                    break;
                }
                default:
                {
                    return "Wrong key! Chose on of the mentioned. ";
                }
            }
            if (chosenItem.GoldValue > state.GameHero.Gold)
            {
                return "You cannot afford such item";
            }

            bool success = state.GameHero.PickItem(chosenItem);
            if (success)
            {
                state.GameHero.Gold -= chosenItem.GoldValue;
                inventory.RemoveAt(idx);
                return "\n" + chosenItem.Name + " has been bought and added into Hero's inventory.";
            }
            else
            {
                return "\nCould not add item to inventory, no more space!";
            }
        }
    }
}
