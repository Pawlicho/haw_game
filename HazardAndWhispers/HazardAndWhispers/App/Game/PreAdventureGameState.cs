using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Creators;
using HazardAndWhispers.App.Hamlet;

namespace HazardAndWhispers.App.Game
{
    internal class PreAdventureGameState : IGameState
    {
        private Game gameContext;
        private Hero gameHero;
        private string helpInstructions;
        private HamletCreator hamletGenerator;
        private Hamlet.Hamlet gameHamlet;
        private IBuilding currentBuilding;
        private bool ready;

        public bool Ready
        {
            get { return ready; }
        }

        public IBuilding CurrentBuilding
        {
            get { return currentBuilding; }
        }

        public HamletCreator HamletGenerator
        {
            get { return hamletGenerator; }
        }

        public Hamlet.Hamlet GetHamlet
        {
            get { return gameHamlet; }
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
            get { return helpInstructions; }
        }

        public PreAdventureGameState(Game gameContext_, Hero gameHero_)
        {
            gameContext = gameContext_;
            gameHero = gameHero_;
            hamletGenerator = new HamletCreator(this);
            gameHamlet = hamletGenerator.CreateHamlet();
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
