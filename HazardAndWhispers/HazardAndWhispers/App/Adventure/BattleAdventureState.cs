using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;
using HazardAndWhispers.App.Game;

namespace HazardAndWhispers.App.Adventure
{
    internal class BattleAdventureState : IAdventureState
    {
        private Expedition expeditionContext;
        private Monster enemy;
        private Hero hero;
        private int enemyMoveIdx;

        public Expedition ExpeditionContext
        {
            get { return expeditionContext; }
            set { expeditionContext = value; }
        }

        public BattleAdventureState(Expedition expeditionContext_)
        {
            ExpeditionContext = expeditionContext_;
            Room room = expeditionContext.CurrPiece as Room;
            enemy = room.Enemy;
            hero = expeditionContext.Visitor;
            expeditionContext.Visitor.SetEnemy(enemy);
            enemy.SetEnemy(hero);
            enemyMoveIdx = 0;
        }

        public string Action(ConsoleKeyInfo keyInfo)
        {
            ConsoleKey key = keyInfo.Key;
            int heroMoveId = 0;
            string temp = "\n";
            switch (key)
            {
                case ConsoleKey.D0:
                {
                    heroMoveId = 0; break;
                }
                case ConsoleKey.D1:
                {
                    heroMoveId = 1; break;
                }
                case ConsoleKey.D2:
                {
                    heroMoveId = 2; break;
                }
                case ConsoleKey.D3:
                {
                    heroMoveId = 3; break;
                }
                case ConsoleKey.D4:
                {
                    heroMoveId = 4; break;
                }
                case ConsoleKey.D5:
                {
                    heroMoveId = 5; break;
                }
                case ConsoleKey.D6:
                {
                    heroMoveId = 6; break;
                }
                case ConsoleKey.D7:
                {
                    heroMoveId = 7; break;
                }
                case ConsoleKey.D8:
                {
                    heroMoveId = 8; break;
                }
                case ConsoleKey.D9:
                {
                    heroMoveId = 9; break;
                }
                case ConsoleKey.C:
                {
                    return enemy.ToString();
                }
                default:
                {
                    return "\nWrong key!";
                }
            }
            if (hero.MoveSet.Count < heroMoveId + 1)
                return "No such move!";

            int dmg = hero.RunMove(heroMoveId);
            temp += "\nHero used: " + hero.MoveSet[heroMoveId].ToString();
            temp += "\nEnemy took " + dmg + " damage.";
            if (enemy.Statistics.HealthPoints < 0)
            {
                temp += "\nEnemy's killed! Congratulations!\nYour price:";
                foreach(var item in expeditionContext.CurrPiece.Reward)
                {
                    if (hero.PickItem(item))
                    {
                        temp += item.ToString();
                    }
                }
                expeditionContext.CurrPiece.IsCompleted = true;
                if (enemy.IsBoss)
                {
                    expeditionContext.GameContext.State.Ready = true;
                }
                expeditionContext.State = new ExploreAdventureState(expeditionContext);
                return temp;
            }
            dmg = enemy.RunMove(enemyMoveIdx);
            temp += "\nHero took " + dmg + " damage.";
            if (hero.Statistics.HealthPoints < 0)
            {
                temp += "\nYour dead! Game Over...";

                expeditionContext.GameContext.Finish();
                return temp;
            }

            enemyMoveIdx++;
            enemyMoveIdx = enemyMoveIdx % enemy.MoveSet.Count;

            temp += "\nEnemy used: " + enemy.MoveSet[enemyMoveIdx].ToString();

            temp += "\nHero HP: " + hero.Statistics.HealthPoints + " / " + hero.Statistics.MaxHealthPoints +
                    "\nEnemy HP: " + enemy.Statistics.HealthPoints + " / " + enemy.Statistics.MaxHealthPoints;

            return temp;
        }
    }
}
