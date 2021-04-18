using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.World
{
    /// <summary>
    /// A class to manage a world with objects in it and the boundaries of said world.
    /// </summary>
    public class World
    {
        #region Constructor
        /// <summary>
        /// Initializing the World object with an injection of an IWorldObjectManager.
        /// </summary>
        /// <param name="worldObjectsManager">An object implementing the IWorldObjectManager interface.</param>
        /// <param name="configFilePath">The path for a xml config file, that implements the integers MaxX and MaxY.</param>
        public World(IWorldObjectManager worldObjectsManager, string configFilePath = null)
        {
            WorldObjectsManager = worldObjectsManager;


            if (!string.IsNullOrEmpty(configFilePath))
            {
                XmlDocument document = new XmlDocument();
                document.Load(configFilePath);
                XmlNode maxX = document.DocumentElement.SelectSingleNode("MaxX");
                XmlNode maxY = document.DocumentElement.SelectSingleNode("MaxY");
                MaxY = Convert.ToInt32(maxY.InnerText.Trim());
                MaxX = Convert.ToInt32(maxX.InnerText.Trim());
            }

            if (MaxX == 0)
            {
                MaxX = 1000;
            }

            if (MaxY == 0)
            {
                MaxY = 1000;
            }
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


        #region Methods

        public virtual IResponse AddWorldObjectToWorld(WorldObject obj)
        {
            return WorldObjectsManager.AddWorldObject(obj);
        }
        public virtual void Act()
        { }
        #endregion
    }
}
