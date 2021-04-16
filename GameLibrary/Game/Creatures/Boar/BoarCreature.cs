using System;
using System.Linq;
using Obligatorisk_Game_Framework.Combat;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.Responses.CombatResponses;
using Obligatorisk_Game_Framework.World;

namespace Game.Creatures.Boar
{
    class BoarCreature : Creature
    {
        public BoarCreature(int hitpoints, string name, bool removable, Position position) : 
            base(hitpoints,
                new ItemManager(
                    new Inventory(), 
                    new BoarGearLoadOut()),
                name,
                removable, 
                position) { }

        public override IResponse ReceiveHit(DamageResponse hit)
        {
            throw new NotImplementedException();
        }

        public override DamageResponse Hit()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            var damageSlotEnumerable = from slot in ItemManager.GearLoadOut.AttackItems.Keys select slot;
            string damageSlot = damageSlotEnumerable.ToArray()[rnd.Next(damageSlotEnumerable.Count())];
            IDamageDealing damageDealer = ItemManager.GearLoadOut.AttackItems[damageSlot];

        }

        public override ItemsResponse Loot()
        {
            throw new NotImplementedException();
        }
    }
}
