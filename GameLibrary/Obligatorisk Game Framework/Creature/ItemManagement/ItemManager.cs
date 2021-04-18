namespace Obligatorisk_Game_Framework.Creature.ItemManagement
{
    /// <summary>
    /// Class for managing the inventory and equipping items. 
    /// </summary>
    public class ItemManager : IItemManager
    {
        #region Constructor
        /// <summary>
        /// Initializes the ItemManager with injected IInventory and GearLoadOut.
        /// </summary>
        /// <param name="inventory">The inventory that will keep track of items in general.</param>
        /// <param name="gearLoadOut">The </param>
        public ItemManager(IInventory inventory, GearLoadOut gearLoadOut)
        {
            Inventory = inventory;
            GearLoadOut = gearLoadOut;

            AddItems = Inventory.AddItems;
            RemoveItem = Inventory.RemoveItem;
            GetItems = Inventory.GetItems;

            EquipGear = GearLoadOut.EquipItem;
            DeEquipGear = GearLoadOut.DeEquipItem;
        }
        #endregion



        #region Properties
        public GearLoadOut GearLoadOut { get; set; }
        public IInventory Inventory { get; set; }

        public IItemManager.AddItemsDelegate AddItems { get; set; }
        public IItemManager.RemoveItemDelegate RemoveItem { get; set; }
        public IItemManager.GetItemsDelegate GetItems { get; set; }

        public IItemManager.EquipGearDelegate EquipGear { get; set; }
        public IItemManager.DeEquipGearDelegate DeEquipGear { get; set; }
        #endregion
    }
}
