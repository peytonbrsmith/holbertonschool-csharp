using System;

/// <summary>
/// obj class
/// </summary>
class Obj
{
    /// <summary>
    ///     determines if obj is int
    /// </summary>
    /// <param name="obj"></param>
    /// <returns> true or false </returns>
    public static bool IsOfTypeInt(object obj)
    {   
        if (typeof (int) == obj.GetType())
        {
            return true;
        }
        return false;
    }
}
