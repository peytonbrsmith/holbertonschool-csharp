using System;

enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public Dog(string Name, float Age, string Owner, Rating Rate)
    {
        name = Name;
        age = Age;
        owner = Owner;
        rating = Rate;
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public override string ToString() => $"My name is {name} and I am {age}. I am an {rating} dog. :)";
}

