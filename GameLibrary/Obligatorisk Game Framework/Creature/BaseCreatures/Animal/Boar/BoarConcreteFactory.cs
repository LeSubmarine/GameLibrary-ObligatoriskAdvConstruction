using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid;
using Obligatorisk_Game_Framework.Creature.CreatureFactory;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items.BaseItems.AnimalItems;
using Obligatorisk_Game_Framework.Items.BaseItems.BoarItems;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Animal.Boar
{
    public class BoarConcreteFactory : AbstractCreatureFactory
    {
        #region Instance field
        private int _level;
        private string _name;
        private Position _position;
        #endregion


        #region Constructor
        public BoarConcreteFactory(int level,string name = null, Position position = null)
        {
            _level = level;
            _name = name;
            _position = position;
        }
        #endregion


        #region Methods
        public override Creature MakeCreature()
        {
            BoarCreature creature = new BoarCreature(
                _level,
                100 + 10 * (_level - 1),
                new ItemManager(
                    new Inventory(),
                    new GearLoadOut(
                        new BoarSlots(),
                        new Hide(null))),
                "boar",
                true,
                new Position(1, 1, 1, 2),
                new BoarLootTableDecorator(new LootTable()));
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
