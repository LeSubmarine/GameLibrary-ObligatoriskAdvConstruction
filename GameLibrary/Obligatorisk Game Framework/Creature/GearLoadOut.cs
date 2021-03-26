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
        private readonly DefenseItem _defaultDefenseItem;
        private readonly AttackItem _defaultAttackItem;
        private readonly IWearable _defaultMiscItem;
        #endregion


        #region Constructor
        protected GearLoadOut(IGearSlots gearSlots, DefenseItem defaultDefenseItem = null, AttackItem defaultAttackItem = null, IWearable defaultMiscItem = null)
        {
            //Loading default items
            _defaultDefenseItem = defaultDefenseItem;
            _defaultAttackItem = defaultAttackItem;
            _defaultMiscItem = defaultMiscItem;


            //Instantiating the object for keeping track of worn items
            DefenseItems = new Dictionary<string, DefenseItem>();
            AttackItems = new Dictionary<string, AttackItem>();
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
        public Dictionary<string, DefenseItem> DefenseItems { get; set; }
        public Dictionary<string, AttackItem> AttackItems { get; set; }
        public Dictionary<string, IWearable> MiscItems { get; set; }
        #endregion


        #region Methods
        public EquipItemResponse EquipItem(IWearable item)
        {
            if (item.GetType().IsSubclassOf(typeof(AttackItem)))
            {
                if (AttackItems.ContainsKey(item.Slot))
                {
                    AttackItems[item.Slot] = (AttackItem)item;
                    return new EquipItemResponse(); 
                }
            }

            if (item.GetType().IsSubclassOf(typeof(DefenseItem)))
            {
                if (DefenseItems.ContainsKey(item.Slot))
                {
                    DefenseItems[item.Slot] = (DefenseItem)item;
                    return new EquipItemResponse();
                }
            }

            if (MiscItems.ContainsKey(item.Slot))
            {
                MiscItems[item.Slot] = item;
                return new EquipItemResponse();
            }

            return new EquipItemResponse();
        }
        public EquipItemResponse DeEquipItem(IWearable item)
        {
            return new EquipItemResponse();
        }
        #endregion
    }
}
