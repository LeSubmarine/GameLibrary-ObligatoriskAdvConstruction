using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.Responses.CombatResponses;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Creature
{
    /// <summary>
    /// Defines the basic behavior of a creature.
    /// </summary>
    public abstract class Creature : WorldObject
    {
        #region Instance field
        private int _hitpoints; 
        #endregion


        #region Constructor
        protected Creature(int hitpoints, IItemManager itemManager, string name, bool removable, Position position, ILootTable lootTable) : base(name, removable, position)
        {
            Hitpoints = hitpoints;
            ItemManager = itemManager;
            LootTable = lootTable;
        }
        #endregion


        #region Properties

        /// <summary>
        /// The hitpoints of the creature.
        /// </summary>
        public int Hitpoints
        {
            get => _hitpoints;
            set {
                if (value < 0)
                {
                    _hitpoints = 0;
                    return;
                }

                _hitpoints = value;
            }
        }

        /// <summary>
        /// The item manager for the creature.
        /// </summary>
        public IItemManager ItemManager { get; set; }

        /// <summary>
        /// The loottable the creature uses.
        /// </summary>
        public ILootTable LootTable { get; set; }
        #endregion


        #region Methods

        public static double StandardLevelModifier(int level)
        {
            double newNumber = 1;
            for (int i = 0; i < level; i++)
            {
                newNumber = (newNumber + 0.5) * 1.03;
            }

            return newNumber;
        }
        public abstract IResponse ReceiveHit(DamageResponse hit);
        public abstract DamageResponse Hit();
        public abstract ItemsResponse Loot();
        protected virtual WorldObjectResponse Death()
        {
            return new WorldObjectResponse($"{Name} is dead, due to health reaching 0.",false,new []{this});
        }
        #endregion
    }
}
