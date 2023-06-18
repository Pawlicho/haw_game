using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class SkipTourMove : ITourMove
    {
        private IAlive? executer;
        private IAlive? receiver;

        public IAlive? Executer
        {
            get => executer;
            set => executer = value;
        }

        public IAlive? Receiver
        {
            get => receiver;
            set => receiver = value;
        }

        public SkipTourMove(IAlive? executer_, IAlive? receiver_)
        {
            Executer = executer_;
            Receiver = receiver_;
        }

        /* Simply do nothing */
        public int MakeMove()
        {
            return 0;
        }
    }
}
