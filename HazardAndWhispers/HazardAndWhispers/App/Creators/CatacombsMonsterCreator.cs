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
     * Difficulty: 2 
     * Damage type: high magic and low physical
     * Defense type: high magic, low physical
     * Resistance: earth, wind, water
     * Spell elements: shadow
     * Other characteristics: low critical strike, low dodge chance
     */
    internal class CatacombsMonsterCreator : IMonsterCreator
    {
        private int attackModifier = 0;
        private int defenseModifier = 0;
        private int chanceModifier = 0;
        private int additionalHealth = 0;
        public Monster CreateMonster(bool isBoss)
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

            healthPoints = 60 + additionalHealth;
            maxHealthPoints = 60 + additionalHealth;
            abilityPoints = 35 + attackModifier;
            speedPoints = 5;
            defensePoints = 4 + defenseModifier;
            magicResistancePoints = 20 + defenseModifier;
            dodgeChance = 10 + chanceModifier;
            missChance = 15;
            attackDamage = 5 + attackModifier;
            criticalStrikeChance = 8 + chanceModifier;
            waterResistance = true;
            earthResistance = true;
            fireResistance = false;
            windResistance = true;
            lightResistance = false;
            shadowResistance = false;

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
                moveSet.Add(new CastSpellMove(16, Element.Shadow));
                moveSet.Add(new CastSpellMove(16, Element.Shadow));
                moveSet.Add(new CastSpellMove(16, Element.Shadow));
                moveSet.Add(new CastSpellMove(16, Element.Shadow));
            }
            else
            {
                moveSet.Add(new CastSpellMove(10, Element.Shadow));
                moveSet.Add(new CastSpellMove(10, Element.Shadow));
                moveSet.Add(new CastSpellMove(10, Element.Shadow));
                moveSet.Add(new BasicAttackMove(7));
            }

            Monster newMonster = new(reg, moveSet, isBoss);

            return newMonster;
        }

        public CatacombsMonsterCreator() { }
    }
}
