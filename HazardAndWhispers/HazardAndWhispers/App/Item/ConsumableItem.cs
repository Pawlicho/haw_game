using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.Item
{
    internal class ConsumableItem : IItem
    {
        private const uint maxNumberOfUsage = 3;
        private string name;
        private bool isConsumable;
        private bool isEquipable;
        private uint goldValue;
        private uint numberOfUsageLeft;
        private StatRegister statBonuses;

        public string Name
        {
            get { return name; }
        }
        public bool IsConsumable
        {
            get { return isConsumable; }
        }
        public bool IsEquipable
        {
            get { return isEquipable; }
        }
        public uint GoldValue
        {
            get { return goldValue; }
        }
        public uint NumberOfUsageLeft
        {
            get { return numberOfUsageLeft; }
        }
        public StatRegister StatBonuses
        {
            get { return statBonuses; }
        }
        public uint MaxNumberOfUsage
        {
            get { return maxNumberOfUsage; }
        }

        /* TODO add some mechanism to autogenerate proper register based on the Potion Type or food */
        public StatRegister CreatePotionStatRegister()
        {
            /* Do some random operations here */
            return new StatRegister();
        }
        public ConsumableItem(string name_, uint goldValue_, StatRegister statBonuses_)
        {
            numberOfUsageLeft = MaxNumberOfUsage;
            isConsumable = true;
            isEquipable = false;
            name = name_;
            goldValue = goldValue_;
            statBonuses = statBonuses_;
        }

        public bool Consume()
        {
            if (NumberOfUsageLeft > 0)
            {
                numberOfUsageLeft--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString() 
        {
            string temp = "";

            temp += "\nName: " + name;
            temp += "\nConsumableItem: ";
            temp += "\nGold Value: " + goldValue;
            temp += "\nBonuses\n" + statBonuses.ToString();
            temp += "\nUsage Left: " + numberOfUsageLeft;

            return temp;
        }
    }
}
