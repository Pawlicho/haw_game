using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Adventure;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Creators
{
    internal class LocationCreator
    {
        private LocationType type;
        private IMonsterCreator monsterSpawner;

        private int xSize;
        private int ySize;
        private List<List<IHallwayPiece>> locationSchema;

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
            locationSchema = new();
            xSize = 5;
            ySize = 5;
        }
        public Location CreateLocation()
        { 
            locationSchema = new();
            for (int x = 0; x < xSize; x++)
            {
                locationSchema.Add(new List<IHallwayPiece>());
                for (int y =0; y < ySize; y++)
                {
                    locationSchema[x].Add(new BlankPiece());
                }
            }

            locationSchema[0][0] = new CorridorPiece(null, false);
            locationSchema[0][1] = new CorridorPiece(null, true);
            locationSchema[1][1] = new Room(new List<IItem> { new ValuableItem("Saphire", 150) },
                                           null);
            locationSchema[2][1] = new CorridorPiece(null, false);
            locationSchema[3][1] = new Room(new List<IItem> { new ValuableItem("Amethyst", 200) },
                                            monsterSpawner.CreateMonster(false));
            locationSchema[1][2] = new CorridorPiece(null, false);
            locationSchema[1][3] = new Room(new List<IItem> { new ValuableItem("Amber", 100) },
                                            monsterSpawner.CreateMonster(false));
            locationSchema[1][4] = new CorridorPiece(null, false);
            locationSchema[2][3] = new CorridorPiece(null, false);
            locationSchema[4][3] = new CorridorPiece(null, false);
            locationSchema[3][3] = new CorridorPiece(null, false);
            locationSchema[4][4] = new Room(new List<IItem> { new ValuableItem("Boss gems", 1000) },
                                            monsterSpawner.CreateMonster(true));

            /* 1. Specify Number of non boss rooms 
             * 2. Choose randomly one of map corners and set it as boss room
             * 3. Put each room on the map, with restriction that there need to be at least 1 non room pieces between each room
             * 4. Fill gaps between rooms, randomize traps on route
             */
            /*
                excludeBusyIdx(new Coords(0,0));
                Coords bossRoomCoords = chooseBossRoom();
                excludeBusyIdx(bossRoomCoords);
                List<Coords> roomCoords = new();

                for (int i = 0; i < nonBossRoomNumber; i++)
                {
                    Coords roomIdx = chooseRoomIdx();
                    roomCoords.Add(roomIdx);
                    excludeBusyIdx(roomIdx);
                }
            */
            /* For now, create map staticly */

            LocationMap locationMap = new(locationSchema, xSize, ySize);

            return new Location(type, locationMap);
        }
    }
}

