using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obligatorisk_Game_Framework.Combat;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.BaseItems.HumanoidItems;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.World;

namespace FrameworkDisplay
{
    public class Human : HumanoidCreature
    {
        public Human(string name, Position position) : base(1, 100, new ItemManager(new Inventory(), new HumanoidLoadOut(new HumanoidSlots(),new HumanoidSkin("",new IDamageType[]{new PhysicalDamageType(), }),new HumanoidFists())), name, false, position, null)
        {
            CurrentAttackItem = ItemManager.GearLoadOut.AttackItems.Values.First();
        }


        public IAttackItem CurrentAttackItem { get; set; }


        protected override IDamageDealing PickDamageDealing()
        {
            return CurrentAttackItem;
        }


        public ItemsResponse PickUp(ItemsResponse items)
        {
            this.ItemManager.AddItems(items);
            return new ItemsResponse("Items picked up",items.Origin,items.Value);
        }


        public override IResponse Move(int newX, int newY)
        {
            return base.Move(Position.X + newX, Position.Y + newY);
        }
    }
}
