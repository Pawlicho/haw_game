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

        private string welcomeMsg;
        private string farewellMsg;

        public string FarewellMsg
        {
            get { return farewellMsg; }
        }

        public string WelcomeMsg
        {
            get { return welcomeMsg; }
        }

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

            welcomeMsg = "Welcome to Hazard & Whispers! Wish you great time playing.\nLet's begin!\n\n" +
                                        "      .-\"\"\"-.\n" +
                          "     /      o\\\n" +
                          "    |    o   0).-.\n" +
                          "    |       .-;(_/     .-.\n" +
                          "     \\     /  /)).---._|  |_\n" +
                          "      '.  '  /((       `'-._`'-.\n" +
                          "        \\  .'  )\\            `-`\n" +
                          "         '.  .'  .';\n" +
                          "           `\"\"\"\"\"\"`\n";

            farewellMsg = "\nCongatulations! You have successfully completed the game\n" +
                          "Thank you for playing!\n";
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
        public bool EvalGame()
        {
            foreach(var state in progressState) 
            {
                if (!(state.Value))
                    return true;
            }
            return false;
        }
        public void Finish()
        {
            isRunning = false;
        }
    }
}
