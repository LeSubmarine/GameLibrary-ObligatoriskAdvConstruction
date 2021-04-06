using System.Collections.Generic;
using System.Linq;
using Game.Item_Models.Animal_Items;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.LootTables;

namespace Game.LootTables.Animal_Items_Table
{
    class TuskLootTable : AbstractLootTableDecorator
    {
        public TuskLootTable(ILootTable lootTable) : base(lootTable)
        {
        }

        public override Dictionary<IItem, double> ItemsWithWeight()
        {
            Dictionary<IItem, double> itemDict = LootTable.ItemsWithWeight();

            if (itemDict.Keys.All(a => a.GetType() != typeof(Leather)))
            {
                itemDict[new Tusk{Name = "tusk"}] = 500;
            }

            return itemDict;
        }
    }
}
