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

    delegate float CalculateHealth(float health);

    /// <summary>
    /// Take damage
    /// </summary>
    /// <param name="damage">amount of damage in health</param>
    public void TakeDamage(float damage)
    {
        // If damage is negative, the Player takes 0 damage and prints <name> takes 0 damage!
        if (damage < 0)
        {
            damage = 0;
        }
        // Prints <name> takes <damage> damage!
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary>
    /// Heal Player
    /// </summary>
    /// <param name="heal">amount of health to heal</param>
    public void HealDamage(float heal)
    {
        // If heal is negative, the Player heals 0 HP and prints <name> heals 0 HP!
        if (heal < 0)
        {
            heal = 0;
        }

         // Prints <name> heals <heal> HP!
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}
