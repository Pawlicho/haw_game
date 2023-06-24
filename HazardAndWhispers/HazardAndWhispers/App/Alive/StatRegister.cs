using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Alive
{
    internal class StatRegister
    {
        private uint healthPoints;
        private uint maxHealthPoints;
        private int abilityPoints;
        private uint speedPoints;
        private uint defensePoints;
        private uint magicResistancePoints;
        private uint dodgeChance;
        private uint missChance;
        private int attackDamage;
        private uint criticalStrikeChance;
        private bool waterResistance;
        private bool earthResistance;
        private bool fireResistance;
        private bool windResistance;
        private bool lightResistance;
        private bool shadowResistance;

        public uint HealthPoints
        {
            get { return healthPoints; }
            set
            {
                if (value < MaxHealthPoints)
                    healthPoints = value;
            }
        }

        public uint MaxHealthPoints
        {
            get => maxHealthPoints;
            set => maxHealthPoints = value;
        }
        public int AbilityPoints
        {
            get => abilityPoints;
            set => abilityPoints = value;
        }
        public uint SpeedPoints
        {
            get => speedPoints;
            set => speedPoints = value;
        }
        public uint DefensePoints
        {
            get => defensePoints;
            set => defensePoints = value;
        }
        public uint MagicResistancePoints
        {
            get => magicResistancePoints;
            set => magicResistancePoints = value;
        }

        public uint DodgeChance
        {
            get { return dodgeChance; }
            set
            {
                if (value < 0 && value > 100)
                    dodgeChance = value;
            }
        }
        public uint MissChance
        {
            get { return missChance; }
            set
            {
                if (value < 0 && value > 100)
                    missChance = value;
            }
        }
        public int AttackDamage
        {
            get { return attackDamage; }
            set
            {
                if (value >= 0)
                    attackDamage = value;
            }
        }
        public uint CriticalStrikeChance
        {
            get { return criticalStrikeChance; }
            set
            {
                if (value < 0 && value > 100)
                    criticalStrikeChance = value;
            }
        }
        public bool WaterResistance
        {
            get { return waterResistance; }
            set
            {
                waterResistance = value;
            }
        }
        public bool WindResistance
        {
            get { return windResistance; }
            set
            {
                windResistance = value;
            }
        }
        public bool EarthResistance
        {
            get { return earthResistance; }
            set
            {
                earthResistance = value;
            }
        }
        public bool FireResistance
        {
            get { return fireResistance; }
            set
            {
                fireResistance = value;
            }
        }
        public bool LightResistance
        {
            get { return lightResistance; }
            set
            {
                lightResistance = value;
            }
        }
        public bool ShadowResistance
        {
            get { return shadowResistance; }
            set
            {
                shadowResistance = value;
            }
        }

        public StatRegister(uint healthPoints_ = 0,
                            uint maxHealthPoints_ = 0,
                            int abilityPoints_ = 0,
                            uint speedPoints_ = 0,
                            uint defensePoints_ = 0,
                            uint magicResistancePoints_ = 0,
                            uint dodgeChance_ = 0,
                            uint missChance_ = 0,
                            int attackDamage_ = 0,
                            uint criticalStrikeChance_ = 0,
                            bool waterResistance_ = false,
                            bool earthResistance_ = false,
                            bool fireResistance_ = false,
                            bool windResistance_ = false,
                            bool lightResistance_ = false,
                            bool shadowResistance_ = false)
        {
            healthPoints = healthPoints_;
            maxHealthPoints = maxHealthPoints_;
            abilityPoints = abilityPoints_;
            speedPoints = speedPoints_;
            defensePoints = defensePoints_;
            magicResistancePoints = magicResistancePoints_;
            dodgeChance = dodgeChance_;
            missChance = missChance_;
            attackDamage = attackDamage_;
            criticalStrikeChance = criticalStrikeChance_;
            waterResistance = waterResistance_;
            earthResistance = earthResistance_;
            fireResistance = fireResistance_;
            windResistance = windResistance_;
            lightResistance = lightResistance_;
            shadowResistance = shadowResistance_;
        }

        public void Update(StatRegister reg)
        {
            healthPoints += reg.HealthPoints;
            maxHealthPoints += reg.MaxHealthPoints;
            abilityPoints += reg.AbilityPoints;
            speedPoints += reg.SpeedPoints;
            defensePoints += reg.DefensePoints;
            magicResistancePoints += reg.MagicResistancePoints;
            dodgeChance += reg.DodgeChance;
            missChance += reg.MissChance;
            attackDamage += reg.AttackDamage;
            criticalStrikeChance += reg.CriticalStrikeChance;
            waterResistance |= reg.WaterResistance;
            earthResistance |= reg.EarthResistance;
            fireResistance |= reg.FireResistance;
            windResistance |= reg.WindResistance;
            lightResistance |= reg.LightResistance;
            shadowResistance |= reg.ShadowResistance;
        }

        public override string ToString()
        {
            string temp = "";

            temp += "\nHealth: " + healthPoints;
            temp += "\nMax Health: " + maxHealthPoints;
            temp += "\nAbility: " + abilityPoints;
            temp += "\nSpeed: " + speedPoints;
            temp += "\nDefense: " + defensePoints;
            temp += "\nMagic Resistance: " + magicResistancePoints;
            temp += "\nDodge Chance: " + dodgeChance;
            temp += "\nMiss Chance: " + missChance;
            temp += "\nAttack Damage: " + attackDamage;
            temp += "\nCritical Strike Chance: " + criticalStrikeChance;
            temp += "\nWater Resistance: "; if (waterResistance) temp += "yes"; else temp += "no";
            temp += "\nEarth Resistance: "; if (earthResistance) temp += "yes"; else temp += "no";
            temp += "\nFire Resistance: "; if (fireResistance) temp += "yes"; else temp += "no";
            temp += "\nWind Resistance: "; if (windResistance) temp += "yes"; else temp += "no";
            temp += "\nLight Resistance: "; if (lightResistance) temp += "yes"; else temp += "no";
            temp += "\nShadow Resistance: "; if (shadowResistance) temp += "yes"; else temp += "no";


            return temp;
        }

        public string ToStringItem()
        {
            string temp = "";

            if (healthPoints != 0) { temp += "\nHealth: " + healthPoints; }
            if (maxHealthPoints != 0) { temp += "\nMax Health: " + maxHealthPoints; }
            if (abilityPoints != 0) { temp += "\nAbility: " + abilityPoints; }
            if (speedPoints != 0) { temp += "\nSpeed: " + speedPoints; }
            if (defensePoints != 0) { temp += "\nDefense: " + defensePoints; }
            if (magicResistancePoints != 0) { temp += "\nMagic Resistance: " + magicResistancePoints; }
            if (dodgeChance != 0) { temp += "\nDodge Chance: " + dodgeChance; }
            if (missChance != 0) { temp += "\nMiss Chance: " + missChance; }
            if (attackDamage != 0) { temp += "\nAttack Damage: " + attackDamage; }
            if (criticalStrikeChance != 0) { temp += "\nCritical Strike Chance: " + criticalStrikeChance; }
            if (waterResistance) { temp += "\nWater Resistance: " + "yes"; }
            if (earthResistance) { temp += "\nEarth Resistance: " + "yes"; }
            if (fireResistance) { temp += "\nFire Resistance: " + "yes"; }
            if (windResistance) { temp += "\nWind Resistance: " + "yes"; }
            if (lightResistance) { temp += "\nLight Resistance: " + "yes"; }
            if (shadowResistance) { temp += "\nShadow Resistance: " + "yes"; }

            return temp;
        }
    }
}