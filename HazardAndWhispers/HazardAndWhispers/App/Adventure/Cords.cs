using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Adventure
{
    public struct Coords
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coords(int x_, int y_)
        {
            X = x_;
            Y = y_;
        }
        public override string ToString() => $"({X}, {Y})";
    }
}