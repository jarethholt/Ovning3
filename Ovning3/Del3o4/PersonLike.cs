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
    public override void DoSound()
    {
        Console.WriteLine("Grrrr...");
    }

    public void Talk()
    {
        Console.WriteLine("UwU");
    }
}
