using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.BaseItems.ItemModels.Humanoid_Items;
using Obligatorisk_Game_Framework.Items.LootTables;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid
{
    public class BoarLootTableDecorator : AbstractLootTableDecorator
    {
        public BoarLootTableDecorator(ILootTable lootTable) : base(lootTable)
        {
        }

        public override Dictionary<IItem, double> ItemsWithWeight()
        {
            Dictionary<IItem, double> dictionary = new Dictionary<IItem, double> {{new Cloth(), 1}};
            return dictionary;
        }
    }
}
