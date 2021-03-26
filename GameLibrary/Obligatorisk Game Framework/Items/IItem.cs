using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Items
{
    public interface IItem
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
