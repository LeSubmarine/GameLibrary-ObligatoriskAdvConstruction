using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Responses.CombatResponses;
using Obligatorisk_Game_Framework.UtilityTools;

namespace Obligatorisk_Game_Framework.Items.BaseItems.Armor.AdvancedArmor.Plate
{
    static class PlateDefense
    {
        public static DamageResponse TransformDamage(DamageResponse attack, double efficiency)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            var allAttackTypes = from attackTypes in attack.DamageSource.DamageTypes select attackTypes;
            var physicalTypes = from attackTypes in attack.DamageSource.DamageTypes
                where TypeComparer.IsSameOrVariant(typeof(PhysicalDamageType), attackTypes.GetType()).SuccessValue
                select attackTypes;
            double physicalPercent = (from weights in physicalTypes select weights.Weight).Sum()/(from weights in allAttackTypes select weights.Weight).Sum();
            if (physicalPercent == 0)
            {
                return attack;
            }

            //todo damage skal regnes så plate fjerne noget af physical skaden.
            attack.Damage = /*(attack.Damage * (1 / physicalPercent)) * (1 - physicalPercent);*/
            
            return null;
        }
    }
}
