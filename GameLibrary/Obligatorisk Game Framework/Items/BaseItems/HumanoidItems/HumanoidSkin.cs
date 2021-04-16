using System.Collections.Generic;
using System.Linq;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Responses.CombatResponses;

namespace Obligatorisk_Game_Framework.Items.BaseItems.HumanoidItems
{
    public class HumanoidSkin : IDefenseItem
    {
        #region Constructor
        public HumanoidSkin(string slot, IEnumerable<IDamageType> types, double defense = 0)
        {
            Name = "skin";
            Slot = slot;
            Types = types;
            Defense = defense;
        }

        public HumanoidSkin(string name, string slot, IEnumerable<IDamageType> types, double defense)
        {
            Name = name;
            Slot = slot;
            Types = types;
            Defense = defense;
        }
        #endregion


        #region Properties
        public string Name { get; set; }
        public string Slot { get; set; }
        public IEnumerable<IDamageType> Types { get; set; }
        public double Defense { get; set; }
        #endregion


        #region Methods
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
        #endregion
    }
}
