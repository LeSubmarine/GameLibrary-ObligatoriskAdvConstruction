using System;
using System.Collections.Generic;
using System.Linq;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.Animal_Items;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Creature.LootTables
{
    class LeatherLootTable : ILootTable
    {
        #region Constructor
        public LeatherLootTable(ILootTable lootTable)
        {
            LootTable = lootTable;
        }
        #endregion


        #region Properties
        public ILootTable LootTable { get; set; }
        #endregion


        #region Methods
        public Dictionary<IItem, double> ItemsWithWeight()
        {
            Dictionary<IItem, double> itemDict = LootTable.ItemsWithWeight();

            if (itemDict.Keys.All(a => a.GetType() != typeof(Leather)))
            {
                itemDict[new Leather()] = 1000;
            }

            return itemDict;
        }

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
