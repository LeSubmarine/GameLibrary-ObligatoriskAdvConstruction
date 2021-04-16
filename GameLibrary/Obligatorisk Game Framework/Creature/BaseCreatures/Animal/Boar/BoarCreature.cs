using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obligatorisk_Game_Framework.Combat;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.Responses.CombatResponses;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid
{
    public class HumanoidCreature : CreatureCombatBehavior
    {
        public HumanoidCreature(int level, int hitpoints, IItemManager itemManager, string name, bool removable,
            Position position, ILootTable lootTable) : base(hitpoints, itemManager, name, removable, position, lootTable, level)
        { }
    }
}
