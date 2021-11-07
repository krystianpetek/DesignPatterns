using System;
using System.Text;

interface ILitery
{
    public string ShowAlfa();
}

interface ICyfry
{
    public string ShowNum();
}

class AlfabetFactory
{
    private SystemFactory systemFactory;
    public ICyfry numbers;
    public ILitery letters;

    public AlfabetFactory(SystemFactory systemFactory)
    {
        this.systemFactory = systemFactory;
    }
    public void Generate()
    {
        numbers = systemFactory.CreateNum();
        letters = systemFactory.CreateAlfa();
    }
    public string Show()
    {
        return $"{letters.ShowAlfa()} {numbers.ShowNum()}";
    }
}

abstract class SystemFactory
{
    public abstract ILitery CreateAlfa();
    public abstract ICyfry CreateNum();
}


class LacinkaFactory : SystemFactory
{
    public override ILitery CreateAlfa()
    {
        return new LacinkaLetters();
    }

    public override ICyfry CreateNum()
    {
        return new LacinkaNumbers();
    }
}


class CyrylicaFactory : SystemFactory
{
    public override ILitery CreateAlfa()
    {
        return new CyrylicaLetters();
    }

    public override ICyfry CreateNum()
    {
        return new CyrylicaNumbers();
    }
}


class GrekaFactory : SystemFactory
{
    public override ILitery CreateAlfa()
    {
        return new GrekaLetters();
    }

    public override ICyfry CreateNum()
    {
        return new GrekaNumbers();
    }
}

class LacinkaNumbers : ICyfry
{
    string numbers;

    public LacinkaNumbers()
    {
        numbers = "I II III";
    }

    public string ShowNum()
    {
        return numbers;
    }
}

class CyrylicaNumbers : ICyfry
{
    string numbers;

    public CyrylicaNumbers()
    {
        numbers = "1 2 3";
    }

    public string ShowNum()
    {
        return numbers;
    }
}

class GrekaNumbers : ICyfry
{
    string numbers;

    public GrekaNumbers()
    {
        numbers = "αʹ βʹ γʹ";
    }

    public string ShowNum()
    {
        return numbers;
    }
}

class LacinkaLetters : ILitery
{
    string letters;

    public LacinkaLetters()
    {
        letters = "abcde";
    }

    public string ShowAlfa()
    {
        return letters;
    }
}

class CyrylicaLetters : ILitery
{
    string letters;

    public CyrylicaLetters()
    {
        letters = "абвгд";
    }

    public string ShowAlfa()
    {
        return letters;
    }
}

class GrekaLetters : ILitery
{
    string letters;

    public GrekaLetters()
    {
        letters = "αβγδε";
    }

    public string ShowAlfa()
    {
        return letters;
    }
}

public class Application
{
    public static void Main(String[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        AlfabetFactory alfabet_lacinka = new AlfabetFactory(new LacinkaFactory());
        AlfabetFactory alfabet_cyrylica = new AlfabetFactory(new CyrylicaFactory());
        AlfabetFactory alfabet_greka = new AlfabetFactory(new GrekaFactory());

        alfabet_lacinka.Generate();
        alfabet_cyrylica.Generate();
        alfabet_greka.Generate();

        Console.WriteLine(alfabet_lacinka.Show());
        Console.WriteLine(alfabet_cyrylica.Show());
        Console.WriteLine(alfabet_greka.Show());
    }
}



//using System;
//using System.Text;


//interface ILitery
//{
//    public string ShowAlfa();
//}

////
////
////

//class AlfabetFactory
//{

//    private SystemFactory systemFactory;

//    //
//    //

//    public AlfabetFactory(SystemFactory systemFactory)
//    {
//        //
//    }

//    public void Generate()
//    {
//        numbers = systemFactory.CreateNum();
//        //
//    }

//}


//abstract class SystemFactory
//{
//    //
//    public abstract ICyfry CreateNum();
//}


////
//// ...
////


//class CyrylicaFactory : SystemFactory
//{
//    public override ILitery CreateAlfa()
//    {
//        return new CyrylicaLetters();
//    }

//    public override ICyfry CreateNum()
//    {
//        return new CyrylicaNumbers();
//    }
//}


////
//// ...
////


//class GrekaNumbers : ICyfry
//{
//    string numbers;

//    //
//    //
//    //  

//    public string ShowNum()
//    {
//        return numbers;
//    }
//}


//class LacinkaLetters : ILitery
//{
//    string letters;

//    public LacinkaLetters()
//    {
//        letters = "abcde";
//    }

//    //
//    //
//    //
//}


////
//// ...
////


//public class Application
//{
//    public static void Main(String[] args)
//    {
//        Console.OutputEncoding = Encoding.UTF8;

//        AlfabetFactory alfabet_lacinka = new AlfabetFactory(new LacinkaFactory());
//        //

//        //
//        alfabet_cyrylica.Generate();

//        //
//        //

//        // 
//        //3x show ;)
//        //
//    }
//}

