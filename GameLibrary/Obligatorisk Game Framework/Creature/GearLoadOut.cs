using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.Creature
{
    /// <summary>
    /// Class for representing what items the owner is wearing
    /// </summary>
    public class GearLoadOut
    {
        #region InstanceField
        private readonly IWearable _defaultDefenseItem;
        private readonly IWearable _defaultAttackItem;
        private readonly IWearable _defaultMiscItem;
        #endregion


        #region Constructor
        protected GearLoadOut(IGearSlots gearSlots, IWearable defaultDefenseItem = null, IWearable defaultAttackItem = null, IWearable defaultMiscItem = null)
        {
            //Loading default items
            _defaultDefenseItem = defaultDefenseItem;
            _defaultAttackItem = defaultAttackItem;
            _defaultMiscItem = defaultMiscItem;


            //Instantiating the object for keeping track of worn items
            DefenseItems = new Dictionary<string, IWearable>();
            AttackItems = new Dictionary<string, IWearable>();
            MiscItems = new Dictionary<string, IWearable>();


            //Adding worn item slots
            //Defense
            foreach (var slot in gearSlots.DefenseSlots)
            {
                DefenseItems.Add(slot,_defaultDefenseItem);
            }
            //Attack
            foreach (var slot in gearSlots.AttackSlots)
            {
                AttackItems.Add(slot, _defaultAttackItem);
            }
            //Miscellaneous
            foreach (var slot in gearSlots.MiscSlots)
            {
                MiscItems.Add(slot, _defaultMiscItem);
            }
        }
        #endregion


        #region Properties
        public Dictionary<string, IWearable> DefenseItems { get; set; }
        public Dictionary<string, IWearable> AttackItems { get; set; }
        public Dictionary<string, IWearable> MiscItems { get; set; }
        #endregion


        #region Methods
        public MoveItemResponse EquipItem(IWearable item)
        {
            if (item.GetType().IsSubclassOf(typeof(AttackItem)))
            {

            }

            if (item.GetType().IsSubclassOf(typeof(DefenseItem)))
            {

            }
            return new MoveItemResponse();
        }
        public MoveItemResponse DeEquipItem(IWearable item)
        {

        }
        #endregion
    }
}
