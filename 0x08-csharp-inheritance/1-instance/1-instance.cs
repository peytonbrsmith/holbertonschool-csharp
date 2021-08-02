using System;
/// <summary>
/// obj class
/// </summary>
class Obj
{
    /// <summary>
    /// determins if in array tree
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>true or false</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
