using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.UtilityTools;

namespace Obligatorisk_Game_Framework.World
{
    public class WorldObjectManager : IWorldObjectManager
    {
        private List<WorldObject> _worldObjects;

        public WorldObjectManager()
        {
            _worldObjects = new List<WorldObject>();
        }

        public WorldObjectResponse GetWorldObjects()
        {
            _worldObjects.RemoveAll(a =>
                a.Removable && TypeComparer.IsSameOrVariant(typeof(Creature.Creature), a.GetType()).SuccessValue ?
                ((Creature.Creature) a).Hitpoints == 0 : false);
            return new WorldObjectResponse(
                $"These are the objects in {this}",
                true,
                from worldObjects in _worldObjects select worldObjects);
        }

        public IResponse AddWorldObject(WorldObject obj)
        {
            _worldObjects.Add(obj);
            return new SuccessResponse($"The obj {obj.Name} was added to {this}");
        }
    }
}
