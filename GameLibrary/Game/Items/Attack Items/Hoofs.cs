using System.Collections.Generic;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Items;

namespace Game.Items.Attack_Items
{
    class Hoofs : IAttackItem
    {
        public Hoofs()
        {
            Name = "Hoofs";
            Slot = "Feet";
            DamageTypes = new []{new PhysicalDamageType()};
            Power = 1;
        }
        public Hoofs(string name, string slot, IEnumerable<IDamageType> damageTypes, double power)
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
