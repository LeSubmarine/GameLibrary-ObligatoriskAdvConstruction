using System;
using System.Collections.Generic;
using System.Linq;
using Obligatorisk_Game_Framework.Combat;
using Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.Responses.CombatResponses;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Creature
{
    public abstract class CreatureCombatBehavior : Creature
    {
        #region Constructor
        protected CreatureCombatBehavior(int hitpoints, IItemManager itemManager, string name, bool removable, Position position, ILootTable lootTable, int level) : base(hitpoints, itemManager, name, removable, position, lootTable)
        {
            Level = level;
        } 
        #endregion


        #region Property
        public int Level { get; set; } 
        #endregion


        #region Methods
        public override IResponse ReceiveHit(DamageResponse hit)
        {
            IDefenseItem defenseItem = PickDefenseItem();
            DamageResponse defended = defenseItem.Defend(hit);
            int damageRoundedUp;
            if (defended.SuccessValue)
            {
                damageRoundedUp = Convert.ToInt32(Math.Ceiling(defended.Damage));
            }
            else
            {
                return new FailureResponse("A defense Item failed");
            }

            if (damageRoundedUp > 0)
            {
                Hitpoints = Hitpoints - damageRoundedUp;
                if (Hitpoints == 0)
                {
                    return Death();
                }
                return new SuccessResponse($"{Name} of type {GetType().Name} took {damageRoundedUp} points of damage from {hit.Origin.Name}.");
            }
            
            return new SuccessResponse($"{Name} blocked the damage from {hit.Origin.Name}'s attack.");
        }
        
        public override DamageResponse Hit()
        {
            if (!(Hitpoints > 0))
            {
                return new DamageResponse($"{Name} is dead and can't fight",false,0,this,null);
            }
            Random random = new Random(DateTime.Now.Millisecond);
            IDamageDealing weapon = PickDamageDealing();
            double baseDamage = weapon.Power * LevelStrengthModifier(Level);
            double finalDamage = (baseDamage / 2) + baseDamage * random.NextDouble() * 2;
            int damage = Convert.ToInt32(Math.Floor(finalDamage));

            string nameOfWeapon = null;
            foreach (var property in weapon.GetType().GetProperties())
            {
                if (property.Name == "Name")
                {
                    nameOfWeapon = property.GetValue(weapon).ToString();
                }
            }

            return new DamageResponse(
                $"{this.GetType().Name} deals {damage} damage with {nameOfWeapon ?? weapon.GetType().Name}",
                damage > 0,
                damage > 0 ? damage : 0,
                this,
                weapon);
        }

        public override ItemsResponse Loot()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            double numberOfRolls = Math.Log10(Level) + 1;
            List<IItem> itemsRolled = new List<IItem>();

            numberOfRolls--;
            var lootItemsResponse = LootTable.Loot();
            if (lootItemsResponse.SuccessValue)
            {
                itemsRolled.AddRange(lootItemsResponse.Value);
            }

            while (numberOfRolls < 0)
            {
                numberOfRolls--;
                if (random.NextDouble() < numberOfRolls && random.NextDouble() > 0.5)
                {
                    lootItemsResponse = LootTable.Loot();
                    if (lootItemsResponse.SuccessValue)
                    {
                        itemsRolled.AddRange(lootItemsResponse.Value);
                    }
                }

            }

            return new ItemsResponse(
                $"A {nameof(Creature)} of class {this.GetType().Name} is getting looted.",
                $"A {nameof(Creature)} of class {this.GetType().Name} 's Loot method.",
                itemsRolled);
        }

        protected virtual IDefenseItem PickDefenseItem()
        {
            return new CompositeDefenseItem(ItemManager.GearLoadOut.DefenseItems.Values);
        }

        protected virtual IDamageDealing PickDamageDealing()
        {
            IDamageDealing weapon = (from weapons in ItemManager.GearLoadOut.AttackItems.Values select weapons).First();
            return weapon;
        }

        public virtual double LevelStrengthModifier(int number)
        {
            return Creature.StandardLevelModifier(number);
        }
        #endregion
    }
}
