﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.TourMove
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
            executor = executer_;
            receiver = receiver_;
            itemToUse = itemToUse_;
        }

        /* Simply do nothing */
        public int MakeMove()
        {
            if (ItemToUse.Consume())
                Receiver.Statistics.Update(ItemToUse.StatBonuses);
            return 0;
        }
    }
}