using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Responses.CombatResponses;

namespace Obligatorisk_Game_Framework.Items
{
    public interface IDefenseItem : IWearable
    {
        #region Properties
        public double Defense { get; set; }
        public IEnumerable<IDamageType> Types { get; set; }
        #endregion


        #region Methods
        public DamageResponse Defend(DamageResponse damage);
        #endregion
    }

}
