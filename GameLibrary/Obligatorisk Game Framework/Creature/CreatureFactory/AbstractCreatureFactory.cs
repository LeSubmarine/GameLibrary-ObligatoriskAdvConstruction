using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Game_Framework.Creature.CreatureFactory
{
    public abstract class AbstractCreatureFactory
    {
        public abstract Creature MakeCreature();

        public virtual Creature GetObject() 
        {
            return this.MakeCreature();
        }
    }
}
