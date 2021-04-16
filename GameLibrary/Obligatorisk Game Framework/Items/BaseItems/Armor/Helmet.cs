using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Responses.CombatResponses;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor
{
    public class Helmet : DefenseItem
    {
        public Helmet(double defense, IEnumerable<IDamageType> types, string name = nameof(Helmet), string slot = "head") : base(name, slot, defense, types)
        {
        }
    }
}
