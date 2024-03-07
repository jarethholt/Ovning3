namespace Ovning3;

/* 1. Skapa en klass Person och ge den följande privata fält:
age, fName, lName, height, weight
Skapa publika properties med get och set som hämtar eller sätter tilldelad variabel.
Instansiera en person i Program.cs, kommer du direkt åt variablerna?
Implementera validering i de skapade properties:
● Age kan bara tilldelas ett värde större än 0.
● FName är obligatorisk och får inte vara mindre än 2 tecken eller längre än 10
tecken.
● LName är obligatorisk och får inte vara mindre än 3 tecken eller större än 15
tecken.
Kasta ett undantag av typen ArgumentException i varje property om dess
validering inte fullföljs, undantaget ska innehålla ett beskrivande
meddelande.
Se till att hantera undantagen i Program-klassen med en try-catch block.
 */

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

    private string fName;
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

    private string lName;
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
