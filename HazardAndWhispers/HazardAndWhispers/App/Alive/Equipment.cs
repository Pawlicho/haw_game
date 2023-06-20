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
            set { head = value; }
        }
        public EquipmentItem Chest
        {
            get { return chest; }
            set { chest = value; }
        }
        public EquipmentItem Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public EquipmentItem Arms
        {
            get { return arms; }
            set { arms = value; }
        }
        public EquipmentItem Hands
        {
            get { return hands; }
            set
            {
                hands = value;
            }
        }
        public EquipmentItem Feet
        {
            get { return feet; }
            set { feet = value; }
        }
        public EquipmentItem Weapon
        {
            get { return weapon; }
            set
            {
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
    }
}
