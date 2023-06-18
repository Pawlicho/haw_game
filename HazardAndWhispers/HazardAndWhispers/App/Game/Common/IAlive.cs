using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal interface IAlive
    {
        public StatRegister Statisctics { get; }
        public List<ITourMove> MoveList { get; }
        public bool RunMove(int moveId);

    }
}
