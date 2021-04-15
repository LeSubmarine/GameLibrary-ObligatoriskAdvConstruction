using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Creature.ItemManagement
{
    /// <summary>
    /// Interface for controlling the items for a creature.
    /// </summary>
    public interface IItemManager
    {
        #region Properties
        /// <summary>
        /// Represents the gear the owner is wearing.
        /// </summary>
        public GearLoadOut GearLoadOut { get; set; }

        /// <summary>
        /// Represents the all the items the owner is carrying.
        /// </summary>
        public IInventory Inventory { get; set; }


        #region GearLoadOut delegates
        /// <summary>
        /// Picks a gear from the inventory and puts it in the GearLoadOut and removes any gear in its place.
        /// If the gear is not in the inventory, it puts it there.
        /// </summary>
        /// <param name="item">The item that is to be equipped.</param>
        /// <returns>Returns an IResponse for information of the operation.</returns>
        public EquipGearDelegate EquipGear { get; set; }

        /// <summary>
        /// Removes a gear from the GearLoadOut.
        /// </summary>
        /// <param name="item">The item that is to be removed from GearLoadOut.</param>
        /// <returns>Returns an IResponse for information of the operation.</returns>
        public DeEquipGearDelegate DeEquipGear { get; set; } 
        #endregion


        #region Inventory delegates
        /// <summary>
        /// Adds an IItem to the inventory.
        /// </summary>
        /// <param name="item">item is the IItem object getting added to the inventory.</param>
        /// <returns>Returns a IResponse describing the operation.</returns>
        public AddItemDelegate AddItem { get; set; }

        /// <summary>
        /// Gets all the items in the inventory.
        /// </summary>
        /// <returns>Return an ItemsResponse containing all the items in the inventory.</returns>
        public GetItemsDelegate GetItems { get; set; }

        /// <summary>
        /// Removes an IItem from the inventory, if it exists in it.
        /// </summary>
        /// <param name="item">item is the IItem object getting removed from the inventory.</param>
        /// <returns>Returns a IResponse describing the operation.</returns>
        public RemoveItemDelegate RemoveItem { get; set; } 
        #endregion
        #endregion


        #region Methods
        public delegate IResponse EquipGearDelegate(IWearable item);
        public delegate IResponse DeEquipGearDelegate(IWearable item);


        public delegate IResponse AddItemDelegate(IItem item);
        public delegate IResponse RemoveItemDelegate(IItem item);

        
        public delegate ItemsResponse GetItemsDelegate();
        #endregion
    }
}
