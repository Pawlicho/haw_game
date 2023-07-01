using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Adventure;
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
            get 
            {
                helpInstructions = "\nPress key for: ";
                helpInstructions += "\nH: Help instructions";
                if (currentExpedition.State is ExploreAdventureState)
                {
                    helpInstructions += "\nUse arrows to move around the map";
                    helpInstructions += "\nM: Show Map";
                    helpInstructions += "\nP: Show Hero's current position";
                }

                return helpInstructions;
            }
        }

        public ExpeditionGameState(Game gameContext_,
                                   Hero gameHero_,
                                   Adventure.Expedition currentExpedition_)
        {
            gameContext = gameContext_;
            gameHero = gameHero_;
            currentExpedition = currentExpedition_;
            ready = false;
        }

        public string Action(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.H:
                {
                    return helpInstructions;
                }
                case ConsoleKey.M:
                {
                    if (currentExpedition.State is ExploreAdventureState)
                        return currentExpedition.Destination.Map.GetMap(currentExpedition.HeroPos) + "\nHero Position: " + currentExpedition.HeroPos.ToString();
                    else
                        break;
                }
                case ConsoleKey.P:
                {
                    if (currentExpedition.State is ExploreAdventureState)
                        return "\nHero Position: " + currentExpedition.HeroPos.ToString();
                    else
                        break;
                }
                case ConsoleKey.UpArrow:
                {
                    return currentExpedition.Action(key);
                }
                case ConsoleKey.DownArrow:
                {
                    return currentExpedition.Action(key);
                }
                case ConsoleKey.LeftArrow:
                {
                    return currentExpedition.Action(key);
                }
                case ConsoleKey.RightArrow:
                {
                    return currentExpedition.Action(key);
                }
                default:
                {
                    return "\nWrong key";
                }
            }
            return "\nWrong key";
        }

        public void ChangeState(IGameState prevState)
        {
       
        }
    }
}
