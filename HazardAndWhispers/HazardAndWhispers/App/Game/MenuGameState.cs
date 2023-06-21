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
            helpInstructions = "\nPress one of the below key for action:";
            helpInstructions += "\nH: Help instructions";
            helpInstructions += "\nQ: Quit the game";
            helpInstructions += "\nW: To create a Hero of class Warrior";
            helpInstructions += "\nM: To create a Hero of class Mage";
            helpInstructions += "\nA: To create a Hero of class Assasin";
            helpInstructions += "\nP: To create a Hero of class Paladin";
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
                case ConsoleKey.W:
                    {
                        gameHero = heroInitializer.CreateHero(ClassType.Warrior);
                        return "\nWarrior created!";
                    }
                case ConsoleKey.M:
                    {
                        gameHero = heroInitializer.CreateHero(ClassType.Mage);
                        return "\nMage created!";
                    }
                case ConsoleKey.A:
                    {
                        gameHero = heroInitializer.CreateHero(ClassType.Assasin);
                        return "\nAssasin created!";
                    }
                case ConsoleKey.P:
                    {
                        gameHero = heroInitializer.CreateHero(ClassType.Paladin);
                        return "\nPaladinCreated";
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
