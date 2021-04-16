using System;
using Obligatorisk_Game_Framework.Responses;

namespace Obligatorisk_Game_Framework.UtilityTools
{
    /// <summary>
    /// A class for comparing types.
    /// </summary>
    public static class TypeComparer
    {
        public static IResponse IsSameOrVariant(Type baseClass, Type otherClass, bool onlyInheritCheck = false)
        {
            if (otherClass.IsSubclassOf(baseClass))
            {
                return new SuccessResponse($"{otherClass.Name} inherits from {baseClass.Name}.");
            }

            if (otherClass == baseClass)
            {
                return new SuccessResponse($"{otherClass.Name} is same class as {baseClass.Name}.");
            }

            if (!onlyInheritCheck)
            {
                return IsSameOrVariant(otherClass, baseClass, true);
            }

            return new FailureResponse($"{otherClass.Name} and {baseClass.Name} do not inherit from each other.");
        }
    }
}
