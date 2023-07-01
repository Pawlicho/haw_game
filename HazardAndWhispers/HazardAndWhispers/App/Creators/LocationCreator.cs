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

            switch (type)
            {
                case LocationType.Graveyard:
                {
                    locationSchema[0][0] = new CorridorPiece(null, false);
                    locationSchema[1][0] = new CorridorPiece(null, false);
                    locationSchema[2][0] = new CorridorPiece(null, false);
                    locationSchema[3][0] = new CorridorPiece(null, false);
                    locationSchema[4][0] = new Room(new List<IItem> { new ValuableItem("Ruby", 250) },
                                                    monsterSpawner.CreateMonster(false));
                    locationSchema[4][1] = new CorridorPiece(null, false);
                    locationSchema[4][2] = new CorridorPiece(null, false);
                    locationSchema[3][2] = new CorridorPiece(null, false);
                    locationSchema[2][2] = new Room(new List<IItem> { new ValuableItem("Ruby", 250) },
                                                    monsterSpawner.CreateMonster(false));

                    locationSchema[1][2] = new CorridorPiece(null, false);

                    locationSchema[2][3] = new CorridorPiece(null, false);

                    locationSchema[0][1] = new CorridorPiece(null, false);
                    locationSchema[0][2] = new CorridorPiece(null, false);
                    locationSchema[0][3] = new CorridorPiece(null, false);
                    locationSchema[0][4] = new Room(new List<IItem> { new ValuableItem("Ruby", 250) },
                                                    monsterSpawner.CreateMonster(false));
                    locationSchema[1][4] = new CorridorPiece(null, false);
                    locationSchema[2][4] = new Room(new List<IItem> { new ValuableItem("Ruby", 250) },
                                                    monsterSpawner.CreateMonster(false));
                    locationSchema[3][4] = new CorridorPiece(null, false);
                    locationSchema[4][4] = new Room(new List<IItem> { new ValuableItem("Graveyard Trophy", 250) },
                                                    monsterSpawner.CreateMonster(true));

                    break;
                }
                case LocationType.Catacombs:
                {
                    locationSchema[0][0] = new CorridorPiece(null, false);
                    locationSchema[1][0] = new CorridorPiece(null, false);
                    locationSchema[2][0] = new Room(new List<IItem> { new ValuableItem("Ruby", 250) },
                                                    monsterSpawner.CreateMonster(false));
                    locationSchema[2][1] = new CorridorPiece(null, false);
                    locationSchema[2][2] = new CorridorPiece(null, false);
                    locationSchema[0][1] = new CorridorPiece(null, true);
                    locationSchema[0][2] = new CorridorPiece(null, true);
                    locationSchema[0][3] = new Room(new List<IItem> { new ValuableItem("Amethyst", 200) },
                                                    null);
                    locationSchema[1][3] = new CorridorPiece(null, false);
                    locationSchema[2][3] = new Room(new List<IItem> { new ValuableItem("Ruby", 250), new ValuableItem("Amethyst", 200)},
                                                    monsterSpawner.CreateMonster(false));
                    locationSchema[3][3] = new CorridorPiece(null, false);
                    locationSchema[4][3] = new CorridorPiece(null, true);
                    locationSchema[4][4] = new Room(new List<IItem> { new ValuableItem("Amber", 100) },
                                                    null);
                    locationSchema[4][2] = new CorridorPiece(null, false);
                    locationSchema[4][1] = new CorridorPiece(null, false);
                    locationSchema[4][0] = new Room(new List<IItem> { new ValuableItem("Catacombs trophy", 1300) },
                                                    monsterSpawner.CreateMonster(true));

                    break;
                }
                case LocationType.Swamp:
                {
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
                    locationSchema[4][4] = new Room(new List<IItem> { new ValuableItem("Swamp trophy", 1000) },
                                                    monsterSpawner.CreateMonster(true));
                    break;
                }
                case LocationType.HauntedMansion:
                {
                    locationSchema[0][0] = new CorridorPiece(null, false);
                    locationSchema[1][0] = new CorridorPiece(null, false);
                    locationSchema[2][0] = new Room(new List<IItem> { new ValuableItem("Ruby", 250), new ValuableItem("Amethyst", 200) },
                                                    monsterSpawner.CreateMonster(false));
                    locationSchema[3][0] = new CorridorPiece(null, false);
                    locationSchema[4][0] = new CorridorPiece(null, false);
                    locationSchema[4][1] = new CorridorPiece(null, false);
                    locationSchema[4][2] = new Room(new List<IItem> { new ValuableItem("Ruby", 250), new ValuableItem("Amethyst", 200) },
                                                    monsterSpawner.CreateMonster(false));
                    locationSchema[3][2] = new CorridorPiece(null, false);
                    locationSchema[2][3] = new CorridorPiece(null, false);
                    locationSchema[2][2] = new CorridorPiece(null, false);
                    locationSchema[1][2] = new Room(new List<IItem> { new ValuableItem("Ruby", 250), new ValuableItem("Amethyst", 200) },
                                                    monsterSpawner.CreateMonster(false));
                    locationSchema[0][2] = new CorridorPiece(null, false);
                    locationSchema[0][3] = new CorridorPiece(null, false);
                    locationSchema[0][4] = new CorridorPiece(null, false);
                    locationSchema[1][4] = new Room(new List<IItem> { new ValuableItem("Ruby", 250), new ValuableItem("Amethyst", 200) },
                                                    monsterSpawner.CreateMonster(false));
                    locationSchema[2][4] = new CorridorPiece(null, false);
                    locationSchema[3][4] = new CorridorPiece(null, false);
                    locationSchema[4][4] = new Room(new List<IItem> { new ValuableItem("Haunted Mansion trophy", 1000) },
                                                    monsterSpawner.CreateMonster(true));

                    break;
                }
                default:
                {
                    break;
                }
            }

            LocationMap locationMap = new(locationSchema, xSize, ySize);

            return new Location(type, locationMap);
        }
    }
}

