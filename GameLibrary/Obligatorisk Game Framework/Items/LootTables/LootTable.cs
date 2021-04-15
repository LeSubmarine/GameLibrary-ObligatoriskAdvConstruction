using System;
using System.Collections.Generic;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Items.LootTables
{
    class LootTable : ILootTable
    {
        #region Methods
        public Dictionary<IItem, double> ItemsWithWeight()
        {
            return new Dictionary<IItem, double>();
        }

        public ItemsResponse Loot(Dictionary<IItem, double> itemsWithWeight)
        {
            double weights = 0;
            foreach (var weight in itemsWithWeight.Values)
            {
                weights += weight;
            }

            Random rnd = new Random();
            double lootDouble = rnd.NextDouble() * weights;

            weights = 0;
            foreach (var keyValuePair in itemsWithWeight)
            {
                if (weights <= lootDouble && lootDouble <= (weights + keyValuePair.Value))
                {
                    return new ItemsResponse(
                        $"The item: {keyValuePair.Key.Name} has been looted.",
                        "Loot table",
                        new[] {keyValuePair.Key}
                    );
                }

                weights += keyValuePair.Value;
            }

            return new ItemsResponse(
                "The loot table failed to loot",
                "Loot table",
                null
            );
        } 
        #endregion
    }
}
