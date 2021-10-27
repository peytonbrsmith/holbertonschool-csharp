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

        float new_hp = this.hp - damage;

        ValidateHP(new_hp);

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

        float new_hp = this.hp + heal;

        ValidateHP(new_hp);

         // Prints <name> heals <heal> HP!
        Console.WriteLine($"{name} heals {heal} HP!");
    }

    /// <summary>
    /// Health value validator
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            newHp = 0;
        }
        if (newHp > maxHp)
        {
            newHp = maxHp;
        }
        this.hp = newHp;
    }

    /// <summary>
    /// Applies modifier to health
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }
}

/// <summary>
/// Enum of health modifiers
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak modifer
    /// </summary>
    Weak,
    /// <summary>
    /// Base modifer
    /// </summary>
    Base,
    /// <summary>
    /// Strong modifer
    /// </summary>
    Strong
}

/// <summary>
/// Delegate for health modifiers
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
