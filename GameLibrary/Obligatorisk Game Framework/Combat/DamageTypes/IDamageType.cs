using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Combat.DamageTypes
{
    public interface IDamageType
    {
        public double Weight { get; set; }
        public ModifierDelegate Modifier { get; set; }

        public delegate double ModifierDelegate(IDamageType damageType);

        public double StandardModifier(IDamageType damageType);
    }
}
