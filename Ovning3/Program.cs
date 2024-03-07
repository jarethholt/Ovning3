﻿namespace Ovning3;

internal class Program
{
    static void Main(string[] args)
    {
        TryGetPrivateProperties();
        TryInvalidPersonParameters();
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
}
