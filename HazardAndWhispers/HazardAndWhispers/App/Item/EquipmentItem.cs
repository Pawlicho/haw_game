using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.Item
{
    internal class EquipmentItem : IItem
    {
        private string name;
        private bool isConsumable;
        private bool isEquipable;
        private int goldValue;
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
        public int GoldValue
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
                             int goldValue_,
                             StatRegister statBonuses_,
                             EquipmentType equipmentType_)
        {
            name = name_;
            isConsumable = false;
            isEquipable = true;
            goldValue = goldValue_;
            statBonuses = statBonuses_;
            equipmentType = equipmentType_;
        }

        public void Reverse(StatRegister reg)
        {
            statBonuses.Reverse(reg);
        }
        public override string ToString()
        {
            string temp = "";

            temp += "\nName: " + name;
            temp += "\nEquipable item: ";
            temp += "\nGold Value: " + goldValue;
            temp += "\nEquipment type: " + Enum.GetName(typeof(EquipmentType), equipmentType);
            temp += statBonuses.ToString();

            return temp;
        }
    }
}
