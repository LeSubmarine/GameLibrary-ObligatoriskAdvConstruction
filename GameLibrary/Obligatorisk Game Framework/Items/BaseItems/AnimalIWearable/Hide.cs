using System.Collections.Generic;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.AnimalIWearable
{
    public class Hide : DefenseItem
    {
        public Hide( IEnumerable<IDamageType> types, string name = "hide", double defense = 1.5, string slot = "skin") : base(name, slot, defense, types)
        {
            types ??= new IDamageType[] {new PhysicalDamageType(3), new WaterDamageType(1)};
        }
    }
}
