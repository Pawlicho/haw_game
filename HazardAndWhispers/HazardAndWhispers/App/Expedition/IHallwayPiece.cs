using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Expedition
{
    internal interface IHallwayPiece
    {
        public List<IItem> Reward { get; }

        public void Enter(IAdventureState state);

        public bool HasReward();
    }
}
