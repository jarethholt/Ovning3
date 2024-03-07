using Ovning3.Del1;
using Ovning3.Del2;
using Ovning3.Del3o4;

namespace Ovning3;

internal class Program
{
    static void Main(string[] args)
    {
        RunDel1();
        RunDel2();
        RunDel3o4();
    }

    static void RunDel1()
    {
        Console.WriteLine("Methods related to exercise 3.1");
        Console.WriteLine("-------------------------------");
        TryGetPrivateProperties();
        TryInvalidPersonParameters();
        CreateValidPersons();
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
        Console.WriteLine();
    }

    static void RunDel2()
    {
        Console.WriteLine("Methods related to exercise 3.2");
        Console.WriteLine("-------------------------------");
        MakeErrorList();
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
        Console.WriteLine();
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

    readonly record struct PersonParams(
        int Age, string FName, string LName, decimal Height, decimal Weight
    )
    {
        /* Old initialization without PersonHandler
        public Person CreatePerson() => new()
        {
            Age = Age,
            FName = FName,
            LName = LName,
            Height = Height,
            Weight = Weight
        };
        */

        public Person CreatePerson() => PersonHandler.CreatePerson(
            Age, FName, LName, Height, Weight);
    }

    static void TryGetPrivateProperties()
    {
        /* Original construction of a Person instance
        Person person = new()
        {
            Age = 18,
            FName = "Sam",
            LName = "Smith",
            Height = 160m,
            Weight = 70m
        };
        */

        // New construction through PersonHandler
        Person person = PersonHandler.CreatePerson(18, "Sam", "Smith", 160m, 70m);

        /*
        int age = person.age;
        // CS0122: 'Person.age' is inaccessible due to its protection level
        Console.WriteLine($"The Person's private age is {age}");
        */

        Console.WriteLine($"The Person's public age is {person.Age}");
        Console.WriteLine();
    }

    static void TryInvalidPersonParameters()
    {
        PersonParams okayParams = new(18, "Sam", "Smith", 160m, 70m);
        List<PersonParams> invalidParams =
        [
            okayParams with { Age = 0 },
            okayParams with { FName = "A" },
            okayParams with { FName = "Atrociousness" },
            okayParams with { LName = "Ng" },
            okayParams with { LName = "Expialodociousness" },
            okayParams with { Height = 0m },
            okayParams with { Weight = 0m },
        ];

        Console.WriteLine("Examples of invalid parameters for Person:");

        foreach (PersonParams pars in invalidParams)
        {
            try
            {
                Person invalidPerson = pars.CreatePerson();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine();
    }

    static void CreateValidPersons()
    {
        List<PersonParams> paramsList =
        [
            new(18, "Sam", "Smith", 160m, 70m),
            new(50, "Atticus", "Finch", 190m, 65m),
            new(12, "Juli", "Soona", 130m, 35m),
            new(85, "James", "Jones", 183m, 90m),
            new(40, "Alexia", "Nguyen", 150m, 50m)
        ];

        Console.WriteLine("Examples of valid parameters to Person:");
        foreach(PersonParams pars in paramsList)
        {
            try
            {
                _ = pars.CreatePerson();
                Console.WriteLine(pars);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine();
    }

    static void MakeErrorList()
    {
        List<UserError> errors =
        [
            new NumericInputError(),
            new TextInputError(),
            new EmptyStringError(),
            new NegativeInputError(),
            new InputTimeoutError()
        ];

        Console.WriteLine("Examples of classes that inherit UserError and their UEMessage:");
        int maxLen = errors
            .Select(error => error.GetType().ToString().Length)
            .Max();
        string format = String.Format("{0}0,-{2}{1} : {0}1{1}", "{", "}", maxLen);
        foreach(UserError error in errors)
        {
            Console.WriteLine(String.Format(format, error.GetType(), error.UEMessage()));
        }
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
