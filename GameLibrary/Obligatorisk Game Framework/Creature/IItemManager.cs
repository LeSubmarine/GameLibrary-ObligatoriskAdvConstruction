using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Creature
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
        #endregion


        #region Methods
        /// <summary>
        /// Picks a gear from the inventory and puts it in the GearLoadOut and removes any gear in its place.
        /// If the gear is not in the inventory, it puts it there.
        /// </summary>
        /// <param name="item">The item that is to be equipped.</param>
        /// <returns>Returns an IResponse for information of the operation.</returns>
        public delegate IResponse EquipGear(IWearable item);

        /// <summary>
        /// Removes a gear from the GearLoadOut.
        /// </summary>
        /// <param name="item">The item that is to be removed from GearLoadOut.</param>
        /// <returns>Returns an IResponse for information of the operation.</returns>
        public delegate IResponse DeEquipGear(IWearable item);


        /// <summary>
        /// Adds an IItem to the inventory.
        /// </summary>
        /// <param name="item">item is the IItem object getting added to the inventory.</param>
        /// <returns>Returns a IResponse describing the operation.</returns>
        public delegate IResponse AddItem(IItem item);

        /// <summary>
        /// Removes an IItem from the inventory, if it exists in it.
        /// </summary>
        /// <param name="item">item is the IItem object getting removed from the inventory.</param>
        /// <returns>Returns a IResponse describing the operation.</returns>
        public delegate IResponse RemoveItem(IItem item);

        /// <summary>
        /// Gets all the items in the inventory.
        /// </summary>
        /// <returns>Return an ItemsResponse containing all the items in the inventory.</returns>
        public delegate ItemsResponse GetItems();
        #endregion
    }
}
