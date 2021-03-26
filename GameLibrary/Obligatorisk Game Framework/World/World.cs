using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.World
{
    /// <summary>
    /// A class to manage a world with objects in it and the boundaries of said world.
    /// </summary>
    class World
    {
        //TODO implement the max x and max y system to respect the manager
        #region Constructor
        /// <summary>
        /// Initializing the World object with an injection of an IWorldObjectManager.
        /// </summary>
        /// <param name="worldObjectsManager">An object implementing the IWorldObjectManager interface.</param>
        public World(IWorldObjectManager worldObjectsManager)
        {
            WorldObjectsManager = worldObjectsManager;
        } 
        #endregion


        #region Properties
        /// <summary>
        /// Defines the maximum X values for the world.
        /// </summary>
        public int MaxX { get; set; }

        /// <summary>
        /// Defines the maximum Y values for the world.
        /// </summary>
        public int MaxY { get; set; }

        /// <summary>
        /// The WorldObjectsManager controls all the objects in the world.
        /// </summary>
        public IWorldObjectManager WorldObjectsManager { get; set; }
        #endregion
    }
}
