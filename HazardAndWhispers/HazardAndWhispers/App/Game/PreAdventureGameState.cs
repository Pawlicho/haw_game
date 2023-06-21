using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.Game
{
    internal class PreAdventureGameState : IGameState
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
            set { gameHero = value; }
        }
        public string HelpInstructions
        {
            get { return helpInstructions; }
        }

        public PreAdventureGameState(Game gameContext_, Hero gameHero_)
        {
            gameContext = gameContext_;
            gameHero = gameHero_;
            helpInstructions = "\nPress one of the below key for action:\n";
        }

        public string Action(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.H:
                    {
                        return helpInstructions;
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
