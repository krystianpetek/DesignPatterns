using Interpreter.Contexts;

namespace Interpreter.Contracts;

abstract class Phrase
{
    public void Interpreter(Context context)
    {
        if (context.Input.Length == 0)
            return;

        if (context.Input.StartsWith(Nine()))
        {
            context.Input = context.Input.Substring(2);
            context.Output += Multiplier() * 9;
        }
        else if (context.Input.StartsWith(Four()))
        {
            context.Input = context.Input.Substring(2);
            context.Output += Multiplier() * 4;
        }
        else if (context.Input.StartsWith(Five()))
        {
            context.Input = context.Input.Substring(1);
            context.Output += Multiplier() * 5;
        }
        while (context.Input.StartsWith(One()))
        {
            context.Input = context.Input.Substring(1);
            context.Output += Multiplier() * 1;
        }
    }

    public abstract string One();
    public abstract string Four();
    public abstract string Five();
    public abstract string Nine();
    public abstract int Multiplier();
}
