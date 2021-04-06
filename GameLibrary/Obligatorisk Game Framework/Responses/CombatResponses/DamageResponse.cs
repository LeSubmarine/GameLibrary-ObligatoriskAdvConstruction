using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Responses.CombatResponses
{
    class DamageResponse : IResponse
    {
        #region Property
        public string Description { get; set; }
        public bool SuccessValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Damage { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public WorldObject Origin { get; set; }
        #endregion
    }
}
