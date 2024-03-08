namespace Ovning3.Del2;

internal abstract class UserError
{
    public abstract string UEMessage();
}

internal class TextInputError : UserError
{
    public override string UEMessage()
        => "You tried to use a text input in a numeric only field. This fired an error!";
}

internal class NumericInputError : UserError
{
    public override string UEMessage()
        => "You tried to use a numeric input in a text only field. This fired an error!";
}

internal class EmptyStringError : UserError
{
    public override string UEMessage()
        => "You did not enter any value in a non-null field. This fired an error!";
}

internal class NegativeInputError : UserError
{
    public override string UEMessage()
        => "You entered a negative number in a positive-only field. This fired an error!";
}

internal class InputTimeoutError : UserError
{
    public override string UEMessage()
        => "You took too long to enter an input. This fired an error!";
}
