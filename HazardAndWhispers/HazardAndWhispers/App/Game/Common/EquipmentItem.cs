using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal class EquipmentItem : IItem
    {
        private string name;
        private bool isConsumable;
        private bool isEquipable;
        private uint goldValue;
        private StatRegister statBonuses;
        private EquipmentType equipmentType;
        public string Name
        {
            get { return name; }
        }
        public bool IsConsumable
        {
            get { return isConsumable; }
        }
        public bool IsEquipable
        {
            get { return isEquipable; }
        }
        public uint GoldValue
        {
            get { return goldValue; }
            
        }
        public StatRegister StatBonuses
        {
            get { return statBonuses; }
        }
        public EquipmentType EquipmentType
        {
            get { return equipmentType; }
        }

        /* TODO add some mechanism to autogenerate proper register based on the Potion Type */
        public StatRegister CreateEquipmentRegister(EquipmentType equipmentType_)
        {
            /* Do some random operations here */
            return new StatRegister();
        }
        public EquipmentItem(string name_,
                             bool isConsumable_,
                             bool isEquipable_,
                             uint goldValue_,
                             StatRegister statBonuses_,
                             EquipmentType equipmentType_)
        {
            name = name_;
            isConsumable = isConsumable_;
            isEquipable = isEquipable_;
            goldValue = goldValue_;
            statBonuses = statBonuses_;
            equipmentType = equipmentType_;
        }
    }
}
