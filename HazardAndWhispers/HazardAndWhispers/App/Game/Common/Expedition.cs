using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class Expedition
    {
        private Location destination;
        private Hero visitor;
        private IAdventureState state;
        private Coords heroPos;
        private IHallwayPiece currPiece;

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
                          IAdventureState state_,
                          Coords heroPos_,
                          IHallwayPiece currPiece_)
        {
            destination = destination_;
            Visitor = visitor_;
            State = state_;
            HeroPos = heroPos_;
            CurrPiece = currPiece_;
        }

        public string Action(ConsoleKey key)
        {
            return state.Action(key);
        }
    }
}
