using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class UseConsumableMove : ITourMove
    {
        private IAlive executor;
        private IAlive receiver;
        private ConsumableItem itemToUse;

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
        public ConsumableItem ItemToUse
        {
            get => itemToUse;
            set => itemToUse = value;
        }


        public UseConsumableMove(IAlive executer_, IAlive receiver_, ConsumableItem itemToUse_)
        {
            Executor = executer_;
            Receiver = receiver_;
            ItemToUse = itemToUse_;
        }

        /* Simply do nothing */
        public int MakeMove()
        {
            if (ItemToUse.Consume())
                Receiver.Statisctics.Update(ItemToUse.StatBonuses);
            return 0;
        }
    }
}
