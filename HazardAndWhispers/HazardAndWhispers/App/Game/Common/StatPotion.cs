using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class StatPotion : IConsumableItem
    {
        private const uint maxNumberOfUsage = 3;

        public string Name { get; private set; }
        public bool IsConsumable { get; private set; }
        public bool IsEquipable { get; private set; }
        public uint GoldValue { get; private set; }
        public uint NumberOfUsageLeft { get; private set; }
        public StatRegister StatBonuses { get; private set; }
        public uint MaxNumberOfUsage { get; }

        /* TODO add some mechanism to autogenerate proper register based on the Potion Type */
        public StatRegister CreatePotionStatRegister()
        {
            /* Do some random operations here */
            return new StatRegister();
        }
        public StatPotion(string name_, uint goldValue_, StatRegister statBonuses_)
        {
            NumberOfUsageLeft = MaxNumberOfUsage;
            IsConsumable = true;
            IsEquipable = false;
            Name = name_;
            GoldValue = goldValue_;
            StatBonuses = statBonuses_;
        }

        public bool Consume()
        {
            if (NumberOfUsageLeft > 0)
            {
                NumberOfUsageLeft--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
