﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Items
{
    public interface IAttackItem : IWearable
    {
        #region Properties
        public double Power { get; set; }
        #endregion
    }
}