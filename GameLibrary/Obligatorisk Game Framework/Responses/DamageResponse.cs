using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Obligatorisk_Game_Framework.Combat;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
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

        /// <summary>
        /// Creates a DamageResponse object.
        /// </summary>
        /// <param name="description">Description of the operation.</param>
        /// <param name="successValue">Whether the operation was successful or not.</param>
        /// <param name="damage">How much damage was dealt.</param>
        /// <param name="origin">What entity dealt the damage.</param>
        /// <param name="damageSource">How did the entity deal the damage.</param>
        public DamageResponse(string description, bool successValue, double damage, WorldObject origin, IDamageDealing damageSource)
        {
            Description = description;
            SuccessValue = successValue;
            Damage = damage;
            Origin = origin;
            DamageSource = damageSource;

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

        /// <summary>
        /// Types of damage being dealt.
        /// </summary>
        public IDamageDealing DamageSource { get; set; }
        #endregion
    }
}
