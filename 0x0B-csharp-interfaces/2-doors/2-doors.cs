using System;

abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().Name);
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class Door : Base, IInteractive
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }

    public void Break()
    {
    }

    public void Collect()
    {
    }
}
