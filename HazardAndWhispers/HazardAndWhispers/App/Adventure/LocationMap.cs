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
            if (locationSchema == null)
            {
                locationSchema = new List<List<IHallwayPiece>>();
            }
            else
            {
                locationSchema = locationSchema_;
            }
        }

        public IHallwayPiece GetNextPiece(Coords pos, Direction direction)
        {
            /*
             * 1. Check if next move is in map border
             * 2. Check if that particular element in list is not null
             * 3. If null return null (higher layer would handle it), 
             *    otherwise return proper IHallwayPiece
             */

            switch (direction)
            {
                case Direction.Left:
                    {
                        if (pos.X - 1 < 0)
                        {
                            break;
                        }
                        return locationSchema[xSize - 1][YSize];
                    }
                case Direction.Right:
                    {
                        if (pos.X + 1 >= xSize)
                        {
                            break;
                        }
                        return locationSchema[xSize + 1][YSize];
                    }
                case Direction.Up:
                    {
                        if (pos.Y + 1 >= ySize)
                        {
                            break;
                        }
                        return locationSchema[xSize][YSize + 1];
                    }
                case Direction.Down:
                    {
                        if (pos.Y - 1 < 0)
                        {
                            break;
                        }
                        return locationSchema[xSize][YSize - 1];
                    }
            }

            return null;
        }
    }
}
