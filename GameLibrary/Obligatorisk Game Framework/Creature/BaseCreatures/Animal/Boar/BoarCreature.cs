using System;
using System.Linq;
using Obligatorisk_Game_Framework.Combat;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Animal.Boar
{
    public class BoarCreature : CreatureCombatBehavior
    {
        public BoarCreature(int level, int hitpoints, IItemManager itemManager, string name, bool removable,
            Position position, ILootTable lootTable) : base(hitpoints, itemManager, name, removable, position, lootTable, level)
        { }

        #region Methods

        protected override IDamageDealing PickDamageDealing()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int noOfAttackSlots = ItemManager.GearLoadOut.AttackItems.Values.Count(a => !(a is null));
            return ItemManager.GearLoadOut.AttackItems.Values.Where(a => !(a is null)).ToArray()[
                random.Next(noOfAttackSlots)];
        }

        #endregion
    }
}
