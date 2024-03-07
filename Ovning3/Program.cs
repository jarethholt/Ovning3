namespace Ovning3;

internal class Program
{
    static void Main(string[] args)
    {
        TryGetPrivateProperties();
        TryInvalidPersonParameters();
    }

    readonly record struct PersonParams(int Age, string FName, string LName, decimal Height, decimal Weight)
    {
        public Person CreatePerson() => new()
        {
            Age = Age,
            FName = FName,
            LName = LName,
            Height = Height,
            Weight = Weight
        };
    }

    static void TryGetPrivateProperties()
    {
        Person person = new()
        {
            Age = 18,
            FName = "Sam",
            LName = "Smith",
            Height = 160m,
            Weight = 70m
        };

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
        Person validPerson = okayParams.CreatePerson();

        int[] badAges = [0];
        string[] badFNames = ["A", "Atrociousness"];
        string[] badLNames = ["Ng", "Expialodociousness"];
        decimal[] badHeights = [0m];
        decimal[] badWeights = [0m];

        Console.WriteLine("Examples of invalid parameters for Person:");

        foreach (int age in badAges)
        {
            try
            {
                var invalidParams = okayParams with { Age = age };
                Person invalidPerson = invalidParams.CreatePerson();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (string fName in badFNames)
        {
            try
            {
                var invalidParams = okayParams with { FName = fName };
                Person invalidPerson = invalidParams.CreatePerson();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (string lName in badLNames)
        {
            try
            {
                var invalidParams = okayParams with { LName = lName };
                Person invalidPerson = invalidParams.CreatePerson();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (decimal height in badHeights)
        {
            try
            {
                var invalidParams = okayParams with { Height = height };
                Person invalidPerson = invalidParams.CreatePerson();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (decimal weight in badWeights)
        {
            try
            {
                var invalidParams = okayParams with { Weight = weight };
                Person invalidPerson = invalidParams.CreatePerson();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine();
    }
}
