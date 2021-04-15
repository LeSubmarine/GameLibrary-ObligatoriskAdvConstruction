using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Obligatorisk_Game_Framework.Tracing;
using Obligatorisk_Game_Framework.World;

namespace Obligatorisk_Game_Framework.Responses.CombatResponses
{
    /// <summary>
    /// Tracing Id 104.
    /// </summary>
    public class DamageResponse : IResponse
    {
        #region Constructor
        public DamageResponse(string description, bool successValue, double damage, WorldObject origin)
        {
            Description = description;
            SuccessValue = successValue;
            Damage = damage;
            Origin = origin;

            TraceSourceSingleton.Ts().TraceEvent(TraceEventType.Information,104,Description,new object[]{Origin,Damage});
        }
        #endregion


        #region Property
        public string Description { get; set; }
        public bool SuccessValue { get; set; }

        /// <summary>
        /// The damage inflicted.
        /// </summary>
        public double Damage { get; set; }
        
        /// <summary>
        /// The origin of the damage.
        /// </summary>
        public WorldObject Origin { get; set; }
        #endregion
    }
}
