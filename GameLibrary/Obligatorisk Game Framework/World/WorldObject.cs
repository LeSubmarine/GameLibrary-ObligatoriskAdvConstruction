using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.World
{
    /// <summary>
    /// Represents an object in the world.
    /// </summary>
    public class WorldObject
    {
        #region Constructor
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public WorldObject()
        {

        }
        /// <summary>
        /// Constructor for initializing all the property of the world object.
        /// </summary>
        /// <param name="name">Name of the WorldObject.</param>
        /// <param name="removable">Defines if the object is removable from the world or not.</param>
        /// <param name="position">The position of the object.</param>
        public WorldObject(string name, bool removable, Position position)
        {
            Name = name;
            Removable = removable;
            Position = position;
        }
        #endregion


        #region Properties
        /// <summary>
        /// Name of the object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Defines if the object is removable from the world or not.
        /// </summary>
        public bool Removable { get; set; }

        /// <summary>
        /// Defines the position of the object.
        /// </summary>
        public Position Position { get; set; } 
        #endregion
    }
}
