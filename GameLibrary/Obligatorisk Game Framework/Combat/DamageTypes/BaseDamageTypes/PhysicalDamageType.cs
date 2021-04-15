using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    /// <summary>
    /// Represents physical damage.
    /// </summary>
    public class PhysicalDamageType : DamageTypeTemplate, IDamageType
    {
        /// <summary>
        /// Initializes a DamageType with Weight and Modifier.
        /// </summary>
        /// <param name="weight">This is how much weighted this IDamageType is in comparison to possibly others.</param>
        /// <param name="modifier">This the function that given another type defines how damage is modified compared to this type.</param>
        public PhysicalDamageType(double weight = 1, IDamageType.ModifierDelegate modifier = null) : base(weight, modifier)
        { }

        public override double StandardModifier(IDamageType damageType)
        {
            return 1;
        }
    }
}
