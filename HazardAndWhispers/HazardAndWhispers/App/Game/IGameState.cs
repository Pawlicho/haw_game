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

        public string Action(ConsoleKey key);
        public void Init();
        public IGameState ChangeState(IGameState prevState);
    }
}
