using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Obligatorisk_Game_Framework.Tracing;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Responses
{
    /// <summary>
    /// Tracing Id 105.
    /// </summary>
    public class WorldObjectResponse : IResponse
    {
        #region Constructor
        public WorldObjectResponse(string description, bool successValue, IEnumerable<WorldObject> worldObjects)
        {
            Description = description;
            SuccessValue = successValue;
            WorldObjects = worldObjects;
            
            TraceSourceSingleton.Ts().TraceEvent(TraceEventType.Information,105,Description,WorldObjects);
            
        }
        #endregion


        #region Properties
        public string Description { get; set; }
        public bool SuccessValue { get; set; }

        /// <summary>
        /// Contains some objects of type WorldObject.
        /// </summary>
        public IEnumerable<WorldObject> WorldObjects { get; set; }
        #endregion
    }
}
