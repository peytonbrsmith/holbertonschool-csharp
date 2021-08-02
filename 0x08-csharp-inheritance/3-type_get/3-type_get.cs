using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
///  obj class
/// </summary>
class Obj {
    /// <summary>
    /// gets properties of obj
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        Type myType = myObj.GetType();
        IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

        foreach (PropertyInfo prop in props)
        {
            Console.WriteLine(prop.Name);
        }
    }
}
