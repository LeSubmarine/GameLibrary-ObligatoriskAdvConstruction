using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Tracing;

namespace Obligatorisk_Game_Framework.Responses
{
    /// <summary>
    /// Represents an operation for equip and unequipping items.
    /// Tracing Id 103.
    /// </summary>
    public class EquipItemResponse : IResponse
    {
        #region Constructor
        /// <summary>
        /// Constructor for setting the equipped item, the unequipped item and the slot, where the items are shifting.
        /// </summary>
        /// <param name="description">The description of the transaction.</param>
        /// <param name="equipped">The item to be equipped.</param>
        /// <param name="unEquipped">The item to be removed from it's slot.</param>
        /// <param name="slot">The slot in which the items are shifting position.</param>
        /// <param name="successValue">SuccessValue describes whether the operation was a success or not.</param>
        public EquipItemResponse(string description, IWearable equipped, IWearable unEquipped, string slot, bool successValue)
        {
            Description = description;
            SuccessValue = successValue;
            Slot = slot;
            Equipped = equipped;
            UnEquipped = unEquipped;
            
            TraceSourceSingleton.Ts().TraceEvent(TraceEventType.Information, 103, Description,new object[]{Equipped, UnEquipped, Slot}); 
            
        }
        #endregion


        #region Properties
        public string Description { get; set; }
        public bool SuccessValue { get; set; }

        /// <summary>
        /// What item was equipped.
        /// </summary>
        public IWearable Equipped { get; set; }

        /// <summary>
        /// Where the slot came from.
        /// </summary>
        public IWearable UnEquipped { get; set; }

        /// <summary>
        /// The item slot changing.
        /// </summary>
        public string Slot { get; set; }
        #endregion
    }
}
