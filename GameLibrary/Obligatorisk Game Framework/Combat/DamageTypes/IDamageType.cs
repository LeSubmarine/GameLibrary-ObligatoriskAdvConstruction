using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes
{
    public interface IDamageType
    {
        public double Weight { get; set; }
        
        public static Dictionary<IDamageType,double> Modifiers { get; set; }
    }
}
