using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Responses;

namespace Game.Injected_Classes
{
    public class Inventory : IInventory
    {
        private List<IItem> _items;

        public Inventory()
        {
            _items = new List<IItem>();
        }

        public IResponse AddItem(IItem item)
        {
            if (item != null)
            {
                _items.Add(item);
                return new SuccessResponse($"The item: {item.Name} was added to the inventory.");
            }
            return new FailureResponse("The item could not be added to the inventory as it was null.");
        }

        public IResponse RemoveItem(IItem item)
        {
            if (item == null)
            {
                if (_items.Remove(item))
                {
                    return new SuccessResponse($"The item: {item.Name} was removed from the inventory.");
                }
                return new FailureResponse($"The item: {item.Name} did not exist in the inventory.");
            }
            return new FailureResponse("The item could not be removed to the inventory as it was null.");
        }

        public ItemsResponse GetItems()
        {
            return new ItemsResponse("The items have been requested from the inventory", "Inventory", new List<IItem>(_items));
        }
    }
}
