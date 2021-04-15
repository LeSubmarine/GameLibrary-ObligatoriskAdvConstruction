using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.Responses.CombatResponses;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid
{
    public class HumanoidCreature : Creature
    {
        public HumanoidCreature(int hitpoints, IItemManager itemManager, string name, bool removable, Position position) : base(hitpoints, itemManager, name, removable, position)
        {
        }

        public override IResponse ReceiveHit(DamageResponse hit)
        {
            throw new NotImplementedException();
        }

        public override DamageResponse Hit()
        {
            throw new NotImplementedException();
        }

        public override ItemsResponse Loot()
        {
            throw new NotImplementedException();
        }
    }
}
