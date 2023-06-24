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
        public PreAdventureGameState State
        {
            get { return state; }
            set { state = value; }
        }

        public HamletCreator(PreAdventureGameState state_) 
        {
            state = state_;
        }

        public Hamlet.Hamlet CreateHamlet()
        {
            /* Create hamlet map */
            Dictionary<BuildingType, IBuilding> hamletMap = new Dictionary<BuildingType, IBuilding>();

            /* Create all the buildings and initialize them */

            /* Armorer */
            List<EquipmentItem> armorerInventory = new List<EquipmentItem>()
            {
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Chest),
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Head),
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Feet),
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Legs),
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Hands),
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Arms)
            };
            ArmorerBuilding armorer = new ArmorerBuilding("", state, armorerInventory);
            hamletMap.Add(BuildingType.Armorer, armorer);

            /* Blacksmith */
            List<EquipmentItem> blacksmithInventory = new List<EquipmentItem>()
            {
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Weapon),
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Weapon),
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Weapon),
                new EquipmentItem("", 0, new StatRegister(), EquipmentType.Weapon),
            };
            BlackSmithBuilding blacksmith = new BlackSmithBuilding("", state, blacksmithInventory);
            hamletMap.Add(BuildingType.Blacksmith,blacksmith);

            /* Hospital */
            List<Treatment> treatmentSet = new List<Treatment>()
            {
                new Treatment(0, (0, 5), "", 50),
                new Treatment(0, (0, 5), "", 50),
                new Treatment(0, (0, 5), "", 50),
                new Treatment(0, (0, 5), "", 50)
            };
            HospitalBuilding hospital = new HospitalBuilding("", state, treatmentSet);
            hamletMap.Add(BuildingType.Hospital, hospital);

           /* Guild */
           List <Upgrade> upgradeSet = new List<Upgrade>()
            {
                new Upgrade("", new StatRegister(), 0, 50),
                new Upgrade("", new StatRegister(), 0, 50),
                new Upgrade("", new StatRegister(), 0, 50),
                new Upgrade("", new StatRegister(), 0, 50)
            };
            GuildBuilding guild = new GuildBuilding("", state, upgradeSet);
            hamletMap.Add(BuildingType.Guild, guild);

            /* Inn */
            InnBuilding inn = new InnBuilding("", state, new ExpeditionCreator());
            hamletMap.Add(BuildingType.Inn, inn);

           /* Courtyard */
           CourtyardBuilding courtyard = new CourtyardBuilding("", state);
            hamletMap.Add(BuildingType.Courtyard, courtyard);

            Hamlet.Hamlet newHamlet = new Hamlet.Hamlet(hamletMap);
            return newHamlet;
        }
    }
}
