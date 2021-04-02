using System.Collections.Generic;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Items.LootTables
{
    interface ILootTable
    {
        #region Methods
        public Dictionary<IItem, double> ItemsWithWeight();
        public ItemsResponse Loot(Dictionary<IItem, double> itemsWithWeight);
        #endregion
    }
}
