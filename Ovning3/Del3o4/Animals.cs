/* Answers to the exercise questions
 * 3.3.13: Om vi under utvecklingen kommer fram till att samtliga fåglar
 *         behöver ett nytt attribut, i vilken klass bör vi lägga det?
 * Svar: Om alla fåglar behäver attributet så ska det vara i klassen Bird.
 * 3.3.14: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
 * Svar: Då ska det vara i klassen Animal.
 */

using System.Text;

namespace Ovning3.Del3o4;

internal abstract class Animal(string name, decimal height, decimal weight, decimal age)
{
    public string Name { get; set; } = name;
    public decimal Height { get; set; } = height;
    public decimal Weight { get; set; } = weight;
    public decimal Age { get; set; } = age;

    public abstract void DoSound();

    public virtual string Stats()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Name: {Name}");
        sb.AppendLine($"Height: {Height}");
        sb.AppendLine($"Weight: {Weight}");
        sb.AppendLine($"Age: {Age}");
        return sb.ToString();
    }
}


internal class Dog(
    string name, decimal height, decimal weight, decimal age,
    string coatColor, bool trained
    ) : Animal(name, height, weight, age)
{
    public string CoatColor { get; set; } = coatColor;
    public bool Trained { get; set; } = trained;

    public override void DoSound()
    {
        Console.WriteLine("Woof");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.Append(base.Stats());
        sb.AppendLine($"CoatColor: {CoatColor}");
        sb.AppendLine($"Trained: {Trained}");
        return sb.ToString();
    }
}


internal class Hedgehog(
    string name, decimal height, decimal weight, decimal age,
    int numberOfSpikes
    ) : Animal(name, height, weight, age)
{
    public int NumberOfSpikes { get; set; } = numberOfSpikes;

    public override void DoSound()
    {
        Console.WriteLine("sniff sniff");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.Append(base.Stats());
        sb.AppendLine($"NumberOfSpikes: {NumberOfSpikes}");
        return sb.ToString();
    }
}


internal class Horse(
    string name, decimal height, decimal weight, decimal age,
    string maneColor, decimal topSpeed
    ) : Animal(name, height, weight, age)
{
    public string ManeColor { get; set; } = maneColor;
    public decimal TopSpeed { get; set; } = topSpeed;

    public override void DoSound()
    {
        Console.WriteLine("Neeeeigh");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.Append(base.Stats());
        sb.AppendLine($"ManeColor: {ManeColor}");
        sb.AppendLine($"TopSpeed: {TopSpeed}");
        return sb.ToString();
    }
}


internal class Wolf(
    string name, decimal height, decimal weight, decimal age,
    string coatColor, int packSize
    ) : Animal(name, height, weight, age)
{
    public string CoatColor { get; set; } = coatColor;
    public int PackSize { get; set; } = packSize;

    public override void DoSound()
    {
        Console.WriteLine("Arooooo");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.Append(base.Stats());
        sb.AppendLine($"CoatColor: {CoatColor}");
        sb.AppendLine($"PackSize: {PackSize}");
        return sb.ToString();
    }
}


internal class Worm(
    string name, decimal height, decimal weight, decimal age,
    bool isPoisonous
    ) : Animal(name, height, weight, age)
{
    public bool IsPoisonous { get; set; } = isPoisonous;

    public override void DoSound()
    {
        Console.WriteLine("...");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.Append(base.Stats());
        sb.AppendLine($"IsPoisonous: {IsPoisonous}");
        return sb.ToString();
    }
}


internal class Bird(
    string name, decimal height, decimal weight, decimal age,
    string featherColor, decimal wingSpan
    ) : Animal(name, height, weight, age)
{
    public string FeatherColor { get; set; } = featherColor;
    public decimal WingSpan { get; set; } = wingSpan;

    public override void DoSound()
    {
        Console.WriteLine("Peeep");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.Append(base.Stats());
        sb.AppendLine($"FeatherColor: {FeatherColor}");
        sb.AppendLine($"WingSpan: {WingSpan}");
        return sb.ToString();
    }
}


internal class Flamingo(
    string name, decimal height, decimal weight, decimal age, decimal wingSpan,
    string species
    ) : Bird(name, height, weight, age, "pink", wingSpan)
{
    public string Species { get; set; } = species;

    public override void DoSound()
    {
        Console.WriteLine("Squonk");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.Append(base.Stats());
        sb.AppendLine($"Species: {Species}");
        return sb.ToString();
    }
}


internal class Pelican(
    string name, decimal height, decimal weight, decimal age, decimal wingSpan,
    decimal beakLength
    ) : Bird(name, height, weight, age, "white", wingSpan)
{
    public decimal BeakLength { get; set; } = beakLength;

    public override void DoSound()
    {
        Console.WriteLine("Hrrraw");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.Append(base.Stats());
        sb.AppendLine($"BeakLength: {BeakLength}");
        return sb.ToString();
    }
}


internal class Swan(
    decimal height, decimal weight, decimal age, decimal wingSpan,
    int aggressiveness
    ) : Bird("Jerk", height, weight, age, "white", wingSpan)
{
    public int Aggressiveness { get; set; } = aggressiveness;

    public override void DoSound()
    {
        Console.WriteLine("Honk");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.Append(base.Stats());
        sb.AppendLine($"Aggressiveness: {Aggressiveness}");
        return sb.ToString();
    }
}
