using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor
{
    public class BreastArmor : DefenseItem
    {
        public BreastArmor(double defense, IEnumerable<IDamageType> types, string name = nameof(BreastArmor), string slot = "breast") : base(name, slot, defense, types)
        {
        }
    }
}
