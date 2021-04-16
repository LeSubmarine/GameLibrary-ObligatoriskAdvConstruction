using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;

namespace Obligatorisk_Game_Framework.Items
{
    public abstract class AttackItem : IAttackItem
    {
        public AttackItem(string name, string slot, IEnumerable<IDamageType> damageTypes, double power)
        {
            Name = name;
            Slot = slot;
            DamageTypes = damageTypes;
            Power = power;
        }
        public string Name { get; set; }
        public string Slot { get; set; }
        public IEnumerable<IDamageType> DamageTypes { get; set; }
        public double Power { get; set; }
    }
}
