using System;
using System.Collections.Generic;
using System.Text;
using Game.Items.Attack_Items;
using Game.Items.Defense_Items;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items;

namespace Game.Creatures.Boar
{
    class BoarGearLoadOut : GearLoadOut
    {
        private static GearSlots _gearSlots = new GearSlots
        {
            
        };
        private static Type _defaultDefenseItem = typeof(Hide);

        public BoarGearLoadOut() : 
            base(new BoarGearSlots(), 
                new Hide(),
                null, 
                null)
        {
            EquipItem(new Hoofs());
            EquipItem(new TuskWeapon());
        }
        public BoarGearLoadOut(GearSlots gearSlots, IDefenseItem defaultDefenseItem = null, IAttackItem defaultAttackItem = null, IWearable defaultMiscItem = null) : base(gearSlots, defaultDefenseItem, defaultAttackItem, defaultMiscItem)
        {
        }
    }
}
