using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class Food : IConsumableItem
    {
        private const uint maxNumberOfUsage = 4;
        public string Name { get; private set; }
        public bool IsConsumable { get; private set; }
        public bool IsEquipable { get; private set; }
        public uint GoldValue { get; private set; }
        public uint NumberOfUsageLeft { get; private set; }
        public uint MaxNumberOfUsage { get;}

        public Food(string name_, uint goldValue_) 
        {
            NumberOfUsageLeft = MaxNumberOfUsage;
            IsConsumable = true;
            IsEquipable = false;
            Name = name_;
            GoldValue = goldValue_;
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
