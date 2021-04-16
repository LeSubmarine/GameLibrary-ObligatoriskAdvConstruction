using System.Collections.Generic;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.AnimalItems
{
    public class TuskWeapon : AttackItem
    {
        public TuskWeapon(IEnumerable<IDamageType> damageTypes, double power = 10, string name = "hoofs", string slot = "teeth") : base(name, slot, damageTypes, power)
        {
            damageTypes ??= new IDamageType[] { new PhysicalDamageType(1.5), new WaterDamageType(2),  };
        }
    }
}
