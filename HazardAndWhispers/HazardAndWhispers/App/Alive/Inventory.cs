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

        public IItem GetItem(int idx)
        {
            return itemSet[idx];
        }

        public int GetInventoryCount()
        {
            return itemSet.Count;
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

        public void AddItem(IItem item, int idx)
        {
            itemSet[idx] = item;
        }

        public bool DropItem(int idx)
        {
            if (itemSet.Count() > idx && idx >= 0)
            {
                itemSet.RemoveAt(idx);
            }
            return false;
        }

        public override string ToString() 
        {
            string temp = "";
            int tempInt = 0;

            foreach (var item in itemSet) 
            {
                temp += "\n" + tempInt + ": ";
                temp += item.ToString();
                tempInt++;
            }

            return temp;
        }
    }
}
