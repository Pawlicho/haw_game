using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Expedition;

namespace HazardAndWhispers.App.Creators
{
    internal class ExpeditionCreator
    {
        private LocationCreator locationGenerator;
        private LocationType chosenLocation;

        public LocationType ChosenLocation
        {
            get { return chosenLocation; }
            set
            { 
                chosenLocation = value;
                locationGenerator.Type = value;
            }
        }

        public ExpeditionCreator()
        {
            locationGenerator = new LocationCreator();
            chosenLocation = locationGenerator.Type;
        }

        public Expedition.Expedition CreateExpedition(Hero visitor)
        {
            /* TODO: IMPLEMENT */
            return null;
        }
    }
}
