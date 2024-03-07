namespace Ovning3.Del2;

internal class InputTimeoutError : UserError
{
    public override string UEMessage()
        => "You took too long to enter an input. This fired an error!";
}