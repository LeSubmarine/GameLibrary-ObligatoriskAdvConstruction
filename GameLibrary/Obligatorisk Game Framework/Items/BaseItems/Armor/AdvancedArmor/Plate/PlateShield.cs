using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor.AdvancedArmor.Plate
{
    public class PlateShield : DefenseItem
    {
        public PlateShield(string name = "Shield", string slot = "offhand", double defense = 15, IEnumerable<IDamageType> types = null) : base(name, slot, defense, types)
        {
            Types = types ?? new IDamageType[] {new PhysicalDamageType(),};
        }
    }
}
