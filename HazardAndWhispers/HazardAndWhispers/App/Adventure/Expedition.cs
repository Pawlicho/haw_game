using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Adventure
{
    internal class Expedition
    {
        private Location destination;
        private Hero visitor;
        private IAdventureState state;
        private Coords heroPos;
        private IHallwayPiece currPiece;
        private Game.Game gameContext;

        public Game.Game GameContext
        {
            get { return gameContext; }
            set { gameContext = value; }
        }

        public Location Destination
        {
            get { return destination; }
        }
        public Hero Visitor
        {
            get { return visitor; }
            set { visitor = value; }
        }
        public IAdventureState State
        {
            get { return state; }
            set { state = value; }
        }
        public Coords HeroPos
        {
            get { return heroPos; }
            set { heroPos = value; }
        }
        public IHallwayPiece CurrPiece
        {
            get { return currPiece; }
            set { currPiece = value; }
        }

        public Expedition(Location destination_,
                          Hero visitor_,
                          Game.Game gameContext_)
        {
            destination = destination_;
            Visitor = visitor_;
            HeroPos = new Coords(0, 0);
            state = new ExploreAdventureState(this);
            CurrPiece = destination_.Map.LocationSchema[0][0];
            gameContext = gameContext_;
        }
        public string Action(ConsoleKeyInfo keyInfo)
        {
            return state.Action(keyInfo);
        }
    }
}
