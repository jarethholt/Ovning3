namespace Ovning3;

internal class Person
{
    private int age;
    public int Age
    {
        get => age;
        set
        {
            if (value <= 0)
                throw new ArgumentException("The age must be greater than 0");
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
                throw new ArgumentException("The first name must be between 2 and 10 characters");
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
                throw new ArgumentException("The last name must be between 3 and 15 characters");
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
                throw new ArgumentException("The height must be greater than 0");
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
                throw new ArgumentException("The weight must be greater than 0");
            weight = value;
        }
    }
}
