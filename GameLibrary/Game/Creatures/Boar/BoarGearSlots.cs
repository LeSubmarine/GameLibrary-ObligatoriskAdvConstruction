using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.Creature.ItemManagement;

namespace Game.Creatures.Boar
{
    class BoarGearSlots : GearSlots
    {
        public BoarGearSlots()
        {
            AttackSlots = new[] {"Feet", "Teeth"};
            DefenseSlots = new[] {"Skin"};
            MiscSlots = new string[] { };
        }
    }
}
