using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Creature.Animals
{
    class Boar : Creature
    {
        #region Constructor
        public Boar(int hitpoints, IItemManager itemManager, string name, Position position, bool removable) : base(hitpoints, itemManager, name, position, removable)
        {
            LootTable = new LootTable();
        }
        #endregion


        #region Properties
        public ILootTable LootTable { get; set; }
        #endregion


        #region Methods
        public override IResponse ReceiveHit(int hit)
        {
            throw new NotImplementedException();
        }

        public override IResponse Hit(int hit)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<IItem> Loot()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
