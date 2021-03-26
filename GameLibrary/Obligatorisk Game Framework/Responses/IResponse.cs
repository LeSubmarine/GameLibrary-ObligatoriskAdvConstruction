using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Responses
{
    /// <summary>
    /// Base interface all responses have to implement
    /// </summary>
    public interface IResponse
    {
        #region Properties
        /// <summary>
        /// Description describes the operation that was performed.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Describes if the operation was a success or not.
        /// </summary>
        public bool SuccessValue { get; set; }
        #endregion
    }
}
