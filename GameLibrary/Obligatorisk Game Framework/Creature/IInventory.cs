using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Creature
{
    /// <summary>
    /// An interface for keeping track of IItems a creature has.
    /// </summary>
    public interface IInventory
    {
        /// <summary>
        /// Takes an object that implements IItem and stores it in the inventory.
        /// </summary>
        /// <param name="item">The object that is getting stored in the inventory.</param>
        /// <returns>Returns a response to describe the operation</returns>
        public IResponse AddItem(IItem item);

        /// <summary>
        /// Gets all the items in the inventory.
        /// </summary>
        /// <returns>Return an IEnumerable containing all the items in the inventory.</returns>
        public IEnumerable<IItem> GetItems();
    }
}
