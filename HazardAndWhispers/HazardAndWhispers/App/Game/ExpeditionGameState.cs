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
        private string helpInstructions;
        private Adventure.Expedition currentExpedition;
        private bool ready;

        public bool Ready
        {
            get { return ready; }
            set { ready = value; }
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
                    if (ready)
                    {
                        helpInstructions += "\nL: Leave location";
                    }
                }
                if (currentExpedition.State is BattleAdventureState)
                {
                    helpInstructions += "\nS: Show Hero's skill set";
                    helpInstructions += "\nC: Show enemy's details";
                    helpInstructions += "\nE: Show HP levels";
                    helpInstructions += "\n0-9: Make a move";
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
            currentExpedition.State = new ExploreAdventureState(currentExpedition);
            ready = false;
        }

        public string Action(ConsoleKeyInfo keyInfo)
        {
            ConsoleKey key = keyInfo.Key;
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
                case ConsoleKey.S:
                {
                    if (currentExpedition.State is BattleAdventureState)
                    {
                        /* Move set*/
                        string temp = "";
                        int tempInt = 0;
                        temp += "\n\nMove set: ";
                        foreach (var move in gameHero.MoveSet)
                        {
                            temp += "\n\n" + tempInt + ": " + move.ToString();
                            tempInt++;
                        }
                        return temp;
                    }
                    else
                        break;
                }
                case ConsoleKey.E:
                {
                    if (currentExpedition.State is BattleAdventureState)
                    {
                        Room currRoom = currentExpedition.CurrPiece as Room;
                        return "Hero's HP: " + gameHero.Statistics.HealthPoints + " / " + gameHero.Statistics.MaxHealthPoints +
                               "\nEnemy HP: " + currRoom.Enemy.Statistics.HealthPoints + " / " + currRoom.Enemy.Statistics.MaxHealthPoints;
                    }
                    else
                        break;
                }
                case ConsoleKey.C:
                {
                    if (currentExpedition.State is BattleAdventureState)
                        return currentExpedition.Action(keyInfo);
                    else
                        break;
                }
                case ConsoleKey.L:
                {
                    ChangeState(this);
                    gameContext.ProgressState[currentExpedition.Destination.Type] = true;
                    return "Leaving location\n";
                }
                case ConsoleKey.UpArrow:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.DownArrow:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.LeftArrow:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.RightArrow:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D0:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D1:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D2:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D3:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D4:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D5:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D6:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D7:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D8:
                {
                    return currentExpedition.Action(keyInfo);
                }
                case ConsoleKey.D9:
                {
                    return currentExpedition.Action(keyInfo);
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
            gameContext.State = new PreAdventureGameState(gameContext, gameHero);
        }
    }
}
