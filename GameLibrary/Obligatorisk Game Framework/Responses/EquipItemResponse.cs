using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Items;

namespace Obligatorisk_Game_Framework.Responses
{
    public class EquipItemResponse : IResponse
    {
        #region Constructor
        public EquipItemResponse()
        {
            SuccessValue = false;
        }
        public EquipItemResponse(IWearable equipped, IWearable unEquipped, string slot)
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
