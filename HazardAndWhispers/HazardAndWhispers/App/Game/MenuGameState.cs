using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.Game
{
    internal class MenuGameState : IGameState
    {
        private Game gameContext;
        private Hero gameHero;
        private string helpInstructions;


        public Game GameContext
        {
            get { return gameContext; }
            set { gameContext = value; }
        }
        public Hero GameHero
        { 
            get { return gameHero; }
            set {  gameHero = value; }
        }

        public MenuGameState(Game gameContext_)
        {
            helpInstructions = "\nPress one of the below key for action:\nH: Help instructions\nQ: Quit the game\n";
            gameContext = gameContext_;
        }
        public string HelpInstructions
        {
            get { return helpInstructions; }
        }

        public string Action(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.H:
                    {
                        return helpInstructions;
                    }
                case ConsoleKey.Q:
                    {
                        gameContext.Finish();
                        return "\nGame finished! Closing...";
                    }
            }
            return String.Empty;
        }

        public IGameState ChangeState(IGameState prevState)
        {
            return null;
        }

    }
}
