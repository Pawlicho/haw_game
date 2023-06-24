using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Creators;

namespace HazardAndWhispers.App.Game
{
    internal class MenuGameState : IGameState
    {
        private Game gameContext;
        private Hero gameHero;
        private string helpInstructions;
        private HeroCreator heroInitializer;
        private bool ready;
        private bool heroSelectionFlag;

        public bool Ready
        {
            get { return ready; }
        }

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
            heroSelectionFlag = false;
            gameContext = gameContext_;
            heroInitializer = new HeroCreator();
            ready = false;
        }
        public string HelpInstructions
        {
            get 
            {
                helpInstructions = "\nPress key for: ";
                helpInstructions += "\nH: Help instructions";
                helpInstructions += "\nQ: Quit the game";
                
                if (heroSelectionFlag)
                {
                    helpInstructions += "\n";
                    helpInstructions += "\nW: Create a Hero of class Warrior";
                    helpInstructions += "\nM: Create a Hero of class Mage";
                    helpInstructions += "\nA: Create a Hero of class Assasin";
                    helpInstructions += "\nP: Create a Hero of class Paladin";
                }
                else
                {
                    helpInstructions += "\nC: Create hero";
                }

                if (ready)
                {
                    helpInstructions += "\nSpacebar: Show hero stats";
                    helpInstructions += "\nN: Start Geame";
                }

                return helpInstructions; 
            }
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
                case ConsoleKey.C:
                    {
                        heroSelectionFlag = true;
                        return "\nHero selection mode. Press key to create hero!";
                    }
                case ConsoleKey.N:
                    {
                        ChangeState(gameContext.State);
                        return "\nGame begins.";
                    }
                case ConsoleKey.Spacebar:
                    {
                        return gameHero.ToString();
                    }
                case ConsoleKey.W:
                    {
                        if (heroSelectionFlag)
                        {
                            gameHero = heroInitializer.CreateHero(ClassType.Warrior);
                            heroSelectionFlag = false;
                            ready = true;
                            return "\nWarrior created!\n" + gameHero.ToString();
                        }
                        break;
                    }
                case ConsoleKey.M:
                    {
                        if (heroSelectionFlag)
                        {
                            gameHero = heroInitializer.CreateHero(ClassType.Mage);
                            heroSelectionFlag = false;
                            ready = true;
                            return "\nMage created!\n" + gameHero.ToString();
                        }
                        break; ;
                    }
                case ConsoleKey.A:
                    {
                        if (heroSelectionFlag)
                        {
                            gameHero = heroInitializer.CreateHero(ClassType.Assasin);
                            heroSelectionFlag = false;
                            ready = true;
                            return "\nAssasin created!\n" + gameHero.ToString();
                        }
                        break;
                    }
                case ConsoleKey.P:
                    {
                        if (heroSelectionFlag)
                        {
                            gameHero = heroInitializer.CreateHero(ClassType.Paladin);
                            heroSelectionFlag = false;
                            ready = true;
                            return "\nPaladinCreated\n" + gameHero.ToString();
                        }
                        break;
                    }
            }
            return String.Empty;
        }

        public void ChangeState(IGameState prevState)
        {
            if (ready)
            {
                PreAdventureGameState newState = new(gameContext, gameHero);
                gameContext.State = newState;
            }
        }

    }
}
