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
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);

        foreach (var prop in myObj.GetType().GetProperties())
            Console.WriteLine(prop.Name);

        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        
        foreach (var method in myObj.GetType().GetMethods())
            Console.WriteLine(method.Name);
    }
}
