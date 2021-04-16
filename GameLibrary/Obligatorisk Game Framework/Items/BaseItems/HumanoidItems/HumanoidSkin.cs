using System.Collections.Generic;
using System.Linq;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Responses.CombatResponses;

namespace Obligatorisk_Game_Framework.Items.BaseItems.HumanoidItems
{
    public class HumanoidSkin : DefenseItem
    {
        #region Constructor
        public HumanoidSkin(string slot, IEnumerable<IDamageType> types, double defense = 0,string name = "skin") : base(name,slot,defense,types)
        {
            Name = name;
            Slot = slot;
            Types = types;
            Defense = defense;
        }
        #endregion
    }
}
