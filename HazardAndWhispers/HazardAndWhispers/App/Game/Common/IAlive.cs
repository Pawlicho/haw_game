﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal interface IAlive
    {
        public StatRegister Statistics { get; }
        public List<ITourMove> MoveSet { get; }
        public int RunMove(int moveId);

    }
}
