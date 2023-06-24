using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Hamlet
{
    internal class Hamlet
    {
        private Dictionary<BuildingType, IBuilding> map;

        public Dictionary<BuildingType, IBuilding> Map
        {
            get { return map; }
        }

        public Hamlet(Dictionary<BuildingType, IBuilding> map_) 
        {
            map = map_;
        }
    }
}
