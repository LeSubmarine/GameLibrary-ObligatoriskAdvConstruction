using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.UtilityTools;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    public class FireDamageType : DamageTypeTemplate, IDamageType
    {
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="modifierMethod"></param>
        public FireDamageType(double weight = 1, IDamageType.ModifierDelegate modifierMethod = null) : base(weight, modifierMethod)
        {
        } 
        #endregion


        #region Methods
        public override double StandardModifier(IDamageType damageType)
        {
            if (TypeComparer.IsSameOrVariant(damageType.GetType(),typeof(FireDamageType)).SuccessValue)
            {
                return 0.5;
            }

            if (TypeComparer.IsSameOrVariant(damageType.GetType(), typeof(WaterDamageType)).SuccessValue)
            {
                return 0.1;
            }


            return 1;
        }
        #endregion
    }
}
