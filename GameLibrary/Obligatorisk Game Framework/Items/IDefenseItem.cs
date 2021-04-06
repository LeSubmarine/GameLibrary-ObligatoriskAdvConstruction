using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Items
{
    public interface IDefenseItem : IWearable
    {
        #region Properties
        public double Defense { get; set; }
        #endregion
    }

}
