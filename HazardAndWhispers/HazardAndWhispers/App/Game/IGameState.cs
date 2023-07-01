using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.Game
{
    internal interface IGameState
    {
        public Game GameContext { get; set; }
        public Hero GameHero { get; set; }
        public string HelpInstructions { get;}
        public bool Ready { get; set; }
        public string Action(ConsoleKeyInfo keyInfo);
        public void ChangeState(IGameState prevState);
    }
}
