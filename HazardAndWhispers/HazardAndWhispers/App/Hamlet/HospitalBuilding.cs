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
            /* TODO: IMPLEMENT */
            return String.Empty;
        }
    }
}
