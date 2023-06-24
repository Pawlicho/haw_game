using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.TourMove
{
    internal interface ITourMove
    {
        public IAlive Executor { get; }
        public IAlive Receiver { get; } /* TODO: think if it is not misleading name */

        public int MakeMove();

        public string ToString();
    }
}
