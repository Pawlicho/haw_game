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

        public Game()
        {
            isRunning = true;
            state = new MenuGameState(this);
        }

        public void Run()
        {
            while(isRunning) 
            {
                /* Print help for the user */
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(state.HelpInstructions);
                Console.ResetColor();

                /* Wait for the keybord input and clear CLI */
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.Clear();

                /* Execute Action and print the output */
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(state.Action(keyInfo.Key));
                Console.ResetColor();
            }
        }

        /* Could do a little more then just switching variable */
        public void Finish()
        {
            isRunning = false;
        }
    }
}
