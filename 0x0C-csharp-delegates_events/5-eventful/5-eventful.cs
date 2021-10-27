using System;

/// <summary>
/// Player Class
/// </summary>
public class Player
{
    private string status { get; set; }
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
        this.status = String.Format("{0} is ready to go!", name);
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;

        this.HPCheck += CheckStatus;
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        // If the value of e‘s currentHp is 0, print Health has reached zero!
        // Otherwise, print Health is low!
        // Optionally, change the colors of the console font or background when the warnings are printed:
        Console.BackgroundColor = ConsoleColor.Red;
        if (e.currentHP == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.WriteLine("Health is low!");
        }
        Console.ResetColor();
    }

    private void OnCheckStatus(CurrentHPArgs e)
    {
        //  if e’s currentHp is less than ¼ of maxHp.
        // If it is, assign HPValueWarning to the HPCheck EventHandler.
        if (e.currentHP < this.maxHp / 4)
        {
            this.HPCheck -= HPValueWarning;
            this.HPCheck += HPValueWarning;
        }
        HPCheck(this, e);
    }
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        // If the value is equal to maxHp, print:
        // <name> is in perfect health!
        if (e.currentHP == this.maxHp)
        {
            Console.WriteLine("{0} is in perfect health!", this.name);
        }
        // If the value is between ½ of maxHp (inclusive) and maxHp (exclusive), print:
        // <name> is doing well!
        else if (e.currentHP >= this.maxHp / 2 && e.currentHP < this.maxHp)
        {
            Console.WriteLine("{0} is doing well!", this.name);
        }
        // If the value is between ¼ of maxHp (inclusive) and ½ of maxHp (exclusive), print:
        // <name> isn't doing too great...
        else if (e.currentHP >= this.maxHp / 4 && e.currentHP < this.maxHp / 2)
        {
            Console.WriteLine("{0} isn't doing too great...", this.name);
        }
        // If the value is between 0 (exclusive) and ¼ of maxHp (exclusive), print:
        // <name> needs help!
        else if (e.currentHP > 0 && e.currentHP < this.maxHp / 4)
        {
            Console.WriteLine("{0} needs help!", this.name);
        }
        // If the value is 0, print:
        // <name> is knocked out!
        else if (e.currentHP == 0)
        {
            Console.WriteLine("{0} is knocked out!", this.name);
        }
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

        // Prints <name> takes <damage> damage!
        Console.WriteLine($"{name} takes {damage} damage!");

        ValidateHP(new_hp);
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

         // Prints <name> heals <heal> HP!
        Console.WriteLine($"{name} heals {heal} HP!");

        ValidateHP(new_hp);
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
        OnCheckStatus(new CurrentHPArgs(newHp));
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

    EventHandler<CurrentHPArgs> HPCheck;
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

class CurrentHPArgs : EventArgs
{
    public float currentHP { get; }

    public CurrentHPArgs(float newHP)
    {
        this.currentHP = newHP;
    }


}
