using System;
using System.Collections.Generic;
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

class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", this.name);
        }
        else if (this.isQuestItem == true)
        {
            Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        }
        else
        {
            Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
        }
    }

    public void Break()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine("The {0} is already broken.", this.name);
        }
        else
        {
            this.durability -= 1;
            if (this.durability > 0)
            {
                Console.WriteLine("You hit the {0}. It cracks.", this.name);
            }
            else if (this.durability == 0)
            {
                Console.WriteLine("You smash the {0}. What a mess.", this.name);
            }
        }
    }
}

class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the {0}.", this.name);
        }
        else
        {
            Console.WriteLine("You have already picked up the {0}.", this.name);
        }
    }
}

class RoomObjects {

    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base item in roomObjects)
        {
            if (item is IInteractive && type.IsAssignableFrom(typeof(IInteractive)))
            {
                ((IInteractive)item).Interact();
            }
            else if (item is IBreakable && type.IsAssignableFrom(typeof(IBreakable)))
            {
                ((IBreakable)item).Break();
            }
            else if (item is ICollectable && type.IsAssignableFrom(typeof(ICollectable)))
            {
                ((ICollectable)item).Collect();
            }
        }
    }
}
