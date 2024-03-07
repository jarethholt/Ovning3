namespace Ovning3.Del2;

internal class EmptyStringError : UserError
{
    public override string UEMessage()
        => "You did not enter any value in a non-null field. This fired an error!";
}