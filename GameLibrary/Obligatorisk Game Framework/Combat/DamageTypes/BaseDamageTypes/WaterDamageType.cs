using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.UtilityTools;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    /// <summary>
    /// Represents water as a damage type.
    /// </summary>
    public class WaterDamageType : DamageTypeTemplate, IDamageType
    {
        #region Constructor
        /// <summary>
        /// Initializes a DamageType with Weight and Modifier.
        /// </summary>
        /// <param name="weight">This is how much weighted this IDamageType is in comparison to possibly others.</param>
        /// <param name="modifier">This the function that given another type defines how damage is modified compared to this type.</param>
        public WaterDamageType(double weight = 1, IDamageType.ModifierDelegate modifier = null) : base(weight,modifier)
        { }
        #endregion


        #region Method
        public override double StandardModifier(IDamageType damageType)
        {
            if (TypeComparer.IsSameOrVariant(damageType.GetType(), typeof(WaterDamageType)).SuccessValue)
            {
                return 0.5;
            }

            if (TypeComparer.IsSameOrVariant(damageType.GetType(), typeof(FireDamageType)).SuccessValue)
            {
                return 0.1;
            }


            return 1;
        } 
        #endregion
    }
}
