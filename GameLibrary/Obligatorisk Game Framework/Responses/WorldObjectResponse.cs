using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Responses
{
    public class WorldObjectResponse : IResponse
    {
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
