using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.TourMove;

namespace HazardAndWhispers.App.Alive
{
    internal interface IAlive
    {
        public StatRegister Statistics { get; }
        public List<ITourMove> MoveSet { get; }
        public int RunMove(int moveId);

    }
}
