using System;

/// <summary>
/// Player Class
/// </summary>
public class Player
{
    private string name { get; set; }
    private float hp { get; set; }
    private float maxHp { get; set; }

    /// <summary>
    /// Player Constructor
    /// </summary>
    /// <param name="name"> Name of player</param>
    /// <param name="maxHp"> maximum hp</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp < 1)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Prints Current Health of Player
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
