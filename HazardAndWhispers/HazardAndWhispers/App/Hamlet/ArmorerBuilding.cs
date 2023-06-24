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
    internal class ArmorerBuilding : IBuilding
    {
        private string name;
        private PreAdventureGameState state;
        private List<EquipmentItem> inventory;

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

        public ArmorerBuilding(string name_, PreAdventureGameState state_, List<EquipmentItem> inventory_)
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
