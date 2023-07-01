using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.TourMove;

namespace HazardAndWhispers.App.Creators
{
    /* Swamp monsters
    * Difficulty: 3 
    * Damage type: high magic and high physical
    * Defense type: high magic, high physical
    * Resistance: earth, wind, water, shadow
    * Spell elements: shadow, wind
    * Other characteristics: high critical strike, very low dodge chance
    */
    internal class HauntedMansionMonsterCreator : IMonsterCreator
    {
        private int attackModifier = 0;
        private int defenseModifier = 0;
        private int chanceModifier = 0;
        private int additionalHealth = 0;
        public Monster CreateMonster(bool isBoss)
        {
            {
                /* Boss has additional statistic + has additional spells in moveSet */

                int healthPoints;
                int maxHealthPoints;
                int abilityPoints;
                int speedPoints;
                int defensePoints;
                int magicResistancePoints;
                int dodgeChance;
                int missChance;
                int attackDamage;
                int criticalStrikeChance;
                bool waterResistance;
                bool earthResistance;
                bool fireResistance;
                bool windResistance;
                bool lightResistance;
                bool shadowResistance;

                if (isBoss)
                {
                    attackModifier = 10;
                    defenseModifier = 15;
                    chanceModifier = 5;
                    additionalHealth = 50;
                }

                healthPoints = 110 + additionalHealth;
                maxHealthPoints = 110 + additionalHealth;
                abilityPoints = 40 + attackModifier;
                speedPoints = 6;
                defensePoints = 35 + defenseModifier;
                magicResistancePoints = 35 + defenseModifier;
                dodgeChance = 0 + chanceModifier;
                missChance = 10 + chanceModifier;
                attackDamage = 40 + attackModifier;
                criticalStrikeChance = 25 + chanceModifier;
                waterResistance = true;
                earthResistance = true;
                fireResistance = false;
                windResistance = true;
                lightResistance = false;
                shadowResistance = true;

                StatRegister reg = new(healthPoints,
                                       maxHealthPoints,
                                       abilityPoints,
                                       speedPoints,
                                       defensePoints,
                                       magicResistancePoints,
                                       dodgeChance,
                                       missChance,
                                       attackDamage,
                                       criticalStrikeChance,
                                       waterResistance,
                                       earthResistance,
                                       fireResistance,
                                       windResistance,
                                       lightResistance,
                                       shadowResistance);

                List<ITourMove> moveSet = new();

                /* Add heal move in future */
                if (isBoss)
                {
                    moveSet.Add(new BasicAttackMove(22));
                    moveSet.Add(new CastSpellMove(20, Element.Wind));
                    moveSet.Add(new BasicAttackMove(19));
                    moveSet.Add(new CastSpellMove(15, Element.Shadow));
                }
                else
                {
                    moveSet.Add(new BasicAttackMove(16));
                    moveSet.Add(new CastSpellMove(11, Element.Wind));
                    moveSet.Add(new BasicAttackMove(17));
                    moveSet.Add(new CastSpellMove(10, Element.Shadow));

                }

                Monster newMonster = new(reg, moveSet, isBoss);

                return newMonster;
            }

        }

        public HauntedMansionMonsterCreator() { }
    }
}
