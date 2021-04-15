using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;

namespace Obligatorisk_Game_Framework.Combat
{
    public interface IDamageDealing
    {
        public IEnumerable<IDamageType> DamageTypes { get; set; }
    }
}
