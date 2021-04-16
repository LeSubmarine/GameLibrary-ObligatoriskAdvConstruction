using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Creature.ItemManagement;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Animal.Boar
{
    public class BoarSlots : GearSlots
    {
        public BoarSlots()
        {
            AttackSlots = new[] {"feet","teeth"};
            DefenseSlots = new[] {"skin"};
            MiscSlots = new string[]{};
        }
    }
}
