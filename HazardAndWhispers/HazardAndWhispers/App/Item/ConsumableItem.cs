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
        private const int maxNumberOfUsage = 3;
        private string name;
        private bool isConsumable;
        private bool isEquipable;
        private int goldValue;
        private int numberOfUsageLeft;
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
        public int GoldValue
        {
            get { return goldValue; }
        }
        public int NumberOfUsageLeft
        {
            get { return numberOfUsageLeft; }
        }
        public StatRegister StatBonuses
        {
            get { return statBonuses; }
        }
        public int MaxNumberOfUsage
        {
            get { return maxNumberOfUsage; }
        }

        /* TODO add some mechanism to autogenerate proper register based on the Potion Type or food */
        public StatRegister CreatePotionStatRegister()
        {
            /* Do some random operations here */
            return new StatRegister();
        }
        public ConsumableItem(string name_, int goldValue_, StatRegister statBonuses_)
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
            temp += statBonuses.ToString();
            temp += "\nUsage Left: " + numberOfUsageLeft;

            return temp;
        }
    }
}
