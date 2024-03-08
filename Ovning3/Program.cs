using Ovning3.Del1;
using Ovning3.Del2;
using Ovning3.Del3o4;

namespace Ovning3;

internal class Program
{
    static void Main(string[] args)
    {
        Del1.Program.RunDel1();
        Del2.Program.RunDel2();
        RunDel3o4();
    }

    static void RunDel3o4()
    {
        Console.WriteLine("Methods related to exercises 3.3 and 3.4");
        Console.WriteLine("----------------------------------------");
        MakeAnimalList();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
    }

    static void MakeAnimalList()
    {
        List<Animal> animals =
        [
            new Dog("Sparky", 0.9m, 30m, 4m, "yellow", true),
            new Hedgehog("Kottis", 0.10m, 0.05m, 4m, 500),
            new Horse("Potoooooooo", 1.9m, 400m, 8m, "black", 50m),
            new Wolf("Balto", 1.4m, 40m, 6m, "white", 16),
            new Worm("Richard", .05m, .008m, .3m, false),
            new Bird("Hootie", .2m, 1m, .8m, "brown", .3m),
            new Flamingo("Salaman", 1.4m, 20m, 3m, 1.3m, "ruber"),
            new Pelican("Harold", 1.2m, 10m, 10m, .9m, .5m),
            new Swan(1.2m, 15m, 8m, 1.4m, 100),
            new Wolfman("Legosi", 1.8m, 70m, 42m, "brown")
        ];

        Console.WriteLine("Here is a list of animals:");
        Console.WriteLine("----------------");
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Type of animal: {animal.GetType()}");
            Console.Write(animal.Stats());
            Console.Write("This animal's DoSound(): ");
            animal.DoSound();

            if (typeof(IPerson).IsInstanceOfType(animal))
            {
                Console.Write("This person's Talk(): ");
                IPerson person = (IPerson)animal;
                person.Talk();
            }
            Console.WriteLine("----------------");
        }
    }


}
