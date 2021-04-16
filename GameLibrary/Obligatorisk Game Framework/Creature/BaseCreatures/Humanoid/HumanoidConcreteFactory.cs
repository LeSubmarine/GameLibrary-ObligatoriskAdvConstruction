using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Creature.CreatureFactory;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items.BaseItems.HumanoidItems;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid
{
    public class HumanoidConcreteFactory : AbstractCreatureFactory
    {
        #region Instance field
        private int _level;
        private string _name;
        private Position _position;
        #endregion


        #region Constructor
        public HumanoidConcreteFactory(int level,string name = null, Position position = null)
        {
            _level = level;
            _name = name;
            _position = position;
        }
        #endregion


        #region Methods
        public override Creature MakeCreature()
        {
            HumanoidCreature creature = new HumanoidCreature(
                _level,
                100 + 10 * (_level - 1),
                new ItemManager(
                    new Inventory(), 
                    new HumanoidLoadOut(
                        new HumanoidSlots(),
                        new HumanoidSkin(
                            "",
                            new IDamageType[]{new PhysicalDamageType()},
                            0),
                        new HumanoidFists(
                            "Fist",
                            new IDamageType[]{new PhysicalDamageType()},
                            5))),
                _name ?? GetName(),
                true,
                _position ?? GetPosition(),
                new HumanoidLootTableDecorator(new LootTable())
            );
            return creature;
        }


        private string GetName()
        {
            return "";
        }

        protected virtual Position GetPosition()
        {
            return new Position(1,1,1,1);
        }

        #endregion


    }
}
