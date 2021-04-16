using System;
using System.Collections.Generic;
using System.Text;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items;

namespace Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid
{
    public class HumanoidLoadOut : GearLoadOut
    {
        public HumanoidLoadOut(GearSlots gearSlots, IDefenseItem defaultDefenseItem = null, IAttackItem defaultAttackItem = null, IWearable defaultMiscItem = null) : base(gearSlots, defaultDefenseItem, defaultAttackItem, defaultMiscItem)
        {
        }
    }
}
