﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Adventure
{
    internal interface IAdventureState
    {
        public Expedition ExpeditionContext { get; set; }
        public string Action(ConsoleKeyInfo keyInfo);
    }
}
