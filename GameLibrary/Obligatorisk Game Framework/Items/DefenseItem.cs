using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Items
{
    public abstract class DefenseItem : IWearable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Slot { get; set; }
    }

}
