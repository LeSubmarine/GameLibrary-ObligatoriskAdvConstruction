using System.Collections.Generic;
using System.Linq;
using Game.Items.Item_Models.Animal_Items;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.LootTables;

namespace Game.LootTables.Animal_Items_Table
{
    class LeatherLootTable : AbstractLootTableDecorator
    {
        #region Constructor
        public LeatherLootTable(ILootTable lootTable) : base(lootTable)
        { }
        #endregion


        #region Methods
        public override Dictionary<IItem, double> ItemsWithWeight()
        {
            Dictionary<IItem, double> itemDict = LootTable.ItemsWithWeight();

            if (itemDict.Keys.All(a => a.GetType() != typeof(Leather)))
            {
                itemDict[new Leather{Name = "leather"}] = 1000;
            }

            return itemDict;
        }
        #endregion
    }
}
