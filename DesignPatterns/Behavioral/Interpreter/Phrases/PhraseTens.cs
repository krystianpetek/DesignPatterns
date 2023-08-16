using Interpreter.Contracts;

namespace Interpreter.Phrases;

class PhraseTens : Phrase
{
    public override string One() { return "X"; }
    public override string Four() { return "XL"; }
    public override string Five() { return "L"; }
    public override string Nine() { return "XC"; }
    public override int Multiplier() { return 10; }
}
