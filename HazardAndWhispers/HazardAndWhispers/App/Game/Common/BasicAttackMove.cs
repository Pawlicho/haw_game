using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class BasicAttackMove
    {
        private IAlive executer;
        private IAlive receiver;
        private int baseDamage;
        public IAlive Executer
        {
            get => executer;
            set => executer = value;
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

        public BasicAttackMove(IAlive executer_, IAlive receiver_, int baseDamage_)
        {
            Executer = executer_;
            Receiver = receiver_;
            BaseDamage = baseDamage_;
        }

        /* Here some algo to */
        public int MakeMove()
        {
            int damage = BaseDamage + Executer.Statisctics.AttackDamage;
            
            /*
             * Count hero's base damage
             * Randomize  the damage by e.g. 30%
             * Decreas it by defense factor
             * Draw for critical strike
             * Draw for hit chance (100% - missChance)
             * Draw for receiver doge chance
             */

            /* TODO: Add some library or just a function that would be able to randomize the output just by input chance in percentage*/
            
            return damage;
        }
    }
}
