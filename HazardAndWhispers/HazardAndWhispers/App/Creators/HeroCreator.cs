using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HazardAndWhispers.App.Alive;

namespace HazardAndWhispers.App.Creators
{
    internal class HeroCreator
    {
        private ClassType heroClass;

        public ClassType HeroClass
        {
            get { return heroClass; }
            set { heroClass = value; }
        }

        public Hero CreateHero(ClassType type)
        {
            /* TODO: IMPLEMENT */
            return null;
        }
    }
}
