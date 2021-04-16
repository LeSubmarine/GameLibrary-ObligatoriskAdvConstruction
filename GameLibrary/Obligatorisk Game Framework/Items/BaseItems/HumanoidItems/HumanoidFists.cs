using System.Collections.Generic;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.HumanoidItems
{
    public class HumanoidFists : IAttackItem
    {
        public HumanoidFists(string name = "fist", string slot = "fist", IEnumerable<IDamageType> damageTypes = null, double power = 1)
        {
            Name = name;
            Slot = slot;
            DamageTypes = damageTypes ?? new []{new PhysicalDamageType(), };
            Power = power;
        }

        public string Name { get; set; }
        public string Slot { get; set; }
        public IEnumerable<IDamageType> DamageTypes { get; set; }
        public double Power { get; set; }
    }
}
