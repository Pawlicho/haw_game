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
     * Difficulty: 1 (easiest) 
     * Damage type: medium magic and medium physical
     * Defense type: medium magic, medium physical
     * Resistance: earth, wind
     * Spell elements: earth, water
     * Boss special abilities: Able to regenerate
     * Other characteristics: low critical strike, dodge chance
     */
    internal class SwampMonsterCreator : IMonsterCreator
    {
        private int attackModifier = 0;
        private int defenseModifier = 0;
        private int chanceModifier = 0;
        private int additionalHealth = 0;
        public Monster CreateMonster(bool isBoss)
        {
            /* Boss has additional statistic + has additional spells in moveSet */

            int  healthPoints;
            int  maxHealthPoints;
            int  abilityPoints;
            int  speedPoints;
            int  defensePoints;
            int  magicResistancePoints;
            int  dodgeChance;
            int  missChance;
            int  attackDamage;
            int  criticalStrikeChance;
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

            healthPoints          = 60 + additionalHealth; 
            maxHealthPoints       = 60 + additionalHealth; 
            abilityPoints         = 15 + attackModifier;
            speedPoints           = 3;
            defensePoints         = 10 + defenseModifier; 
            magicResistancePoints = 10 + defenseModifier; 
            dodgeChance           = 10 + chanceModifier;
            missChance            = 10 + chanceModifier;
            attackDamage          = 15 + attackModifier;
            criticalStrikeChance  = 8 + chanceModifier;
            waterResistance       = false;
            earthResistance       = true;
            fireResistance        = false;
            windResistance        = true;
            lightResistance       = false;
            shadowResistance      = false;

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
                moveSet.Add(new BasicAttackMove(12));
                moveSet.Add(new CastSpellMove(12, Element.Water));
                moveSet.Add(new BasicAttackMove(10));
                moveSet.Add(new CastSpellMove(13, Element.Earth));
            }
            else
            {
                moveSet.Add(new BasicAttackMove(5));
                moveSet.Add(new CastSpellMove(7, Element.Water));
                moveSet.Add(new BasicAttackMove(5));
                moveSet.Add(new CastSpellMove(7, Element.Earth));

            }

            Monster newMonster = new(reg, moveSet, isBoss);

            return newMonster;
        }

        public SwampMonsterCreator() { }
    }
}
