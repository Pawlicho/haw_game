﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Hamlet
{
    internal class CourtyardBuilding : IBuilding
    {
        private string name;
        private PreAdventureGameState state;
        private string welcomeMessage;

        public string WelcomeMessage
        {
            get 
            {
                welcomeMessage = "\nWelcome to " + name +
                                 ".\n\nChose a number from 0-9 to use an item from inventory" +
                                 "\nChoose Ctrl + 0-9 to drop an item from inventory" +
                                 state.GameHero.Inventory.ToString();
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

        public CourtyardBuilding(string name_, PreAdventureGameState state_)
        {
            name = name_;
            state = state_;
        }

        public string Action(ConsoleKeyInfo keyInfo)
        {
            ConsoleKey key = keyInfo.Key;
            ConsoleModifiers modifier = keyInfo.Modifiers;
            IItem chosenItem = null;
            int idx = 0;
            switch (key)
            {
                case ConsoleKey.D0:
                {
                    idx = 0;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                case ConsoleKey.D1:
                {
                    idx = 1;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                case ConsoleKey.D2:
                {
                    idx = 2;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                case ConsoleKey.D3:
                {
                    idx = 3;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                case ConsoleKey.D4:
                {
                    idx = 4;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                case ConsoleKey.D5:
                {
                    idx = 5;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                case ConsoleKey.D6:
                {
                    idx = 6;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                case ConsoleKey.D7:
                {
                    idx = 7;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                case ConsoleKey.D8:
                {
                    idx = 8;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                case ConsoleKey.D9:
                {
                    idx = 0;
                    if (idx <= state.GameHero.Inventory.GetInventoryCount() - 1)
                        chosenItem = state.GameHero.Inventory.GetItem(idx);
                    else
                        return "No such item.";
                    break;
                }
                default:
                {
                    return "Wrong key";
                }
            }
            if (chosenItem == null)
                return "No such item.";

            if (modifier == ConsoleModifiers.Control)
            {
                state.GameHero.DropItem(idx);
                return "\nDropped item" + chosenItem.Name + " from inventory";
            }

            if (chosenItem.IsEquipable)
            {
                if (state.GameHero.Equip(idx))
                    return "Equipped " + chosenItem.Name + ".";
                else
                    return "Could not equip an item.";
            }
            else if (chosenItem.IsConsumable)
            {
                if (state.GameHero.EquipConsumableMove(idx))
                    return "Added " + chosenItem.Name + "To the movement set.";
                else
                    return "Could not add an item to the movement set";
            }
            else
            {
                state.GameHero.Gold += chosenItem.GoldValue;
                state.GameHero.DropItem(idx);
                return "Item " + chosenItem.Name +
                       " has been sold for: " +
                       chosenItem.GoldValue +
                       ".\nCurrent Hero's balance is: " + state.GameHero.Gold + ".";
            }
        }
    }    
}
