using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Hamlet
{
    internal class BlackSmithBuilding : IBuilding
    {
        private string name;
        private PreAdventureGameState state;
        private List<Equipment> inventory;

        public string Name
        {
            get { return name; }
        }
        public PreAdventureGameState State
        {
            get { return state; }
            set { state = value; }
        }
        public List<Equipment> Inventory
        {
            get { return inventory; }
        }

        public BlackSmithBuilding(string name_, PreAdventureGameState state_, List<Equipment> inventory_)
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
