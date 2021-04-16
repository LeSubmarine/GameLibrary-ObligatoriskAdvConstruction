using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Responses.CombatResponses;

namespace Obligatorisk_Game_Framework.Items
{
    public class CompositeDefenseItem : IDefenseItem
    {
        public CompositeDefenseItem(double defense, IEnumerable<IDamageType> types, IEnumerable<IDefenseItem> defensiveItems)
        {
            DefensiveItems = defensiveItems;
            Name = nameof(CompositeDefenseItem);
            Slot = null;
            Defense = (from defenseItems in DefensiveItems select defenseItems.Defense).Sum();
            Types = (from defenseItems in DefensiveItems select defenseItems.Types).SelectMany(a => a);
        }

        public string Name { get; set; }
        public string Slot { get; set; }
        public double Defense { get; set; }
        public IEnumerable<IDamageType> Types { get; set; }
        public IEnumerable<IDefenseItem> DefensiveItems { get; set; }

        public DamageResponse Defend(DamageResponse damage)
        {
            List<DamageResponse> allDamageResponses = new List<DamageResponse>();
            foreach (var defenseItem in DefensiveItems)
            {
                allDamageResponses.Add(defenseItem.Defend(damage));
            }

            var successValues = from damageResponse in allDamageResponses
                where damage.SuccessValue == false
                select damageResponse.SuccessValue;
            
            bool successValue = !successValues.Any();

            var totalDamageDealt = from damageResponse in allDamageResponses select damageResponse.Damage;
            double damageDealt = totalDamageDealt.Average();
            damageDealt = damageDealt > 0 ? damageDealt : 0;


            return new DamageResponse(
                "Average effort of the composite defend items",
                successValue,
                damageDealt,
                damage.Origin,
                damage.DamageSource);
        }
    }
}
