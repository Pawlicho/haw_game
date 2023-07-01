using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.TourMove
{
    internal class BasicAttackMove : ITourMove
    {
        /* Twig those in order to balance the fight */
        /* Hardcoded, but there is an option to make it in-game modificable */
        private const double baseDamageRangeFactor = 0.3;
        private const float defenseReductionFactor = 0.2f;
        private const int criticalStrikeFactor = 2;

        private IAlive executor;
        private IAlive receiver;
        private int baseDamage;
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

        public BasicAttackMove(int baseDamage_)
        {
            baseDamage = baseDamage_;
        }

        /* Here some algo to */
        public int MakeMove()
        {
            /* Count Base damage */
            int damage = BaseDamage + Executor.Statistics.AttackDamage;

            /* Randomize the damage value from range (0.7 base; 1.3 base) */
            Random random = new Random();

            double seed = random.NextDouble();
            double damageMax = damage + damage * baseDamageRangeFactor;
            double damageMin = damage - damage * baseDamageRangeFactor;

            double randomValue = damageMin + seed * (damageMax - damageMin);


            /* Decreas damage by the opponent's defense factor */
            randomValue -= (int)Receiver.Statistics.DefensePoints * defenseReductionFactor;

            damage = (int)Math.Round(randomValue);

            /* Draw for critical strike */
            if (random.Next(0, 101) <= Executor.Statistics.CriticalStrikeChance)
            {
                damage *= criticalStrikeFactor;
            }

            /* Draw for hitChance */
            if (random.Next(0, 101) <= Executor.Statistics.MissChance)
            {
                damage = 0;
            }

            /* Draw for opponent's dodge */
            int missValue = random.Next(0, 101);
            if (missValue <= Receiver.Statistics.MissChance)
            {
                damage = 0;
                /* Just now the idea of logging events hit me*/
                /* That might be the best solution */
            }

            /* TODO: Add some library or just a function that would be able to randomize the output just by input chance in percentage*/

            /* If damage is negative, do nothing - retorn 0 */
            if (damage < 0) { damage = 0; }

            receiver.Statistics.HealthPoints -= damage;

            return damage;
        }

        public override string ToString()
        {
            string temp = "";

            temp += "\nBasicAttackMove";
            temp += "BaseDamage: " + baseDamage;

            return temp;
        }
    }
}
