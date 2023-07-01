using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Adventure;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;

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

        public Adventure.Expedition CreateExpedition(Hero visitor, Game.Game gameContext)
        {
            Expedition nextExpedition = new Expedition(locationGenerator.CreateLocation(), visitor, gameContext);
            return nextExpedition;
        }
    }
}
