using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Items
{
    /// <summary>
    /// Represents an item, which creatures can wear, given they have the slot available in their GearLoadOut.
    /// </summary>
    public interface IWearable : IItem
    {
        /// <summary>
        /// The slot the item occupies.
        /// </summary>
        public string Slot { get; set; }
    }
}
