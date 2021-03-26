using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Items;

namespace Obligatorisk_Game_Framework.Responses
{
    public class MoveItemResponse : IResponse
    {
        #region Constructor
        public MoveItemResponse()
        {
            SuccessValue = false;
        }
        public MoveItemResponse(string target, string origin,IEnumerable<IItem> value = null)
        {
            if (value == null)
            {
                SuccessValue = false; 
            }
            else
            {
                SuccessValue = true;
            }

            Value = value;
            Target = target;
            Origin = origin;
        }
        #endregion


        #region Properties
        public string Description { get; set; }
        public bool SuccessValue { get; set; }

        /// <summary>
        /// Where the value was headed.
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Where the value came from.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// The items changing place.
        /// </summary>
        public IEnumerable<IItem> Value { get; set; }
        #endregion



        #region Methods
        /// <summary>
        /// Creates a string based on the information available to describe the events of the operation.
        /// </summary>
        /// <returns>A string telling how the transaction went, and who the participants was.</returns>
        public override string ToString()
        {
            //TODO make ToString to describe journey
            StringBuilder returnString = new StringBuilder();
            return "";
        }
        #endregion
    }
}
