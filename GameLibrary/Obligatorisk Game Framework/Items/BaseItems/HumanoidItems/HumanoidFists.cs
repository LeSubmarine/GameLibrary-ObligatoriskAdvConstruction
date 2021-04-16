using System.Collections.Generic;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.HumanoidItems
{
    public class HumanoidFists : AttackItem
    {
        public HumanoidFists(string name = "fist", string slot = "fist", IEnumerable<IDamageType> damageTypes = null, double power = 1) : base(name, slot, damageTypes, power)
        {
            DamageTypes = damageTypes ?? new []{new PhysicalDamageType(), };
        }
    }
}
