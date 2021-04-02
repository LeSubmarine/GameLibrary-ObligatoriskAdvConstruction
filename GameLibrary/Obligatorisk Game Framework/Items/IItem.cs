using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Items
{
    /// <summary>
    /// Represents an item in the world.
    /// </summary>
    public interface IItem
    {
        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name { get; set; }

        ///// <summary>
        ///// The value of the item.
        ///// </summary>
        //public double Value { get; set; }


        ///// <summary>
        ///// The id of the item.
        ///// </summary>
        //public int Id { get; set; }
    }
}
