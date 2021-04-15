using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat;

namespace Obligatorisk_Game_Framework.Items
{
    public interface IAttackItem : IWearable,IDamageDealing
    {
        #region Properties
        public double Power { get; set; }
        #endregion
    }
}
