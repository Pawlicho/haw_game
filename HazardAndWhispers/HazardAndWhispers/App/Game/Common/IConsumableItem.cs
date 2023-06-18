using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazardAndWhispers.App.Game.Common
{
    internal interface IConsumableItem : IItem
    {
        public uint NumberOfUsageLeft { get; }
        public uint MaxNumberOfUsage { get; }

        public bool Consume();
    }
}
