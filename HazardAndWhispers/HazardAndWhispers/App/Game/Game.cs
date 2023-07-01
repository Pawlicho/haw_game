using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Adventure;

namespace HazardAndWhispers.App.Game
{
    internal class Game
    {
        private IGameState state;

        private bool isRunning;

        private Dictionary<LocationType, bool> progressState;

        public Dictionary<LocationType, bool> ProgressState
        {
            get { return progressState; }
            set { progressState = value; }
        }
        public IGameState State
        {
            get { return state; }
            set { state = value; }
        }

        public bool IsRunning
        {
            get { return isRunning; }
        }

        public Game()
        {
            isRunning = true;
            state = new MenuGameState(this);
            progressState = new()
            {
                {LocationType.Swamp, false },
                {LocationType.Catacombs, false },
                {LocationType.Graveyard, false },
                {LocationType.HauntedMansion, false }
            };
        }

        /* Just a wrapper, not to bother user with unnessesery dependencies  */
        public string GetHelpInstructions()
        {
            return state.HelpInstructions;
        }

        public string Action(ConsoleKeyInfo keyInfo)
        {

            return state.Action(keyInfo);
        }

        /* Could do a little more then just switching variable */
        public void Finish()
        {
            isRunning = false;
        }
    }
}
