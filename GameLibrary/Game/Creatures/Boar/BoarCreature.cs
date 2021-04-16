using System;
using System.Linq;
using Obligatorisk_Game_Framework.Combat;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.Responses.CombatResponses;
using Obligatorisk_Game_Framework.World;

namespace Game.Creatures.Boar
{
    class BoarCreature : CreatureCombatBehavior
    {
        public BoarCreature(int hitpoints, IItemManager itemManager, string name, bool removable, Position position, ILootTable lootTable, int level) : base(hitpoints, itemManager, name, removable, position, lootTable, level)
        {

        }
    }
}
