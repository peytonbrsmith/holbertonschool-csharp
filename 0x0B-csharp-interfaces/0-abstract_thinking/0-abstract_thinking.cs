using System;
/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name of instance of base or inherited class
    /// </summary>
    public string name;

    /// <summary>
    /// Overrides string method withen required format
    /// </summary>
    /// <returns> String </returns>
    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().Name);
    }
}
