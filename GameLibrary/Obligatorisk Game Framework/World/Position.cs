using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.World
{
    /// <summary>
    /// Represents a position in the world with x and y coordinates.
    /// </summary>
    public class Position
    {
        #region Properties
        /// <summary>
        /// Defines the absolute X value of a position.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Defines the absolute Y value of a position.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Width of the owner.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Height of the owner.
        /// </summary>
        public int Height { get; set; }
        #endregion
    }
}
