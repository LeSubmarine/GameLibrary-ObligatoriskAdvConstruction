using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Items;

namespace Obligatorisk_Game_Framework.Responses
{
    /// <summary>
    /// Represents an operation for equip and unequipping items.
    /// </summary>
    public class EquipItemResponse : IResponse
    {
        #region Constructor
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public EquipItemResponse()
        {
        }

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
            SuccessValue = true;
            Slot = slot;
            Equipped = equipped;
            UnEquipped = unEquipped;
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


        #region Methods
        /// <summary>
        /// Creates a string based on the information available to describe the events of the operation.
        /// </summary>
        /// <returns>A string telling how the transaction went, and who the participants was.</returns>
        public override string ToString()
        {
            //TODO make ToString to describe journey
            StringBuilder returnString = new StringBuilder();
            return "";
        }
        #endregion
    }
}
