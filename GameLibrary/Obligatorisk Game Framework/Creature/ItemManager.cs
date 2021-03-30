using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Creature
{
    class ItemManager : IItemManager
    {
        #region Constructor
        public ItemManager(IInventory inventory, GearLoadOut gearLoadOut)
        {
            Inventory = inventory;
            gearLoadOut = GearLoadOut;

            IItemManager.AddItem = Inventory.AddItem;
        }
        #endregion



        #region Properties
        public GearLoadOut GearLoadOut { get; set; }
        public IInventory Inventory { get; set; } 
        #endregion
    }
}
