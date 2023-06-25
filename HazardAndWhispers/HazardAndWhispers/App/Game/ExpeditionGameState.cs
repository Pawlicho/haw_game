using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Creators;

namespace HazardAndWhispers.App.Game
{
    internal class ExpeditionGameState : IGameState
    {
        private Game gameContext;
        private Hero gameHero;
        private readonly Adventure.Expedition currentExpedition_;
        private string helpInstructions;
        private Adventure.Expedition currentExpedition;
        private bool ready;

        public bool Ready
        {
            get { return ready; }
        }

        public Adventure.Expedition CurrentExpedition
        {
            get { return currentExpedition; }
        }
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
            get { return helpInstructions;}
        }

        public ExpeditionGameState(Game gameContext_,
                                   Hero gameHero_,
                                   Adventure.Expedition currentExpedition_)
        {
            gameContext = gameContext_;
            gameHero = gameHero_;
            currentExpedition = currentExpedition_;
            ready = false;
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

        public void ChangeState(IGameState prevState)
        {
       
        }
    }
}
