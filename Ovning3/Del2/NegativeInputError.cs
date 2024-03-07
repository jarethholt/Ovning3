namespace Ovning3.Del2;

internal class NegativeInputError : UserError
{
    public override string UEMessage()
        => "You entered a negative number in a positive-only field. This fired an error!";
}