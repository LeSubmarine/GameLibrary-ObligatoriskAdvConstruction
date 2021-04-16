using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Weapons
{
    public class Sword : AttackItem
    {
        public Sword(IEnumerable<IDamageType> damageTypes, double power, string slot = "fist", string name = "sword") : base(name, slot, damageTypes, power)
        {
        }
    }
}
