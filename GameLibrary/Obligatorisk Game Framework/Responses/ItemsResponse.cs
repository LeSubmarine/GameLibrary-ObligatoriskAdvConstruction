using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Tracing;

namespace Obligatorisk_Game_Framework.Responses
{
    public class ItemsResponse : IResponse
    {
        #region Constructor
        /// <summary>
        /// Constructor to define description, who is receiving, who is sending, what items.
        /// Tracing Id 102.
        /// </summary>
        /// <param name="description">Describes the transaction of items.</param>
        /// <param name="origin">Origin represent who is sending items.</param>
        /// <param name="value">Value contains what items is being transferred.</param>
        public ItemsResponse(string description, string origin,IEnumerable<IItem> value = null)
        {
            if (value == null)
            {
                SuccessValue = false; 
            }
            else
            {
                SuccessValue = true;
            }

            Description = description;
            Value = value;
            Origin = origin;
            
            TraceSourceSingleton.Ts().TraceEvent(TraceEventType.Information, 102, Description, Value);

        }
        #endregion


        #region Properties
        public string Description { get; set; }
        public bool SuccessValue { get; set; }

        /// <summary>
        /// Where the value came from.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// The Items.
        /// </summary>
        public IEnumerable<IItem> Value { get; set; }
        #endregion
    }
}
