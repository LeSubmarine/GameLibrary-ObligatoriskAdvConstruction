using System.Linq;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid;
using Obligatorisk_Game_Framework.Creature.CreatureFactory;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.BaseItems.AnimalIWearable;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.UtilityTools;
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
                20 * (_level),
                new ItemManager(
                    new Inventory(),
                    new GearLoadOut(
                        new BoarSlots(),
                        new Hide(null))),
                _name ?? "boar",
                true,
                _position ?? new Position(1, 1, 1, 2),
                new BoarLootTableDecorator(new LootTable()));
            creature.ItemManager.AddItems(new ItemsResponse("Adding start items.", $"{GetType().Name}", new IItem[]
            {
                new Hide(null), new Hoofs(null), new TuskWeapon(null)   
            }));
            creature.ItemManager.GetItems().Value.Where(a => TypeComparer.IsSameOrVariant(typeof(IWearable),a.GetType()).SuccessValue)
                .ToList().ForEach(a => { creature.ItemManager.EquipGear((IWearable) a); });

            return creature;
        }


        protected virtual string GetName()
        {
            return "boar";
        }

        protected virtual Position GetPosition()
        {
            return new Position(1,1,1,1);
        }

        #endregion


    }
}
