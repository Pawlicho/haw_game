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
     * Damage type: low magic and high physical
     * Defense type: medium magic, medium physical
     * Resistance: shadow, wind, earth
     * Spell elements: wind, fire
     * Boss special abilities: Able to regenerate
     * Other characteristics: medium critical strike, dodge chance
     */
    internal class GraveyardMonsterCreator : IMonsterCreator
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

                healthPoints = 80 + additionalHealth;
                maxHealthPoints = 80 + additionalHealth;
                abilityPoints = 10 + attackModifier;
                speedPoints = 4;
                defensePoints = 25 + defenseModifier;
                magicResistancePoints = 10 + defenseModifier;
                dodgeChance = 10 + chanceModifier;
                missChance = 5 + chanceModifier;
                attackDamage = 30 + attackModifier;
                criticalStrikeChance = 10 + chanceModifier;
                waterResistance = false;
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
                    moveSet.Add(new BasicAttackMove(18));
                    moveSet.Add(new BasicAttackMove(18));
                    moveSet.Add(new CastSpellMove(13, Element.Wind));
                    moveSet.Add(new BasicAttackMove(18));
                    moveSet.Add(new BasicAttackMove(18));
                    moveSet.Add(new CastSpellMove(14, Element.Fire));
                }
                else
                {
                    moveSet.Add(new BasicAttackMove(13));
                    moveSet.Add(new BasicAttackMove(13));
                    moveSet.Add(new BasicAttackMove(13));
                    moveSet.Add(new CastSpellMove(10, Element.Fire));
                    moveSet.Add(new BasicAttackMove(14));

                }

                Monster newMonster = new(reg, moveSet, isBoss);

                return newMonster;
            }

        }

        public GraveyardMonsterCreator() { }
    }
}
