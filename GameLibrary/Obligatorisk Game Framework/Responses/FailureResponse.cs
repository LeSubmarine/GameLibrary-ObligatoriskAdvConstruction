using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Obligatorisk_Game_Framework.Tracing;

namespace Obligatorisk_Game_Framework.Responses
{
    /// <summary>
    /// Represents a failed operation.
    /// Uses Description to define the error, ToString to create a formatted string for console etc,
    /// and SuccessValue to describe if the operation was a success or not.
    /// Tracing Id 101.
    /// </summary>
    public class FailureResponse : IResponse
    {
        #region Constructor
        /// <summary>
        /// Takes a description of the operation and stores it, and defaults the SuccessValue to false.
        /// </summary>
        /// <param name="description">A string describing the result of a operation.</param>
        public FailureResponse(string description)
        {
            Description = description;
            SuccessValue = false;

            TraceSourceSingleton.Ts().TraceEvent(TraceEventType.Information,101,ToString());
        }
        #endregion


        #region Properties
        public string Description { get; set; }
        public bool SuccessValue { get; set; }
        #endregion


        #region Methods
        /// <summary>
        /// Takes the Description and SuccessValue of a Response and formats a string to show them.
        /// </summary>
        /// <returns>Returns a string to show the Response.</returns>
        public override string ToString()
        {
            return $"Operation: ({Description}), was a {(SuccessValue ? "success" : "failure")}.";
        }
        #endregion
    }
}