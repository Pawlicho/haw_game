using System;
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


        public UseConsumableMove(ConsumableItem itemToUse_)
        {
            itemToUse = itemToUse_;
        }

        public int MakeMove()
        {
            if (ItemToUse.Consume())
                Executor.Statistics.Update(ItemToUse.StatBonuses);
            return 0;
        }

        public override string ToString() 
        {
            string temp = "";

            temp += "\nUse Consumable move";
            temp += "\nItem to be used: \n" + itemToUse.ToString(); 

            return temp;
        }
    }
}
