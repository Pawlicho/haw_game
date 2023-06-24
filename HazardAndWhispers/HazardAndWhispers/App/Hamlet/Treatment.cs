using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.Hamlet
{
    internal class Treatment
    {
        private int price;
        private (int, int) healRange;
        private string name;
        private int successChance;

        public int Price
        {
            get { return price; }
        }
        public (int, int) HealRange
        {
            get { return healRange; }
        }
        public string Name
        {
            get { return name; } 
        }
        public int SuccessChance
        {
            get { return successChance; } 
        }

        public Treatment(int price_, (int, int) healRange_, string name_, int successChance_)
        {
            price = price_;
            healRange = healRange_;
            name = name_;
            successChance = successChance_;
        }

        public override string ToString() 
        {
            string temp = "";

            temp += "\nName: " + name;
            temp += "\nPrice: " + price;
            temp += "\nHeal: " + healRange.Item1 + "-" + healRange.Item1;
            temp += "\nSuccess Chance: " + successChance;

            return temp;
        }

        public bool TreatHero(Hero patient)
        {
            /* TODO: IMPLEMENT */
            return true;
        }
    }
}
