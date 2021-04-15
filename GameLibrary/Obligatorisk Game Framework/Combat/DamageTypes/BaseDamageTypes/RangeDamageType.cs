using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    class RangeDamageType : DamageTypeTemplate,IDamageType
    {
        #region Constructor
        public RangeDamageType(double weight, IDamageType.ModifierDelegate modifier = null) : base(weight, modifier)
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
