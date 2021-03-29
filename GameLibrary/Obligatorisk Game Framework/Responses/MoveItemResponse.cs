using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Items;

namespace Obligatorisk_Game_Framework.Responses
{
    public class MoveItemResponse : IResponse
    {
        #region Constructor
        /// <summary>
        /// Empty constructor, defaults SuccessValue to false.
        /// </summary>
        public MoveItemResponse()
        {
            SuccessValue = false;
        }

        /// <summary>
        /// Constructor to define description, who is receiving, who is sending, what items.
        /// </summary>
        /// <param name="description">Describes the transaction of items.</param>
        /// <param name="target">Target represent who is receiving items.</param>
        /// <param name="origin">Origin represent who is sending items.</param>
        /// <param name="value">Value contains what items is being transferred.</param>
        public MoveItemResponse(string description, string target, string origin,IEnumerable<IItem> value = null)
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
