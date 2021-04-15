using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Creature.ItemManagement;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid
{
    public class HumanoidSlots : GearSlots
    {
        public HumanoidSlots()
        {
            AttackSlots = new[] {""};
            DefenseSlots = new[] {""};
            MiscSlots = new[] {""};
        }
    }
}
