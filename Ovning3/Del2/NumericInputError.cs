namespace Ovning3.Del2;

internal class NumericInputError : UserError
{
    public override string UEMessage()
        => "You tried to use a numeric input in a text only field. This fired an error!";
}
