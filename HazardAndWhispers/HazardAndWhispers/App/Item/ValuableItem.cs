﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Item
{
    internal class ValuableItem : IItem
    {
        private string name;
        private bool isConsumable;
        private bool isEquipable;
        private uint goldValue;
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

        public ValuableItem(string name_, uint goldValue_)
        {
            name = name_;
            goldValue = goldValue_;
            isConsumable = false;
            isEquipable = false;
        }

        public override string ToString() 
        {
            string temp = "";

            temp += "\nName: " + name;
            temp += "\nValuable item";
            temp += "\nGold Value: " + goldValue;

            return temp;
        }
    }
}
