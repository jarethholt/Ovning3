namespace Ovning3.Del1;

internal class Person
{
    private int age;
    public int Age
    {
        get => age;
        set
        {
            if (value <= 0)
                throw new ArgumentException($"The age must be greater than 0; got {value}");
            age = value;
        }
    }

    private string fName = "";
    public string FName
    {
        get => fName;
        set
        {
            if (value.Length < 2 || value.Length > 10)
                throw new ArgumentException(
                    $"The first name must be between 2 and 10 characters; got {value}");
            fName = value;
        }
    }

    private string lName = "";
    public string LName
    {
        get => lName;
        set
        {
            if (value.Length < 3 || value.Length > 15)
                throw new ArgumentException(
                    $"The last name must be between 3 and 15 characters; got {value}");
            lName = value;
        }
    }

    private decimal height;
    public decimal Height
    {
        get => height;
        set
        {
            if (value <= 0)
                throw new ArgumentException($"The height must be greater than 0; got {value}");
            height = value;
        }
    }

    private decimal weight;
    public decimal Weight
    {
        get => weight;
        set
        {
            if (value <= 0)
                throw new ArgumentException($"The weight must be greater than 0; got {value}");
            weight = value;
        }
    }
}


internal class PersonHandler
{
    public static Person CreatePerson(
        int age, string fName, string lName, decimal height, decimal weight
    ) => new()
    {
        Age = age,
        FName = fName,
        LName = lName,
        Height = height,
        Weight = weight
    };

    public static void SetAge(Person person, int age) => person.Age = age;
    public static void SetFirstName(Person person, string fName) => person.FName = fName;
    public static void SetLastName(Person person, string lName) => person.LName = lName;
    public static void SetHeight(Person person, decimal height) => person.Height = height;
    public static void SetWeight(Person person, decimal weight) => person.Weight = weight;
}
