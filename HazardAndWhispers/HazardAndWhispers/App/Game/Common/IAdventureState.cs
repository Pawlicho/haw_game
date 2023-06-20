using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal interface IAdventureState
    {
        public Expedition ExpeditionContext { get; set; }
        public string Action(ConsoleKey key);
    }
}
