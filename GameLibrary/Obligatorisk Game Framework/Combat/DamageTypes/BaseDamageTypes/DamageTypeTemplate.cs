using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    /// <summary>
    /// Implements the basic components of an IDamageType
    /// </summary>
    public abstract class DamageTypeTemplate : IDamageType
    {
        #region Constructor
        /// <summary>
        /// Initializes a DamageType with Weight and Modifier.
        /// </summary>
        /// <param name="weight">This is how much weighted this IDamageType is in comparison to possibly others.</param>
        /// <param name="modifier">This the function that given another type defines how damage is modified compared to this type.</param>
        protected DamageTypeTemplate(double weight, IDamageType.ModifierDelegate modifier = null)
        {
            Weight = weight;
            Modifier = modifier ?? StandardModifier;
        } 
        #endregion


        #region Properties
        public double Weight { get; set; }
        public IDamageType.ModifierDelegate Modifier { get; set; }
        #endregion


        #region Methods
        public abstract double StandardModifier(IDamageType damageType); 
        #endregion
    }
}
