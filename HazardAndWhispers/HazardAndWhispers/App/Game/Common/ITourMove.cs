using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal interface ITourMove
    {
        public IAlive Executer { get; }
        public IAlive Receiver { get; } /* TODO: think if it is not misleading name */

        public int MakeMove();
    }
}
