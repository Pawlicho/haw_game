using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.Creators
{
    internal interface IMonsterCreator
    {
        public Monster CreateMonster(bool isBoss);
    }
}
