using System.Collections.Generic;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Creature.ItemManagement
{
    public class Inventory : IInventory
    {
        private List<IItem> _items;

        public Inventory()
        {
            _items = new List<IItem>();
        }

        public IResponse AddItems(ItemsResponse items)
        {
            if (items != null)
            {
                _items.AddRange(items.Value);
                return new SuccessResponse($"The items were added to the inventory.");
            }
            return new FailureResponse("The items could not be added to the inventory as it was null.");
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