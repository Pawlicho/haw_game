﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Adventure
{
    internal class Location
    {
        private LocationType type;
        private bool isCompleted;
        private LocationMap map;

        public LocationType Type
        {
            get { return type; }
        }
        public bool IsCompleted
        {
            get { return isCompleted; }
        }
        public LocationMap Map
        {
            get { return map; }
        }

        public Location(LocationType type_, LocationMap map_)
        {
            type = type_;
            isCompleted = false;
            map = map_;
        }

        public Location() 
        {
            //debug
            type = LocationType.Swamp;
        }
    }
}
