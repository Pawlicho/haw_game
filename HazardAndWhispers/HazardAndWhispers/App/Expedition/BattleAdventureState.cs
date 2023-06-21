using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Expedition
{
    internal class BattleAdventureState : IAdventureState
    {
        private Expedition expeditionContext;

        public Expedition ExpeditionContext
        {
            get { return expeditionContext; }
            set { expeditionContext = value; }
        }

        public BattleAdventureState(Expedition expeditionContext_)
        {
            ExpeditionContext = expeditionContext_;
        }

        public string Action(ConsoleKey key)
        {
            /* TODO: IMPLEMENT */
            return String.Empty;
        }
    }
}
