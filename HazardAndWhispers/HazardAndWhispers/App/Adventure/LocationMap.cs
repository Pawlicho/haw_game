using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Adventure
{
    internal class LocationMap
    {
        private int xSize;
        private int ySize;
        private List<List<IHallwayPiece>> locationSchema;

        public int XSize
        {
            get { return xSize; }
        }
        public int YSize
        {
            get { return ySize; }
        }
        public List<List<IHallwayPiece>> LocationSchema
        {
            get { return locationSchema; }
        }

        public LocationMap(List<List<IHallwayPiece>> locationSchema_, int xSize_, int ySize_)
        {
            xSize = xSize_;
            ySize = ySize_;
            locationSchema = locationSchema_;
        }

        public IHallwayPiece GetNextPiece(Coords pos)
        {
            return locationSchema[pos.X][pos.Y];
        }

        public string GetMap() 
        {
            string temp = "\n   ";
            for (int i = 0; i < xSize; i++)
            {
                temp += " " + i;
            }
            temp += "\n   ";
            for (int i = 0; i < xSize; i++)
            {
                temp += "__";
            }

            for (int x = 0; x < xSize; x++)
            {
                temp += " \n" + x + "| ";
                for (int y = 0; y < ySize; y++)
                {
                    if (locationSchema[x][y] is BlankPiece)
                    {
                        temp += "  ";
                    }
                    else if (locationSchema[x][y] is CorridorPiece)
                    {
                        temp += " -";
                    }
                    else if (locationSchema[x][y] is Room)
                    {
                        temp += " O";
                    }
                }
                temp += " | " + x;
            }
            temp += "\n   ";
            for (int i = 0; i < xSize; i++)
            {
                temp += "__";
            }
            temp += "\n   ";
            for (int i = 0; i < xSize; i++)
            {
                temp += " " + i;
            }

            temp += "\n\nLegend:\n'O': Room\n'-': Corridor\n";

            return temp;
        }

        public string GetMap(Coords heroPos)
        {
            string temp = "\n   ";
            for (int i = 0; i < xSize; i++)
            {
                temp += " " + i;
            }
            temp += "\n   ";
            for (int i = 0; i < xSize; i++)
            {
                temp += "__";
            }

            for (int x = 0; x < xSize; x++)
            {
                temp += " \n" + x + "| ";
                for (int y = 0; y < ySize; y++)
                {
                    if (x == heroPos.X && y == heroPos.Y)
                    {
                        temp += " x";
                        continue;
                    }
                    if (locationSchema[x][y] is BlankPiece)
                    {
                        temp += "  ";
                    }
                    else if (locationSchema[x][y] is CorridorPiece)
                    {
                        temp += " -";
                    }
                    else if (locationSchema[x][y] is Room)
                    {
                        temp += " O";
                    }
                }
                temp += " | " + x;
            }
            temp += "\n   ";
            for (int i = 0; i < xSize; i++)
            {
                temp += "__";
            }
            temp += "\n   ";
            for (int i = 0; i < xSize; i++)
            {
                temp += " " + i;
            }

            temp += "\n\nLegend:\n'O': Room\n'-': Corridor\n'x': Hero\n";

            return temp;
        }
    }
}
