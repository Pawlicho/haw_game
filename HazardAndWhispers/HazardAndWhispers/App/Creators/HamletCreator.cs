using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;
using HazardAndWhispers.App.Hamlet;
using HazardAndWhispers.App.Item;

namespace HazardAndWhispers.App.Creators
{
    internal class HamletCreator
    {
        private PreAdventureGameState state;
        private EquipmentCreator equipmentCreator;
        public PreAdventureGameState State
        {
            get { return state; }
            set { state = value; }
        }

        public HamletCreator(PreAdventureGameState state_) 
        {
            state = state_;
            equipmentCreator = new EquipmentCreator();
        }

        public Hamlet.Hamlet CreateHamlet()
        {
            /* Create hamlet map */
            Dictionary<BuildingType, IBuilding> hamletMap = new();

            /* Create all the buildings and initialize them */

            /* Armorer */
            Equipment intermediateEquipment = equipmentCreator.CreateEquipment(EquipmentLevel.Intermediate, state.GameHero.ClassType);
            List<EquipmentItem> armorerInventory = new List<EquipmentItem>()
            {
                intermediateEquipment.Chest,
                intermediateEquipment.Head,
                intermediateEquipment.Legs,
                intermediateEquipment.Feet,
                intermediateEquipment.Arms,
                intermediateEquipment.Hands,
            };

            /* Blacksmith */
            List<EquipmentItem> blacksmithInventory = new List<EquipmentItem>()
            {
                intermediateEquipment.Weapon
            };

            ArmorerBuilding armorer = new("Steelhaven Armory", state, armorerInventory);
            hamletMap.Add(BuildingType.Armorer, armorer);

            BlackSmithBuilding blacksmith = new("Inferno's Blacksmith", state, blacksmithInventory);
            hamletMap.Add(BuildingType.Blacksmith,blacksmith);

            /* Hospital */
            List<Treatment> treatmentSet = new()
            {
                new Treatment(30, (10, 25), "Small Heal", 90),
                new Treatment(50, (25, 45), "Medium Heal", 85),
                new Treatment(75, (45, 80), "Big Heal", 80),
                new Treatment(90, (500, 500), "Full Heal", 75),
                new Treatment(45, (0, 150), "Experimental Heal", 50)
            };
            HospitalBuilding hospital = new("Stellar Mercy Hospital", state, treatmentSet);
            hamletMap.Add(BuildingType.Hospital, hospital);

            /* Guild */
            List<Upgrade> upgradeSet = new();
            StatRegister abilityUpgradeReg = new()
            {
                AbilityPoints = 5
            };
            upgradeSet.Add(new Upgrade("Ability Upgrade", abilityUpgradeReg, 200, 80));
            StatRegister maxHealthUpgradeReg = new()
            {
                MaxHealthPoints = 5
            };
            upgradeSet.Add(new Upgrade("Max Health Upgrade", maxHealthUpgradeReg, 200, 80));
            StatRegister attackUpgradeReg = new()
            {
                AttackDamage = 5
            };
            upgradeSet.Add(new Upgrade("Attack Upgrade", attackUpgradeReg, 200, 80));
            StatRegister defenseUpgradeReg = new()
            {
                DefensePoints = 5
            };
            upgradeSet.Add(new Upgrade("Defense Upgrade", defenseUpgradeReg, 200, 80));
            StatRegister magicResistanceUpgradeReg = new()
            {
                MagicResistancePoints = 5
            };
            upgradeSet.Add(new Upgrade("Magic Resistance Upgrade", magicResistanceUpgradeReg, 200, 80));
            StatRegister critStrikeUpgradeReg = new()
            {
                CriticalStrikeChance = 3
            };
            upgradeSet.Add(new Upgrade("Critical Strike Chance Upgrade", critStrikeUpgradeReg, 200, 80));
            StatRegister dodgeUpgradeReg = new()
            {
                DodgeChance = 3
            };
            upgradeSet.Add(new Upgrade("Dodge Upgrade", dodgeUpgradeReg, 200, 80));
            StatRegister speedUpgradeReg = new()
            {
                SpeedPoints = 3
            };
            upgradeSet.Add(new Upgrade("Speed Upgrade", speedUpgradeReg, 200, 80));
            GuildBuilding guild = new("Shadowsong Guild", state, upgradeSet);
            hamletMap.Add(BuildingType.Guild, guild);

            /* Inn */
            InnBuilding inn = new("Cozy Corner Inn", state, new ExpeditionCreator());
            hamletMap.Add(BuildingType.Inn, inn);

            /* Courtyard */
            CourtyardBuilding courtyard = new("Courtyard of Whispers", state);
            hamletMap.Add(BuildingType.Courtyard, courtyard);

            Hamlet.Hamlet newHamlet = new(hamletMap);
            return newHamlet;
        }
    }
}
