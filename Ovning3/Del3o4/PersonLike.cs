using System.Text;

namespace Ovning3.Del3o4;

internal interface IPerson
{
    void Talk();
}


internal class Wolfman(
    string name, decimal height, decimal weight, decimal age,
    string coatColor
    ) : Wolf(name, height, weight, age, coatColor, 1), IPerson
{
    public static readonly bool IsHuman = true;

    public override void DoSound()
    {
        Console.WriteLine("Grrrr...");
    }

    public void Talk()
    {
        Console.WriteLine("UwU");
    }

    public override string Stats()
    {
        StringBuilder sb = new();
        sb.AppendLine(base.Stats());
        sb.AppendLine($"IsHuman: {IsHuman}");
        return sb.ToString();
    }
}
