﻿using System;
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
            get 
            {
                helpInstructions = "\nYou are in " + currentBuilding.Name + "\n";
                helpInstructions += "\nPress key for: ";
                helpInstructions += "\nH: Help instructions";
                helpInstructions += "\nQ: Quit the game";
                helpInstructions += "\nC: Enter Courtyard";
                helpInstructions += "\nI: Enter Inn";
                helpInstructions += "\nA: Enter Armorer";
                helpInstructions += "\nB: Enter BlackSmith";
                helpInstructions += "\nM: Enter Hospital";
                helpInstructions += "\nG: Enter Guild";

                return helpInstructions;
            }
        }

        public PreAdventureGameState(Game gameContext_, Hero gameHero_)
        {
            gameContext = gameContext_;
            gameHero = gameHero_;
            hamletGenerator = new HamletCreator(this);
            gameHamlet = hamletGenerator.CreateHamlet();
            ready = false;
            currentBuilding = gameHamlet.Map[BuildingType.Courtyard];
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
                        currentBuilding = gameHamlet.Map[BuildingType.Courtyard];
                        return "\nEntering the " + currentBuilding.Name + currentBuilding.WelcomeMessage;
                    }
                case ConsoleKey.I:
                    {
                        currentBuilding = gameHamlet.Map[BuildingType.Inn];
                        return "\nEntering the " + currentBuilding.Name + currentBuilding.WelcomeMessage;
                    }
                case ConsoleKey.M:
                    {
                        currentBuilding = gameHamlet.Map[BuildingType.Hospital];
                        return "\nEntering the " + currentBuilding.Name + currentBuilding.WelcomeMessage;
                    }
                case ConsoleKey.B:
                    {
                        currentBuilding = gameHamlet.Map[BuildingType.Blacksmith];
                        return "\nEntering the " + currentBuilding.Name + currentBuilding.WelcomeMessage;
                    }
                case ConsoleKey.G:
                    {
                        currentBuilding = gameHamlet.Map[BuildingType.Guild];
                        return "\nEntering the " + currentBuilding.Name + currentBuilding.WelcomeMessage;
                    }
                case ConsoleKey.A:
                    {
                        currentBuilding = gameHamlet.Map[BuildingType.Armorer];
                        return "\nEntering the " + currentBuilding.Name + currentBuilding.WelcomeMessage;
                    }
                case ConsoleKey.D0: 
                    {
                        return currentBuilding.Action(key);
                    }
                case ConsoleKey.D1:
                    {
                        return currentBuilding.Action(key);
                    }
                case ConsoleKey.D2:
                    {
                        return currentBuilding.Action(key);
                    }
                case ConsoleKey.D3:
                    {
                        return currentBuilding.Action(key);
                    }
                case ConsoleKey.D4:
                    {
                        return currentBuilding.Action(key);
                    }
                case ConsoleKey.D5:
                    {
                        return currentBuilding.Action(key);
                    }
                case ConsoleKey.D6:
                    {
                        return currentBuilding.Action(key);
                    }
                case ConsoleKey.D7:
                    {
                        return currentBuilding.Action(key);
                    }
                case ConsoleKey.D8:
                    {
                        return currentBuilding.Action(key);
                    }
                case ConsoleKey.D9:
                    {
                        return currentBuilding.Action(key);
                    }

            }
            return String.Empty;
        }

        public void ChangeState(IGameState prevState)
        {
           
        }
    }
}
