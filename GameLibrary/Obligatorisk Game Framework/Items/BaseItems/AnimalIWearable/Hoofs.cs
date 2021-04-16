using System.Collections.Generic;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.AnimalIWearable
{
    public class Hoofs : AttackItem
    {
        public Hoofs( IEnumerable<IDamageType> damageTypes, double power = 5, string name = "hoofs", string slot = "feet") : base(name, slot, damageTypes, power)
        {
            damageTypes ??= new IDamageType[]{new PhysicalDamageType(), };
        }
    }
}
