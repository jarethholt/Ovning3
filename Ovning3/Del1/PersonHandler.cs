namespace Ovning3.Del1;

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

    public void SetAge      (Person person, int age       ) => person.Age    = age;
    public void SetFirstName(Person person, string fName  ) => person.FName  = fName;
    public void SetLastName (Person person, string lName  ) => person.LName  = lName;
    public void SetHeight   (Person person, decimal height) => person.Height = height;
    public void SetWeight   (Person person, decimal weight) => person.Weight = weight;
}
