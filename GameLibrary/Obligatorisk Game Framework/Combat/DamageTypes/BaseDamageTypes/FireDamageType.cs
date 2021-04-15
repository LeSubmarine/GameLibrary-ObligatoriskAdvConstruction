using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.UtilityTools;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    public class FireDamageType : IDamageType
    {
        #region Constructor
        public FireDamageType(double weight = 1, IDamageType.ModifierDelegate modifierMethod = null)
        {
            Weight = weight;
            Modifier = modifierMethod ?? StandardModifier;
        } 
        #endregion


        #region Properties
        public double Weight { get; set; }
        public IDamageType.ModifierDelegate Modifier { get; set; }
        #endregion


        #region Methods
        public virtual double StandardModifier(IDamageType damageType)
        {
            if (TypeComparer<IDamageType>.IsSameOrVariant(this,new FireDamageType()).SuccessValue)
            {
                return 0.1;
            }

            if (expr)
            {
                
            }


            return 1;
        }
        #endregion
    }
}
