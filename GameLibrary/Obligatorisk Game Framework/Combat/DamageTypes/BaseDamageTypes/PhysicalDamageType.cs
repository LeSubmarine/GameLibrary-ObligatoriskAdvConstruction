using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    class PhysicalDamageType : DamageTypeTemplate, IDamageType
    {
        public PhysicalDamageType(double weight = 1, IDamageType.ModifierDelegate modifier = null) : base(weight, modifier)
        { }

        public override double StandardModifier(IDamageType damageType)
        {
            return 1;
        }
    }
}
