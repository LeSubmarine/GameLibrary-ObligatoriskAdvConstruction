﻿using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Creature
{
    /// <summary>
    /// Defines the basic behavior of a creature
    /// </summary>
    public abstract class Creature : WorldObject
    {
        #region Constructor
        protected Creature(int hitpoints, IItemManager itemManager, string name, Position position, bool removable) : base(name,removable, position)
        {
            Hitpoints = hitpoints;
            ItemManager = itemManager;
        }
        #endregion


        #region Properties
        public int Hitpoints { get; set; }
        public IItemManager ItemManager { get; set; }
        #endregion


        #region Methods
        public abstract IResponse ReceiveHit(int hit);
        public abstract int Hit(int hit);
        public abstract IEnumerable<IItem> Loot();
        #endregion
    }
}
