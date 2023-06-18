using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
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
            get => executor;
            set => executor = value;
        }

        public IAlive Receiver
        {
            get => receiver;
            set => receiver = value;
        }

        public int BaseDamage
        {
            get => baseDamage;
            private set => baseDamage = value;
        }
        public Element Type
        {
            get => type;
            set => type = value;
        }

        public CastSpellMove(IAlive executor_, IAlive receiver_, int baseDamage_)
        {
            Executor = executor_;
            Receiver = receiver_;
            BaseDamage = baseDamage_;
        }

        /* Here some algo to */
        public int MakeMove()
        {
            int damage = baseDamage + Executor.Statisctics.AbilityPoints;
            bool isResistant = false;
            double tempDmg;

            switch (type)
            {
                case Element.Fire:
                    {
                        if (Executor.Statisctics.FireResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Wind:
                    {
                        if (Executor.Statisctics.WindResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Earth:
                    {
                        if (Executor.Statisctics.EarthResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Water:
                    {
                        if (Executor.Statisctics.WaterResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Shadow:
                    {
                        if (Executor.Statisctics.ShadowResistance)
                            isResistant = true;
                        break;
                    }
                case Element.Light:
                    {
                        if (Executor.Statisctics.LightResistance)
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
                tempDmg = damage * Receiver.Statisctics.MagicResistancePoints * magicResistanceReductionFactor;
            }

            damage = (int)Math.Round(tempDmg);

            return damage;
        }
    }
}
