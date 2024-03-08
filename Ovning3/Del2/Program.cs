namespace Ovning3.Del2;

public class Program
{
    public static void RunDel2()
    {
        Console.WriteLine("Methods related to exercise 3.2");
        Console.WriteLine("-------------------------------");
        MakeErrorList();
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
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
        foreach (UserError error in errors)
        {
            Console.WriteLine(String.Format(format, error.GetType(), error.UEMessage()));
        }
    }
}
