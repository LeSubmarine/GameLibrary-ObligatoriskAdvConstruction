using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor
{
    public class ShoulderArmor : DefenseItem
    {
        public ShoulderArmor(string name = "Shoulder armor", string slot = "shoulder", double defense = 5, IEnumerable<IDamageType> types = null) : base(name, slot, defense, types)
        {
            Types = types ?? new IDamageType[] { new PhysicalDamageType(), };
        }
    }
}
