namespace Ovning3.Del3o4;

public class Program
{
    public static void RunDel3o4()
    {
        Console.WriteLine("Methods related to exercises 3.3 and 3.4");
        Console.WriteLine("----------------------------------------");
        MakeAnimalList();
        MakeDogList();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
    }

    private static List<Animal> animals =
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

    private static List<Dog> dogs =
    [
        new("Sparky", 0.9m, 30m, 4m, "yellow", true),
        new("Edina", 1.5m, 50m, 11m, "white", true),
        new("Kujo", 1.4m, 80m, 14m, "brown", false),
        /*
        new Horse("Potoooooooo", 1.9m, 400m, 8m, "black", 50m)
         * CS0029: Cannot implicitly convert type 'Ovning3.Del3o4.Horse' to 'Ovning3.Del3o4.Dog'
         * Exercise 3.4,9-10: The horse cannot be added because Horse is not a subclass of Dog.
         * If we want to add a horse, we need to use a superclass of both, i.e. another List<Animal>.
         */
    ];

    static void MakeAnimalList()
    {
        Console.WriteLine("Here is a list of animals:");
        Console.WriteLine("----------------");
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Type of animal: {animal.GetType()}");
            Console.Write(animal.Stats());
            /* Exercise 3.4,13: Because Stats has been overriden for every subclass,
             * even though they are initialized as a type of Animal, each animal
             * uses it's own class' Stats method. As a result, *all* of its traits
             * are printed, not just the ones present in Animal.
             */
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

    static void MakeDogList()
    {
        Console.WriteLine("Here are all the dogs in the list of animals:");
        Console.WriteLine("----------------");
        foreach (Animal animal in animals)
        {
            if (animal is not Dog) continue;
            Console.Write(animal.Stats());

            /*
            animal.RollOver();
             * CS1061: 'Animal' does not contain a definition for 'RollOver'
             * and no accessible extension method 'RollOver' accepting a first
             * argument of type 'Animal' could be found
             * (are you missing a using directive or an assembly reference?)
             * 
             * Exercise 3.4,17: This does not work because, despite the fact that
             * only a dog would make it to this point in the code, the compiler
             * has to treat it as a generic animal, and RollOver is not a method
             * on Animal.
             */

            // Correct way
            Dog? dog = animal as Dog;
            dog!.RollOver();
        }
    }
}
