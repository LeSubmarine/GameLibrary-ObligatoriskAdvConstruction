using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.UtilityTools;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    class WaterDamageType : DamageTypeTemplate, IDamageType
    {
        #region Constructor
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
