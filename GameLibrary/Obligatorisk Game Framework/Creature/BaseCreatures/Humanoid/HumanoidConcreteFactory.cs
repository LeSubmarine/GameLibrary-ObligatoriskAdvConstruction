using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Creature.CreatureFactory;
using Obligatorisk_Game_Framework.Creature.ItemManagement;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid
{
    public class HumanoidConcreteFactory : AbstractCreatureFactory
    {
        #region Instance field
        private int _level;
        #endregion


        #region Constructor
        public HumanoidConcreteFactory(int level)
        {
            _level = level;
        }
        #endregion


        #region Methods
        public override Creature MakeCreature()
        {
            HumanoidCreature creature = new HumanoidCreature(
                100 + 10 * (_level - 1),
                new ItemManager(
                    new Inventory(), 
                    new HumanoidLoadOut(
                        new HumanoidSlots(),)), 
            );
        }
        #endregion


    }
}
