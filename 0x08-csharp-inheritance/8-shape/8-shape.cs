using System;

/// <summary>
/// shape class
/// </summary>
class Shape
{
    /// <summary>
    /// area func
    /// </summary>
    /// <returns>nothing</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>
/// rectangle class
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    public new int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}
/// <summary>
/// square class
/// </summary>
class Square: Rectangle
{
    private int size;
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");

            size = value;
            Width = size;
            Height = size;
        }
    }
}
