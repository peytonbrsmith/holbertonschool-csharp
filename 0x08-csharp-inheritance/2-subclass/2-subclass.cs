using System;
/// <summary>
/// class obj
/// </summary>
class Obj
{
    /// <summary>
    /// determins if subclass
    /// </summary>
    /// <param name="derivedType"></param>
    /// <param name="baseType"></param>
    /// <returns>true or false</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        return false;
    }
}
