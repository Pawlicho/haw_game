using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.TourMove
{
    internal class SkipTourMove : ITourMove
    {
        private IAlive executor;
        private IAlive receiver;

        public IAlive Executor
        {
            get => executor;
            set => executor = value;
        }

        public IAlive Receiver
        {
            get => receiver;
            set => receiver = value;
        }

        public SkipTourMove(IAlive executer_, IAlive receiver_)
        {
            executor = executer_;
            receiver = receiver_;
        }

        /* Simply do nothing */
        public int MakeMove()
        {
            return 0;
        }
    }
}
