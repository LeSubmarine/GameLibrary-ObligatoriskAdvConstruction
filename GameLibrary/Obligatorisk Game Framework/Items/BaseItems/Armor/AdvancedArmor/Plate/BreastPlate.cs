using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Responses.CombatResponses;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor.AdvancedArmor.Plate
{
    public class BreastPlate : BreastArmor,IPlate
    {
        public BreastPlate(double efficiency, double defense = 10, IEnumerable<IDamageType> types = null, string name = "BreastArmor", string slot = "breast") : base(defense, types, name, slot)
        {
            Efficiency = efficiency;
        }
        public double Efficiency { get; set; }

        public override DamageResponse Defend(DamageResponse damage)
        {
            damage.Damage = PlateDefense.TransformDamage(damage, Efficiency);
            return base.Defend(damage);
        }
    }
}
