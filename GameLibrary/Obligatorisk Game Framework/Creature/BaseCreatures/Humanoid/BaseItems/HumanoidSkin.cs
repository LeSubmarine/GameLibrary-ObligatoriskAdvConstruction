using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Responses.CombatResponses;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid.BaseItems
{
    public class HumanoidSkin : IDefenseItem
    {
        #region Constructor
        public HumanoidSkin(string slot, double defense, IEnumerable<IDamageType> types)
        {
            Name = "skin";
            Slot = slot;
            Defense = defense;
            Types = types;
        }

        public HumanoidSkin(string name, string slot, double defense, IEnumerable<IDamageType> types)
        {
            Name = name;
            Slot = slot;
            Defense = defense;
            Types = types;
        }
        #endregion


        #region Properties
        public string Name { get; set; }
        public string Slot { get; set; }
        public double Defense { get; set; }
        public IEnumerable<IDamageType> Types { get; set; }
        #endregion


        #region Methods
        public DamageResponse Defend(DamageResponse damage)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
