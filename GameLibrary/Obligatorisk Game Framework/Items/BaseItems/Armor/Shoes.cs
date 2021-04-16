using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor
{
    public class Shoes : DefenseItem
    {
        public Shoes(string name = "Shoes", string slot = "feet", double defense = 1, IEnumerable<IDamageType> types = null) : base(name, slot, defense, types)
        {
            Types = types ?? new IDamageType[] { new PhysicalDamageType(), };
        }
    }
}
