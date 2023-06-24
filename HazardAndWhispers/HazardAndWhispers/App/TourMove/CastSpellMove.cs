using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.TourMove
{
    internal class CastSpellMove : ITourMove
    {
        /* Twig those in order to balance the fight */
        /* Hardcoded, but there is an option to make it in-game modificable */
        private double elementSpecificResistanceFactor = 0.9;
        private const int magicResistanceReductionFactor = 1;

        private IAlive executor;
        private IAlive receiver;
        private int baseDamage;
        private Element type;
        public IAlive Executor
        {
            get { return executor; }
            set { executor = value; }
        }

        public IAlive Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }

        public int BaseDamage
        {
            get { return baseDamage; }
        }
        public Element Type
        {
            get { return type; }
        }

        public CastSpellMove(int baseDamage_, Element type_)
        {
            type = type_;
            baseDamage = baseDamage_;
        }

        /* Here some algo to */
        public int MakeMove()
        {
            int damage = baseDamage + Executor.Statistics.AbilityPoints;
            bool isResistant = false;
            double tempDmg;

            switch (type)
            {
                case Element.Fire:
                    {
                        if (Executor.Statistics.FireResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Wind:
                    {
                        if (Executor.Statistics.WindResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Earth:
                    {
                        if (Executor.Statistics.EarthResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Water:
                    {
                        if (Executor.Statistics.WaterResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Shadow:
                    {
                        if (Executor.Statistics.ShadowResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Light:
                    {
                        if (Executor.Statistics.LightResistance)
                            isResistant = true;
                        break;
                    }
            }

            if (isResistant)
            {
                tempDmg = damage * elementSpecificResistanceFactor;
            }
            else
            {
                tempDmg = damage * Receiver.Statistics.MagicResistancePoints * magicResistanceReductionFactor;
            }

            damage = (int)Math.Round(tempDmg);

            return damage;
        }

        public override string ToString()
        {
            string temp = "";

            temp += "\nCast Spell";
            temp += "\nType: " + Enum.GetName(typeof(Element), type);
            temp += "\nBaseDamage: " + baseDamage;

            return temp;
        }
    }
}
