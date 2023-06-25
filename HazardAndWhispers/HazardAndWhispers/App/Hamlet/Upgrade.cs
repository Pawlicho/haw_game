using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.Hamlet
{
    internal class Upgrade
    {
        private string name;
        private StatRegister bonus;
        private int price;
        private int successChance;

        public string Name
        {
            get { return name; }
        }
        public StatRegister Bonus
        {
            get { return bonus; } 
        }
        public int Price
        {
            get { return price; } 
        }
        public int SuccessChance
        {
            get { return successChance; }
        }

        public Upgrade(string name_, StatRegister bonus_, int price_, int successChance_)
        {
            name = name_;
            bonus = bonus_;
            price = price_;
            successChance = successChance_;
        }

        public override string ToString()
        {
            string temp = "";

            temp += "\nName: " + name;
            temp += "\nPrice: " + price;
            temp += bonus.ToString();
            temp += "\nSuccess Chance: " + successChance;

            return temp;
        }
        public bool UpgradeHero(Hero customer)
        {
            Random random = new();

            if (random.Next(0, 101) <= successChance)
            {
                customer.Statistics.Update(bonus);
                return true;
            }

            return false;
        }
    }
}
