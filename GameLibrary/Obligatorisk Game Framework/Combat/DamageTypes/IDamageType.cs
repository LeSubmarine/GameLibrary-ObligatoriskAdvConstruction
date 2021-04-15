using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes
{
    /// <summary>
    /// Represents a type of damage.
    /// </summary>
    public interface IDamageType
    {
        #region Properties
        /// <summary>
        /// How much is this type of damage is of this type.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// This the function that defines how a damage type is affected by other damage types.
        /// </summary>
        public ModifierDelegate Modifier { get; set; }

        /// <summary>
        /// This the function that defines how a damage type is affected by other damage types.
        /// </summary>
        /// <param name="damageType">This the damage type that will be compared to this type.</param>
        /// <returns>Return a double representing how much the damage should be modified.</returns>
        public delegate double ModifierDelegate(IDamageType damageType);
        #endregion

        /// <summary>
        /// This is the standard modifier for the property Modifier, if given no other is given.
        /// </summary>
        /// <param name="damageType">This the damage type that will be compared to this type.</param>
        /// <returns>Return a double representing how much the damage should be modified.</returns>
        public double StandardModifier(IDamageType damageType);
    }
}
