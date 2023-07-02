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
        private int healthPoints;
        private int maxHealthPoints;
        private int abilityPoints;
        private int speedPoints;
        private int defensePoints;
        private int magicResistancePoints;
        private int dodgeChance;
        private int missChance;
        private int attackDamage;
        private int criticalStrikeChance;
        private bool waterResistance;
        private bool earthResistance;
        private bool fireResistance;
        private bool windResistance;
        private bool lightResistance;
        private bool shadowResistance;

        public int HealthPoints
        {
            get { return healthPoints; }
            set
            {
                if (value < MaxHealthPoints)
                    healthPoints = value;
                else
                    healthPoints = MaxHealthPoints;

                /* Setter for potions */
                if (MaxHealthPoints == 0)
                    healthPoints = value;

            }
        }

        public int MaxHealthPoints
        {
            get => maxHealthPoints;
            set => maxHealthPoints = value;
        }
        public int AbilityPoints
        {
            get => abilityPoints;
            set => abilityPoints = value;
        }
        public int SpeedPoints
        {
            get => speedPoints;
            set => speedPoints = value;
        }
        public int DefensePoints
        {
            get => defensePoints;
            set => defensePoints = value;
        }
        public int MagicResistancePoints
        {
            get => magicResistancePoints;
            set => magicResistancePoints = value;
        }

        public int DodgeChance
        {
            get { return dodgeChance; }
            set
            {
                if (value < 0 && value > 100)
                    dodgeChance = value;
            }
        }
        public int MissChance
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
        public int CriticalStrikeChance
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

        public StatRegister(int healthPoints_ = 0,
                            int maxHealthPoints_ = 0,
                            int abilityPoints_ = 0,
                            int speedPoints_ = 0,
                            int defensePoints_ = 0,
                            int magicResistancePoints_ = 0,
                            int dodgeChance_ = 0,
                            int missChance_ = 0,
                            int attackDamage_ = 0,
                            int criticalStrikeChance_ = 0,
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

        public void Reverse(StatRegister reg)
        {
            healthPoints -= reg.HealthPoints;
            maxHealthPoints -= reg.MaxHealthPoints;
            abilityPoints -= reg.AbilityPoints;
            speedPoints -= reg.SpeedPoints;
            defensePoints -= reg.DefensePoints;
            magicResistancePoints -= reg.MagicResistancePoints;
            dodgeChance -= reg.DodgeChance;
            missChance -= reg.MissChance;
            attackDamage -= reg.AttackDamage;
            criticalStrikeChance -= reg.CriticalStrikeChance;
            waterResistance = !reg.WaterResistance & waterResistance;
            earthResistance = !reg.EarthResistance & earthResistance;
            fireResistance = !reg.FireResistance & fireResistance;
            windResistance = !reg.WindResistance & windResistance;
            lightResistance = !reg.LightResistance & lightResistance;
            shadowResistance = !reg.ShadowResistance & shadowResistance;
        }
        public override string ToString()
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