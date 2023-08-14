using System;
using Prototype.Two.Clonable;

namespace Prototype.Two;

public static class Program
{
    public static void Main()
    {
        Person krystian = new Person("Krystian", "Petek", 24, new DateTime(1998, 10, 06));
        krystian.DisplayMe();

        Person krystianKlon = (Person)krystian.DeepCopy();
        krystian.Name = "Krzysztof";
        krystianKlon.DisplayMe();
    }
}
