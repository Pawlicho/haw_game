using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Alive
{
    internal class Inventory
    {
        private uint maxSize;
        private List<IItem> itemSet;

        public uint MaxSize
        {
            get { return maxSize; }
        }
        public List<IItem> ItemSet
        {
            get { return itemSet; }
        }

        public Inventory(uint maxSize_)
        {
            itemSet = new List<IItem>();
            maxSize = maxSize_;
        }

        public bool AddItem(IItem item)
        {
            if (itemSet.Count == maxSize)
            {
                return false;
            }

            itemSet.Add(item);
            return true;
        }

        public bool DropItem(int idx)
        {
            if (itemSet.Count() > idx && idx >= 0)
            {
                itemSet.RemoveAt(idx);
            }
            return false;
        }
    }
}
