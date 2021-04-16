using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.World.WorldObjects
{
    public class Boulder : WorldObject
    {
        public Boulder(string name, Position position = null, bool removable = false) : base(name, removable, position)
        {
            position ??= new Position(1, 1, 3, 3);
        }
    }
}
