using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor
{
    public class BreastPlate : DefenseItem
    {
        public BreastPlate(double defense, IEnumerable<IDamageType> types, string name = nameof(BreastPlate), string slot = "breast") : base(name, slot, defense, types)
        {
        }
    }
}
