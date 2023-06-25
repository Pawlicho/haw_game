using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Alive
{
    internal class Equipment
    {
        /* TODO: Add some sanity check whether there are all enums? */
        private EquipmentItem head;
        private EquipmentItem chest;
        private EquipmentItem legs;
        private EquipmentItem arms;
        private EquipmentItem hands;
        private EquipmentItem feet;
        private EquipmentItem weapon;
        public EquipmentItem Head
        {
            get { return head; }
            set
            {
                if (value.EquipmentType == EquipmentType.Head)
                    head = value;
            }
        }
        public EquipmentItem Chest
        {
            get { return chest; }
            set 
            {
                if (value.EquipmentType == EquipmentType.Chest)
                    chest = value;
            }
        }
        public EquipmentItem Legs
        {
            get { return legs; }
            set 
            {
                if (value.EquipmentType == EquipmentType.Legs)
                    legs = value;
            }
        }
        public EquipmentItem Arms
        {
            get { return arms; }
            set 
            {
                if (value.EquipmentType == EquipmentType.Arms)
                    arms = value;
            }
        }
        public EquipmentItem Hands
        {
            get { return hands; }
            set
            {
                if (value.EquipmentType == EquipmentType.Hands)
                    hands = value;
            }
        }
        public EquipmentItem Feet
        {
            get { return feet; }
            set 
            {
                if (value.EquipmentType == EquipmentType.Feet)
                    feet = value;
            }
        }
        public EquipmentItem Weapon
        {
            get { return weapon; }
            set
            {
                if (value.EquipmentType == EquipmentType.Weapon)
                    weapon = value;
            }
        }

        public Equipment(EquipmentItem head_,
                 EquipmentItem chest_,
                 EquipmentItem legs_,
                 EquipmentItem arms_,
                 EquipmentItem hands_,
                 EquipmentItem feet_,
                 EquipmentItem weapon_)
        {
            head = head_;
            chest = chest_;
            legs = legs_;
            arms = arms_;
            hands = hands_;
            feet = feet_;
            weapon = weapon_;
        }

        public void UpdateStatRegister(StatRegister register)
        {
            register.Update(head.StatBonuses);
            register.Update(chest.StatBonuses);
            register.Update(legs.StatBonuses);
            register.Update(arms.StatBonuses);
            register.Update(hands.StatBonuses);
            register.Update(feet.StatBonuses);
            register.Update(weapon.StatBonuses);
        }

        public override string ToString()
        {
            string temp = "";

            temp += "\n\nHead: \n"; temp += head.ToString();
            temp += "\n\nChest: \n"; temp += chest.ToString();
            temp += "\n\nLegs: \n"; temp += legs.ToString();
            temp += "\n\nArms: \n"; temp += arms.ToString();
            temp += "\n\nHands: \n"; temp += hands.ToString();
            temp += "\n\nFeet: \n"; temp += feet.ToString();
            temp += "\n\nWeapon: \n"; temp += weapon.ToString();

            return temp;
        }
    }
}
