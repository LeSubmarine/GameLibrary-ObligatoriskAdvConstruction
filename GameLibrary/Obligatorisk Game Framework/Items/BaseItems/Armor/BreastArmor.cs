using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor
{
    public class BreastArmor : DefenseItem
    {
        public BreastArmor(double defense = 10, IEnumerable<IDamageType> types = null, string name = nameof(BreastArmor), string slot = "breast") : base(name, slot, defense, types)
        {
        }
    }
}
