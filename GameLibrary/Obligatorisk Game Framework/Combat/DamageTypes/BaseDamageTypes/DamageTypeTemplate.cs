﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    /// <summary>
    /// Implements the basic components of an IDamageType
    /// </summary>
    public abstract class DamageTypeTemplate
    {
        #region Constructor
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
