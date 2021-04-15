using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    /// <summary>
    /// Represents ranged damage.
    /// </summary>
    public class RangeDamageType : DamageTypeTemplate,IDamageType
    {
        #region Constructor
        /// <summary>
        /// Initializes a DamageType with Weight and Modifier.
        /// </summary>
        /// <param name="weight">This is how much weighted this IDamageType is in comparison to possibly others.</param>
        /// <param name="modifier">This the function that given another type defines how damage is modified compared to this type.</param>
        public RangeDamageType(double weight = 1, IDamageType.ModifierDelegate modifier = null) : base(weight, modifier)
        { }
        #endregion


        #region Methods
        public override double StandardModifier(IDamageType damageType)
        {
            return 1;
        } 
        #endregion
    }
}
