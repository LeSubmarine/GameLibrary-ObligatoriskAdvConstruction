using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Creature.ItemManagement
{
    /// <summary>
    /// An interface for keeping track of IItems a creature has.
    /// </summary>
    public interface IInventory
    {
        /// <summary>
        /// Takes a IEnumerable of objects that implements IItem and stores them in the inventory.
        /// </summary>
        /// <param name="items">An response with the items that will be getting stored in the inventory.</param>
        /// <returns>Returns a response to describe the result of the operation.</returns>
        public IResponse AddItems(ItemsResponse items);
        
        /// <summary>
        /// Removes an IItem object from the inventory, if it exists.
        /// </summary>
        /// <param name="item">The object that is getting removed from the inventory.</param>
        /// <returns>Returns a response to describe the result of the operation.</returns>
        public IResponse RemoveItem(IItem item);

        /// <summary>
        /// Gets all the items in the inventory.
        /// </summary>
        /// <returns>Return an ItemsResponse containing all the items in the inventory.</returns>
        public ItemsResponse GetItems();
    }
}
