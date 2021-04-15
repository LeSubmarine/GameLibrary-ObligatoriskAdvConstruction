using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes
{
    public class FireDamageType : IDamageType
    {
        public FireDamageType(double weight)
        {
            Weight = weight;
        }

        public double Weight { get; set; }
    }
}
