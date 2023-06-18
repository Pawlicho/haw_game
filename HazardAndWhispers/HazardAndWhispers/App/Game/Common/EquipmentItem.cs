using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class EquipmentItem : IItem
    {
        public string? Name { get; private set; }
        public bool IsConsumable { get; private set; }
        public bool IsEquipable { get; private set; }
        public uint GoldValue { get; private set; }
        public StatRegister? StatBonuses { get; private set; }
        public EquipmentType? EquipmentType { get; private set;}

        /* TODO add some mechanism to autogenerate proper register based on the Potion Type */
        public StatRegister CreateEquipmentRegister(EquipmentType equipmentType_)
        {
            /* Do some random operations here */
            return new StatRegister();
        }
        public EquipmentItem(string? name_,
                             bool isConsumable_,
                             bool isEquipable_,
                             uint goldValue_,
                             StatRegister? statBonuses_,
                             EquipmentType? equipmentType_)
        {
            Name = name_;
            IsConsumable = isConsumable_;
            IsEquipable = isEquipable_;
            GoldValue = goldValue_;
            StatBonuses = statBonuses_;
            EquipmentType = equipmentType_;
            Name = name_;
            IsConsumable = isConsumable_;
            IsEquipable = isEquipable_;
            GoldValue = goldValue_;
            StatBonuses = statBonuses_;
            EquipmentType = equipmentType_;
        }
    }
}
