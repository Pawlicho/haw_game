using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class ValuableItem : IItem
    {
        public string? Name { get; set; }
        public bool IsConsumable { get; private set; }
        public bool IsEquipable { get; private set; }
        public uint GoldValue { get; private set; }

        public ValuableItem(string name_, uint goldValue_)
        {
            Name = name_;
            GoldValue = goldValue_;
            IsConsumable = false;
            IsEquipable = false;
        }
    }
}
