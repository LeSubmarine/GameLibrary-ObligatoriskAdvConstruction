using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Responses.CombatResponses;

namespace Obligatorisk_Game_Framework.Items
{
    public class DefenseItem: IDefenseItem
    {
        public DefenseItem(string name, string slot, double defense, IEnumerable<IDamageType> types)
        {
            Name = name;
            Slot = slot;
            Defense = defense;
            Types = types;
        }

        public string Name { get; set; }
        public string Slot { get; set; }
        public double Defense { get; set; }
        public IEnumerable<IDamageType> Types { get; set; }

        public DamageResponse Defend(DamageResponse damage)
        {
            double newDamage = damage.Damage;
            double totalWeight = (from types in damage.DamageSource.DamageTypes select types.Weight).Sum();
            foreach (var damageType in damage.DamageSource.DamageTypes)
            {
                foreach (var defendDamageType in Types)
                {
                    double weightShare = damageType.Weight / totalWeight;
                    newDamage = newDamage * (damageType.Modifier(defendDamageType) * weightShare);
                }
            }

            newDamage = newDamage - Defense;

            if (newDamage < 0)
            {
                newDamage = 0;
            }
            return new DamageResponse("Damage was successfully defended", true, newDamage, damage.Origin, damage.DamageSource);
        }
    }
}
