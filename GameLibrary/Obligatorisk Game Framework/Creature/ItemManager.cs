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
            GearLoadOut = gearLoadOut;

            AddItem = Inventory.AddItem;
            RemoveItem = Inventory.RemoveItem;
            GetItems = Inventory.GetItems;

            EquipGear = GearLoadOut.EquipItem;
            DeEquipGear = GearLoadOut.DeEquipItem;
        }
        #endregion



        #region Properties
        public GearLoadOut GearLoadOut { get; set; }
        public IInventory Inventory { get; set; }

        public IItemManager.AddItemDelegate AddItem { get; set; }
        public IItemManager.RemoveItemDelegate RemoveItem { get; set; }
        public IItemManager.GetItemsDelegate GetItems { get; set; }

        public IItemManager.EquipGearDelegate EquipGear { get; set; }
        public IItemManager.DeEquipGearDelegate DeEquipGear { get; set; }
        #endregion
    }
}
