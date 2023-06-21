using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Expedition;

namespace HazardAndWhispers.App.Creators
{
    internal class LocationCreator
    {
        private LocationType type;
        private IMonsterCreator monsterSpawner;

        public LocationType Type
        {
            get { return type; }
            set
            {
                type = value;
                switch (type)
                {
                    case LocationType.Swamp:
                         monsterSpawner = new SwampMonsterCreator(); break;
                    case LocationType.Catacombs:
                         monsterSpawner = new CatacombsMonsterCreator(); break;
                    case LocationType.Graveyard:
                         monsterSpawner = new GraveyardMonsterCreator(); break;
                    case LocationType.HauntedMansion:
                         monsterSpawner = new HauntedMansionMonsterCreator(); break;
                }
            }
        }
        public IMonsterCreator MonsterSpawner
        {
            get {  return monsterSpawner; }
            set
            { 
                if (value is SwampMonsterCreator)
                    type = LocationType.Swamp;
                else if (value is CatacombsMonsterCreator)
                    type = LocationType.Catacombs;
                else if (value is GraveyardMonsterCreator)
                    type = LocationType.Graveyard;
                else if (value is  HauntedMansionMonsterCreator)
                    type = LocationType.HauntedMansion;
            }
        }

        public LocationCreator(LocationType type_=LocationType.Graveyard)
        {
            Type = type_;
        }

        public Location CreateLocation()
        {
            /* TODO: IMPLEMENT */
            return null;
        }
    }
}

