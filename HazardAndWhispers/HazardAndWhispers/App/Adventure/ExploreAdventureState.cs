using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Adventure
{
    internal class ExploreAdventureState : IAdventureState
    {
        private Expedition expeditionContext;

        public Expedition ExpeditionContext
        {
            get { return expeditionContext; }
            set { expeditionContext = value; }
        }

        public ExploreAdventureState(Expedition expeditionContext_)
        {
            ExpeditionContext = expeditionContext_;
        }

        public string Action(ConsoleKeyInfo keyInfo)
        {
            ConsoleKey key = keyInfo.Key;
            Direction currDirection;
            Coords newCoords = new Coords(0, 0);

            switch (key)
            {
                case ConsoleKey.UpArrow:
                {
                    /* Set hero's position */
                    newCoords = new(expeditionContext.HeroPos.X - 1, expeditionContext.HeroPos.Y);
                    if (newCoords.X < 0)
                        return "You are not allowed to move there. See map!\n" + expeditionContext.Destination.Map.GetMap(expeditionContext.HeroPos);

                    currDirection = Direction.Up;
                    break;
                }
                case ConsoleKey.DownArrow:
                {
                    /* Set hero's position */
                    newCoords = new(expeditionContext.HeroPos.X + 1, expeditionContext.HeroPos.Y);
                    if (newCoords.X >= expeditionContext.Destination.Map.XSize)
                        return "You are not allowed to move there. See map!\n" + expeditionContext.Destination.Map.GetMap(expeditionContext.HeroPos);

                    currDirection = Direction.Down;
                    break;
                }
                case ConsoleKey.LeftArrow:
                {
                    /* Set hero's position */
                    newCoords = new(expeditionContext.HeroPos.X, expeditionContext.HeroPos.Y - 1);
                    if (newCoords.Y < 0)
                        return "You are not allowed to move there. See map!\n" + expeditionContext.Destination.Map.GetMap(expeditionContext.HeroPos);

                    currDirection = Direction.Left;
                    break;
                }
                case ConsoleKey.RightArrow:
                {
                    /* Set hero's position */
                    newCoords = new(expeditionContext.HeroPos.X, expeditionContext.HeroPos.Y + 1);
                    if (newCoords.Y >= expeditionContext.Destination.Map.YSize)
                        return "You are not allowed to move there. See map!\n" + expeditionContext.Destination.Map.GetMap(expeditionContext.HeroPos);

                    currDirection = Direction.Right;
                    break;
                }
                default:
                {
                    return "Wrong key!\n";
                }
            }

            IHallwayPiece nextPiece = expeditionContext.Destination.Map.GetNextPiece(newCoords);
            if (nextPiece is BlankPiece || nextPiece == null)
            {
                return "You are not allowed to move there. See map!\n" + expeditionContext.Destination.Map.GetMap(expeditionContext.HeroPos);
            }

            expeditionContext.HeroPos = newCoords;


            expeditionContext.CurrPiece = nextPiece;

            return "Hero's moving " + Enum.GetName(typeof(Direction), currDirection) +
                     "...\nNew position: " + expeditionContext.Destination.Map.GetMap(expeditionContext.HeroPos) + "\nNew coordinates: " +
                     expeditionContext.HeroPos+
                    expeditionContext.CurrPiece.Enter(this);
        }
    }
}
