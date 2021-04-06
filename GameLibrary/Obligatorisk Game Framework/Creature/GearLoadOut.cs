using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
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
        //TODO fix for json saving
        private readonly IDefenseItem _defaultDefenseItem;
        private readonly IAttackItem _defaultAttackItem;
        private readonly IWearable _defaultMiscItem;
        #endregion


        #region Constructor
        /// <summary>
        /// Standard constructor for initializing default items and defining Gear Slots.
        /// </summary>
        /// <param name="gearSlots">Represent the slots in which items can be put.</param>
        /// <param name="defaultDefenseItem">The default item for defense items, defaults to null.</param>
        /// <param name="defaultAttackItem">The default item for attack items, defaults to null.</param>
        /// <param name="defaultMiscItem">The default item for miscellaneous items, defaults to null.</param>
        public GearLoadOut(GearSlots gearSlots, IDefenseItem defaultDefenseItem = null, IAttackItem defaultAttackItem = null, IWearable defaultMiscItem = null)
        {
            //Loading default items
            _defaultDefenseItem = defaultDefenseItem;
            _defaultAttackItem = defaultAttackItem;
            _defaultMiscItem = defaultMiscItem;


            //Instantiating the object for keeping track of worn items
            DefenseItems = new Dictionary<string, IDefenseItem>();
            AttackItems = new Dictionary<string, IAttackItem>();
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
        /// <summary>
        /// Stores the equipped defense items.
        /// </summary>
        public Dictionary<string, IDefenseItem> DefenseItems { get; set; }

        /// <summary>
        /// Stores the equipped attack items.
        /// </summary>
        public Dictionary<string, IAttackItem> AttackItems { get; set; }

        /// <summary>
        /// Stores the equipped miscellaneous items.
        /// </summary>
        public Dictionary<string, IWearable> MiscItems { get; set; }
        #endregion


        #region Methods
        /// <summary>
        /// Equips a given item to the owner.
        /// </summary>
        /// <param name="item">item is the item that is going to be equipped.</param>
        /// <returns>Returns a EquipItemResponse to describe the operation.</returns>
        public virtual EquipItemResponse EquipItem(IWearable item)
        {
            Type itemType = item.GetType();

            if (itemType.IsSubclassOf(typeof(IAttackItem)))
            {
                return ChangeItems<IAttackItem>(AttackItems, (IAttackItem)item);
            }

            if (itemType.IsSubclassOf(typeof(IDefenseItem)))
            {
                return ChangeItems<IDefenseItem>(DefenseItems, (IDefenseItem)item);
            }

            return ChangeItems<IWearable>(MiscItems, item);
        }

        /// <summary>
        /// Unequips a given item, if it is equipped.
        /// </summary>
        /// <param name="item">item is the item that is to be unequipped</param>
        /// <returns>Returns a EquipItemResponse to describe the operation.</returns>
        public virtual EquipItemResponse DeEquipItem(IWearable item)
        {
            Type itemType = item.GetType();
            if (itemType.IsSubclassOf(typeof(IAttackItem)))
            {
                return RemoveItem<IAttackItem>(AttackItems, (IAttackItem)item,_defaultAttackItem);
            } 

            if (itemType.IsSubclassOf(typeof(IDefenseItem)))
            {
                return RemoveItem<IDefenseItem>(DefenseItems, (IDefenseItem)item,_defaultDefenseItem);
            }
            return RemoveItem<IWearable>(MiscItems,item,_defaultMiscItem);
        }

        //Removes a item from a dictionary a replaces it with the default value
        protected EquipItemResponse RemoveItem<T>(Dictionary<string, T> dictionary, T item, T defaultValue) where T : IWearable
        {
            if (dictionary.ContainsKey(item.Slot))
            {
                dictionary[item.Slot] = defaultValue;
                return new EquipItemResponse
                {
                    Description = $"Item: {item.Name} has been removed from the {item.Slot} slot.",
                    Equipped = defaultValue,
                    UnEquipped = item,
                    Slot = item.Slot,
                    SuccessValue = true
                };
            }
            return new EquipItemResponse
            {
                Description = $"Item: {item.Name} has failed to be removed from the slot {item.Slot} as a {typeof(T).Name}",
                Equipped = null,
                UnEquipped = item,
                Slot = item.Slot,
                SuccessValue = false
            };
        }

        //Replaces the item in the dictionary with the given item
        protected EquipItemResponse ChangeItems<T>(Dictionary<string, T> dictionary, T item) where T : IWearable
        {
            if (dictionary.ContainsKey(item.Slot))
            {
                T unEquipped = dictionary[item.Slot];
                dictionary[item.Slot] = item;
                return new EquipItemResponse
                {
                    Description = $"Item: {item.Name} has replaced item: {unEquipped.Name} in the {item.Slot} slot.",
                    Equipped = item,
                    UnEquipped = unEquipped,
                    Slot = item.Slot,
                    SuccessValue = true
                };
            }
            return new EquipItemResponse
            {
                Description = $"Item: {item.Name} has failed to be placed in the slot {item.Slot} as a {typeof(T).Name}",
                Equipped = item,
                UnEquipped = null,
                Slot = item.Slot,
                SuccessValue = false
            };
        }
        #endregion
    }
}
