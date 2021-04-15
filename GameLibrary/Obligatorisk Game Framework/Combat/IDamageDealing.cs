using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;

namespace Obligatorisk_Game_Framework.Combat
{
    /// <summary>
    /// Represents something that can deal damage.
    /// </summary>
    public interface IDamageDealing
    {
        /// <summary>
        /// The Types of damage this object deals.
        /// </summary>
        public IEnumerable<IDamageType> DamageTypes { get; set; }
    }
}
