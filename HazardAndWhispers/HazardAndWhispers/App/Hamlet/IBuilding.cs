using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Hamlet
{
    internal interface IBuilding
    {
        public string Name { get; }
        public PreAdventureGameState State { get; }
        public string WelcomeMessage { get; }
        public string Action(ConsoleKeyInfo keyInfo);
    }
}
