using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Items.LootTables
{
    public abstract class AbstractLootTableDecorator : ILootTable
    {
        #region Constructor
        public AbstractLootTableDecorator(ILootTable lootTable)
        {
            LootTable = lootTable;
        }
        #endregion


        #region Properties
        public ILootTable LootTable { get; set; }
        #endregion


        #region Methods
        public abstract Dictionary<IItem, double> ItemsWithWeight();

        public ItemsResponse Loot(Dictionary<IItem, double> itemsWithWeight = null)
        {
            if (itemsWithWeight == null)
            {
                itemsWithWeight = ItemsWithWeight();
            }
            return LootTable.Loot(itemsWithWeight);
        }
        #endregion
    }
}
