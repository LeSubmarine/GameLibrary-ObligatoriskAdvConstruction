using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Responses.CombatResponses;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor
{
    public class HeadArmor : DefenseItem
    {
        public HeadArmor(double defense = 5, IEnumerable<IDamageType> types = null, string name = nameof(HeadArmor), string slot = "head") : base(name, slot, defense, types)
        {
            Types = types ?? new IDamageType[] {new PhysicalDamageType(),};
        }
    }
}
