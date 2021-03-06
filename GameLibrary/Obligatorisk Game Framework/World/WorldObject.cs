using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.World
{
    /// <summary>
    /// Represents an object in the world.
    /// </summary>
    public class WorldObject
    {
        #region Constructor
        /// <summary>
        /// Constructor for initializing all the property of the world object.
        /// </summary>
        /// <param name="name">Name of the WorldObject.</param>
        /// <param name="removable">Defines whether the object is removable from the world or not.</param>
        /// <param name="position">The position of the object.</param>
        public WorldObject(string name, bool removable, Position position)
        {
            Name = name;
            Removable = removable;
            Position = position;
        }
        #endregion


        #region Properties
        /// <summary>
        /// The id of the object.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Defines if the object is removable from the world or not.
        /// </summary>
        public bool Removable { get; set; }

        /// <summary>
        /// Defines the position of the object.
        /// </summary>
        public Position Position { get; set; }
        #endregion


        #region Overloaded Operators
        /// <summary>
        /// Checks if two WorldObjects have same id.
        /// </summary>
        /// <param name="a">First WorldObject.</param>
        /// <param name="b">Second WorldObject</param>
        /// <returns>Returns a true if the two objects have same equal Id property.</returns>
        public static bool operator ==(WorldObject a, WorldObject b)
        {
            return a.Id == b.Id;
        }

        /// <summary>
        /// Checks if two WorldObjects does not have same id.
        /// </summary>
        /// <param name="a">First WorldObject.</param>
        /// <param name="b">Second WorldObject</param>
        /// <returns>Returns a false if the two objects have same equal Id property, otherwise true.</returns>
        public static bool operator !=(WorldObject a, WorldObject b)
        {
            return !(a == b);
        }
        #endregion


        #region Methods
        /// <summary>
        /// Gets the neighbors of this object within a given the world it lives in, within a given range.
        /// </summary>
        /// <param name="range">The range to find neighbors.</param>
        /// <param name="inhabitedWorld">The world the object lives in.</param>
        /// <returns>Returns an IResponse with a IEnumerable containing the neighbors if any.</returns>
        public virtual WorldObjectResponse GetNeighbors(double range, World inhabitedWorld)
        {
            WorldObjectResponse otherObjects = inhabitedWorld.WorldObjectsManager.GetWorldObjects();
            var neighbors =
                from worldObject in otherObjects.WorldObjects
                where !ReferenceEquals(worldObject,this) &&
                      worldObject.Position.X < this.Position.X + range &&
                      worldObject.Position.X > this.Position.X - range &&
                      worldObject.Position.Y < this.Position.Y + range &&
                      worldObject.Position.Y > this.Position.Y - range
                select worldObject;
            if (neighbors.Any())
            {
                return new WorldObjectResponse
                (
                   $"These are the neighbors of the WorldObject: {Name}, Id: {Id}.",
                   true,
                   neighbors
                ); 
            }
            return new WorldObjectResponse(
                $"The WorldObject: {Name}, Id: {Id}, did not have any neighbors within the range of {range}, with the coordinates X:{Position.X},Y:{Position.Y}.",
                false,
                null
            );
        }

        public IResponse Act()
        {
            throw new NotImplementedException();
        }

        public virtual IResponse Move(int newX, int newY)
        {
            this.Position.X = newX;
            this.Position.Y = newY;

            return new SuccessResponse($"{Name} han moved to the coordinates {newX},{newY}");
        }


        #region OverridesForOperators
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
        #endregion
    }
}
