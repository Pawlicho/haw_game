using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Item
{
    internal interface IItem
    {
        public string? Name { get; }
        public uint GoldValue { get; }
        public bool IsConsumable { get; }
        public bool IsEquipable { get; }

        public string ToString();
    }
}
