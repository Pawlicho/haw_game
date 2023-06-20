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
        private uint manaPoints;
        private uint maxManaPoints;
        private uint defensePoints;
        private uint magicResistancePoints;
        private uint dodgeChance;
        private uint missChance;
        private int attackDamage;
        private uint criticalStrikeChance;
        bool waterResistance;
        bool earthResistance;
        bool fireResistance;
        bool windResistance;
        bool lightResistance;
        bool shadowResistance;

        public uint HealthPoints
        {
            get { return healthPoints; }
            set
            {
                if (value < 0 || value > MaxHealthPoints)
                    throw new ArgumentOutOfRangeException("healthPoints");

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
        public uint MaxManaPoints
        {
            get => maxManaPoints;
            set => maxManaPoints = value;
        }
        public uint ManaPoints
        {
            get { return manaPoints; }
            set
            {
                if (value < 0 || value > MaxManaPoints)
                    manaPoints = value;
            }
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
                            uint manaPoints_ = 0,
                            uint maxManaPoints_ = 0,
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
            HealthPoints = healthPoints_;
            MaxHealthPoints = maxHealthPoints_;
            AbilityPoints = abilityPoints_;
            SpeedPoints = speedPoints_;
            ManaPoints = manaPoints_;
            MaxManaPoints = maxManaPoints_;
            DefensePoints = defensePoints_;
            MagicResistancePoints = magicResistancePoints_;
            DodgeChance = dodgeChance_;
            MissChance = missChance_;
            AttackDamage = attackDamage_;
            CriticalStrikeChance = criticalStrikeChance_;
            WaterResistance = waterResistance_;
            EarthResistance = earthResistance_;
            FireResistance = fireResistance_;
            WindResistance = windResistance_;
            LightResistance = lightResistance_;
            ShadowResistance = shadowResistance_;
        }

        public void Update(StatRegister reg)
        {
            HealthPoints += reg.HealthPoints;
            MaxHealthPoints += reg.MaxHealthPoints;
            AbilityPoints += reg.AbilityPoints;
            SpeedPoints += reg.SpeedPoints;
            ManaPoints += reg.ManaPoints;
            MaxManaPoints += reg.MaxManaPoints;
            DefensePoints += reg.DefensePoints;
            MagicResistancePoints += reg.MagicResistancePoints;
            DodgeChance += reg.DodgeChance;
            MissChance += reg.MissChance;
            AttackDamage += reg.AttackDamage;
            CriticalStrikeChance += reg.CriticalStrikeChance;
            WaterResistance |= reg.WaterResistance;
            EarthResistance |= reg.EarthResistance;
            FireResistance |= reg.FireResistance;
            WindResistance |= reg.WindResistance;
            LightResistance |= reg.LightResistance;
            ShadowResistance |= reg.ShadowResistance;
        }
    }
}