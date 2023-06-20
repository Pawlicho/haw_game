using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game
{
    internal class Game
    {
        private IGameState state;

        public IGameState State
        {
            get { return state; }
            set { state = value; }
        }

        public void Run()
        {
            while(true) 
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine(state.Action(keyInfo.Key));
            }
        }
    }
}
