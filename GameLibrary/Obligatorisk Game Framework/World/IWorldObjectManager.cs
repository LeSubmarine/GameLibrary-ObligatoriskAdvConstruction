using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.World
{
    /// <summary>
    /// Keeps track of all WorldObjects in a world.
    /// </summary>
    public interface IWorldObjectManager
    {
        #region Methods
        /// <summary>
        /// Gets all the WorldObjects in the world.
        /// </summary>
        /// <returns>Returns a Enumerable of WorldObjects.</returns>
        public IEnumerable<WorldObject> GetWorldObjects();

        /// <summary>
        /// Adds a WorldObject to the world.
        /// </summary>
        /// <param name="obj">A object of the WorldObject type to add to the world.</param>
        /// <returns>Returns a IResponse object to describe if the operation was a success.</returns>
        public IResponse AddWorldObject(WorldObject obj);
        #endregion
    }
}
