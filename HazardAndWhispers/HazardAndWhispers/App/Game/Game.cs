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

        private bool isRunning;

        public IGameState State
        {
            get { return state; }
            set { state = value; }
        }

        public bool IsRunning
        {
            get { return isRunning; }
        }

        public Game()
        {
            isRunning = true;
            state = new MenuGameState(this);
        }

        /* Just a wrapper, not to bother user with unnessesery dependencies  */
        public string GetHelpInstructions()
        {
            return state.HelpInstructions;
        }

        public string Action(ConsoleKey key)
        {

            return state.Action(key);
        }

        /* Could do a little more then just switching variable */
        public void Finish()
        {
            isRunning = false;
        }
    }
}
